using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GEZOND
{
    public partial class Form1 : Form
    {
        Database db = new Database();

        public Form1()
        {
            InitializeComponent();

            // dropdown bij de klant voor de doktoren
            foreach (Huisartsen item in db.Huisartsen)
            {
               Artsen.Items.Add(item.Naam);
            }

            // dropdown bij de medicatie voor de klanten
            foreach (Klanten item in db.Klanten)
            {
                Klant.Items.Add(item.Naam);
            }

            // dropdown bij de dokter voor de maanden
            Maanden.Items.Add("Januari");
            Maanden.Items.Add("Februari");
            Maanden.Items.Add("Maart");
            Maanden.Items.Add("April");
            Maanden.Items.Add("Mei");
            Maanden.Items.Add("Juni");
            Maanden.Items.Add("Juli");
            Maanden.Items.Add("Augustus");
            Maanden.Items.Add("September");
            Maanden.Items.Add("Oktober");
            Maanden.Items.Add("November");
            Maanden.Items.Add("December");
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            Klanten.DataSource = db.Klanten.ToList();
            Huisartsen.DataSource = db.Huisartsen.ToList();
            Medicatie.DataSource = db.Medicatie.ToList();
        }

        // Huisarts contract met een jaar verlengen
        private void button1_Click(object sender, EventArgs e)
        {
            Huisartsen h = (Huisartsen)Huisartsen.CurrentRow.DataBoundItem;
            h.Jaar++;

            db.SaveChanges();
            Huisartsen.DataSource = db.Huisartsen.ToList();
        }

        // stickerlabels printen
        private void button2_Click(object sender, EventArgs e)
        {

        }

        // zoeken
        private void button4_Click(object sender, EventArgs e)
        {
            string Zoek = textBox11.Text;
        }

        // huisarts of klant toevoegen
        private void button5_Click(object sender, EventArgs e)
        {
            Database db = new Database();

            if (radioButton1.Checked)
            {
                if (textBox1 != null && textBox2 != null && textBox3 != null && textBox4 != null && Artsen != null && textBox7 != null)
                {
                    string naam = textBox1.Text;
                    Klanten k = new Klanten();
                    k.Naam = naam;
                    k.Adres = textBox2.Text;
                    k.Postcode = textBox3.Text;
                    k.Plaats = textBox4.Text;
                    int Dokter = 0;
                    foreach (Huisartsen item in db.Huisartsen)
                    {
                        if (Artsen.Text == item.Naam)
                        {
                            Dokter = item.Id;
                        }
                    }
                    k.ArtsId = Dokter;
                    k.Verzekeraar = textBox7.Text;

                    db.Klanten.Add(k);
                    db.SaveChanges();
                    Klanten.DataSource = db.Klanten.ToList();

                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    Artsen.Text = "";
                    textBox7.Text = "";
                    Klant.Items.Add(naam);
                }
                else
                {
                }
            }

            else if (radioButton2.Checked)
            {
                if (textBox1 != null && textBox2 != null && textBox3 != null && textBox4 != null && Maanden != null && textBox9 != null)
                {
                    string naam = textBox1.Text;
                    Huisartsen h = new Huisartsen();
                    h.Naam = naam;
                    h.Adres = textBox2.Text;
                    h.Postcode = textBox3.Text;
                    h.Plaats = textBox4.Text;
                    h.Maand = Maanden.Text;
                    h.Jaar = Convert.ToInt32(textBox9.Text);

                    db.Huisartsen.Add(h);
                    db.SaveChanges();
                    Huisartsen.DataSource = db.Huisartsen.ToList();

                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    Maanden.Text = "";
                    textBox9.Text = "";
                    Artsen.Items.Add(naam);
                }
                else
                {
                }
            }

        }

        // medicatie toevoegen
        private void button6_Click(object sender, EventArgs e)
        {
            Medicatie m = new Medicatie();
            int Patient = 0;
            foreach (Klanten item in db.Klanten)
            {
                if (Klant.Text == item.Naam)
                {
                    Patient = item.Id;
                }
            }
            m.KlantId = Patient;
            m.Naam = textBox6.Text;

            db.Medicatie.Add(m);
            db.SaveChanges();
            Medicatie.DataSource = db.Medicatie.ToList();

            Klant.Text = "";
            textBox6.Text = "";
        }

        // De huisarts en medicatie van de gekozen klant laten zien
        private void Klanten_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Klanten.SelectedRows.Count == 1)
            {
                Klanten k = (Klanten)Klanten.CurrentRow.DataBoundItem;
                Huisartsen.DataSource = db.Huisartsen.ToList();
                Medicatie.DataSource = db.Medicatie.ToList();
            }
        }

        // De klanten van de gekozen arts laten zien
        private void Huisartsen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Huisartsen.SelectedRows.Count == 1)
            {
                Huisartsen h = (Huisartsen)Huisartsen.CurrentRow.DataBoundItem;
                Klanten.DataSource = db.Klanten.ToList();
                Medicatie.DataSource = db.Medicatie.ToList();
            }
        }

        // klant verwijderen
        private void button8_Click(object sender, EventArgs e)
        {
            if (Klanten.SelectedRows.Count == 1)
            {
                Klanten k = (Klanten)Klanten.CurrentRow.DataBoundItem;
                var itemToRemove = db.Klanten.SingleOrDefault(x => x.Id == k.Id);

                if (itemToRemove != null)
                {
                    db.Klanten.Remove(itemToRemove);
                    db.SaveChanges();
                    Klanten.DataSource = db.Klanten.ToList();
                }
            }
        }

        // medicatie verwijderen
        private void button7_Click(object sender, EventArgs e)
        {
            if (Medicatie.SelectedRows.Count == 1)
            {
                Medicatie m = (Medicatie)Medicatie.CurrentRow.DataBoundItem;
                var itemToRemove = db.Medicatie.SingleOrDefault(x => x.Id == m.Id);

                if (itemToRemove != null)
                {
                    db.Medicatie.Remove(itemToRemove);
                    db.SaveChanges();
                    Medicatie.DataSource = db.Medicatie.ToList();
                }
            }
        }

        // arts verwijderen
        private void button3_Click(object sender, EventArgs e)
        {
            if (Huisartsen.SelectedRows.Count == 1)
            {
                Huisartsen h = (Huisartsen)Huisartsen.CurrentRow.DataBoundItem;
                var itemToRemove = db.Huisartsen.SingleOrDefault(x => x.Id == h.Id);

                if (itemToRemove != null)
                {
                    db.Huisartsen.Remove(itemToRemove);
                    db.SaveChanges();
                    Huisartsen.DataSource = db.Huisartsen.ToList();
                }
            }
        }

        // alle gegevens tonens
        private void button9_Click(object sender, EventArgs e)
        {
            Klanten.DataSource = db.Klanten.ToList();
            Huisartsen.DataSource = db.Huisartsen.ToList();
            Medicatie.DataSource = db.Medicatie.ToList();
        }
    }
}
