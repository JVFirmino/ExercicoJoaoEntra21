using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrudComBanco.Entidades;

namespace CrudComBanco.Dao
{
    class CrudBanco
    {
        public CrudBanco () { }
        public string Salvar(Produto produto)
        {
            using (SqlConnection connec = new SqlConnection())
            {
                // criando conecxao
                connec.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Projetos;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

                //montando o dml a ser enviado para a database
                SqlCommand cnnn = new SqlCommand();
                cnnn.CommandType = System.Data.CommandType.Text;
                cnnn.CommandText = "insert into tb_produtos([id], [nome], [ValorUnitario], [qtdEstoque], [id_categoria]) values(@id, @nome, @ValorUnitario, @qtdEstoque, @id_categoria)";

                // envia os dados a serem gravados
                cnnn.Parameters.Add("id", System.Data.SqlDbType.Int).Value = produto.Id;
                cnnn.Parameters.Add("nome", System.Data.SqlDbType.VarChar).Value = produto.Nome;
                cnnn.Parameters.Add("ValorUnitario", System.Data.SqlDbType.Float).Value = produto.ValorUnitário;
                cnnn.Parameters.Add("qtdEstoque", System.Data.SqlDbType.Int).Value = produto.qtdEstoque;
                cnnn.Parameters.Add("id_categoria", System.Data.SqlDbType.Int).Value = produto.Id_categoria.Id;

                //abrir a conecxao
                connec.Open();
                cnnn.Connection = connec;
                try
                {
                    return $"{cnnn.ExecuteNonQuery() > 0}";

                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    return ex.Message;
                }
            }
        }

        public void Listando(List<Produto> listarr)
        {
            listarr.Clear();
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Projetos;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

                SqlCommand cnnn = new SqlCommand();
                cnnn.CommandType = System.Data.CommandType.Text;
                cnnn.CommandText = "select * from tb_produtos";
                con.Open();

                cnnn.Connection = con;
                SqlDataReader dr;
                dr = cnnn.ExecuteReader();

                while (dr.Read())
                {

                    int Id = Convert.ToInt32(dr["id"]);
                    string Nome = Convert.ToString(dr["nome"]);
                    double ValorUnitário = Convert.ToDouble(dr["ValorUnitario"]);
                    int qtdEstoque = Convert.ToInt32(dr["qtdEstoque"]);
                    int Id_categoria = Convert.ToInt32(dr["id_categoria"]);
                    Categoria categoria = new Categoria(Id_categoria);
                    Produto produto = new Produto(Id, Nome, ValorUnitário, qtdEstoque, categoria);

                    listarr.Add(produto);
                }
            }
            

        }


        public bool Remover(int id)
        {
            using (SqlConnection connec = new SqlConnection())
            {

                connec.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Projetos;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

                //montando o dml a ser enviado para a database
                SqlCommand cnnn = new SqlCommand();
                cnnn.CommandType = System.Data.CommandType.Text;
                cnnn.CommandText = "delete from tb_produtos where [id] = @id";

                cnnn.Parameters.Add("id", System.Data.SqlDbType.Int).Value = id;

                //abrir a conecxao
                connec.Open();
                cnnn.Connection = connec;
                return cnnn.ExecuteNonQuery() > 0;
            }
        }

        public bool Alterar(int id, string nome, float valorUnitario, int qtdEstoque, Categoria id_categoria)
        {
            using (SqlConnection connec = new SqlConnection())
            {

                connec.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Projetos;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

                //montando o dml a ser enviado para a database
                SqlCommand cnnn = new SqlCommand();
                cnnn.CommandType = System.Data.CommandType.Text;
                cnnn.CommandText = "update tb_produtos set [nome] = @nome, [valorUnitario] = @valorUnitario, [qtdEstoque] = @qtdEstoque, [id_categoria] = @id_categoria where [id] = @id";

                cnnn.Parameters.Add("id", System.Data.SqlDbType.Int).Value = id;
                cnnn.Parameters.Add("nome", System.Data.SqlDbType.VarChar).Value = nome;
                cnnn.Parameters.Add("ValorUnitario", System.Data.SqlDbType.Float).Value = valorUnitario;
                cnnn.Parameters.Add("qtdEstoque", System.Data.SqlDbType.Int).Value = qtdEstoque;
                cnnn.Parameters.Add("id_categoria", System.Data.SqlDbType.Int).Value = id_categoria.Id;

                //abrir a conecxao
                connec.Open();
                cnnn.Connection = connec;
                return cnnn.ExecuteNonQuery() > 0;
            }
        }


