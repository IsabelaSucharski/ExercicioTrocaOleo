using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocaOleo
{
    public class ServicoDAO
    {
        public void Inserir(ServicoTrocaOleo obj)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn))
            {
                string strSQL = @"INSERT INTO servico_troca_oleo (data, cliente, oleo, categoria, tipo, fabricante, valor_total, email) VALUES (@data, @cliente, @oleo, @categoria, @tipo, @fabricante, @valor_Total, @email);";

                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@Data", SqlDbType.VarChar).Value = obj.Data;
                    cmd.Parameters.Add("@Cliente", SqlDbType.VarChar).Value = obj.Cliente;
                    cmd.Parameters.Add("@Oleo", SqlDbType.VarChar).Value = obj.Oleo;
                    cmd.Parameters.Add("@Categoria", SqlDbType.VarChar).Value = obj.Categoria;
                    cmd.Parameters.Add("@Tipo", SqlDbType.VarChar).Value = obj.Tipo;
                    cmd.Parameters.Add("@Fabricante", SqlDbType.VarChar).Value = obj.Fabricante;
                    cmd.Parameters.Add("@ValorTotal", SqlDbType.VarChar).Value = obj.ValorTotal;
                    cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = obj.Email;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }       
    }
}
