using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocaOleo
{ 

    class OleoDAO
    {
        public List<Oleo> CarregarOleo()
        {
            using (SqlConnection conn = new
            SqlConnection(Properties.Settings.Default.conn))
            {
                string srtSQL = "SELECT * FROM oleo";
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
                    conn.Close();
                    
                    if (!(dt != null && dt.Rows.Count > 0))
                        return null;

                    List<Oleo> lst = new List<Oleo>();
                    foreach (DataRow row in dt.Rows)
                    {
                        Oleo oleo = new Oleo();
                        oleo.Nome = Convert.ToString(row["nome"]);
                        oleo.Categoria = Convert.ToString(row["categoria"]);
                        oleo.Tipo = Convert.ToString(row["tipo_oleo"]);
                        oleo.Fabricante = Convert.ToString(row["fabricante"]);                        
                        lst.Add(oleo);
                    }
                    return lst;
                }
            }
        }
              
    }
}
