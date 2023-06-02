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
    public partial class FrmSelecionarLocal : Form
    {
        public string LocaisEnviados { get; private set; }

        private void Fechar()
        {
            if (!string.IsNullOrEmpty(txtDescricaoLocal.Text))
            {
                DialogResult = DialogResult.OK;
                LocaisEnviados = txtDescricaoLocal.Text;
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
            this.Close();
        }

        private void CarregarLocaisgrid()
        {
            gridLayout.Rows.Clear();
            using(SqlConnection connection = DaoConnection.GetConexao())
            {
                LocalDAO dao = new LocalDAO(connection);
                List<LocalModel> locais = dao.GetLocais();
                foreach(LocalModel local in locais)
                {
                    DataGridViewRow row = gridLayout.Rows[gridLayout.Rows.Add()];
                    row.Cells[colCodigoLocal.Index].Value = local.CodLocal;
                    row.Cells[colDescricaoLocal.Index].Value = local.NomeLocal;
                }
            }
        }
    
        public FrmSelecionarLocal()
        {
            InitializeComponent();
        }

        private void gridLayout_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                txtCodigoLocal.Text = gridLayout.Rows[e.RowIndex].Cells[colCodigoLocal.Index].Value + "";
                txtDescricaoLocal.Text = gridLayout.Rows[e.RowIndex].Cells[colDescricaoLocal.Index].Value + "";
                btnEscolherLocal.Enabled = true;

                if (string.IsNullOrEmpty(this.txtDescricaoLocal.Text))
                {
                    btnEscolherLocal.Enabled = false;

                }
                else
                {
                    btnEscolherLocal.Enabled = true;
                }
            }
        }

        private void FrmSelecionarLocal_Load(object sender, EventArgs e)
        {
            CarregarLocaisgrid();
            btnEscolherLocal.Enabled = false;
        }

        private void btnEscolherLocal_Click(object sender, EventArgs e)
        {
            Fechar();
        }
    }

}
