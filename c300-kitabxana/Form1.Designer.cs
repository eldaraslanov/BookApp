namespace c300_kitabxana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aNASEHIFEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bOOKSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sHOWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aUTHORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anasekil = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anasekil)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aNASEHIFEToolStripMenuItem,
            this.bOOKSToolStripMenuItem,
            this.aUTHORToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1252, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aNASEHIFEToolStripMenuItem
            // 
            this.aNASEHIFEToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aNASEHIFEToolStripMenuItem.Name = "aNASEHIFEToolStripMenuItem";
            this.aNASEHIFEToolStripMenuItem.Size = new System.Drawing.Size(67, 25);
            this.aNASEHIFEToolStripMenuItem.Text = "HOME";
            // 
            // bOOKSToolStripMenuItem
            // 
            this.bOOKSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDToolStripMenuItem,
            this.sHOWToolStripMenuItem});
            this.bOOKSToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.bOOKSToolStripMenuItem.Name = "bOOKSToolStripMenuItem";
            this.bOOKSToolStripMenuItem.Size = new System.Drawing.Size(73, 25);
            this.bOOKSToolStripMenuItem.Text = "BOOKS";
            // 
            // aDDToolStripMenuItem
            // 
            this.aDDToolStripMenuItem.Name = "aDDToolStripMenuItem";
            this.aDDToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.aDDToolStripMenuItem.Text = "ADD";
            this.aDDToolStripMenuItem.Click += new System.EventHandler(this.ADDToolStripMenuItem_Click);
            // 
            // sHOWToolStripMenuItem
            // 
            this.sHOWToolStripMenuItem.Name = "sHOWToolStripMenuItem";
            this.sHOWToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.sHOWToolStripMenuItem.Text = "SHOW";
            // 
            // aUTHORToolStripMenuItem
            // 
            this.aUTHORToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aUTHORToolStripMenuItem.Name = "aUTHORToolStripMenuItem";
            this.aUTHORToolStripMenuItem.Size = new System.Drawing.Size(84, 25);
            this.aUTHORToolStripMenuItem.Text = "AUTHOR";
            // 
            // anasekil
            // 
            this.anasekil.Image = ((System.Drawing.Image)(resources.GetObject("anasekil.Image")));
            this.anasekil.Location = new System.Drawing.Point(0, 32);
            this.anasekil.Name = "anasekil";
            this.anasekil.Size = new System.Drawing.Size(1252, 555);
            this.anasekil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.anasekil.TabIndex = 1;
            this.anasekil.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 651);
            this.Controls.Add(this.anasekil);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anasekil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aNASEHIFEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bOOKSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sHOWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aUTHORToolStripMenuItem;
        private System.Windows.Forms.PictureBox anasekil;
    }
}

