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

            /*Huisartsen moeten in de dropdown komen.
            foreach ()
            {
               Artsen.Items.Add();
            }
            */

            /*Klanten moeten in de dropdown komen.
            foreach ()
            {
                Klant.Items.Add();
            }
            */

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

        // Huisarts contract moet met een jaar omhoog
        private void button1_Click(object sender, EventArgs e)
        {
        }

        // Er moeten stickerlabels geprint kunnen worden
        private void button2_Click(object sender, EventArgs e)
        {

        }

        // Gegevens van klant of huisarts moeten aangepast worden (code klopt niet helemaal voor deze actie)
        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {

                Klanten k = new Klanten();
                k.Naam = textBox1.Text;
                k.Adres = textBox2.Text;
                k.Postcode = textBox3.Text;
                k.Plaats = textBox4.Text;
                k.Arts = Artsen.Text;
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
            }

            else if (radioButton2.Checked)
            {
                Huisartsen h = new Huisartsen();
                h.Naam = textBox1.Text;
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
            }
        }

        // Er moet gezocht kunne worden
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Database db = new Database();

            if (radioButton1.Checked)
            {

                Klanten k = new Klanten();
                k.Naam = textBox1.Text;
                k.Adres = textBox2.Text;
                k.Postcode = textBox3.Text;
                k.Plaats = textBox4.Text;
                k.Arts = Artsen.Text;
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
            }

            else if (radioButton2.Checked)
            {
                Huisartsen h = new Huisartsen();
                h.Naam = textBox1.Text;
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
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Medicatie m = new Medicatie();
            m.KlantId = Convert.ToInt32(Klant.Text);
            m.Naam = textBox6.Text;

            db.Medicatie.Add(m);
            db.SaveChanges();
            Medicatie.DataSource = db.Medicatie.ToList();

            Klant.Text = "";
            textBox6.Text = "";
        }

        // Huisarts moet verwijderd worden uit de db
        private void button7_Click(object sender, EventArgs e)
        {

        }

        // Medicijn moet verwijderd worden uit de db
        private void button8_Click(object sender, EventArgs e)
        {

        }

        // Klant moet verwijderd worden uit de db
        private void button9_Click(object sender, EventArgs e)
        {

        }

        // De huisarts van de gekozen klant moet verschijnen en de medicatie van de klant
        private void Klanten_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // De klanten van de gekonzen arts moeten verschijnen
        private void Huisartsen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
