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
                listBox2.Items.Clear();
                foreach (var item in authors[listBox1.SelectedIndex]._books)
                {
                    listBox2.Items.Add(item.serialNumber+ " "+ item.bookName);
                }
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
                
            }
        }

        public void addBookListbox(int index)
        {
            foreach (var item in authors[index]._books)
            {
                listBox1.Items.Add($"{item.bookName} ({authors[index]._firstName} {authors[index]._lastName})");
            }
        }

        public void addAuthorListbox(AuthorModel author)
        {
            listBox1.Items.Add($"UID: {author._uid} name: {author._firstName} surname: {author._lastName}");
        }

        // buton görünürlüğü
        private void listBox1_Click(object sender, EventArgs e)
        {
            int select = listBox1.SelectedIndex;
            if (select != -1)
            {
                changeVisile(true);
            }
            
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

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void yazarEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthorManager authorManager = new AuthorManager(this);
            authorManager.Show();
            this.Hide();
        }
    }

}
