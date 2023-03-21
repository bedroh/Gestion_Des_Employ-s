using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Des_Employés.Gestion_Des_Département
{
    public partial class Ajouter_Département : Form
    {
        public Ajouter_Département()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            if (bunifuTextBox1.Text=="" || bunifuTextBox2.Text == "")
            {
                MessageBox.Show("Esseyer remplir toutes les zones.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

            }
            else
            {
                Data_Département.Ajouter_DPT(bunifuTextBox1.Text, bunifuTextBox2.Text);
                MessageBox.Show("Département ajouter avec succes", "Ajouter avec succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.Close();
                bunifuTextBox1.Clear();
                bunifuTextBox2.Clear();
            }
        }
    }
}
