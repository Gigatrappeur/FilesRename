using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Text.RegularExpressions;

namespace FilesRename
{
    public partial class Form1 : Form
    {
        private string current_location;
        public Form1()
        {
            InitializeComponent();

            this.ltv_source.ListViewItemSorter = new ListViewItemComparer();

            this.current_location = "";
            this.tsl_search.Text = this.current_location;
            this.bindingFiles();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.ltv_source_Resize(sender, e);
            this.ltv_dest_Resize(sender, e);
        }


        private void bindingFiles()
        {
            this.ltv_source.Items.Clear();
            if (this.current_location != "")
            {
                foreach (string file in Directory.EnumerateFileSystemEntries(this.current_location))
                {
                    this.ltv_source.Items.Add(file.Substring(file.LastIndexOf('\\')+1));
                }
                this.sortFiles();
            }
        }

        private void sortFiles()
        {
            Regex tmp = null;
            if (this.tbx_mask.Text != "")
            {
//                if (this.tbx_mask.Text.StartsWith("^"))
                try
                {
                    tmp = new Regex(this.tbx_mask.Text);
                }
                catch (Exception)
                {
                    tmp = null;
                }
            }

            ((ListViewItemComparer)this.ltv_source.ListViewItemSorter).pattern = tmp;
            this.ltv_source.Sort();

            this.replaceFilesName();
        }
        
        private void replaceFilesName()
        {
            Regex tmp = ((ListViewItemComparer)this.ltv_source.ListViewItemSorter).pattern;
            this.ltv_dest.Items.Clear();

            Dictionary<string, int> alreadyUsed = new Dictionary<string, int>();
            foreach (ListViewItem item in this.ltv_source.Items)
            {
                if (tmp != null && tmp.IsMatch(item.Text))
                {
                    item.ForeColor = Color.Black;

                    string newName = tmp.Replace(item.Text, this.tbx_pattern.Text);

                    //MatchCollection colls = tmp.Matches(item.Text);
                    
                    ListViewItem lvi = this.ltv_dest.Items.Add(newName);
                    lvi.Tag = item.Text;


                    if (!alreadyUsed.ContainsKey(lvi.Text))
                    {
                        alreadyUsed.Add(lvi.Text, 0);
                    }
                    alreadyUsed[lvi.Text]++;

                    if (alreadyUsed[lvi.Text] > 1)
                    {
                        string basename = lvi.Text;
                        string extension = "";
                        int pos = basename.LastIndexOf('.');
                        if (pos > -1)
                        {
                            extension = basename.Substring(pos);
                            basename = basename.Substring(0, pos);
                        }

                        lvi.Text = basename + " (" + alreadyUsed[lvi.Text] + ")" + extension;
                    }
                }
                else
                    item.ForeColor = Color.Gray;
            }

            appliquerToolStripMenuItem.Enabled = (this.ltv_dest.Items.Count > 0);
        }


        private void dossierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = this.current_location;
            if (DialogResult.OK == folderBrowserDialog1.ShowDialog())
            {
                this.setFolder(folderBrowserDialog1.SelectedPath);
                this.tsl_search.Text = this.current_location;
            }
        }

