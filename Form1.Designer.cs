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
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTextColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLineColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxToolColor)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(707, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectComicToolStripMenuItem,
            this.convertPDFToJPGToolStripMenuItem,
            this.editComicMetadataToolStripMenuItem,
            this.finalizeComicToolStripMenuItem});
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
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBoxToolColor);
            this.panel1.Controls.Add(this.btnToolColor);
            this.panel1.Controls.Add(this.pictureBoxLineColor);
            this.panel1.Controls.Add(this.pictureBoxTextColor);
            this.panel1.Controls.Add(this.btnLineColor);
            this.panel1.Controls.Add(this.btnTextColor);
            this.panel1.Location = new System.Drawing.Point(0, 183);
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
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.btnUndo);
            this.panel2.Location = new System.Drawing.Point(0, 408);
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
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnNext);
            this.panel3.Controls.Add(this.btnPrevious);
            this.panel3.Controls.Add(this.lblPageNumber);
            this.panel3.Location = new System.Drawing.Point(0, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(103, 113);
            this.panel3.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(109, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(481, 293);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.pictureBox1_PreviewKeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 703);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
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
    }
}

