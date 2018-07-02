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
            using (SqlConnection conn = new SqlConnection(@"Initial Catalog = TrocaOleo; Data Source = localhost; Integrated Security = SSPI"))
            {
                string strSQL = @"INSERT INTO servico_troca_oleo (data_servico, cod_cliente, cod_oleo, qtde_litro) VALUES (@data_servico, @cod_cliente, @cod_oleo, @qtde_litro);";
                
                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@data_servico", SqlDbType.DateTime).Value = obj.Data;
                    cmd.Parameters.Add("@cod_cliente", SqlDbType.Int).Value = obj.Cliente.Cod;
                    cmd.Parameters.Add("@cod_oleo", SqlDbType.Int).Value = obj.Oleo.Cod;
                    cmd.Parameters.Add("@qtde_litro", SqlDbType.Int).Value = obj.QtdeLitro;                                    
                   
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
    }
}
