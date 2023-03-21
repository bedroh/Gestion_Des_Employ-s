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
    public partial class Liste_Des_Employé : UserControl
    {
        public Liste_Des_Employé()
        {
            InitializeComponent();
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            Ajouter_Employé ajt = new Ajouter_Employé();
            ajt.ShowDialog();
            Data_Employé.liste_Emp(bunifuDataGridView1, bunifuTextBox1.Text);
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = bunifuDataGridView1.Rows[e.RowIndex].Index;
                bunifuButton22.PerformClick();
                String colname = bunifuDataGridView1.Columns[e.ColumnIndex].Name;
                String id = bunifuDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                String nom_dep = bunifuDataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                String nom_emp = bunifuDataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                String prénom = bunifuDataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                String adress = bunifuDataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                String numéro = bunifuDataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                String sexe = bunifuDataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                String date = bunifuDataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                String salaire = bunifuDataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                if(colname== "mod")
                {
                    Modifier_Employé modi = new Modifier_Employé(int.Parse(id));
                    modi.ShowDialog();

                }


                bunifuButton22.PerformClick();

                bunifuDataGridView1.Rows[index].Selected = true;

            }
            catch
            {

            }
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            Data_Employé.liste_Emp(bunifuDataGridView1, bunifuTextBox1.Text);
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            Data_Employé.liste_Emp(bunifuDataGridView1, bunifuTextBox1.Text);
        }

        private void Liste_Des_Employé_Load(object sender, EventArgs e)
        {
           Data_Employé.liste_Emp(bunifuDataGridView1, bunifuTextBox1.Text);
        }
    }
}
