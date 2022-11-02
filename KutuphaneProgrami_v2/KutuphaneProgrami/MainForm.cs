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
        public List<AuthorModel> authors = new List<AuthorModel>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void kitapErleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBookForm addBookForm = new AddBookForm(this);
            addBookForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // listboxtan item seçmediğimizde "-1" döndüğü için kontrol ediyoruz
            if (listBox1.SelectedIndex != -1)
            {
                int autIndex = listBox1.SelectedIndex;
                int bookIndex = listBox2.SelectedIndex;
                EditAuthorForm editAuthorForm = new EditAuthorForm(this, autIndex);
                editAuthorForm.Show();
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
                int index = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(index);
                authors.RemoveAt(index);
                changeVisile(false, button1, button2);
                listBox2.Items.Clear();
                listing();
                changeVisile(false, button3, button4);
            }
        }

        public void updateAuthorListbox(int i)
        {
            listBox1.Items[i] = $"Ad: {authors[i]._firstName} Soyad: {authors[i]._lastName}";
        }
  

        public void addAuthorListbox(AuthorModel author)
        {
            listBox1.Items.Add($"UID: {author._uid} name: {author._firstName} surname: {author._lastName}");
        }

        // buton görünürlüğü
        private void listBox1_Click(object sender, EventArgs e)
        {
            listing();
        }

        public void listing()
        {
            int select = listBox1.SelectedIndex;
            if (select != -1)
            {
                changeVisile(true, button1, button2);
                listBox2.Items.Clear();
                foreach (var item in authors[select]._books)
                {
                    listBox2.Items.Add($"SN: {item.serialNumber}  Book name: { item.bookName}");
                }
            }
        }

        private void listBox2_Click(object sender, EventArgs e)
        {
            int select = listBox2.SelectedIndex;
            if (select != -1)
            {
                changeVisile(true, button3, button4);
            }
        }

        private void MainForm_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            changeVisile(false, button1, button2);
            changeVisile(false, button3, button4);
        }

        void changeVisile(bool visible, Button btn1, Button btn2)
        {
            btn1.Visible = visible;
            btn2.Visible = visible;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void yazarEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthorManager authorManager = new AuthorManager(this);
            authorManager.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int autIndex = listBox1.SelectedIndex;
            int bookIndex = listBox2.SelectedIndex;
            EditBookForm editBookForm = new EditBookForm(this,autIndex,bookIndex);
            editBookForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Silmek istediğinize emin misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                int index = listBox2.SelectedIndex;
                int index2 = listBox1.SelectedIndex;
                listBox2.Items.RemoveAt(index);
                authors[index2]._books.RemoveAt(index);
                listing();
                changeVisile(false, button3, button4);
            }
        }
    }

}
