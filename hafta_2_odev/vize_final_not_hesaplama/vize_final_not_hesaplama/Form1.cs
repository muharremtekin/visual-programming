using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vize_final_not_hesaplama
{
    public partial class Form1 : Form
    {
        // public varribles

        double sinav1 = 0;
        double sinav2 = 0;
        double ortalama = 0;

        public Form1()
        {
            InitializeComponent();
            label3.Visible = false;
        }
        

        String gectiKaldiHesapla(double avg)
        {
            if (avg >= 84)
                return "AA";

            else if(avg >= 70 && avg <= 83)
                return "BB";

            else if (avg >= 60 && avg < 70)
                return "BC";

            else if (avg >= 50 && avg < 60)
                return "CC";

            else if ( avg < 49)
                return "DD";
            
            else
                return "FF";
        }

        void ortHesapla()
        {
            sinav1 = Convert.ToInt32(numericUpDown1.Value);
            sinav2 = Convert.ToInt32(numericUpDown2.Value);
            ortalama = sinav1 * 0.4 + sinav2 * 0.6;
        }

        void hesapla()
        {
            if (label3.Visible == false)
                label3.Visible = true;

            ortHesapla();
            if (ortalama < 50 || sinav2 < 50)
            {
                // "\n" koyarsak bir satır aşağı iner.
                label3.ForeColor = Color.Red;
                label3.Text = $"Kaldı!\nOrtalama: {ortalama}\nHarf notu: {gectiKaldiHesapla(ortalama)}";
            }
            else
            {
                label3.ForeColor = Color.Green;
                label3.Text = $"Geçti!\nOrtalama: {ortalama}\nHarf notu: {gectiKaldiHesapla(ortalama)} ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hesapla();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            hesapla();
        }
    }
}
