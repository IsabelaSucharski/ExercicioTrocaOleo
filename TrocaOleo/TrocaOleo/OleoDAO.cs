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
        //public List<Oleo> CarregarOleo()
        //{
        //    using (SqlConnection conn = new
        //    SqlConnection(Properties.Settings.Default.conn))
        //    {
        //        string srtSQL = "SELECT * FROM oleo";
        //        DataTable dt = new DataTable();
        //        conn.Open();
        //        using (SqlCommand cmdo = new SqlCommand())
        //        {
        //            cmdo.CommandType = CommandType.Text;
        //            cmdo.Connection = conn;
        //            cmdo.CommandText = srtSQL;
        //            SqlDataReader dataReader;

        //            dataReader = cmdo.ExecuteReader();
        //            dt.Load(dataReader);

        //            if (!(dt != null && dt.Rows.Count > 0))
        //                return null;

        //            List<Oleo> lst = new List<Oleo>();
        //            foreach (DataRow row in dt.Rows)
        //            {
        //                Oleo oleo = new Oleo();
        //                oleo.Nome = Convert.ToString(row["nome"]);
        //                oleo.Categoria = Convert.ToString(row["categoria"]);
        //                oleo.Tipo = Convert.ToString(row["tipo"]);
        //                oleo.Fabricante = Convert.ToString(row["fabricante"]);
        //                oleo.Valor = Convert.ToDouble(row["valor"]);
        //                lst.Add(oleo);
        //            }
        //            conn.Close();
        //            return lst;
        //        }
        //    }
        //}

        //public List<Oleo> CarregarOleos()
        //{
        //    using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn))
        //    {
        //        string strSQL = "select * from Oleo";

        //        DataTable dt = new DataTable();
        //        conn.Open();

        //        using (SqlCommand cmdo = new SqlCommand())
        //        {
        //            cmdo.CommandType = CommandType.Text;
        //            cmdo.Connection = conn;
        //            cmdo.CommandText = strSQL;

        //            SqlDataReader dataReader;
        //            dataReader = cmdo.ExecuteReader();
        //            dt.Load(dataReader);

        //            if (!(dt != null && dt.Rows.Count > 0))
        //                return null;

        //            List<Oleo> lstOleo = new List<Oleo>();

        //            foreach (DataRow linha in dt.Rows)
        //            {
        //                Oleo oleo = new Oleo();

        //                oleo.Cod = Convert.ToInt32(linha["cod_oleo"]);
        //                oleo.Nome = Convert.ToString(linha["nome"]);
        //                oleo.Categoria = Convert.ToString(linha["categoria"]);
        //                oleo.Tipo = Convert.ToString(linha["tipo"]);
        //                oleo.Fabricante = Convert.ToString(linha["fabricante"]);
        //                oleo.Valor = Convert.ToDouble(linha["valor"]);

        //                lstOleo.Add(oleo);
        //            }

        //            conn.Close();
        //            return lstOleo;
        //        }
        //    }
        //}


        public List<Oleo> CarregarNome()
        {
            var lst = new List<Oleo>();

            using (SqlConnection conn = new SqlConnection(@"Initial Catalog = TrocaOleo; Data Source = localhost; Integrated Security = SSPI"))
            {
                string strSQL = "SELECT nome FROM oleo;";

                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = strSQL;

                    var dataReader = cmd.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(dataReader);

                    if (!(dt != null && dt.Rows.Count > 0))
                        return null;

                    conn.Close();
                    foreach (DataRow row in dt.Rows)
                    {
                        var oleo = new Oleo()
                        {
                            Cod = Convert.ToInt32(row["cod_oleo"]),
                            Nome = row["nome"].ToString()
                        };
                        lst.Add(oleo);
                    }
                }
            }
            return lst;
        }

        public List<Oleo> CarregarCategoria()
        {
            var lst = new List<Oleo>();

            using (SqlConnection conn = new SqlConnection(@"Initial Catalog = TrocaOleo; Data Source = localhost; Integrated Security = SSPI"))
            {
                string strSQL = "SELECT categoria FROM oleo;";

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
                        var oleo = new Oleo()
                        {
                            Cod = Convert.ToInt32(row["cod_oleo"]),
                            Categoria = row["categoria"].ToString()
                        };
                        lst.Add(oleo);
                    }
                }
            }
            return lst;
        }

        public List<Oleo> CarregarTipo()
        {
            var lst = new List<Oleo>();

            using (SqlConnection conn = new SqlConnection(@"Initial Catalog = TrocaOleo; Data Source = localhost; Integrated Security = SSPI"))
            {
                string strSQL = "SELECT tipo FROM oleo;";

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
                        var oleo = new Oleo()
                        {
                            Cod = Convert.ToInt32(row["cod_oleo"]),
                            Tipo = row["tipo_oleo"].ToString()
                        };
                        lst.Add(oleo);
                    }
                }
            }
            return lst;
        }

        public List<Oleo> CarregarFabricante()
        {
            var lst = new List<Oleo>();

            using (SqlConnection conn = new SqlConnection(@"Initial Catalog = TrocaOleo; Data Source = localhost; Integrated Security = SSPI"))
            {
                string strSQL = "SELECT fabricante FROM oleo;";

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
                        var oleo = new Oleo()
                        {
                            Cod = Convert.ToInt32(row["cod_oleo"]),
                            Fabricante = row["fabicante"].ToString()
                        };
                        lst.Add(oleo);
                    }
                }
            }
            return lst;
        }      
    }
}