        private void setFolder(string folder)
        {
            if (folder != "" && Directory.Exists(folder))
            {
                if (folder.EndsWith(@"\")) folder = folder.Remove(folder.Length - 1);

                this.current_location = folder;
                this.Text = "Files Rename [" + this.current_location + "]";
                this.bindingFiles();
            }
        }

        private void tbx_mask_TextChanged(object sender, EventArgs e)
        {
            this.sortFiles();
        }

        private void ltv_source_Resize(object sender, EventArgs e)
        {
            this.ltv_source.Columns[0].Width = this.ltv_source.Width - 5;
        }

        private void ltv_dest_Resize(object sender, EventArgs e)
        {
            this.ltv_dest.Columns[0].Width = this.ltv_dest.Width - 5;
        }

        
        private void tbx_pattern_TextChanged(object sender, EventArgs e)
        {
            Regex r = new Regex("\\$(?:[0-9]+|\\{[^}]+\\})");
            MatchCollection items = r.Matches(this.tbx_pattern.Text);
            
            //this.stl_text.Text = "Nb: " + items.Count;
            this.flagModifier.Rows.Clear();
            foreach (Match item in items)
            {
                this.flagModifier.Rows.Add(new string[] { item.Value, "Aucune" });
            }
            this.replaceFilesName();
        }

        private void rechargerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.bindingFiles();
        }

        private void appliquerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bw_rename.IsBusy != true && this.ltv_dest.Items.Count > 0)
            {
                this.stl_text.Text = "Renommage en cours...     ";
                this.stp_bar.Value = 0;
                this.stp_bar.Visible = true;
                Dictionary<string, string> files = new Dictionary<string, string>();
                foreach (ListViewItem item in this.ltv_dest.Items)
                {
                    if (item.Tag is string)
                    {
                        string oldName = this.current_location + @"\" + ((string)item.Tag);
                        string newName = this.current_location + @"\" + item.Text;
                        if (oldName != newName)
                            files.Add(oldName, newName);
                    }
                }

                this.tbx_mask.Enabled = false;
                this.tbx_pattern.Enabled = false;
                bw_rename.RunWorkerAsync(files);
            }
            else
            {
                appliquerToolStripMenuItem.Enabled = false;
            }
        }

        private void bw_rename_DoWork(object sender, DoWorkEventArgs e)
        {
            // faire les changements
            BackgroundWorker worker = sender as BackgroundWorker;

            Dictionary<string, string> files = (Dictionary<string, string>)e.Argument;
            if (files.Count == 0)
                return;

            int offset = 100 / files.Count;
            int i = 1;
            foreach (KeyValuePair<string, string> item in files)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    Directory.Move(item.Key, item.Value);
                    worker.ReportProgress(i++ * offset);
                }
            }
        }

        private void bw_rename_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.stp_bar.Value = e.ProgressPercentage;
        }

        private void bw_rename_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                MessageBox.Show("Opération arrêté !");
            }
            else if (e.Error != null)
            {
                MessageBox.Show("Error: " + e.Error.Message);
            }
            else
            {
                // mettre à jour les ListViews
                this.bindingFiles();
            }
            this.stp_bar.Visible = false;
            this.stl_text.Text = "Prêt";
            this.tbx_mask.Enabled = true;
            this.tbx_pattern.Enabled = true;
        }

        private void dossierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.tsl_search.Visible = !this.tsl_search.Visible;
        }

        private void tsl_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string tmp_location = ((ToolStripTextBox)sender).Text;
                this.setFolder(tmp_location);

                e.Handled = true;
                this.tsl_search.Visible = false;
                this.tsl_search.Text = this.current_location;
            }
        }

        private void tbx_pattern_Enter(object sender, EventArgs e)
        {
            this.flagModifier.Visible = true;
            this.closeFlagModifierBtn.Visible = true;
        }
        
        private void closeFlagModifierBtn_Click(object sender, EventArgs e)
        {
            this.flagModifier.Visible = false;
            this.closeFlagModifierBtn.Visible = false;
        }
    }

    class ListViewItemComparer : IComparer
    {
        public Regex pattern { get; set; }

        public ListViewItemComparer(Regex pattern = null)
        {
            this.pattern = pattern;
        }

        public int Compare(object x, object y)
        {
            string sx = ((ListViewItem)x).SubItems[0].Text;
            string sy = ((ListViewItem)y).SubItems[0].Text;
            int c = String.Compare(sx, sy);
            if (this.pattern == null)
                return c;

            bool bx = this.pattern.IsMatch(sx);
            bool by = this.pattern.IsMatch(sy);
            if (bx && by)
                return c;
            else if (bx && !by)
                return -1;
            else if (!bx && by)
                return 1;
            else
                return c;
        }
    }

}
