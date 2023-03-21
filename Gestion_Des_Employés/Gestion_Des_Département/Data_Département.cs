using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Des_Employés.Gestion_Des_Département
{
    internal class Data_Département
    {
        public static void Ajouter_DPT(string nom,string description)
        {
            try
            {
                Connexion.conn.Open();
                SqlCommand sql = new SqlCommand(" INSERT INTO Département (Nom_dep , description_dep) VALUES ('" + nom+"' , '"+description+"');",Connexion.conn);
                sql.ExecuteNonQuery();
                Connexion.conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connexion.conn.Close();

            }
        }
        public static string get_dep(int id)
        {
            try
            {
                Connexion.conn.Open();
                SqlCommand sql = new SqlCommand("select * from Département where id_dep='" + id + "'; ", Connexion.conn);
                SqlDataReader dr = sql.ExecuteReader();
                String nom = "";
                while (dr.Read())
                {
                    nom = dr[1].ToString();
                }
                Connexion.conn.Close();
                return nom ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connexion.conn.Close();
                return "";
            }
        }
    }
}
