using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneProgrami
{
    public partial class AuthorManager : Form
    {
        MainForm mainForm;
        public AuthorManager(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string UID = textBox1.Text;
            string firstName = textBox2.Text;
            string lastName = textBox3.Text;
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                AuthorModel author = new AuthorModel(UID, firstName, lastName);
                mainForm.authors.Add(author);
                mainForm.addAuthorListbox(author);
                mainForm.Show();
                this.Close();
            }
            else MessageBox.Show("Boş Alan Bırakılamaz");
        }

        private void AuthorManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
