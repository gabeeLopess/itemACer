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
    public partial class FrmSelecionarAutor : Form
    {
        public String AutoresEnviados { get; private set; }

        public void Fechar()
        {
            if (!string.IsNullOrEmpty(txtNomeAutor2.Text))
            {
                DialogResult = DialogResult.OK;
                AutoresEnviados = txtNomeAutor2.Text;
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
            this.Close();
        }
        public FrmSelecionarAutor()
        {
            InitializeComponent();
        }

        private void CarregarAutoresgrid()
        {
            gridLayout.Rows.Clear();
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                AutorDAO dao = new AutorDAO(connection);
                List<AutorModel> autores = dao.GetAutores();
                foreach (AutorModel autor in autores)
                {

                    DataGridViewRow row = gridLayout.Rows[gridLayout.Rows.Add()];
                    row.Cells[colCodAutor.Index].Value = autor.CodAutor;
                    row.Cells[colNomeAutor.Index].Value = autor.NomeAutor;

                }
            }
        }



        private void gridLayout_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                txtCodigoAutor.Text = gridLayout.Rows[e.RowIndex].Cells[colCodAutor.Index].Value + "";
                txtNomeAutor2.Text = gridLayout.Rows[e.RowIndex].Cells[colNomeAutor.Index].Value + "";
                btnEscolher.Enabled = true;

                if (string.IsNullOrEmpty(this.txtNomeAutor2.Text))
                {
                    btnEscolher.Enabled = false;

                }
                else
                {
                    btnEscolher.Enabled = true;
                }

            }
        }

        public void Form2_Load(object sender, EventArgs e)
        {
            CarregarAutoresgrid();
            btnEscolher.Enabled = false;
        }

        private void btnEscolher_MouseClick(object sender, MouseEventArgs e)
        {
            Fechar();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }


        private void gridLayout_MouseDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEscolher_Click(object sender, EventArgs e)
        {

        }

        private void txtNomeAutor2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmSelecionarAutor_InputLanguageChanging(object sender, InputLanguageChangingEventArgs e)
        {

        }
    }
}
