namespace FrmCadastroItemAcervo
{
    partial class FrmSelecionarLocal
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
            this.colCodigoLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricaoLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEscolherLocal = new System.Windows.Forms.Button();
            this.txtDescricaoLocal = new System.Windows.Forms.TextBox();
            this.txtCodigoLocal = new System.Windows.Forms.TextBox();
            this.lblDescricaoLocal = new System.Windows.Forms.Label();
            this.lblCodigoLocal = new System.Windows.Forms.Label();
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
            this.colCodigoLocal,
            this.colDescricaoLocal});
            this.gridLayout.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridLayout.Location = new System.Drawing.Point(14, 76);
            this.gridLayout.Name = "gridLayout";
            this.gridLayout.ReadOnly = true;
            this.gridLayout.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridLayout.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridLayout.Size = new System.Drawing.Size(394, 293);
            this.gridLayout.TabIndex = 17;
            this.gridLayout.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLayout_CellDoubleClick);
            // 
            // colCodigoLocal
            // 
            this.colCodigoLocal.HeaderText = "Id";
            this.colCodigoLocal.Name = "colCodigoLocal";
            this.colCodigoLocal.ReadOnly = true;
            // 
            // colDescricaoLocal
            // 
            this.colDescricaoLocal.HeaderText = "Descrição";
            this.colDescricaoLocal.Name = "colDescricaoLocal";
            this.colDescricaoLocal.ReadOnly = true;
            // 
            // btnEscolherLocal
            // 
            this.btnEscolherLocal.Location = new System.Drawing.Point(318, 7);
            this.btnEscolherLocal.Name = "btnEscolherLocal";
            this.btnEscolherLocal.Size = new System.Drawing.Size(90, 20);
            this.btnEscolherLocal.TabIndex = 16;
            this.btnEscolherLocal.Text = "Escolher";
            this.btnEscolherLocal.UseVisualStyleBackColor = true;
            this.btnEscolherLocal.Click += new System.EventHandler(this.btnEscolherLocal_Click);
            // 
            // txtDescricaoLocal
            // 
            this.txtDescricaoLocal.Location = new System.Drawing.Point(88, 36);
            this.txtDescricaoLocal.Name = "txtDescricaoLocal";
            this.txtDescricaoLocal.ReadOnly = true;
            this.txtDescricaoLocal.Size = new System.Drawing.Size(320, 20);
            this.txtDescricaoLocal.TabIndex = 15;
            // 
            // txtCodigoLocal
            // 
            this.txtCodigoLocal.Location = new System.Drawing.Point(88, 7);
            this.txtCodigoLocal.Name = "txtCodigoLocal";
            this.txtCodigoLocal.Size = new System.Drawing.Size(215, 20);
            this.txtCodigoLocal.TabIndex = 14;
            // 
            // lblDescricaoLocal
            // 
            this.lblDescricaoLocal.AutoSize = true;
            this.lblDescricaoLocal.Location = new System.Drawing.Point(11, 43);
            this.lblDescricaoLocal.Name = "lblDescricaoLocal";
            this.lblDescricaoLocal.Size = new System.Drawing.Size(67, 13);
            this.lblDescricaoLocal.TabIndex = 13;
            this.lblDescricaoLocal.Text = "Descricação";
            // 
            // lblCodigoLocal
            // 
            this.lblCodigoLocal.AutoSize = true;
            this.lblCodigoLocal.Location = new System.Drawing.Point(11, 14);
            this.lblCodigoLocal.Name = "lblCodigoLocal";
            this.lblCodigoLocal.Size = new System.Drawing.Size(40, 13);
            this.lblCodigoLocal.TabIndex = 12;
            this.lblCodigoLocal.Text = "Código";
            // 
            // FrmSelecionarLocal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 376);
            this.Controls.Add(this.gridLayout);
            this.Controls.Add(this.btnEscolherLocal);
            this.Controls.Add(this.txtDescricaoLocal);
            this.Controls.Add(this.txtCodigoLocal);
            this.Controls.Add(this.lblDescricaoLocal);
            this.Controls.Add(this.lblCodigoLocal);
            this.Name = "FrmSelecionarLocal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar Local";
            this.Load += new System.EventHandler(this.FrmSelecionarLocal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridLayout;
        private System.Windows.Forms.Button btnEscolherLocal;
        private System.Windows.Forms.TextBox txtDescricaoLocal;
        private System.Windows.Forms.TextBox txtCodigoLocal;
        private System.Windows.Forms.Label lblDescricaoLocal;
        private System.Windows.Forms.Label lblCodigoLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricaoLocal;
    }
}