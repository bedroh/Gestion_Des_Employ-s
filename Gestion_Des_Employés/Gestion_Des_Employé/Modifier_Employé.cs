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
    public partial class Modifier_Employé : Form
    {
        List<string> data = new List<string>();
        public Modifier_Employé(int id )
        {
            InitializeComponent();
            data = Data_Employé.GetEmp(id);
            bunifuTextBox1.Text = data[1];
            bunifuTextBox2.Text = data[2];
            bunifuTextBox3.Text = data[3];
            bunifuTextBox4.Text = data[4];
            bunifuDropdown1.Text = data[5];
            bunifuDatePicker1.Value = DateTime.Parse(data[6]);
            bunifuTextBox7.Text = data[7];
            bunifuDropdown2.SelectedValue = data[8];
            bunifuDropdown2.Text = Gestion_Des_Département.Data_Département.get_dep(int.Parse(data[8]));


        }

        private void Modifier_Employé_Load(object sender, EventArgs e)
        {

        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            //Data_Employé.Modifier_Emp(bunifuTextBox1.Text, bunifuTextBox2.Text, bunifuTextBox3.Text, bunifuTextBox4.Text, bunifuDropdown1.Text, bunifuDatePicker1.Value, double.Parse(bunifuTextBox7.Text), int.Parse(bunifuDropdown2.SelectedValue.ToString()));
           // MessageBox.Show("information Modifier avec succes", "Modifier avec succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
           // this.Close();
        }
    }
}
