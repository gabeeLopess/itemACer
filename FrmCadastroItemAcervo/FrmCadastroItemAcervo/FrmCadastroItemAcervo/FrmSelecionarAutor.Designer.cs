namespace FrmCadastroItemAcervo
{
    partial class FrmSelecionarAutor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.btnEscolher = new System.Windows.Forms.Button();
            this.txtNomeAutor2 = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.Label();
            this.colNomeAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridLayout = new System.Windows.Forms.DataGridView();
            this.txtCodigoAutor = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEscolher
            // 
            this.btnEscolher.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEscolher.Location = new System.Drawing.Point(321, 6);
            this.btnEscolher.Name = "btnEscolher";
            this.btnEscolher.Size = new System.Drawing.Size(85, 20);
            this.btnEscolher.TabIndex = 1;
            this.btnEscolher.Text = "Escolher";
            this.btnEscolher.UseVisualStyleBackColor = true;
            this.btnEscolher.Click += new System.EventHandler(this.btnEscolher_Click);
            this.btnEscolher.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnEscolher_MouseClick);
            // 
            // txtNomeAutor2
            // 
            this.txtNomeAutor2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNomeAutor2.Location = new System.Drawing.Point(91, 34);
            this.txtNomeAutor2.Name = "txtNomeAutor2";
            this.txtNomeAutor2.ReadOnly = true;
            this.txtNomeAutor2.Size = new System.Drawing.Size(315, 20);
            this.txtNomeAutor2.TabIndex = 6;
            this.txtNomeAutor2.TextChanged += new System.EventHandler(this.txtNomeAutor2_TextChanged);
            // 
            // txtAutor
            // 
            this.txtAutor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAutor.AutoSize = true;
            this.txtAutor.Location = new System.Drawing.Point(12, 41);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(32, 13);
            this.txtAutor.TabIndex = 4;
            this.txtAutor.Text = "Autor";
            // 
            // colNomeAutor
            // 
            this.colNomeAutor.HeaderText = "Nome Autor";
            this.colNomeAutor.Name = "colNomeAutor";
            this.colNomeAutor.ReadOnly = true;
            // 
            // colCodAutor
            // 
            this.colCodAutor.HeaderText = "Id";
            this.colCodAutor.Name = "colCodAutor";
            this.colCodAutor.ReadOnly = true;
            // 
            // gridLayout
            // 
            this.gridLayout.AllowUserToAddRows = false;
            this.gridLayout.AllowUserToDeleteRows = false;
            this.gridLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridLayout.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridLayout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLayout.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodAutor,
            this.colNomeAutor});
            this.gridLayout.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridLayout.Location = new System.Drawing.Point(12, 78);
            this.gridLayout.Name = "gridLayout";
            this.gridLayout.ReadOnly = true;
            this.gridLayout.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridLayout.Size = new System.Drawing.Size(394, 292);
            this.gridLayout.TabIndex = 2;
            this.gridLayout.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridLayout_CellMouseDoubleClick);
            // 
            // txtCodigoAutor
            // 
            this.txtCodigoAutor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCodigoAutor.Location = new System.Drawing.Point(91, 6);
            this.txtCodigoAutor.Name = "txtCodigoAutor";
            this.txtCodigoAutor.ReadOnly = true;
            this.txtCodigoAutor.Size = new System.Drawing.Size(212, 20);
            this.txtCodigoAutor.TabIndex = 5;
            this.txtCodigoAutor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCodigo.AutoSize = true;
            this.txtCodigo.Location = new System.Drawing.Point(9, 13);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(40, 13);
            this.txtCodigo.TabIndex = 3;
            this.txtCodigo.Text = "Código";
            // 
            // FrmSelecionarAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 376);
            this.Controls.Add(this.txtNomeAutor2);
            this.Controls.Add(this.txtCodigoAutor);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.gridLayout);
            this.Controls.Add(this.btnEscolher);
            this.Name = "FrmSelecionarAutor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar Autor";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.InputLanguageChanging += new System.Windows.Forms.InputLanguageChangingEventHandler(this.FrmSelecionarAutor_InputLanguageChanging);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Button btnEscolher;
        private System.Windows.Forms.TextBox txtNomeAutor2;
        private System.Windows.Forms.Label txtAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodAutor;
        private System.Windows.Forms.DataGridView gridLayout;
        private System.Windows.Forms.TextBox txtCodigoAutor;
        private System.Windows.Forms.Label txtCodigo;
    }
}