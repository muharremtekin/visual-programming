
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
            this.yazarEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sdsdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sdsdToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menü5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.menuStrip1.Size = new System.Drawing.Size(692, 27);
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
            this.asdaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yazarEkleToolStripMenuItem});
            this.asdaToolStripMenuItem.Name = "asdaToolStripMenuItem";
            this.asdaToolStripMenuItem.Size = new System.Drawing.Size(46, 23);
            this.asdaToolStripMenuItem.Text = "Yazar";
            // 
            // yazarEkleToolStripMenuItem
            // 
            this.yazarEkleToolStripMenuItem.Name = "yazarEkleToolStripMenuItem";
            this.yazarEkleToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.yazarEkleToolStripMenuItem.Text = "Yazar ekle/düzenle";
            this.yazarEkleToolStripMenuItem.Click += new System.EventHandler(this.yazarEkleToolStripMenuItem_Click);
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
            this.listBox1.Location = new System.Drawing.Point(24, 199);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(172, 214);
            this.listBox1.TabIndex = 1;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(519, 198);
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
            this.button2.Location = new System.Drawing.Point(519, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Yazarlar";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(253, 199);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(260, 214);
            this.listBox2.TabIndex = 1;
            this.listBox2.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kitaplar";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Kütüphane otomasyonu";
            this.Load += new System.EventHandler(this.MainForm_Load);
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
        private System.Windows.Forms.ToolStripMenuItem yazarEkleToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label2;
    }
}