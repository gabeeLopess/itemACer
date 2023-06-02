namespace FrmCadastroItemAcervo
{
    partial class FrmSelecionarEditora
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
            this.lblCodigoEditora = new System.Windows.Forms.Label();
            this.lblNomeEditora = new System.Windows.Forms.Label();
            this.txtCodigoEditora = new System.Windows.Forms.TextBox();
            this.txtNomeEditora = new System.Windows.Forms.TextBox();
            this.btnEscolherEditora = new System.Windows.Forms.Button();
            this.gridLayout = new System.Windows.Forms.DataGridView();
            this.colCodigoEditora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeEditora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigoEditora
            // 
            this.lblCodigoEditora.AutoSize = true;
            this.lblCodigoEditora.Location = new System.Drawing.Point(9, 13);
            this.lblCodigoEditora.Name = "lblCodigoEditora";
            this.lblCodigoEditora.Size = new System.Drawing.Size(40, 13);
            this.lblCodigoEditora.TabIndex = 0;
            this.lblCodigoEditora.Text = "Código";
            // 
            // lblNomeEditora
            // 
            this.lblNomeEditora.AutoSize = true;
            this.lblNomeEditora.Location = new System.Drawing.Point(9, 42);
            this.lblNomeEditora.Name = "lblNomeEditora";
            this.lblNomeEditora.Size = new System.Drawing.Size(71, 13);
            this.lblNomeEditora.TabIndex = 1;
            this.lblNomeEditora.Text = "Nome Editora";
            // 
            // txtCodigoEditora
            // 
            this.txtCodigoEditora.Location = new System.Drawing.Point(86, 6);
            this.txtCodigoEditora.Name = "txtCodigoEditora";
            this.txtCodigoEditora.ReadOnly = true;
            this.txtCodigoEditora.Size = new System.Drawing.Size(215, 20);
            this.txtCodigoEditora.TabIndex = 2;
            // 
            // txtNomeEditora
            // 
            this.txtNomeEditora.Location = new System.Drawing.Point(86, 35);
            this.txtNomeEditora.Name = "txtNomeEditora";
            this.txtNomeEditora.ReadOnly = true;
            this.txtNomeEditora.Size = new System.Drawing.Size(320, 20);
            this.txtNomeEditora.TabIndex = 3;
            // 
            // btnEscolherEditora
            // 
            this.btnEscolherEditora.Location = new System.Drawing.Point(316, 6);
            this.btnEscolherEditora.Name = "btnEscolherEditora";
            this.btnEscolherEditora.Size = new System.Drawing.Size(90, 20);
            this.btnEscolherEditora.TabIndex = 4;
            this.btnEscolherEditora.Text = "Escolher";
            this.btnEscolherEditora.UseVisualStyleBackColor = true;
            this.btnEscolherEditora.Click += new System.EventHandler(this.btnEscolherEditora_Click);
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
            this.colCodigoEditora,
            this.colNomeEditora});
            this.gridLayout.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridLayout.Location = new System.Drawing.Point(12, 75);
            this.gridLayout.Name = "gridLayout";
            this.gridLayout.ReadOnly = true;
            this.gridLayout.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridLayout.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridLayout.Size = new System.Drawing.Size(394, 293);
            this.gridLayout.TabIndex = 5;
            this.gridLayout.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridLayout_CellMouseDoubleClick);
            // 
            // colCodigoEditora
            // 
            this.colCodigoEditora.HeaderText = "Id";
            this.colCodigoEditora.Name = "colCodigoEditora";
            this.colCodigoEditora.ReadOnly = true;
            // 
            // colNomeEditora
            // 
            this.colNomeEditora.HeaderText = "Nome Editora";
            this.colNomeEditora.Name = "colNomeEditora";
            this.colNomeEditora.ReadOnly = true;
            // 
            // FrmSelecionarEditora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 376);
            this.Controls.Add(this.gridLayout);
            this.Controls.Add(this.btnEscolherEditora);
            this.Controls.Add(this.txtNomeEditora);
            this.Controls.Add(this.txtCodigoEditora);
            this.Controls.Add(this.lblNomeEditora);
            this.Controls.Add(this.lblCodigoEditora);
            this.Name = "FrmSelecionarEditora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar Editora";
            this.Load += new System.EventHandler(this.FrmSelecionarEditora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigoEditora;
        private System.Windows.Forms.Label lblNomeEditora;
        private System.Windows.Forms.TextBox txtCodigoEditora;
        private System.Windows.Forms.TextBox txtNomeEditora;
        private System.Windows.Forms.Button btnEscolherEditora;
        private System.Windows.Forms.DataGridView gridLayout;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoEditora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeEditora;
    }
}