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
            _mainForm = mainForm;
            currentIndex = index;
            textBox1.Text = bookModel.bookAuthor;
            textBox2.Text = bookModel.bookName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // değişen kitap bilgilerini aldık.
            string updatedBookAuthor = textBox1.Text;
            string updatedBookName = textBox2.Text;

            // aldığımız verileri kitap modeline attık
            BookModel updatedBook = new BookModel(updatedBookAuthor, updatedBookName);

            // main formun nesnesi aracılığıyla güncelleme metotlarına eriştik ve güncellemeyi tamamladık.
            _mainForm.updateListboxItem(updatedBook);
            _mainForm.Show();
            
        }
    }
}
