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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Klanten.ToList();
            dataGridView2.DataSource = db.Huisartsen.ToList();
            dataGridView3.DataSource = db.Medicatie.ToList();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
