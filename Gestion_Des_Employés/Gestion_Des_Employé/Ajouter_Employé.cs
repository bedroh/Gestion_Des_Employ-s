using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Des_Employés.Gestion_Des_Employé
{
    public partial class Ajouter_Employé : Form
    {
        public Ajouter_Employé()
        {
            InitializeComponent();
        }

      

        private void bunifuTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Ajouter_Employé_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'employéDataSet.Département'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.départementTableAdapter.Fill(this.employéDataSet.Département);
            // TODO: cette ligne de code charge les données dans la table 'employéDataSet.Employé'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.employéTableAdapter.Fill(this.employéDataSet.Employé);

        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            if (bunifuTextBox1.Text==""||  bunifuTextBox2.Text == "" || bunifuTextBox3.Text == "" || bunifuTextBox4.Text == "" || bunifuTextBox7.Text == "" )
            {

                MessageBox.Show("Esseyer remplir toutes les zones.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

            }
            else
            {
                Data_Employé.Ajouter_Emp(bunifuTextBox1.Text, bunifuTextBox2.Text ,bunifuTextBox3.Text, bunifuTextBox4.Text, bunifuDropdown1.Text, bunifuDatePicker1.Value,double.Parse(bunifuTextBox7.Text),int.Parse(bunifuDropdown2.SelectedValue.ToString()));
                MessageBox.Show("Employé ajouter avec succes", "Ajouter avec succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
