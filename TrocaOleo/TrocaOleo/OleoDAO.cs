using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocaOleo
{
    public class OleoDAO
    {
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
                            Cod = Convert.ToInt32(row["cod_cliente"]),
                            Tipo = row["tipo"].ToString()
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
                            Cod = Convert.ToInt32(row["cod_cliente"]),
                            Fabricante = row["fabicante"].ToString()
                        };
                        lst.Add(oleo);
                    }
                }
            }
            return lst;
        }

        //public string CarregarValor(Oleo obj)
        //{
        //    using (SqlConnection conn = new SqlConnection(@"Initial Catalog = TrocaOleo; Data Source = localhost; Integrated Security = SSPI"))
        //    {
        //        string strSQL = "SELECT valor FROM oleo where cod_oleo = @cod_oleo;";

        //        using (SqlCommand cmd = new SqlCommand(strSQL))
        //        {
        //            conn.Open();
        //            cmd.Connection = conn;
        //            cmd.CommandText = strSQL;

        //            var dataReader = cmd.ExecuteReader();
        //            var dt = new DataTable();
        //            dt.Load(dataReader);

        //            conn.Close();
        //            foreach (DataRow row in dt.Rows)
        //            {
        //                var oleo = new Oleo()
        //                {
        //                    Cod = Convert.ToInt32(row["cod_cliente"]),
        //                    Fabricante = row["fabicante"].ToString()
        //                };                        
        //            }
        //        }
        //    }
        //}
    }
}
