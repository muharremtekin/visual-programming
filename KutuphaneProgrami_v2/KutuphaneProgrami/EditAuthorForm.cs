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
    public partial class EditAuthorForm : Form
    {
        MainForm _mainForm;
        int _authorIndex;
        public EditAuthorForm(MainForm mainForm, int authorIndex)
        {
            InitializeComponent();
            this._mainForm = mainForm;
            this._authorIndex = authorIndex;
            _initValues();
        }
        void _initValues()
        {
            textBox1.Text = _mainForm.authors[_authorIndex]._uid;
            textBox2.Text = _mainForm.authors[_authorIndex]._firstName;
            textBox3.Text = _mainForm.authors[_authorIndex]._lastName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Yazarı güncellemek istediğinize emin misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                _mainForm.authors[_authorIndex]._firstName = textBox2.Text;
                _mainForm.authors[_authorIndex]._lastName = textBox3.Text;
                _mainForm.updateAuthorListbox(_authorIndex);
                this.Close();
                _mainForm.Show();
            }
        }

        private void EditAuthorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _mainForm.Show();
        }
    }
}
