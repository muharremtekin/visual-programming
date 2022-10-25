
namespace KutuphaneProgrami
{
    partial class MainForm
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
            this.ktapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapErleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sdsdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sdsdToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menü5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ktapToolStripMenuItem,
            this.asdaToolStripMenuItem,
            this.sdsdToolStripMenuItem,
            this.sdsdToolStripMenuItem1,
            this.menü5ToolStripMenuItem,
            this.toolStripTextBox1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(433, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ktapToolStripMenuItem
            // 
            this.ktapToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapErleToolStripMenuItem});
            this.ktapToolStripMenuItem.Name = "ktapToolStripMenuItem";
            this.ktapToolStripMenuItem.Size = new System.Drawing.Size(46, 23);
            this.ktapToolStripMenuItem.Text = "Kitap";
            // 
            // kitapErleToolStripMenuItem
            // 
            this.kitapErleToolStripMenuItem.Name = "kitapErleToolStripMenuItem";
            this.kitapErleToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.kitapErleToolStripMenuItem.Text = "kitap ekle";
            this.kitapErleToolStripMenuItem.Click += new System.EventHandler(this.kitapErleToolStripMenuItem_Click);
            // 
            // asdaToolStripMenuItem
            // 
            this.asdaToolStripMenuItem.Name = "asdaToolStripMenuItem";
            this.asdaToolStripMenuItem.Size = new System.Drawing.Size(56, 23);
            this.asdaToolStripMenuItem.Text = "menü2";
            // 
            // sdsdToolStripMenuItem
            // 
            this.sdsdToolStripMenuItem.Name = "sdsdToolStripMenuItem";
            this.sdsdToolStripMenuItem.Size = new System.Drawing.Size(56, 23);
            this.sdsdToolStripMenuItem.Text = "menü3";
            // 
            // sdsdToolStripMenuItem1
            // 
            this.sdsdToolStripMenuItem1.Name = "sdsdToolStripMenuItem1";
            this.sdsdToolStripMenuItem1.Size = new System.Drawing.Size(56, 23);
            this.sdsdToolStripMenuItem1.Text = "menü4";
            // 
            // menü5ToolStripMenuItem
            // 
            this.menü5ToolStripMenuItem.Name = "menü5ToolStripMenuItem";
            this.menü5ToolStripMenuItem.Size = new System.Drawing.Size(56, 23);
            this.menü5ToolStripMenuItem.Text = "menü5";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Text = "ara";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 50);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(260, 214);
            this.listBox1.TabIndex = 1;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(279, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Düzenle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(279, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 275);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Click += new System.EventHandler(this.MainForm_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ktapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapErleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sdsdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sdsdToolStripMenuItem1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem menü5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
    }
}