using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;

namespace sinemaseanstakipuygulama
{
    public partial class Form1 : Form
    {
        private ApplicationContext dbContext;
        public Form1()
        {
            InitializeComponent();
            dbContext = new ApplicationContext();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView2.AutoGenerateColumns = false;
            dataGridView3.AutoGenerateColumns = false;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int colIndex = e.ColumnIndex;
            MessageBox.Show("DataGridView1 hücresinde içerik değişti. Satır: " + rowIndex + ", Sütun: " + colIndex);
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int colIndex = e.ColumnIndex;
            MessageBox.Show("DataGridView3 hücresinde içerik değişti. Satır: " + rowIndex + ", Sütun: " + colIndex);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int colIndex = e.ColumnIndex;
            MessageBox.Show("DataGridView2 hücresinde içerik değişti. Satır: " + rowIndex + ", Sütun: " + colIndex);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string girilenMetin = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string girilenMetin = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Film yeniFilm = new Film { FilmAdi = textBox1.Text, SeansSaatleri = textBox2.Text };
            dbContext.Filmler.Add(yeniFilm);
            dbContext.SaveChanges();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string girilenMetin = textBox3.Text;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int secilenSayi = (int)numericUpDown1.Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Salon yeniSalon = new Salon { SalonAdi = textBox3.Text, KoltukKapasitesi = (int)numericUpDown1.Value };
            dbContext.Salonlar.Add(yeniSalon);
            dbContext.SaveChanges();
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string secilenTarih = dateTimePicker1.Value.ToShortDateString();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenItem = comboBox4.SelectedItem.ToString();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenItem = comboBox5.SelectedItem.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Film seciliFilm = dataGridView1.SelectedRows[0].DataBoundItem as Film;
            Salon seciliSalon = dataGridView2.SelectedRows[0].DataBoundItem as Salon;
            DateTime seciliTarihSaat = dateTimePicker1.Value;

            Seans yeniSeans = new Seans
            {
                FilmID = seciliFilm.FilmID,
                SalonID = seciliSalon.SalonID,
                TarihSaat = seciliTarihSaat
            };
            dbContext.Seanslar.Add(yeniSeans);
            dbContext.SaveChanges();
  
        }
    }
}
