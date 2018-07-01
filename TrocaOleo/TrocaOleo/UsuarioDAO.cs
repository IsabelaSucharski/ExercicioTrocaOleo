using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocaOleo
{
    public class UsuarioDAO
    {
        public void Inserir()
        {
            using (SqlConnection conn = new SqlConnection(@"Initial Catalog=troca_oleo; Data Source = localhost; Integrated Security=SSPI"))
            {

            }
        }
    }
}
