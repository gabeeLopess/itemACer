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
    public partial class FrmSelecionarSecao : Form
    {
        public string SecaoEnviadas { get; private set; }

        private void Fechar()
        {
            if (!string.IsNullOrEmpty(txtDescricaoSecao.Text))
            {
                DialogResult = DialogResult.OK;
                SecaoEnviadas = txtDescricaoSecao.Text;
            }
            else
            {
                DialogResult= DialogResult.Cancel;  
            }
            this.Close();
        }

        private void CaarregarSecoesgrid()
        {
            gridLayout.Rows.Clear();
            using(SqlConnection connection = DaoConnection.GetConexao())
            {
                SecaoDao dao = new SecaoDao(connection);
                List<SecaoModel> secaos = dao.GetSecaos();
                foreach(SecaoModel secao in secaos)
                {
                    DataGridViewRow row = gridLayout.Rows[gridLayout.Rows.Add()];
                    row.Cells[colCodigoSecao.Index].Value = secao.CodSecao;
                    row.Cells[colDescricaoSecao.Index].Value = secao.DescricaoSecao;
                }

            }
        }
        public FrmSelecionarSecao()
        {
            InitializeComponent();
        }

        private void txtCodigoSecao_TextChanged(object sender, EventArgs e)
        {

        }

        private void gridLayout_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                txtCodigoSecao.Text = gridLayout.Rows[e.RowIndex].Cells[colCodigoSecao.Index].Value + "";
                txtDescricaoSecao.Text = gridLayout.Rows[e.RowIndex].Cells[colDescricaoSecao.Index].Value + "";
                btnEscolherSecao.Enabled = true;

                if (string.IsNullOrEmpty(this.txtDescricaoSecao.Text))
                {
                    btnEscolherSecao.Enabled = false;

                }
                else
                {
                    btnEscolherSecao.Enabled = true;
                }

            }
        }

        private void FrmSelecionarSecao_Load(object sender, EventArgs e)
        {
            CaarregarSecoesgrid();
            btnEscolherSecao.Enabled = false;
        }

        private void btnEscolherSecao_Click(object sender, EventArgs e)
        {
            Fechar();
        }
    }
}
