using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Gestion_Des_Employés
{
    internal class Connexion
    {
        public static SqlConnection conn = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=Employé;Integrated Security=True");
    }
}
