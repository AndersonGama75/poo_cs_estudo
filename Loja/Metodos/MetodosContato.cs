using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Loja.Classes
{
    public partial class Contato : IDisposable
    {
        public void Insert()
        {
            SqlConnection cn = new SqlConnection("Server=.\\sqlexpress;Database=Loja;Trusted_Connection=True;");
            {
                try
                {
                    cn.Open();
                }
                catch (Exception)
                {
                    throw;
                }
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "Insert Into Contato (Codigo, Cliente, DadosContato, Tipo) values (@codigo, @cliente, @dadoscontato, @tipo)";
                    // Informando que a conexão está usando a conexão cn que foi aberta acima
                    cmd.Connection = cn;

                    cmd.Parameters.AddWithValue("@codigo", this._codigo);
                    cmd.Parameters.AddWithValue("@cliente", this._cliente);
                    cmd.Parameters.AddWithValue("@dadoscontato", this._dadosContato);
                    cmd.Parameters.AddWithValue("@tipo", this._tipo);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        this._isNew = false;
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    finally
                    {
                        cn.Close();
                    }
                }
            }
        }

        public void Update()
        {
            SqlConnection cn = new SqlConnection("Server=.\\sqlexpress;Database=Loja;Trusted_Connection=True;");
            {
                try
                {
                    cn.Open();
                }
                catch (Exception)
                {
                    throw;
                }
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "Update Contato Set Cliente = @cliente, DadosContato = @dadoscontato, Tipo = @tipo where Codigo = @codigo";
                    // Informando que a conexão está usando a conexão cn que foi aberta acima
                    cmd.Connection = cn;

                    cmd.Parameters.AddWithValue("@codigo", this._codigo);
                    cmd.Parameters.AddWithValue("@cliente", this._cliente);
                    cmd.Parameters.AddWithValue("@dadoscontato", this._dadosContato);
                    cmd.Parameters.AddWithValue("@tipo", this._tipo);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        this._isModified = false;
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    finally
                    {
                        cn.Close();
                    }
                }
            }
        }
        public void Gravar()
        {
            if (this._isNew)
            {
                Insert();
            }
            else if (this._isModified)
            {
                Update();
            }
        }

        public static Int32 Proximo()
        {
            Int32 _return = 0;
            using (SqlConnection cn = new SqlConnection("Server=.\\sqlexpress;Database=Loja;Trusted_Connection=True;"))
            {
                try
                {
                    cn.Open();
                }
                catch (Exception)
                {
                    throw;
                }
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "Select MAX(Codigo) + 1 from Contato";

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            dr.Read();
                            _return = dr.GetInt32(0);
                        }
                    }
                }
                cn.Close();

            }
            return _return;
        }

        public static List<Contato> Todos(int Cliente)
        {
            List<Contato> _return = null;
            using (SqlConnection cn = new SqlConnection("Server=.\\sqlexpress;Database=Loja;Trusted_Connection=True;"))
            {
                try
                {
                    cn.Open();
                }
                catch (Exception)
                {
                    throw;
                }
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "Select * from Contato where Cliente = @cliente";

                    cmd.Parameters.AddWithValue("@cliente", Cliente);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                Contato cont = new Contato();
                                cont._dadosContato = dr.GetString(dr.GetOrdinal("DadosContato"));
                                cont._tipo = dr.GetString(dr.GetOrdinal("Tipo"));
                                cont._codigo = dr.GetInt32(dr.GetOrdinal("Codigo"));
                                cont._cliente = dr.GetInt32(dr.GetOrdinal("Cliente"));

                                if (_return == null)
                                {
                                    _return = new List<Contato>();
                                }

                                cont._isNew = false;
                                _return.Add(cont);
                            }
                        }
                    }
                }
                cn.Close();

            }
            return _return;
        }
        public void Apagar()
        {
            SqlConnection cn = new SqlConnection("Server=.\\sqlexpress;Database=Loja;Trusted_Connection=True;");
            {
                try
                {
                    cn.Open();
                }
                catch (Exception)
                {
                    throw;
                }
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "Delete From Contato where Codigo = @codigo";
                    // Informando que a conexão está usando a conexão cn que foi aberta acima
                    cmd.Connection = cn;

                    cmd.Parameters.AddWithValue("@codigo", this._codigo);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    finally
                    {
                        cn.Close();
                    }
                }
            }
        }

        public void Dispose()
        {
            this.Gravar();
        }

        public Contato()
        {
            this._codigo = Proximo();
            this._isNew = true;
            this._isModified = false;
        }

        public Contato(int codigo)
        {
            this._codigo = codigo;
            using (SqlConnection cn = new SqlConnection("Server=.\\sqlexpress;Database=Loja;Trusted_Connection=True;"))
            {
                try
                {
                    cn.Open();
                }
                catch (Exception)
                {
                    throw;
                }
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "Select * from Cliente where Codigo = @codigo";

                    cmd.Parameters.AddWithValue("@codigo", Codigo);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            dr.Read();
                            this._codigo = dr.GetInt32(dr.GetOrdinal("Codigo"));
                            this._cliente = dr.GetInt32(dr.GetOrdinal("Cliente"));
                            this._dadosContato = dr.GetString(dr.GetOrdinal("DadosContato"));
                            this._tipo = dr.GetString(dr.GetOrdinal("Tipo"));
                        }
                    }
                }
                cn.Close();
                this._isModified = false;
                this._isNew = false;


            }
        }
    }
}
