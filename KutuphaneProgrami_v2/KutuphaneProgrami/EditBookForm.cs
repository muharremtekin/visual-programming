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
    public partial class EditBookForm : Form
    {
        MainForm _mainForm;
        int _authorIndex;
        int _bookIndex;
        public EditBookForm(MainForm mainForm, int authorIndex, int bookIndex)
        {
           // kullanımlar yanlış ama daha detaylı ve temiz yapacak vaktim yok.
            InitializeComponent();
            this._mainForm = mainForm;
            this._authorIndex = authorIndex;
            this._bookIndex = bookIndex;
            _initValues();
        }
        void _initValues()
        {
            textBox1.Text = _mainForm.authors[_authorIndex]._books[_bookIndex].bookName;
            textBox2.Text = _mainForm.authors[_authorIndex]._books[_bookIndex].serialNumber;
        }

        private void EditBookForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainForm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Kitabı güncellemek istediğinize emin misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                _mainForm.authors[_authorIndex]._books[_bookIndex].bookName = textBox1.Text;
                _mainForm.listing();
                this.Close();
                _mainForm.Show();
            }
        }
    }
}
