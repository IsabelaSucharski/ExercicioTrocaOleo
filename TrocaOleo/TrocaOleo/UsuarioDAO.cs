using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocaOleo
{
    public class UsuarioDAO
    {
        public static Usuario Logar(Usuario obj)
        {
            using (SqlConnection conn = new SqlConnection(@"Initial Catalog = TrocaOleo; Data Source = localhost; Integrated Security = SSPI"))
            {
                string strSQL = "select email, senha from Usuario " +
                    "where email = @email or senha = @senha";

                DataTable dt = new DataTable();
                conn.Open();

                using (SqlCommand cmdo = new SqlCommand(strSQL))
                {
                    cmdo.CommandType = CommandType.Text;
                    cmdo.Connection = conn;
                    cmdo.CommandText = strSQL;

                    cmdo.Parameters.Add("@email", SqlDbType.VarChar).Value = obj.Email;
                    cmdo.Parameters.Add("@senha", SqlDbType.VarChar).Value = obj.Senha;

                    SqlDataReader dataReader;
                    dataReader = cmdo.ExecuteReader();
                    dt.Load(dataReader);

                    if (!(dt != null && dt.Rows.Count > 0))
                        return null;

                    var row = dt.Rows[0];
                    var usuario = new Usuario()
                    {
                        Email = row["email"].ToString(),
                        Senha = row["senha"].ToString()
                    };

                    conn.Close();
                    return usuario;
                }
            }
        }

        public static void Inserir(Usuario obj)
        {
            using (SqlConnection conn = new SqlConnection(@"Initial Catalog = TrocaOleo; Data Source = localhost; Integrated Security = SSPI"))
            {

                string strSQL = @"INSERT INTO usuario (email, senha) VALUES (@email, @senha);";

                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = obj.Email;
                    cmd.Parameters.Add("@senha", SqlDbType.VarChar).Value = obj.Senha;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    
                }
            }
        }
    }
}
