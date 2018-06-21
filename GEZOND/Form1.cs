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
            Dokters.DataSource = db.Huisartsen.ToList();
            Medicatie.DataSource = db.Medicatie.ToList();
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
                k.ArtsId = Convert.ToInt32(textBox5.Text);
                k.Verzekeraar = textBox6.Text;

                db.Klanten.Add(k);
                db.SaveChanges();
                Klanten.DataSource = db.Klanten.ToList();
            }

            else if (radioButton2.Checked)
            {
                Klanten k = new Klanten();
                k.Naam = Convert.ToString(textBox1.Text);
                k.Adres = Convert.ToString(textBox2.Text);
                k.Postcode = Convert.ToString(textBox3.Text);
                k.Plaats = Convert.ToString(textBox4.Text);

                db.Klanten.Add(k);
                db.SaveChanges();
                Klanten.DataSource = db.Klanten.ToList();
            }

        }
    }
}
