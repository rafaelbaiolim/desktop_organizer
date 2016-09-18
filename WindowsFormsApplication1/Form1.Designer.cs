namespace WindowsFormsApplication1
{
    partial class desktop_org
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(desktop_org));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chk_lst_movedFiles = new System.Windows.Forms.CheckedListBox();
            this.labelFolderNameTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_lst_movedFolders = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelFolderName = new System.Windows.Forms.Label();
            this.labelFolder = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(68, 26);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // chk_lst_movedFiles
            // 
            this.chk_lst_movedFiles.FormattingEnabled = true;
            this.helpProvider1.SetHelpKeyword(this.chk_lst_movedFiles, "Todos os arquivos que foram movidos estão listados aqui.");
            this.helpProvider1.SetHelpString(this.chk_lst_movedFiles, "Todos os arquivos que foram movidos estão listados aqui.");
            this.chk_lst_movedFiles.Location = new System.Drawing.Point(12, 33);
            this.chk_lst_movedFiles.Name = "chk_lst_movedFiles";
            this.helpProvider1.SetShowHelp(this.chk_lst_movedFiles, true);
            this.chk_lst_movedFiles.Size = new System.Drawing.Size(373, 94);
            this.chk_lst_movedFiles.TabIndex = 1;
            
            // 
            // labelFolderNameTitle
            // 
            this.labelFolderNameTitle.AutoSize = true;
            this.labelFolderNameTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelFolderNameTitle.Location = new System.Drawing.Point(13, 276);
            this.labelFolderNameTitle.Name = "labelFolderNameTitle";
            this.labelFolderNameTitle.Size = new System.Drawing.Size(57, 13);
            this.labelFolderNameTitle.TabIndex = 2;
            this.labelFolderNameTitle.Text = "Caminho : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Desenvolvido Por : Rafael Artal";
            // 
            // chk_lst_movedFolders
            // 
            this.chk_lst_movedFolders.FormattingEnabled = true;
            this.helpProvider1.SetHelpKeyword(this.chk_lst_movedFolders, "Todas as pastas que foram movidas estão listadas aqui.");
            this.helpProvider1.SetHelpString(this.chk_lst_movedFolders, "Todas as pastas que foram movidas estão listadas aqui.");
            this.chk_lst_movedFolders.Location = new System.Drawing.Point(12, 162);
            this.chk_lst_movedFolders.Name = "chk_lst_movedFolders";
            this.helpProvider1.SetShowHelp(this.chk_lst_movedFolders, true);
            this.chk_lst_movedFolders.Size = new System.Drawing.Size(373, 94);
            this.chk_lst_movedFolders.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pastas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Arquivos";
            // 
            // labelFolderName
            // 
            this.labelFolderName.AutoSize = true;
            this.labelFolderName.Location = new System.Drawing.Point(66, 276);
            this.labelFolderName.Name = "labelFolderName";
            this.labelFolderName.Size = new System.Drawing.Size(0, 13);
            this.labelFolderName.TabIndex = 7;
            // 
            // labelFolder
            // 
            this.labelFolder.AutoSize = true;
            this.labelFolder.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.labelFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelFolder.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.helpProvider1.SetHelpKeyword(this.labelFolder, "Clique para abrir no explorer a pasta de arquivos/pastas movidos.");
            this.helpProvider1.SetHelpString(this.labelFolder, "Clique para abrir no explorer a pasta de arquivos/pastas movidos.");
            this.labelFolder.Location = new System.Drawing.Point(66, 277);
            this.labelFolder.Name = "labelFolder";
            this.helpProvider1.SetShowHelp(this.labelFolder, true);
            this.labelFolder.Size = new System.Drawing.Size(27, 13);
            this.labelFolder.TabIndex = 8;
            this.labelFolder.Text = "N/A";
            this.labelFolder.Click += new System.EventHandler(this.label4_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonHelp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonHelp.Location = new System.Drawing.Point(12, 305);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(75, 23);
            this.buttonHelp.TabIndex = 9;
            this.buttonHelp.Text = "Ajuda";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // desktop_org
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(397, 335);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.labelFolder);
            this.Controls.Add(this.labelFolderName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chk_lst_movedFolders);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelFolderNameTitle);
            this.Controls.Add(this.chk_lst_movedFiles);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.helpProvider1.SetHelpKeyword(this, "");
            this.helpProvider1.SetHelpString(this, "Ajuda");
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(413, 374);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(413, 374);
            this.Name = "desktop_org";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desktop Organizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.CheckedListBox chk_lst_movedFiles;
        private System.Windows.Forms.Label labelFolderNameTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox chk_lst_movedFolders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelFolderName;
        private System.Windows.Forms.Label labelFolder;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button buttonHelp;
    }
}

