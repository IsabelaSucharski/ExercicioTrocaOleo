using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocaOleo
{
    class ClienteDAO
    {
        public List<Cliente> CarregarCliente()
        {
            var lst = new List<Cliente>();

            using (SqlConnection conn = new SqlConnection(@"Initial Catalog = TrocaOleo; Data Source = localhost; Integrated Security = SSPI"))
            {
                string strSQL = "SELECT nome FROM clientes;";

                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = strSQL;

                    var dataReader = cmd.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(dataReader);

                    conn.Close();
                    foreach (DataRow row in dt.Rows)
                    {
                        var Cliente = new Cliente()
                        {
                            Cod = Convert.ToInt32(row["cod_cliente"]),
                            Nome = row["nome"].ToString()
                        };
                        lst.Add(Cliente);
                    }
                }
            }
            return lst;
        }

        public Cliente BuscarPorEmail()
        {

        }
    }
}
