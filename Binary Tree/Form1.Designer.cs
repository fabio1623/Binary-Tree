namespace Binary_Tree
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnNodeObjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadTreeToolStripMenuItem,
            this.returnNodeObjectToolStripMenuItem,
            this.geToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // loadTreeToolStripMenuItem
            // 
            this.loadTreeToolStripMenuItem.Name = "loadTreeToolStripMenuItem";
            this.loadTreeToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.loadTreeToolStripMenuItem.Text = "Load tree";
            this.loadTreeToolStripMenuItem.Click += new System.EventHandler(this.loadTreeToolStripMenuItem_Click);
            // 
            // returnNodeObjectToolStripMenuItem
            // 
            this.returnNodeObjectToolStripMenuItem.Name = "returnNodeObjectToolStripMenuItem";
            this.returnNodeObjectToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.returnNodeObjectToolStripMenuItem.Text = "Return Node Object";
            this.returnNodeObjectToolStripMenuItem.Click += new System.EventHandler(this.returnNodeObjectToolStripMenuItem_Click);
            // 
            // geToolStripMenuItem
            // 
            this.geToolStripMenuItem.Name = "geToolStripMenuItem";
            this.geToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.geToolStripMenuItem.Text = "Exit";
            this.geToolStripMenuItem.Click += new System.EventHandler(this.geToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadTreeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnNodeObjectToolStripMenuItem;
    }
}

