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

        private void Form1_Load(object sender, EventArgs e)
        {
            Klanten.DataSource = db.Klanten.ToList();
            Dokters.DataSource = db.Huisartsen.ToList();
            Medicatie.DataSource = db.Medicatie.ToList();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
