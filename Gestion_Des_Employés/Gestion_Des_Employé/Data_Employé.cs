using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Serialization;
using Bunifu.UI.WinForms;

namespace Gestion_Des_Employés.Gestion_Des_Employé
{
    internal class Data_Employé
    {
        public static void Ajouter_Emp(string nom_emp, string prenom_emp, string adress_emp, string num_tel, string sexe_emp, DateTime date, double salaire, int id_emp)
        {
            try
            {
                Connexion.conn.Open();
                SqlCommand sql = new SqlCommand("INSERT INTO Employé (Nom_emp,prénom_emp,Adress_emp,Numéro_emp,sexe_emp,date_de_naissance,Salaire_emp,id_dep) VALUES ('" + nom_emp + "' ,'" + prenom_emp + "','" + adress_emp + "','" + num_tel + "','" + sexe_emp + "','" + date + "','" + salaire + "','" + id_emp + "');", Connexion.conn);
                sql.ExecuteNonQuery();
                Connexion.conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connexion.conn.Close();

            }

        }
        public static void Modifier_Emp(string nom_emp, string prenom_emp, string adress_emp, string num_tel, string sexe_emp, DateTime date, double salaire,int id)
        {
            try
            {
                Connexion.conn.Open();
                SqlCommand sql = new SqlCommand("update Employé set Nom_emp=N'"+nom_emp+"', prénom_emp=N'"+prenom_emp+"',Adress_emp=N'"+adress_emp+"',Numéro_emp='"+num_tel+"',sexe_emp='"+sexe_emp+ "',date_de_naissance='" + date+ "',Salaire_emp='"+salaire+"' where id_emp='"+id+"';", Connexion.conn);
                sql.ExecuteNonQuery();
                Connexion.conn.Close();
            }
            catch(Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connexion.conn.Close();

            }
        }
        public static List<String> GetEmp (int id )
        {
            List<String> liste = new List<string>();
            try
            {
                Connexion.conn.Open();
                SqlCommand sql = new SqlCommand("select * from Employé where id_emp='"+id+"';", Connexion.conn);
                SqlDataReader dr = sql.ExecuteReader();
                while (dr.Read())
                {
                    liste.Add(dr[0].ToString());
                    liste.Add(dr[1].ToString());
                    liste.Add(dr[2].ToString());
                    liste.Add(dr[3].ToString());
                    liste.Add(dr[4].ToString());
                    liste.Add(dr[5].ToString());
                    liste.Add(dr[6].ToString());
                    liste.Add(dr[7].ToString());
                    liste.Add(dr[8].ToString());

                }
                Connexion.conn.Close();
                return liste;
            }
            catch(Exception ex )
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connexion.conn.Close();
                return liste;
            }
        }
        public static void liste_Emp(BunifuDataGridView bunifuDataGridView, string text)
        {
            try
            {
                Connexion.conn.Open();
                SqlCommand sql = new SqlCommand("select id_emp,Nom_dep,Nom_emp,prénom_emp,Adress_emp,Numéro_emp,sexe_emp,date_de_naissance,Salaire_emp  from Employé, Département where Département.id_dep =Employé.id_dep AND Nom_emp LIKE '%" + text + "%' order by id_emp", Connexion.conn);
                SqlDataReader dr = sql.ExecuteReader();
                bunifuDataGridView.Rows.Clear();
                while (dr.Read())
                {
                    bunifuDataGridView.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], dr[6], dr[7], dr[8]);
                }
                Connexion.conn.Close();
            }
            catch(Exception ex )
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connexion.conn.Close();

            }
        }
      
    }
}
