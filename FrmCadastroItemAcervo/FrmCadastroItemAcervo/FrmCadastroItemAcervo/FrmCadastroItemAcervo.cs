using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmCadastroItemAcervo
{
    public partial class FrmItemAcervo : Form
    {
        public FrmItemAcervo()
        {
            InitializeComponent();
        }
        public string AutorSelecionado { get; set; }
        public string EditoraSelecionado { get; set; }
        public string SecaoSelecionado { get; set; }
        public string LocalSelecionado { get; set; }
        private void FrmItemAcervo_Load(object sender, EventArgs e)
        {
            CarregarAcervosGrid();
            CarregarUltimoId_Load();
        }

        private void CarregarAcervosGrid()
        {
            gridLayout.Rows.Clear();
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                ItemAcervoDAO dao = new ItemAcervoDAO(connection);
                List<ItemAcervoModel> acervos = dao.GetAcervos();
                foreach (ItemAcervoModel itemAcervo in acervos)
                {

                    DataGridViewRow row = gridLayout.Rows[gridLayout.Rows.Add()];

                    row.Cells[colCodItem.Index].Value = itemAcervo.CodItem;
                    row.Cells[colNome.Index].Value = itemAcervo.Nome;
                    row.Cells[colNomeLocal.Index].Value = itemAcervo.LocalModel.NomeLocal;
                    row.Cells[colNomeAutor.Index].Value = itemAcervo.AutorModel.NomeAutor;
                    row.Cells[colNomeEditora.Index].Value = itemAcervo.EditoraModel.NomeEditora;
                    row.Cells[colNomeColecao.Index].Value = itemAcervo.NomeColecao;
                    row.Cells[colTipoItem.Index].Value = itemAcervo.TipoItem;
                    row.Cells[colNumExemplar.Index].Value = itemAcervo.NumExemplar;
                    row.Cells[colVolume.Index].Value = itemAcervo.Volume;
                    row.Cells[colAnoEdicao.Index].Value = itemAcervo.AnoEdicao;
                    row.Cells[colLocalizacao.Index].Value = itemAcervo.Localizacao;
                    row.Cells[colSecao.Index].Value = itemAcervo.SecaoModel.DescricaoSecao;
                    row.Cells[colStatus.Index].Value = itemAcervo.Status;
                    btnExcluir.Enabled = false;
                }
            }
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtNumExemplar.Text = "";
            txtVolume.Text = "";
            txtNomeColecao.Text = "";
            txtAnoEdicao.Text = "";
            txtNomeLocal.Text = "";
            txtLocalizacao.Text = "";
            txtNomeAutor.Text = "";
            txtStatus.SelectedIndex = -1;
            txtNomeEditora.Text = "";
            txtTipoItem.SelectedIndex = -1;
            txtSecao.Text = "";
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {


            try
            {
                using (SqlConnection connection = DaoConnection.GetConexao())
                {
                    ItemAcervoDAO dao = new ItemAcervoDAO(connection);
                    bool registroExistente = dao.Validacao(new ItemAcervoModel()
                    {

                        Nome = txtNome.Text,
                        TipoItem = txtTipoItem.Text,
                        Localizacao = txtLocalizacao.Text,

                    }, new AutorModel()
                    {
                        NomeAutor = txtNomeAutor.Text,
                    }, new EditoraModel()
                    {
                        NomeEditora = txtNomeEditora.Text,
                    }, new LocalModel()
                    {
                        NomeLocal = txtNomeLocal.Text,
                    }, new SecaoModel()
                    {
                        DescricaoSecao = txtSecao.Text,
                    });

                    string codAutor = dao.GetCodAutor(new AutorModel()
                    {
                        NomeAutor = txtNomeAutor.Text
                    });

                    string codEditora = dao.GetCodEditora(new EditoraModel()
                    {
                        NomeEditora = txtNomeEditora.Text
                    });

                    string codSecao = dao.GetCodSecao(new SecaoModel()
                    {
                        DescricaoSecao = txtSecao.Text
                    });

                    string codLocal = dao.GetCodLocal(new LocalModel()
                    {
                        NomeLocal = txtNomeLocal.Text
                    });

                    if (registroExistente)
                    {
                        int count = dao.VerificaRegistroBanco(new ItemAcervoModel()
                        {
                            CodItem = txtCodigo.Text

                        });

                        if (count > 0)
                        {
                            dao.Atualizar(new ItemAcervoModel()
                            {
                                CodItem = txtCodigo.Text,
                                NumExemplar = txtNumExemplar.Text,
                                Nome = txtNome.Text,
                                TipoItem = txtTipoItem.Text,
                                Volume = txtVolume.Text,
                                AnoEdicao = txtAnoEdicao.Text,
                                Localizacao = txtLocalizacao.Text,
                                NomeColecao = txtNomeColecao.Text,
                                Status = txtStatus.Text,

                            }, new AutorModel()
                            {
                                CodAutor = codAutor,
                                NomeAutor = txtNomeAutor.Text
                            }, new EditoraModel()
                            {
                                CodEditora = codEditora,
                                NomeEditora = txtNomeEditora.Text
                            }, new LocalModel()
                            {
                                CodLocal = codLocal,
                                NomeLocal = txtNomeLocal.Text
                            }, new SecaoModel()
                            {
                                CodSecao = codSecao,
                                DescricaoSecao = txtSecao.Text
                            });
                            MessageBox.Show("Atualizado com sucesso");
                            LimparCampos();
                            btnExcluir.Enabled = false;
                        }
                        else
                        {
                            dao.Salvar(new ItemAcervoModel()
                            {

                                CodItem = txtCodigo.Text,
                                NumExemplar = txtNumExemplar.Text,
                                Nome = txtNome.Text,
                                TipoItem = txtTipoItem.Text,
                                Volume = txtVolume.Text,
                                AnoEdicao = txtAnoEdicao.Text,
                                Localizacao = txtLocalizacao.Text,
                                NomeColecao = txtNomeColecao.Text,
                                Status = txtStatus.Text,

                            }, new AutorModel()
                            {
                                CodAutor = codAutor,
                                NomeAutor = txtNomeAutor.Text
                            }, new EditoraModel()
                            {
                                CodEditora = codEditora,
                                NomeEditora = txtNomeEditora.Text
                            }, new LocalModel()
                            {
                                CodLocal = codLocal,
                                NomeLocal = txtNomeLocal.Text
                            }, new SecaoModel()
                            {
                                CodSecao = codSecao,
                                DescricaoSecao = txtSecao.Text
                            });
                            MessageBox.Show("Salvo com sucesso");
                            CarregarAcervosGrid();
                            LimparCampos();
                            btnExcluir.Enabled = false;
                          
                        }
                    }
                }
            
            }

             catch(Exception ex)
            {
                MessageBox.Show($"Houve um problema ao salvar ou atualizar o leitor{ex.Message}!");
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Selecione o nome do item", "Atenção");
                return;
            }

            DialogResult cont = MessageBox.Show("Tem certeza que deseja excluir?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            try
            {
                if(cont == DialogResult.Yes)
                {
                    using(SqlConnection connection = DaoConnection.GetConexao())
                    {
                        ItemAcervoDAO dao = new ItemAcervoDAO(connection);
                        dao.Excluir(new ItemAcervoModel()
                        {
                            CodItem = txtCodigo.Text,
                        });
                    }
                    MessageBox.Show("Item excluido com sucesso");
                    CarregarAcervosGrid();
                    LimparCampos();
                    CarregarUltimoId_Load();
                    btnExcluir.Enabled = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve problema ao excluir o item do acervo!\n{ex.Message}");
            }
        }
        private void lblNomeAutor_Click(object sender, EventArgs e)
        {

        }

        private void txtNomeColecao_TextChanged(object sender, EventArgs e)
        {

        }

   
        private void btnOpenEditora_Click(object sender, EventArgs e)
        {
             FrmSelecionarEditora frmEditora = new FrmSelecionarEditora();
            if (frmEditora.ShowDialog() == DialogResult.OK)
            {
                EditoraSelecionado = frmEditora.EditorasEnviadas;
                txtNomeEditora.Text = EditoraSelecionado;

            }

        }

        private void btnOpenAutor_Click(object sender, EventArgs e)
        {
            FrmSelecionarAutor frmSelecionarAutor = new FrmSelecionarAutor();
            if (frmSelecionarAutor.ShowDialog() == DialogResult.OK)
            {
                AutorSelecionado = frmSelecionarAutor.AutoresEnviados;
                txtNomeAutor.Text = AutorSelecionado;

            }
        }

        private void btnOpenSecao_Click(object sender, EventArgs e)
        {
            FrmSelecionarSecao frmSelecionarSecao = new FrmSelecionarSecao();
            if (frmSelecionarSecao.ShowDialog() == DialogResult.OK)
            {
                SecaoSelecionado = frmSelecionarSecao.SecaoEnviadas;
                txtSecao.Text = SecaoSelecionado;

            }

        }

        private void btnOpenNomeLocal_Click(object sender, EventArgs e)
        {
            FrmSelecionarLocal frmSelecionarLocal = new FrmSelecionarLocal();
            if (frmSelecionarLocal.ShowDialog() == DialogResult.OK)
            {
                LocalSelecionado = frmSelecionarLocal.LocaisEnviados;
                txtNomeLocal.Text = LocalSelecionado;

            }
        }

        private void CarregarUltimoId_Load()
        {
            using (SqlConnection connection = DaoConnection.GetConexao())
            {

                SqlCommand cmd = new SqlCommand("SELECT IDENT_CURRENT('mvtBiibItemAcervo') + 1", connection);
                int proximoID = Convert.ToInt32(cmd.ExecuteScalar());

                txtNome.Text = string.Empty;
                txtNumExemplar.Text = string.Empty;
                txtAnoEdicao.Text = string.Empty;

                txtCodigo.Text = proximoID.ToString();


            }




        }


        private void txtAnoEdicao_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNumExemplar_Click(object sender, EventArgs e)
        {

        }
       

        private void gridLayout_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridLayout_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                txtCodigo.Text = gridLayout.Rows[e.RowIndex].Cells[colCodItem.Index].Value.ToString();
                txtNumExemplar.Text = gridLayout.Rows[e.RowIndex].Cells[colNumExemplar.Index].Value.ToString();
                txtAnoEdicao.Text = gridLayout.Rows[e.RowIndex].Cells[colAnoEdicao.Index].Value.ToString();
                txtVolume.Text = gridLayout.Rows[e.RowIndex].Cells[colVolume.Index].Value.ToString();
                txtTipoItem.Text = gridLayout.Rows[e.RowIndex].Cells[colTipoItem.Index].Value.ToString();
                txtNomeEditora.Text = gridLayout.Rows[e.RowIndex].Cells[colNomeEditora.Index].Value.ToString();
                txtNome.Text = gridLayout.Rows[e.RowIndex].Cells[colNome.Index].Value.ToString();
                txtSecao.Text = gridLayout.Rows[e.RowIndex].Cells[colSecao.Index].Value.ToString();
                txtNomeLocal.Text = gridLayout.Rows[e.RowIndex].Cells[colNomeLocal.Index].Value.ToString();
                txtNomeAutor.Text = gridLayout.Rows[e.RowIndex].Cells[colNomeAutor.Index].Value.ToString();
                txtNomeColecao.Text = gridLayout.Rows[e.RowIndex].Cells[colNomeColecao.Index].Value.ToString();
                txtLocalizacao.Text = gridLayout.Rows[e.RowIndex].Cells[colLocalizacao.Index].Value.ToString();
                txtStatus.Text = gridLayout.Rows[e.RowIndex].Cells[colStatus.Index].Value.ToString();
                btnExcluir.Enabled = true;
            }
        }

        private void txtVolume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Apenas numeros");
            }
        }

        private void txtAnoEdicao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Apenas numeros");
            }
        }

        private void txtNumExemplar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Apenas numeros");
            }
        }
    }
}
