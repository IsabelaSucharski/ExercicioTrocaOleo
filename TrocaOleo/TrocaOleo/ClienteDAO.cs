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
            using (SqlConnection conn = new
            SqlConnection(Properties.Settings.Default.conn))
            {
                string srtSQL = "SELECT nome FROM cliente";
                DataTable dt = new DataTable();
                conn.Open();
                using (SqlCommand cmdo = new SqlCommand())
                {
                    cmdo.CommandType = CommandType.Text;
                    cmdo.Connection = conn;
                    cmdo.CommandText = srtSQL;
                    SqlDataReader dataReader;

                    dataReader = cmdo.ExecuteReader();
                    dt.Load(dataReader);

                    if (!(dt != null && dt.Rows.Count > 0))
                        return null;

                    List<Cliente> lst = new List<Cliente>();
                    foreach (DataRow row in dt.Rows)
                    {
                        Cliente cli = new Cliente();
                        cli.Nome = Convert.ToString(row["nome"]);
                        lst.Add(cli);
                    }
                    conn.Close();
                    return lst;
                }
            }
        }

        public bool ValidarEmail(string email)
        {
            if (String.IsNullOrEmpty(email))
                return false;
            if (!email.Contains("@") || !email.Contains("."))
                return false;
            string[] strCamposEmail = email.Split(new String[] { "@" }, StringSplitOptions.RemoveEmptyEntries);
            if (strCamposEmail.Length != 2)
                return false;
            if (strCamposEmail[0].Length < 3)
                return false;
            if (!strCamposEmail[1].Contains("."))
                return false;
            strCamposEmail = strCamposEmail[1].Split(new String[] { "." }, StringSplitOptions.RemoveEmptyEntries);
            if (strCamposEmail.Length < 2)
                return false;
            if (strCamposEmail[0].Length < 1)
                return false;
            return true;
        }
    }
}
