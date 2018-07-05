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
                string strSQL = @"INSERT INTO servico_troca_oleo (data, cliente, oleo, categoria, tipo, fabricante, valor_litro, valor_total, qtde, email) VALUES (@data, @cliente, @oleo, @categoria, @tipo, @fabricante, @valor_litro, @valor_Total, @qtde, @email);";

                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@data", SqlDbType.VarChar).Value = obj.Data;
                    cmd.Parameters.Add("@cliente", SqlDbType.VarChar).Value = obj.Cliente;
                    cmd.Parameters.Add("@oleo", SqlDbType.VarChar).Value = obj.Oleo;
                    cmd.Parameters.Add("@categoria", SqlDbType.VarChar).Value = obj.Categoria;
                    cmd.Parameters.Add("@tipo", SqlDbType.VarChar).Value = obj.Tipo;
                    cmd.Parameters.Add("@fabricante", SqlDbType.VarChar).Value = obj.Fabricante;
                    cmd.Parameters.Add("@valor_litro", SqlDbType.Decimal).Value = obj.ValorLitro;
                    cmd.Parameters.Add("@qtde", SqlDbType.Int).Value = obj.QtdeLitro;
                    cmd.Parameters.Add("@valor_total", SqlDbType.Decimal).Value = obj.ValorTotal;
                    cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = obj.Email;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }       
    }
}
