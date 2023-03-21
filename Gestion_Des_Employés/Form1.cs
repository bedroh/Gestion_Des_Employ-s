using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Gestion_Des_Employés.Gestion_Des_Employé;

namespace Gestion_Des_Employés
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            liste_Des_Employé1.Show();
            liste_Des_Employé1.BringToFront();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            Gestion_Des_Département.Ajouter_Département ajty = new Gestion_Des_Département.Ajouter_Département();
            ajty.ShowDialog();
        }
    }
}
