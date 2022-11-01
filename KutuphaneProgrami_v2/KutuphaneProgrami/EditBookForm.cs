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
        int currentIndex;
        public EditBookForm(BookModel bookModel, int index, MainForm mainForm)
        {
           // kullanımlar yanlış ama daha detaylı ve temiz yapacak vaktim yok.
            InitializeComponent();
            
        }

        private void EditBookForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainForm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
