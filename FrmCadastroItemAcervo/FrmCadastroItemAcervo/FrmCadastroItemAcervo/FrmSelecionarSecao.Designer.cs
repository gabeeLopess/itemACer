namespace FrmCadastroItemAcervo
{
    partial class FrmSelecionarSecao
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
            this.gridLayout = new System.Windows.Forms.DataGridView();
            this.colCodigoSecao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricaoSecao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEscolherSecao = new System.Windows.Forms.Button();
            this.txtDescricaoSecao = new System.Windows.Forms.TextBox();
            this.txtCodigoSecao = new System.Windows.Forms.TextBox();
            this.lblDescricaoSecao = new System.Windows.Forms.Label();
            this.lblCodigoSecao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout)).BeginInit();
            this.SuspendLayout();
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
            this.colCodigoSecao,
            this.colDescricaoSecao});
            this.gridLayout.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridLayout.Location = new System.Drawing.Point(14, 76);
            this.gridLayout.Name = "gridLayout";
            this.gridLayout.ReadOnly = true;
            this.gridLayout.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridLayout.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridLayout.Size = new System.Drawing.Size(394, 293);
            this.gridLayout.TabIndex = 11;
            this.gridLayout.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridLayout_CellMouseDoubleClick);
            // 
            // colCodigoSecao
            // 
            this.colCodigoSecao.HeaderText = "Id";
            this.colCodigoSecao.Name = "colCodigoSecao";
            this.colCodigoSecao.ReadOnly = true;
            // 
            // colDescricaoSecao
            // 
            this.colDescricaoSecao.HeaderText = "Descrição";
            this.colDescricaoSecao.Name = "colDescricaoSecao";
            this.colDescricaoSecao.ReadOnly = true;
            // 
            // btnEscolherSecao
            // 
            this.btnEscolherSecao.Location = new System.Drawing.Point(318, 7);
            this.btnEscolherSecao.Name = "btnEscolherSecao";
            this.btnEscolherSecao.Size = new System.Drawing.Size(90, 20);
            this.btnEscolherSecao.TabIndex = 10;
            this.btnEscolherSecao.Text = "Escolher";
            this.btnEscolherSecao.UseVisualStyleBackColor = true;
            this.btnEscolherSecao.Click += new System.EventHandler(this.btnEscolherSecao_Click);
            // 
            // txtDescricaoSecao
            // 
            this.txtDescricaoSecao.Location = new System.Drawing.Point(88, 36);
            this.txtDescricaoSecao.Name = "txtDescricaoSecao";
            this.txtDescricaoSecao.ReadOnly = true;
            this.txtDescricaoSecao.Size = new System.Drawing.Size(320, 20);
            this.txtDescricaoSecao.TabIndex = 9;
            // 
            // txtCodigoSecao
            // 
            this.txtCodigoSecao.Location = new System.Drawing.Point(88, 7);
            this.txtCodigoSecao.Name = "txtCodigoSecao";
            this.txtCodigoSecao.ReadOnly = true;
            this.txtCodigoSecao.Size = new System.Drawing.Size(215, 20);
            this.txtCodigoSecao.TabIndex = 8;
            this.txtCodigoSecao.TextChanged += new System.EventHandler(this.txtCodigoSecao_TextChanged);
            // 
            // lblDescricaoSecao
            // 
            this.lblDescricaoSecao.AutoSize = true;
            this.lblDescricaoSecao.Location = new System.Drawing.Point(11, 43);
            this.lblDescricaoSecao.Name = "lblDescricaoSecao";
            this.lblDescricaoSecao.Size = new System.Drawing.Size(67, 13);
            this.lblDescricaoSecao.TabIndex = 7;
            this.lblDescricaoSecao.Text = "Descricação";
            // 
            // lblCodigoSecao
            // 
            this.lblCodigoSecao.AutoSize = true;
            this.lblCodigoSecao.Location = new System.Drawing.Point(11, 14);
            this.lblCodigoSecao.Name = "lblCodigoSecao";
            this.lblCodigoSecao.Size = new System.Drawing.Size(40, 13);
            this.lblCodigoSecao.TabIndex = 6;
            this.lblCodigoSecao.Text = "Código";
            // 
            // FrmSelecionarSecao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 376);
            this.Controls.Add(this.gridLayout);
            this.Controls.Add(this.btnEscolherSecao);
            this.Controls.Add(this.txtDescricaoSecao);
            this.Controls.Add(this.txtCodigoSecao);
            this.Controls.Add(this.lblDescricaoSecao);
            this.Controls.Add(this.lblCodigoSecao);
            this.Name = "FrmSelecionarSecao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar Seção";
            this.Load += new System.EventHandler(this.FrmSelecionarSecao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridLayout;
        private System.Windows.Forms.Button btnEscolherSecao;
        private System.Windows.Forms.TextBox txtDescricaoSecao;
        private System.Windows.Forms.TextBox txtCodigoSecao;
        private System.Windows.Forms.Label lblDescricaoSecao;
        private System.Windows.Forms.Label lblCodigoSecao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoSecao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricaoSecao;
    }
}