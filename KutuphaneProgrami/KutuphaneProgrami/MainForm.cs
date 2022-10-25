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
    public partial class MainForm : Form
    {
        // kitapların obje olarak tutulduğu list
        public List<BookModel> addedBooks = new List<BookModel>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void kitapErleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBook addBook = new(this);
            addBook.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // listboxtan item seçmediğimizde "-1" döndüğü için kontrol ediyoruz
            if (listBox1.SelectedIndex != -1)
            {
                EditBookForm _editBookForm = new EditBookForm(addedBooks[listBox1.SelectedIndex], listBox1.SelectedIndex, this);
                _editBookForm.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Kitap seçmediniz!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // dialog resul ile messageboxtan gelen dialogu yakalayıp evet e basıldıysa silme işlemini yapıyoruz. 
            DialogResult dialog = MessageBox.Show("Silmek istediğinize emin misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if ( dialog == DialogResult.Yes)
            {
                int index = listBox1.SelectedIndex; // seçili itemin indexini alıp index değişkenine atıyoruz. dümdüz yazsam da çalışırdı.
                listBox1.Items.RemoveAt(index); 
                addedBooks.RemoveAt(index);
            }
        }

        public void addBook(BookModel _book)
        {
            listBox1.Items.Add(_book.bookAuthor + " " + _book.bookName);
            addedBooks.Add(_book);
        }
        public void updateListboxItem(BookModel _book)
        {
            int index = listBox1.SelectedIndex;
            listBox1.Items[index] = $"Yazar: {_book.bookAuthor} - Kitap adı: {_book.bookName}";
            addedBooks[index] = _book;
            label1.Text = _book.bookName;
        }

        // buton görünürlüğü
        private void listBox1_Click(object sender, EventArgs e)
        {
            changeVisile(true);
        }

        private void MainForm_Click(object sender, EventArgs e)
        {
            changeVisile(false);
        }

        void changeVisile(bool vb)
        {
            button1.Visible = vb;
            button2.Visible = vb;
        }
    }

}
