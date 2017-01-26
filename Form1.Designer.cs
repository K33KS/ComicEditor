namespace ComicEditor
{
    partial class Form1
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectComicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertPDFToJPGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editComicMetadataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finalizeComicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadJSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnTextColor = new System.Windows.Forms.Button();
            this.btnLineColor = new System.Windows.Forms.Button();
            this.pictureBoxTextColor = new System.Windows.Forms.PictureBox();
            this.pictureBoxLineColor = new System.Windows.Forms.PictureBox();
            this.btnToolColor = new System.Windows.Forms.Button();
            this.pictureBoxToolColor = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPageNumber = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelMetadata = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSummary = new System.Windows.Forms.TextBox();
            this.buttonHideMetadata = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPublisher = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxArtist = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTextColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLineColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxToolColor)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelMetadata.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.showMenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1280, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectComicToolStripMenuItem,
            this.convertPDFToJPGToolStripMenuItem,
            this.editComicMetadataToolStripMenuItem,
            this.finalizeComicToolStripMenuItem,
            this.loadJSONToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // selectComicToolStripMenuItem
            // 
            this.selectComicToolStripMenuItem.Name = "selectComicToolStripMenuItem";
            this.selectComicToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.selectComicToolStripMenuItem.Text = "Select Comic";
            this.selectComicToolStripMenuItem.Click += new System.EventHandler(this.selectComicToolStripMenuItem_Click);
            // 
            // convertPDFToJPGToolStripMenuItem
            // 
            this.convertPDFToJPGToolStripMenuItem.Name = "convertPDFToJPGToolStripMenuItem";
            this.convertPDFToJPGToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.convertPDFToJPGToolStripMenuItem.Text = "Convert PDF to JPG";
            this.convertPDFToJPGToolStripMenuItem.Click += new System.EventHandler(this.convertPDFToJPGToolStripMenuItem_Click);
            // 
            // editComicMetadataToolStripMenuItem
            // 
            this.editComicMetadataToolStripMenuItem.Name = "editComicMetadataToolStripMenuItem";
            this.editComicMetadataToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.editComicMetadataToolStripMenuItem.Text = "Edit Comic Metadata";
            this.editComicMetadataToolStripMenuItem.Click += new System.EventHandler(this.editComicMetadataToolStripMenuItem_Click);
            // 
            // finalizeComicToolStripMenuItem
            // 
            this.finalizeComicToolStripMenuItem.Name = "finalizeComicToolStripMenuItem";
            this.finalizeComicToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.finalizeComicToolStripMenuItem.Text = "Finalize Comic";
            this.finalizeComicToolStripMenuItem.Click += new System.EventHandler(this.finalizeComicToolStripMenuItem_Click);
            // 
            // loadJSONToolStripMenuItem
            // 
            this.loadJSONToolStripMenuItem.Name = "loadJSONToolStripMenuItem";
            this.loadJSONToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.loadJSONToolStripMenuItem.Text = "Load JSON";
            this.loadJSONToolStripMenuItem.Click += new System.EventHandler(this.loadJSONToolStripMenuItem_Click);
            // 
            // showMenuToolStripMenuItem
            // 
            this.showMenuToolStripMenuItem.Name = "showMenuToolStripMenuItem";
            this.showMenuToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.showMenuToolStripMenuItem.Text = "Show Tool Strip";
            this.showMenuToolStripMenuItem.Click += new System.EventHandler(this.showMenuToolStripMenuItem_Click);
            // 
            // btnTextColor
            // 
            this.btnTextColor.Location = new System.Drawing.Point(13, 145);
            this.btnTextColor.Name = "btnTextColor";
            this.btnTextColor.Size = new System.Drawing.Size(75, 23);
            this.btnTextColor.TabIndex = 9;
            this.btnTextColor.Text = "Text Color";
            this.btnTextColor.UseVisualStyleBackColor = true;
            this.btnTextColor.Click += new System.EventHandler(this.btnTextColor_Click);
            // 
            // btnLineColor
            // 
            this.btnLineColor.Location = new System.Drawing.Point(13, 92);
            this.btnLineColor.Name = "btnLineColor";
            this.btnLineColor.Size = new System.Drawing.Size(75, 23);
            this.btnLineColor.TabIndex = 8;
            this.btnLineColor.Text = "Line Color";
            this.btnLineColor.UseVisualStyleBackColor = true;
            this.btnLineColor.Click += new System.EventHandler(this.btnLineColor_Click);
            // 
            // pictureBoxTextColor
            // 
            this.pictureBoxTextColor.Location = new System.Drawing.Point(13, 130);
            this.pictureBoxTextColor.Name = "pictureBoxTextColor";
            this.pictureBoxTextColor.Size = new System.Drawing.Size(75, 18);
            this.pictureBoxTextColor.TabIndex = 11;
            this.pictureBoxTextColor.TabStop = false;
            // 
            // pictureBoxLineColor
            // 
            this.pictureBoxLineColor.Location = new System.Drawing.Point(14, 77);
            this.pictureBoxLineColor.Name = "pictureBoxLineColor";
            this.pictureBoxLineColor.Size = new System.Drawing.Size(74, 18);
            this.pictureBoxLineColor.TabIndex = 10;
            this.pictureBoxLineColor.TabStop = false;
            // 
            // btnToolColor
            // 
            this.btnToolColor.Location = new System.Drawing.Point(13, 39);
            this.btnToolColor.Name = "btnToolColor";
            this.btnToolColor.Size = new System.Drawing.Size(75, 23);
            this.btnToolColor.TabIndex = 12;
            this.btnToolColor.Text = "Tool Color";
            this.btnToolColor.UseVisualStyleBackColor = true;
            this.btnToolColor.Click += new System.EventHandler(this.btnToolColor_Click);
            // 
            // pictureBoxToolColor
            // 
            this.pictureBoxToolColor.Location = new System.Drawing.Point(13, 24);
            this.pictureBoxToolColor.Name = "pictureBoxToolColor";
            this.pictureBoxToolColor.Size = new System.Drawing.Size(75, 18);
            this.pictureBoxToolColor.TabIndex = 13;
            this.pictureBoxToolColor.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBoxToolColor);
            this.panel1.Controls.Add(this.btnToolColor);
            this.panel1.Controls.Add(this.pictureBoxLineColor);
            this.panel1.Controls.Add(this.pictureBoxTextColor);
            this.panel1.Controls.Add(this.btnLineColor);
            this.panel1.Controls.Add(this.btnTextColor);
            this.panel1.Location = new System.Drawing.Point(3, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(103, 188);
            this.panel1.TabIndex = 12;
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(14, 71);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(74, 50);
            this.btnUndo.TabIndex = 6;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(14, 15);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(74, 50);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh Page";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.btnUndo);
            this.panel2.Location = new System.Drawing.Point(3, 316);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(103, 136);
            this.panel2.TabIndex = 13;
            // 
            // lblPageNumber
            // 
            this.lblPageNumber.AutoSize = true;
            this.lblPageNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageNumber.Location = new System.Drawing.Point(14, 81);
            this.lblPageNumber.Name = "lblPageNumber";
            this.lblPageNumber.Size = new System.Drawing.Size(75, 17);
            this.lblPageNumber.TabIndex = 4;
            this.lblPageNumber.Text = "Page: XX";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(15, 43);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.Text = "Prev";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(15, 14);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnNext);
            this.panel3.Controls.Add(this.btnPrevious);
            this.panel3.Controls.Add(this.lblPageNumber);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(103, 113);
            this.panel3.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(886, 763);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.pictureBox1_PreviewKeyDown);
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 24);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(109, 763);
            this.panel4.TabIndex = 16;
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.AutoSize = true;
            this.panel5.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Location = new System.Drawing.Point(112, 24);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(886, 763);
            this.panel5.TabIndex = 17;
            // 
            // panelMetadata
            // 
            this.panelMetadata.BackColor = System.Drawing.SystemColors.Control;
            this.panelMetadata.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMetadata.Controls.Add(this.label7);
            this.panelMetadata.Controls.Add(this.textBoxSummary);
            this.panelMetadata.Controls.Add(this.buttonHideMetadata);
            this.panelMetadata.Controls.Add(this.label4);
            this.panelMetadata.Controls.Add(this.textBoxGenre);
            this.panelMetadata.Controls.Add(this.label5);
            this.panelMetadata.Controls.Add(this.textBoxPublisher);
            this.panelMetadata.Controls.Add(this.label6);
            this.panelMetadata.Controls.Add(this.textBoxArtist);
            this.panelMetadata.Controls.Add(this.label3);
            this.panelMetadata.Controls.Add(this.textBoxAuthor);
            this.panelMetadata.Controls.Add(this.label2);
            this.panelMetadata.Controls.Add(this.textBoxDate);
            this.panelMetadata.Controls.Add(this.label1);
            this.panelMetadata.Controls.Add(this.textBoxTitle);
            this.panelMetadata.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMetadata.Location = new System.Drawing.Point(1005, 24);
            this.panelMetadata.Name = "panelMetadata";
            this.panelMetadata.Size = new System.Drawing.Size(275, 763);
            this.panelMetadata.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Summary:";
            // 
            // textBoxSummary
            // 
            this.textBoxSummary.Location = new System.Drawing.Point(13, 266);
            this.textBoxSummary.Multiline = true;
            this.textBoxSummary.Name = "textBoxSummary";
            this.textBoxSummary.Size = new System.Drawing.Size(255, 272);
            this.textBoxSummary.TabIndex = 13;
            // 
            // buttonHideMetadata
            // 
            this.buttonHideMetadata.Location = new System.Drawing.Point(13, 544);
            this.buttonHideMetadata.Name = "buttonHideMetadata";
            this.buttonHideMetadata.Size = new System.Drawing.Size(75, 23);
            this.buttonHideMetadata.TabIndex = 12;
            this.buttonHideMetadata.Text = "Hide Panel";
            this.buttonHideMetadata.UseVisualStyleBackColor = true;
            this.buttonHideMetadata.Click += new System.EventHandler(this.buttonHideMetadata_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Genre:";
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Location = new System.Drawing.Point(13, 225);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(255, 20);
            this.textBoxGenre.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Publisher:";
            // 
            // textBoxPublisher
            // 
            this.textBoxPublisher.Location = new System.Drawing.Point(13, 186);
            this.textBoxPublisher.Name = "textBoxPublisher";
            this.textBoxPublisher.Size = new System.Drawing.Size(255, 20);
            this.textBoxPublisher.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Artist:";
            // 
            // textBoxArtist
            // 
            this.textBoxArtist.Location = new System.Drawing.Point(13, 147);
            this.textBoxArtist.Name = "textBoxArtist";
            this.textBoxArtist.Size = new System.Drawing.Size(255, 20);
            this.textBoxArtist.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Author:";
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(13, 109);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(255, 20);
            this.textBoxAuthor.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date:";
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(13, 70);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(255, 20);
            this.textBoxDate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title:";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(13, 31);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(255, 20);
            this.textBoxTitle.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1280, 787);
            this.Controls.Add(this.panelMetadata);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Launchpad Comic Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTextColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLineColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxToolColor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panelMetadata.ResumeLayout(false);
            this.panelMetadata.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectComicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editComicMetadataToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripMenuItem finalizeComicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertPDFToJPGToolStripMenuItem;
        private System.Windows.Forms.Button btnTextColor;
        private System.Windows.Forms.Button btnLineColor;
        private System.Windows.Forms.PictureBox pictureBoxTextColor;
        private System.Windows.Forms.PictureBox pictureBoxLineColor;
        private System.Windows.Forms.Button btnToolColor;
        private System.Windows.Forms.PictureBox pictureBoxToolColor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPageNumber;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ToolStripMenuItem showMenuToolStripMenuItem;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panelMetadata;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Button buttonHideMetadata;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPublisher;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxArtist;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxSummary;
        private System.Windows.Forms.ToolStripMenuItem loadJSONToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

