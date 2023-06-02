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
    public partial class FrmSelecionarEditora : Form
    {
        public string EditorasEnviadas { get; private set; }


        public void Fechar()
        {
            if (!string.IsNullOrEmpty(txtNomeEditora.Text))
            {
                DialogResult = DialogResult.OK;
                EditorasEnviadas = txtNomeEditora.Text;
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
            this.Close();
        }
        public FrmSelecionarEditora()
        {
            InitializeComponent();
        }

        public void CaregarEditorasgrid()
        {
            gridLayout.Rows.Clear();
            using(SqlConnection connection = DaoConnection.GetConexao())
            {
                EditoraDAO dao = new EditoraDAO(connection);
                List<EditoraModel> editoras = dao.GetEditoras();
                foreach(EditoraModel editora in editoras)
                {
                    DataGridViewRow row = gridLayout.Rows[gridLayout.Rows.Add()];
                    row.Cells[colCodigoEditora.Index].Value = editora.CodEditora;
                    row.Cells[colNomeEditora.Index].Value = editora.NomeEditora;
                }

            }
        }
        private void btnEscolherEditora_Click(object sender, EventArgs e)
        {
            Fechar();
        }

        private void gridLayout_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                txtCodigoEditora.Text = gridLayout.Rows[e.RowIndex].Cells[colCodigoEditora.Index].Value + "";
                txtNomeEditora.Text = gridLayout.Rows[e.RowIndex].Cells[colNomeEditora.Index].Value + "";
                btnEscolherEditora.Enabled = true;

                if (string.IsNullOrEmpty(this.txtNomeEditora.Text))
                {
                    btnEscolherEditora.Enabled = false;

                }
                else
                {
                    btnEscolherEditora.Enabled = true;
                }

            }
        }

        private void FrmSelecionarEditora_Load(object sender, EventArgs e)
        {
            CaregarEditorasgrid();
            btnEscolherEditora.Enabled = false;
        }
    }
}
