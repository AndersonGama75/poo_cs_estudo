using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

public static class MetodoExtensao
{
    public static double metade(this double valor)
    {
        return valor / 2;
    }

    public static double juros(this double valor)
    {
        return valor * 1.1;
    }

    public static string primeiraMaiuscula(this string palavra)
    {
        return palavra.Substring(0, 1).ToUpper() + palavra.Substring(1, (palavra.Length - 1)).ToLower();
    }
}

namespace Loja.Classes
{
    public partial class Cliente : IDisposable
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
                    cmd.CommandText = "Insert Into Cliente (Codigo, Nome, Tipo, DataCadastro) values (@codigo, @nome, @tipo, @datacadastro)";
                    // Informando que a conexão está usando a conexão cn que foi aberta acima
                    cmd.Connection = cn;

                    cmd.Parameters.AddWithValue("@codigo", this._codigo);
                    cmd.Parameters.AddWithValue("@nome", this._nome);
                    cmd.Parameters.AddWithValue("@tipo", this._tipo);
                    cmd.Parameters.AddWithValue("@datacadastro", this._dataCadastro);

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
                    cmd.CommandText = "Update Cliente Set Nome = @nome, Tipo = @tipo, DataCadastro = @datacadastro where Codigo = @codigo";
                    // Informando que a conexão está usando a conexão cn que foi aberta acima
                    cmd.Connection = cn;

                    cmd.Parameters.AddWithValue("@codigo", this._codigo);
                    cmd.Parameters.AddWithValue("@nome", this._nome);
                    cmd.Parameters.AddWithValue("@tipo", this._tipo);
                    cmd.Parameters.AddWithValue("@datacadastro", this._dataCadastro);

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
                    cmd.CommandText = "Select MAX(Codigo) + 1 from Cliente";

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

        public static List<Cliente> Todos()
        {
            List<Cliente> _return = null;
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
                    cmd.CommandText = "Select * from Cliente";

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                Cliente cli = new Cliente();
                                cli._codigo = dr.GetInt32(dr.GetOrdinal("Codigo"));
                                cli._nome = dr.GetString(dr.GetOrdinal("Nome"));
                                cli._tipo = dr.GetInt32(dr.GetOrdinal("Tipo"));
                                cli._dataCadastro = dr.GetDateTime(dr.GetOrdinal("DataCadastro"));

                                if (_return == null)
                                {
                                    _return = new List<Cliente>();
                                }

                                cli._isNew = false;
                                _return.Add(cli);
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
                    cmd.CommandText = "Delete From Cliente where Codigo = @codigo";
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

        public Cliente()
        {
            this._codigo = Proximo();
            this._isNew = true;
            this._isModified = false;
        }

        public Cliente(int codigo)
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
                using(SqlCommand cmd = new SqlCommand())
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
                            this._nome = dr.GetString(dr.GetOrdinal("Nome"));
                            this._tipo = dr.GetInt32(dr.GetOrdinal("Tipo"));
                            this._dataCadastro = dr.GetDateTime(dr.GetOrdinal("DataCadastro"));
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
