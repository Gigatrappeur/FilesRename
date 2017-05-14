namespace FilesRename
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.ltv_source = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbx_mask = new System.Windows.Forms.TextBox();
            this.tbx_pattern = new System.Windows.Forms.TextBox();
            this.ltv_dest = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.closeFlagModifierBtn = new System.Windows.Forms.Button();
            this.flagModifier = new System.Windows.Forms.DataGridView();
            this.Substitue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modifier = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stl_text = new System.Windows.Forms.ToolStripStatusLabel();
            this.stp_bar = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dossierToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsl_search = new System.Windows.Forms.ToolStripTextBox();
            this.dossierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechargerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appliquerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.bw_rename = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flagModifier)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ltv_source
            // 
            this.ltv_source.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ltv_source.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.ltv_source.FullRowSelect = true;
            this.ltv_source.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ltv_source.Location = new System.Drawing.Point(3, 29);
            this.ltv_source.Name = "ltv_source";
            this.ltv_source.Size = new System.Drawing.Size(273, 322);
            this.ltv_source.TabIndex = 0;
            this.ltv_source.UseCompatibleStateImageBehavior = false;
            this.ltv_source.View = System.Windows.Forms.View.Details;
            this.ltv_source.Resize += new System.EventHandler(this.ltv_source_Resize);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nom";
            // 
            // tbx_mask
            // 
            this.tbx_mask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_mask.Location = new System.Drawing.Point(3, 3);
            this.tbx_mask.Name = "tbx_mask";
            this.tbx_mask.Size = new System.Drawing.Size(273, 20);
            this.tbx_mask.TabIndex = 1;
            this.tbx_mask.Text = ".*";
            this.tbx_mask.TextChanged += new System.EventHandler(this.tbx_mask_TextChanged);
            // 
            // tbx_pattern
            // 
            this.tbx_pattern.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_pattern.Location = new System.Drawing.Point(3, 3);
            this.tbx_pattern.Name = "tbx_pattern";
            this.tbx_pattern.Size = new System.Drawing.Size(287, 20);
            this.tbx_pattern.TabIndex = 2;
            this.tbx_pattern.Text = "$0";
            this.tbx_pattern.TextChanged += new System.EventHandler(this.tbx_pattern_TextChanged);
            this.tbx_pattern.Enter += new System.EventHandler(this.tbx_pattern_Enter);
            // 
            // ltv_dest
            // 
            this.ltv_dest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ltv_dest.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.ltv_dest.FullRowSelect = true;
            this.ltv_dest.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ltv_dest.Location = new System.Drawing.Point(3, 29);
            this.ltv_dest.Name = "ltv_dest";
            this.ltv_dest.Size = new System.Drawing.Size(287, 322);
            this.ltv_dest.TabIndex = 3;
            this.ltv_dest.UseCompatibleStateImageBehavior = false;
            this.ltv_dest.View = System.Windows.Forms.View.Details;
            this.ltv_dest.Resize += new System.EventHandler(this.ltv_dest_Resize);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nouveau nom";
            this.columnHeader2.Width = 283;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ltv_source);
            this.splitContainer1.Panel1.Controls.Add(this.tbx_mask);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flagModifier);
            this.splitContainer1.Panel2.Controls.Add(this.closeFlagModifierBtn);
            this.splitContainer1.Panel2.Controls.Add(this.ltv_dest);
            this.splitContainer1.Panel2.Controls.Add(this.tbx_pattern);
            this.splitContainer1.Size = new System.Drawing.Size(576, 354);
            this.splitContainer1.SplitterDistance = 279;
            this.splitContainer1.TabIndex = 4;
            // 
            // closeFlagModifierBtn
            // 
            this.closeFlagModifierBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeFlagModifierBtn.AutoSize = true;
            this.closeFlagModifierBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.closeFlagModifierBtn.Location = new System.Drawing.Point(257, 153);
            this.closeFlagModifierBtn.Name = "closeFlagModifierBtn";
            this.closeFlagModifierBtn.Size = new System.Drawing.Size(24, 23);
            this.closeFlagModifierBtn.TabIndex = 5;
            this.closeFlagModifierBtn.Text = "X";
            this.closeFlagModifierBtn.UseVisualStyleBackColor = true;
            this.closeFlagModifierBtn.Visible = false;
            this.closeFlagModifierBtn.Click += new System.EventHandler(this.closeFlagModifierBtn_Click);
            // 
            // flagModifier
            // 
            this.flagModifier.AllowUserToAddRows = false;
            this.flagModifier.AllowUserToDeleteRows = false;
            this.flagModifier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flagModifier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flagModifier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Substitue,
            this.Modifier});
            this.flagModifier.Location = new System.Drawing.Point(3, 185);
            this.flagModifier.Name = "flagModifier";
            this.flagModifier.Size = new System.Drawing.Size(287, 169);
            this.flagModifier.TabIndex = 4;
            this.flagModifier.Visible = false;
            this.flagModifier.CurrentCellChanged += new System.EventHandler(this.flagModifier_CurrentCellChanged);
            // 
            // Substitue
            // 
            this.Substitue.HeaderText = "Flag";
            this.Substitue.Name = "Substitue";
            // 
            // Modifier
            // 
            this.Modifier.HeaderText = "Fonction";
            this.Modifier.Items.AddRange(new object[] {
            "Aucune",
            "Majuscule",
            "Minuscule"});
            this.Modifier.Name = "Modifier";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stl_text,
            this.stp_bar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 378);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(576, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stl_text
            // 
            this.stl_text.Name = "stl_text";
            this.stl_text.Size = new System.Drawing.Size(28, 17);
            this.stl_text.Text = "Prêt";
            // 
            // stp_bar
            // 
            this.stp_bar.Name = "stp_bar";
            this.stp_bar.Size = new System.Drawing.Size(100, 16);
            this.stp_bar.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dossierToolStripMenuItem1,
            this.tsl_search,
            this.dossierToolStripMenuItem,
            this.rechargerToolStripMenuItem,
            this.appliquerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(576, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dossierToolStripMenuItem1
            // 
            this.dossierToolStripMenuItem1.Name = "dossierToolStripMenuItem1";
            this.dossierToolStripMenuItem1.Size = new System.Drawing.Size(57, 20);
            this.dossierToolStripMenuItem1.Text = "Dossier";
            this.dossierToolStripMenuItem1.Click += new System.EventHandler(this.dossierToolStripMenuItem1_Click);
            // 
            // tsl_search
            // 
            this.tsl_search.AutoSize = false;
            this.tsl_search.Margin = new System.Windows.Forms.Padding(0);
            this.tsl_search.Name = "tsl_search";
            this.tsl_search.Size = new System.Drawing.Size(100, 20);
            this.tsl_search.Visible = false;
            this.tsl_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tsl_search_KeyDown);
            // 
            // dossierToolStripMenuItem
            // 
            this.dossierToolStripMenuItem.Name = "dossierToolStripMenuItem";
            this.dossierToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.dossierToolStripMenuItem.Text = "Parcourir";
            this.dossierToolStripMenuItem.Click += new System.EventHandler(this.dossierToolStripMenuItem_Click);
            // 
            // rechargerToolStripMenuItem
            // 
            this.rechargerToolStripMenuItem.Name = "rechargerToolStripMenuItem";
            this.rechargerToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.rechargerToolStripMenuItem.Text = "Recharger";
            this.rechargerToolStripMenuItem.Click += new System.EventHandler(this.rechargerToolStripMenuItem_Click);
            // 
            // appliquerToolStripMenuItem
            // 
            this.appliquerToolStripMenuItem.Enabled = false;
            this.appliquerToolStripMenuItem.Name = "appliquerToolStripMenuItem";
            this.appliquerToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.appliquerToolStripMenuItem.Text = "Appliquer";
            this.appliquerToolStripMenuItem.Click += new System.EventHandler(this.appliquerToolStripMenuItem_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // bw_rename
            // 
            this.bw_rename.WorkerReportsProgress = true;
            this.bw_rename.WorkerSupportsCancellation = true;
            this.bw_rename.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_rename_DoWork);
            this.bw_rename.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bw_rename_ProgressChanged);
            this.bw_rename.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_rename_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 400);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Files Rename";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flagModifier)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ltv_source;
        private System.Windows.Forms.TextBox tbx_mask;
        private System.Windows.Forms.TextBox tbx_pattern;
        private System.Windows.Forms.ListView ltv_dest;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.ComponentModel.BackgroundWorker bw_rename;
        private System.Windows.Forms.ToolStripStatusLabel stl_text;
        private System.Windows.Forms.ToolStripProgressBar stp_bar;
        private System.Windows.Forms.ToolStripMenuItem dossierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appliquerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechargerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dossierToolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox tsl_search;
        private System.Windows.Forms.DataGridView flagModifier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Substitue;
        private System.Windows.Forms.DataGridViewComboBoxColumn Modifier;
        private System.Windows.Forms.Button closeFlagModifierBtn;
    }
}

