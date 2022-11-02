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
    public partial class AddBookForm : Form
    {
        MainForm mainForm;
        public AddBookForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            _initComboboxItems();
        }

        void _initComboboxItems()
        {
            foreach (var a in mainForm.authors)
            {
                comboBox1.Items.Add( a.ToString() );
            }
        }
        void addBookItem()
        {
            string serialNumber = textBox2.Text;
            string bookName = textBox1.Text;

            if (comboBox1.SelectedIndex != -1 && serialNumber != null)
            {
                BookModel book = new BookModel(serialNumber, bookName);
                mainForm.authors[comboBox1.SelectedIndex]._books.Add(book);
                mainForm.Show();
                this.Close();
            }
            else MessageBox.Show("Lütfen İlgili Alanları Doldurunuz");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addBookItem();
        }

        private void AddBookForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Show();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