        public void Smostrando(int id_categoria, List<Produto> Selecionandoo)
        {
            Selecionandoo.Clear();
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Projetos;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

                SqlCommand cnnn = new SqlCommand();
                cnnn.CommandType = System.Data.CommandType.Text;
                cnnn.CommandText = "select * from tb_produtos where [id_categoria] = @id_categoria";
                con.Open();
                cnnn.Parameters.Add("id_categoria", System.Data.SqlDbType.Int).Value = id_categoria;
                cnnn.Connection = con;
                SqlDataReader dr;
                dr = cnnn.ExecuteReader();

                while (dr.Read())
                {

                    int Id = Convert.ToInt32(dr["id"]);
                    string Nome = Convert.ToString(dr["nome"]);
                    double ValorUnitário = Convert.ToDouble(dr["ValorUnitario"]);
                    int qtdEstoque = Convert.ToInt32(dr["qtdEstoque"]);
                    int Id_categoria = Convert.ToInt32(dr["id_categoria"]);
                    Categoria categoria = new Categoria(Id_categoria);
                    Produto produto = new Produto(Id, Nome, ValorUnitário, qtdEstoque, categoria);

                    Selecionandoo.Add(produto);
                }
            }
        }





        public bool Salvarr(Categoria categoria)
        {
            using (SqlConnection connec = new SqlConnection())
            {
                // criando conecxao
                connec.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Projetos;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

                //montando o dml a ser enviado para a database
                SqlCommand cnnn = new SqlCommand();
                cnnn.CommandType = System.Data.CommandType.Text;
                cnnn.CommandText = "insert into tb_categorias([id], [nome]) values(@id, @nome)";

                // envia os dados a serem gravados
                cnnn.Parameters.Add("id", System.Data.SqlDbType.VarChar).Value = categoria.Id;
                cnnn.Parameters.Add("nome", System.Data.SqlDbType.VarChar).Value = categoria.Nome;


                //abrir a conecxao
                connec.Open();
                cnnn.Connection = connec;
                return cnnn.ExecuteNonQuery() > 0;
            }
        }


        public void Listando(List<Categoria> listar)
        {
            listar.Clear();
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Projetos;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

                SqlCommand cnnn = new SqlCommand();
                cnnn.CommandType = System.Data.CommandType.Text;
                cnnn.CommandText = "select * from tb_categorias";
                con.Open();

                cnnn.Connection = con;
                SqlDataReader dr;
                dr = cnnn.ExecuteReader();

                while (dr.Read())
                {

                    int Id = Convert.ToInt32(dr["id"]);
                    string Nome = Convert.ToString(dr["nome"]);

                    Categoria categoria = new Categoria(Id, Nome);

                    listar.Add(categoria);
                }
            }
        }

        public bool Removerr(int id)
        {
            using (SqlConnection connec = new SqlConnection())
            {

                connec.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Projetos;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

                //montando o dml a ser enviado para a database
                SqlCommand cnnn = new SqlCommand();
                cnnn.CommandType = System.Data.CommandType.Text;
                cnnn.CommandText = "delete from tb_categorias where [id] = @id";

                cnnn.Parameters.Add("id", System.Data.SqlDbType.Int).Value = id;

                //abrir a conecxao
                connec.Open();
                cnnn.Connection = connec;
                return cnnn.ExecuteNonQuery() > 0;
            }
        }


        public bool Alterarr(int id, string nome)
        {
            using (SqlConnection connec = new SqlConnection())
            {

                connec.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Projetos;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

                //montando o dml a ser enviado para a database
                SqlCommand cnnn = new SqlCommand();
                cnnn.CommandType = System.Data.CommandType.Text;
                cnnn.CommandText = "update tb_categorias set [nome] = @nome where [id] = @id";

                cnnn.Parameters.Add("id", System.Data.SqlDbType.Int).Value = id;
                cnnn.Parameters.Add("nome", System.Data.SqlDbType.VarChar).Value = nome;

                //abrir a conecxao
                connec.Open();
                cnnn.Connection = connec;
                return cnnn.ExecuteNonQuery() > 0;
            }
        }

        public void Smostrandoo(int id, List<Categoria> Selecionandoo)
        {
            Selecionandoo.Clear();
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Projetos;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

                SqlCommand cnnn = new SqlCommand();
                cnnn.CommandType = System.Data.CommandType.Text;
                cnnn.CommandText = "select * from tb_categorias where [id] = @id";
                con.Open();
                cnnn.Parameters.Add("id", System.Data.SqlDbType.Int).Value = id;
                cnnn.Connection = con;
                SqlDataReader dr;
                dr = cnnn.ExecuteReader();

                while (dr.Read())
                {

                    int Id = Convert.ToInt32(dr["id"]);
                    string Nome = Convert.ToString(dr["nome"]);

                    Categoria categoria = new Categoria(Id, Nome);

                    Selecionandoo.Add(categoria);
                }

            }
        }
    }
}
