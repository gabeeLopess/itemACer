using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmCadastroItemAcervo
{
    public class ItemAcervoDAO
    {
        private SqlConnection Connection { get; }

        public ItemAcervoDAO(SqlConnection connection)
        {
            Connection = connection;
        }

        public bool Validacao(ItemAcervoModel item, AutorModel autor, EditoraModel editora, LocalModel local, SecaoModel secao)
        {
            if (string.IsNullOrEmpty(item.Nome) || string.IsNullOrWhiteSpace(item.Nome))
            {
                MessageBox.Show("Informe o campo Nome", "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(autor.NomeAutor) || string.IsNullOrWhiteSpace(autor.NomeAutor))
            {
                MessageBox.Show("Informe o campo Nome do autor", "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(editora.NomeEditora) || string.IsNullOrWhiteSpace(editora.NomeEditora))
            {
                MessageBox.Show("Informe o campo Nome da editora", "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(item.TipoItem) || string.IsNullOrWhiteSpace(item.TipoItem))
            {
                MessageBox.Show("Informe o campo Tipo Item", "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(local.NomeLocal) || string.IsNullOrWhiteSpace(local.NomeLocal))
            {
                MessageBox.Show("Informe o campo Nome Local", "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(secao.DescricaoSecao) || string.IsNullOrWhiteSpace(secao.DescricaoSecao))
            {
                MessageBox.Show("Informe o campo Descrição", "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(item.Localizacao) || string.IsNullOrWhiteSpace(item.Localizacao))
            {
                MessageBox.Show("Informe o campo Descrição", "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }
        //Quando usado como um tipo de retorno da função, a palavra-chave void especifica
        //que a função não retorna um valor. Quando usado para a lista de parâmetros de uma função,
        //um item nulo especifica void que a função não usa parâmetros.
        public void Salvar(ItemAcervoModel ItemAcervo, AutorModel autor, EditoraModel editora, LocalModel local, SecaoModel secao)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                SqlTransaction t = Connection.BeginTransaction();
                try
                {
                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine($"INSERT INTO mvtBiibItemAcervo (codLocal, numExemplar, nome, codAutor, nomeAutor, codEditora, codSecao, nomeEditora, nomeColecao," +
                        $" tipoItem, nomeLocal, volume, anoEdicao, localizacao, secao, stts) VALUES(@codLocal, @numExemplar, @nome, @CodAutor, @nomeAutor, @CodEditora," +
                        $" @CodSecao, @nomeEditora, @nomeColecao, @tipoItem, @nomeLocal, @volume, @anoEdicao, @localizacao, @secao, @stts)");
                    command.CommandText = sql.ToString();
                    command.Parameters.Add(new SqlParameter("@codLocal", local.CodLocal));
                    command.Parameters.Add(new SqlParameter("@numExemplar", ItemAcervo.NumExemplar));
                    command.Parameters.Add(new SqlParameter("@nome", ItemAcervo.Nome));
                    command.Parameters.Add(new SqlParameter("@CodAutor", autor.CodAutor));
                    command.Parameters.Add(new SqlParameter("@nomeAutor", autor.NomeAutor));
                    command.Parameters.Add(new SqlParameter("@CodEditora", editora.CodEditora));
                    command.Parameters.Add(new SqlParameter("@CodSecao", secao.CodSecao));
                    command.Parameters.Add(new SqlParameter("@nomeEditora", editora.NomeEditora));
                    command.Parameters.Add(new SqlParameter("@nomeColecao", ItemAcervo.NomeColecao));
                    command.Parameters.Add(new SqlParameter("@tipoItem", ItemAcervo.TipoItem));
                    command.Parameters.Add(new SqlParameter("@nomeLocal", local.NomeLocal));
                    command.Parameters.Add(new SqlParameter("@volume", ItemAcervo.Volume));
                    command.Parameters.Add(new SqlParameter("@anoEdicao", ItemAcervo.AnoEdicao));
                    command.Parameters.Add(new SqlParameter("@localizacao", ItemAcervo.Localizacao));
                    command.Parameters.Add(new SqlParameter("@secao", secao.DescricaoSecao));
                    command.Parameters.Add(new SqlParameter("@stts", ItemAcervo.Status));
                    command.Transaction = t;
                    command.ExecuteNonQuery();
                    t.Commit();

                }
                catch (Exception ex)
                {
                    t.Rollback();
                    throw ex;
                }

            }
        }


        public void Atualizar(ItemAcervoModel ItemAcervo, AutorModel autor, EditoraModel editora, LocalModel local, SecaoModel secao)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                SqlTransaction t = Connection.BeginTransaction();
                try
                {

                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine("UPDATE mvtBiibItemAcervo SET codLocal = @codLocal, numExemplar = @numExemplar, nome = @nome, codAutor = @CodAutor," +
                        " nomeAutor = @nomeAutor, codEditora = @CodEditora, codSecao = @CodSecao, nomeEditora = @nomeEditora, nomeColecao = @nomeColecao," +
                        " tipoItem = @tipoItem, nomeLocal = @nomeLocal, volume = @volume, anoEdicao = @anoEdicao, " +
                        "localizacao = @localizacao, secao = @secao, stts = @stts WHERE codItem = @CodItem");
                    command.CommandText = sql.ToString();
                    command.Parameters.Add(new SqlParameter("@CodItem", ItemAcervo.CodItem));
                    command.Parameters.Add(new SqlParameter("@codLocal", local.CodLocal));
                    command.Parameters.Add(new SqlParameter("@numExemplar", ItemAcervo.NumExemplar));
                    command.Parameters.Add(new SqlParameter("@nome", ItemAcervo.Nome));
                    command.Parameters.Add(new SqlParameter("@CodAutor", autor.CodAutor));
                    command.Parameters.Add(new SqlParameter("@nomeAutor", autor.NomeAutor));
                    command.Parameters.Add(new SqlParameter("@CodEditora", editora.CodEditora));
                    command.Parameters.Add(new SqlParameter("@CodSecao", secao.CodSecao));
                    command.Parameters.Add(new SqlParameter("@nomeEditora", editora.NomeEditora));
                    command.Parameters.Add(new SqlParameter("@nomeColecao", ItemAcervo.NomeColecao));
                    command.Parameters.Add(new SqlParameter("@tipoItem", ItemAcervo.TipoItem));
                    command.Parameters.Add(new SqlParameter("@nomeLocal", local.NomeLocal));
                    command.Parameters.Add(new SqlParameter("@volume", ItemAcervo.Volume));
                    command.Parameters.Add(new SqlParameter("@anoEdicao", ItemAcervo.AnoEdicao));
                    command.Parameters.Add(new SqlParameter("@localizacao", ItemAcervo.Localizacao));
                    command.Parameters.Add(new SqlParameter("@secao", secao.DescricaoSecao));
                    command.Parameters.Add(new SqlParameter("@stts", ItemAcervo.Status));
                    command.Transaction = t;
                    command.ExecuteNonQuery();
                    t.Commit();


                }

                catch (Exception ex)
                {
                    t.Rollback();
                    throw ex;
                }
            }
        }

        public void Excluir(ItemAcervoModel ItemAcervo, SqlTransaction t = null)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                if (t != null)
                {
                    command.Transaction = t;
                }
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"DELETE FROM mvtBiibItemAcervo WHERE codItem = @CodItem");
                command.CommandText = sql.ToString();
                command.Parameters.Add(new SqlParameter("CodItem", ItemAcervo.CodItem));
                command.ExecuteNonQuery();

            }
        }

        //List é uma coleção de objetos que mantém a ordem em que eles foram adicionados.

        public List<ItemAcervoModel> GetAcervos()
        {
            List<ItemAcervoModel> acervos = new List<ItemAcervoModel>();
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT codItem, codLocal, numExemplar, nome, codAutor, nomeAutor, codEditora, codSecao, nomeEditora, nomeColecao, tipoItem, nomeLocal, volume, anoEdicao, localizacao, secao, stts FROM mvtBiibItemAcervo");
                command.CommandText = sql.ToString();
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        acervos.Add(PopulateDr(dr));
                    }
                }
            }
            return acervos;
        }

        public int VerificaRegistroBanco(ItemAcervoModel ItemAcervo)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"SELECT COUNT(codItem) FROM mvtBiibItemAcervo WHERE codItem = @codItem");
                command.CommandText = sql.ToString();
                command.Parameters.AddWithValue("@codItem", ItemAcervo.CodItem);
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count;

            }
        }

        public string GetCodAutor(AutorModel autor)
        {
            try
            {
                using (SqlCommand command = Connection.CreateCommand())
                {
                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine($"SELECT codAutor FROM mvtBiibAutor WHERE nome = @nome");
                    command.CommandText = sql.ToString();
                    command.Parameters.AddWithValue("@nome", autor.NomeAutor);
                    String codAutor = Convert.ToString(command.ExecuteScalar());
                    return codAutor;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public string GetCodEditora(EditoraModel editora)
        {
            try
            {
                using (SqlCommand command = Connection.CreateCommand())
                {
                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine($"SELECT codEditora FROM mvtBiibEditora WHERE nome = @nome");
                    command.CommandText = sql.ToString();
                    command.Parameters.AddWithValue("@nome", editora.NomeEditora);
                    String codEditora = Convert.ToString(command.ExecuteScalar());
                    return codEditora;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public string GetCodSecao(SecaoModel secao)
        {
            try
            {
                using (SqlCommand command = Connection.CreateCommand())
                {
                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine($"SELECT codSecao FROM MvtBIBSecao WHERE descricaoSecao = @descricaoSecao");
                    command.CommandText = sql.ToString();
                    command.Parameters.AddWithValue("@descricaoSecao", secao.DescricaoSecao);
                    String codSecao = Convert.ToString(command.ExecuteScalar());
                    return codSecao;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public string GetCodLocal(LocalModel local)
        {
            try
            {
                using (SqlCommand command = Connection.CreateCommand())
                {
                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine($"SELECT codLocal FROM MvtBIBLocal WHERE descricaoLocal = @descricaoLocal");
                    command.CommandText = sql.ToString();
                    command.Parameters.AddWithValue("@descricaoLocal", local.NomeLocal);
                    String codSecao = Convert.ToString(command.ExecuteScalar());
                    return codSecao;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private ItemAcervoModel PopulateDr(SqlDataReader dr)
        {
            string codItem = "";
            string numExemplar = "";
            string nome = "";
            AutorModel nomeAutor = null;
            EditoraModel nomeEditora = null;
            string nomeColecao = "";
            string tipoItem = "";
            LocalModel nomeLocal = null;
            string volume = "";
            string anoEdicao = "";
            string localizacao = "";
            SecaoModel descricaoSecao = null;
            string status = "";

            if (DBNull.Value != dr["codItem"])
            {
                codItem = dr["codItem"] + "";
            }

            if (DBNull.Value != dr["numExemplar"])
            {
                numExemplar = dr["numExemplar"] + "";
            }
            if (DBNull.Value != dr["nome"])
            {
                nome = dr["nome"] + "";
            }

            if (DBNull.Value != dr["nomeAutor"])
            {
                string autor = dr["nomeAutor"] + "";
                nomeAutor = new AutorModel()
                {
                    NomeAutor = autor,
                };
            }
            if (DBNull.Value != dr["nomeEditora"])
            {
                string editora = dr["nomeEditora"] + "";
                nomeEditora = new EditoraModel()
                {
                    NomeEditora = editora,

                };
            }
            if (DBNull.Value != dr["nomeColecao"])
            {
                nomeColecao = dr["nomeColecao"] + "";
            }
            if (DBNull.Value != dr["tipoItem"])
            {
                tipoItem = dr["tipoItem"] + "";
            }
            if (DBNull.Value != dr["nomeLocal"])
            {
                string local = dr["nomeLocal"] + "";
                nomeLocal = new LocalModel()
                {
                    NomeLocal = local,
                };
            }
            if (DBNull.Value != dr["volume"])
            {
                volume = dr["volume"] + "";
            }
            if (DBNull.Value != dr["anoEdicao"])
            {
                anoEdicao = dr["anoEdicao"] + "";
            }
            if (DBNull.Value != dr["localizacao"])
            {
                localizacao = dr["localizacao"] + "";
            }
            if (DBNull.Value != dr["secao"])
            {
                string descricao = dr["secao"] + "";
                descricaoSecao = new SecaoModel()
                {
                    DescricaoSecao = descricao,
                };
            }
            if (DBNull.Value != dr["stts"])
            {
                status = dr["stts"] + "";
            }

            return new ItemAcervoModel()

            {

                CodItem = codItem,
                NumExemplar = numExemplar,
                Nome = nome,
                AutorModel = nomeAutor,
                NomeColecao = nomeColecao,
                TipoItem = tipoItem,
                Volume = volume,
                AnoEdicao = anoEdicao,
                EditoraModel = nomeEditora,
                SecaoModel = descricaoSecao,
                LocalModel = nomeLocal,
                Localizacao = localizacao,
                Status = status


            };

        }

    }
}
