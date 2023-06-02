namespace FrmCadastroItemAcervo
{
    partial class FrmItemAcervo
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmItemAcervo));
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtNomeLocal = new System.Windows.Forms.TextBox();
            this.txtNomeEditora = new System.Windows.Forms.TextBox();
            this.txtNomeAutor = new System.Windows.Forms.TextBox();
            this.txtSecao = new System.Windows.Forms.TextBox();
            this.txtLocalizacao = new System.Windows.Forms.TextBox();
            this.txtAnoEdicao = new System.Windows.Forms.TextBox();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.txtNumExemplar = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.gridLayout = new System.Windows.Forms.DataGridView();
            this.colCodItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeEditora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeColecao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumExemplar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAnoEdicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocalizacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSecao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblNomeAutor = new System.Windows.Forms.Label();
            this.lblNomeLocal = new System.Windows.Forms.Label();
            this.lblNumExemplar = new System.Windows.Forms.Label();
            this.lblTipoItem = new System.Windows.Forms.Label();
            this.lblNomeEditora = new System.Windows.Forms.Label();
            this.lblLocalizacao = new System.Windows.Forms.Label();
            this.lblAnoEdicao = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblSecao = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.ComboBox();
            this.txtTipoItem = new System.Windows.Forms.ComboBox();
            this.lblNomeColecao = new System.Windows.Forms.Label();
            this.txtNomeColecao = new System.Windows.Forms.TextBox();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.btnOpenAutor = new System.Windows.Forms.Button();
            this.btnOpenEditora = new System.Windows.Forms.Button();
            this.btnOpenSecao = new System.Windows.Forms.Button();
            this.btnOpenNomeLocal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCodigo.Location = new System.Drawing.Point(70, 12);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(207, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNome.Location = new System.Drawing.Point(70, 38);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(207, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtNomeLocal
            // 
            this.txtNomeLocal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNomeLocal.Location = new System.Drawing.Point(359, 117);
            this.txtNomeLocal.Name = "txtNomeLocal";
            this.txtNomeLocal.ReadOnly = true;
            this.txtNomeLocal.Size = new System.Drawing.Size(236, 20);
            this.txtNomeLocal.TabIndex = 2;
            // 
            // txtNomeEditora
            // 
            this.txtNomeEditora.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNomeEditora.Location = new System.Drawing.Point(359, 38);
            this.txtNomeEditora.Name = "txtNomeEditora";
            this.txtNomeEditora.ReadOnly = true;
            this.txtNomeEditora.Size = new System.Drawing.Size(236, 20);
            this.txtNomeEditora.TabIndex = 4;
            // 
            // txtNomeAutor
            // 
            this.txtNomeAutor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNomeAutor.Location = new System.Drawing.Point(359, 64);
            this.txtNomeAutor.Name = "txtNomeAutor";
            this.txtNomeAutor.ReadOnly = true;
            this.txtNomeAutor.Size = new System.Drawing.Size(236, 20);
            this.txtNomeAutor.TabIndex = 3;
            // 
            // txtSecao
            // 
            this.txtSecao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSecao.Location = new System.Drawing.Point(359, 90);
            this.txtSecao.Name = "txtSecao";
            this.txtSecao.ReadOnly = true;
            this.txtSecao.Size = new System.Drawing.Size(236, 20);
            this.txtSecao.TabIndex = 11;
            // 
            // txtLocalizacao
            // 
            this.txtLocalizacao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLocalizacao.Location = new System.Drawing.Point(70, 143);
            this.txtLocalizacao.Name = "txtLocalizacao";
            this.txtLocalizacao.Size = new System.Drawing.Size(207, 20);
            this.txtLocalizacao.TabIndex = 10;
            // 
            // txtAnoEdicao
            // 
            this.txtAnoEdicao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAnoEdicao.Location = new System.Drawing.Point(70, 64);
            this.txtAnoEdicao.Name = "txtAnoEdicao";
            this.txtAnoEdicao.Size = new System.Drawing.Size(207, 20);
            this.txtAnoEdicao.TabIndex = 9;
            this.txtAnoEdicao.TextChanged += new System.EventHandler(this.txtAnoEdicao_TextChanged);
            this.txtAnoEdicao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnoEdicao_KeyPress);
            // 
            // txtVolume
            // 
            this.txtVolume.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtVolume.Location = new System.Drawing.Point(70, 117);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(207, 20);
            this.txtVolume.TabIndex = 8;
            this.txtVolume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVolume_KeyPress);
            // 
            // txtNumExemplar
            // 
            this.txtNumExemplar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNumExemplar.Location = new System.Drawing.Point(360, 169);
            this.txtNumExemplar.Name = "txtNumExemplar";
            this.txtNumExemplar.Size = new System.Drawing.Size(291, 20);
            this.txtNumExemplar.TabIndex = 7;
            this.txtNumExemplar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumExemplar_KeyPress);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSalvar.Location = new System.Drawing.Point(480, 195);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(78, 20);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExcluir.Location = new System.Drawing.Point(573, 195);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(78, 20);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
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
            this.colCodItem,
            this.colNome,
            this.colNomeAutor,
            this.colNomeLocal,
            this.colNomeEditora,
            this.colNomeColecao,
            this.colTipoItem,
            this.colNumExemplar,
            this.colVolume,
            this.colAnoEdicao,
            this.colLocalizacao,
            this.colSecao,
            this.colStatus});
            this.gridLayout.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridLayout.Location = new System.Drawing.Point(7, 221);
            this.gridLayout.Name = "gridLayout";
            this.gridLayout.ReadOnly = true;
            this.gridLayout.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridLayout.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridLayout.Size = new System.Drawing.Size(644, 323);
            this.gridLayout.TabIndex = 14;
            this.gridLayout.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLayout_CellContentClick);
            this.gridLayout.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLayout_CellDoubleClick);
            // 
            // colCodItem
            // 
            this.colCodItem.HeaderText = "Id item";
            this.colCodItem.Name = "colCodItem";
            this.colCodItem.ReadOnly = true;
            // 
            // colNome
            // 
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            // 
            // colNomeAutor
            // 
            this.colNomeAutor.HeaderText = "Nome Autor";
            this.colNomeAutor.Name = "colNomeAutor";
            this.colNomeAutor.ReadOnly = true;
            // 
            // colNomeLocal
            // 
            this.colNomeLocal.HeaderText = "Nome Local";
            this.colNomeLocal.Name = "colNomeLocal";
            this.colNomeLocal.ReadOnly = true;
            this.colNomeLocal.Visible = false;
            // 
            // colNomeEditora
            // 
            this.colNomeEditora.HeaderText = "Nome Editora";
            this.colNomeEditora.Name = "colNomeEditora";
            this.colNomeEditora.ReadOnly = true;
            this.colNomeEditora.Visible = false;
            // 
            // colNomeColecao
            // 
            this.colNomeColecao.HeaderText = "Nome Coleção";
            this.colNomeColecao.Name = "colNomeColecao";
            this.colNomeColecao.ReadOnly = true;
            // 
            // colTipoItem
            // 
            this.colTipoItem.HeaderText = "Tipo Item";
            this.colTipoItem.Name = "colTipoItem";
            this.colTipoItem.ReadOnly = true;
            this.colTipoItem.Visible = false;
            // 
            // colNumExemplar
            // 
            this.colNumExemplar.HeaderText = "Numero Exemplar";
            this.colNumExemplar.Name = "colNumExemplar";
            this.colNumExemplar.ReadOnly = true;
            this.colNumExemplar.Visible = false;
            // 
            // colVolume
            // 
            this.colVolume.HeaderText = "Volume";
            this.colVolume.Name = "colVolume";
            this.colVolume.ReadOnly = true;
            this.colVolume.Visible = false;
            // 
            // colAnoEdicao
            // 
            this.colAnoEdicao.HeaderText = "Ano Edição";
            this.colAnoEdicao.Name = "colAnoEdicao";
            this.colAnoEdicao.ReadOnly = true;
            this.colAnoEdicao.Visible = false;
            // 
            // colLocalizacao
            // 
            this.colLocalizacao.HeaderText = "Localização";
            this.colLocalizacao.Name = "colLocalizacao";
            this.colLocalizacao.ReadOnly = true;
            // 
            // colSecao
            // 
            this.colSecao.HeaderText = "Seção";
            this.colSecao.Name = "colSecao";
            this.colSecao.ReadOnly = true;
            this.colSecao.Visible = false;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(-1, 19);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 16;
            this.lblCodigo.Text = "Código";
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(-1, 45);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 17;
            this.lblNome.Text = "Nome";
            // 
            // lblNomeAutor
            // 
            this.lblNomeAutor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNomeAutor.AutoSize = true;
            this.lblNomeAutor.Location = new System.Drawing.Point(279, 71);
            this.lblNomeAutor.Name = "lblNomeAutor";
            this.lblNomeAutor.Size = new System.Drawing.Size(63, 13);
            this.lblNomeAutor.TabIndex = 19;
            this.lblNomeAutor.Text = "Nome Autor";
            this.lblNomeAutor.Click += new System.EventHandler(this.lblNomeAutor_Click);
            // 
            // lblNomeLocal
            // 
            this.lblNomeLocal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNomeLocal.AutoSize = true;
            this.lblNomeLocal.Location = new System.Drawing.Point(279, 124);
            this.lblNomeLocal.Name = "lblNomeLocal";
            this.lblNomeLocal.Size = new System.Drawing.Size(64, 13);
            this.lblNomeLocal.TabIndex = 18;
            this.lblNomeLocal.Text = "Nome Local";
            // 
            // lblNumExemplar
            // 
            this.lblNumExemplar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNumExemplar.AutoSize = true;
            this.lblNumExemplar.Location = new System.Drawing.Point(279, 177);
            this.lblNumExemplar.Name = "lblNumExemplar";
            this.lblNumExemplar.Size = new System.Drawing.Size(75, 13);
            this.lblNumExemplar.TabIndex = 23;
            this.lblNumExemplar.Text = "Num Exemplar";
            this.lblNumExemplar.Click += new System.EventHandler(this.lblNumExemplar_Click);
            // 
            // lblTipoItem
            // 
            this.lblTipoItem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTipoItem.AutoSize = true;
            this.lblTipoItem.Location = new System.Drawing.Point(-1, 98);
            this.lblTipoItem.Name = "lblTipoItem";
            this.lblTipoItem.Size = new System.Drawing.Size(51, 13);
            this.lblTipoItem.TabIndex = 22;
            this.lblTipoItem.Text = "Tipo Item";
            // 
            // lblNomeEditora
            // 
            this.lblNomeEditora.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNomeEditora.AutoSize = true;
            this.lblNomeEditora.Location = new System.Drawing.Point(279, 45);
            this.lblNomeEditora.Name = "lblNomeEditora";
            this.lblNomeEditora.Size = new System.Drawing.Size(71, 13);
            this.lblNomeEditora.TabIndex = 20;
            this.lblNomeEditora.Text = "Nome Editora";
            // 
            // lblLocalizacao
            // 
            this.lblLocalizacao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLocalizacao.AutoSize = true;
            this.lblLocalizacao.Location = new System.Drawing.Point(-1, 150);
            this.lblLocalizacao.Name = "lblLocalizacao";
            this.lblLocalizacao.Size = new System.Drawing.Size(64, 13);
            this.lblLocalizacao.TabIndex = 26;
            this.lblLocalizacao.Text = "Localização";
            // 
            // lblAnoEdicao
            // 
            this.lblAnoEdicao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAnoEdicao.AutoSize = true;
            this.lblAnoEdicao.Location = new System.Drawing.Point(-1, 71);
            this.lblAnoEdicao.Name = "lblAnoEdicao";
            this.lblAnoEdicao.Size = new System.Drawing.Size(62, 13);
            this.lblAnoEdicao.TabIndex = 25;
            this.lblAnoEdicao.Text = "Ano Edição";
            // 
            // lblVolume
            // 
            this.lblVolume.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(-1, 124);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(42, 13);
            this.lblVolume.TabIndex = 24;
            this.lblVolume.Text = "Volume";
            // 
            // lblSecao
            // 
            this.lblSecao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSecao.AutoSize = true;
            this.lblSecao.Location = new System.Drawing.Point(279, 98);
            this.lblSecao.Name = "lblSecao";
            this.lblSecao.Size = new System.Drawing.Size(38, 13);
            this.lblSecao.TabIndex = 27;
            this.lblSecao.Text = "Seção";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(-1, 177);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 28;
            this.lblStatus.Text = "Status";
            // 
            // txtStatus
            // 
            this.txtStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtStatus.FormattingEnabled = true;
            this.txtStatus.Items.AddRange(new object[] {
            "Disponível",
            "Emprestado",
            "Reservado"});
            this.txtStatus.Location = new System.Drawing.Point(70, 169);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(207, 21);
            this.txtStatus.TabIndex = 29;
            // 
            // txtTipoItem
            // 
            this.txtTipoItem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTipoItem.FormattingEnabled = true;
            this.txtTipoItem.Items.AddRange(new object[] {
            "Livro",
            "Revista",
            "Jornal",
            "DVD/CD",
            "Folheto",
            "Artigo"});
            this.txtTipoItem.Location = new System.Drawing.Point(70, 90);
            this.txtTipoItem.Name = "txtTipoItem";
            this.txtTipoItem.Size = new System.Drawing.Size(207, 21);
            this.txtTipoItem.TabIndex = 30;
            // 
            // lblNomeColecao
            // 
            this.lblNomeColecao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNomeColecao.AutoSize = true;
            this.lblNomeColecao.Location = new System.Drawing.Point(279, 150);
            this.lblNomeColecao.Name = "lblNomeColecao";
            this.lblNomeColecao.Size = new System.Drawing.Size(77, 13);
            this.lblNomeColecao.TabIndex = 21;
            this.lblNomeColecao.Text = "Nome Coleção";
            // 
            // txtNomeColecao
            // 
            this.txtNomeColecao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNomeColecao.Location = new System.Drawing.Point(359, 143);
            this.txtNomeColecao.Name = "txtNomeColecao";
            this.txtNomeColecao.Size = new System.Drawing.Size(292, 20);
            this.txtNomeColecao.TabIndex = 5;
            this.txtNomeColecao.TextChanged += new System.EventHandler(this.txtNomeColecao_TextChanged);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // btnOpenAutor
            // 
            this.btnOpenAutor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOpenAutor.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenAutor.Image")));
            this.btnOpenAutor.Location = new System.Drawing.Point(601, 65);
            this.btnOpenAutor.Name = "btnOpenAutor";
            this.btnOpenAutor.Size = new System.Drawing.Size(50, 20);
            this.btnOpenAutor.TabIndex = 31;
            this.btnOpenAutor.UseVisualStyleBackColor = true;
            this.btnOpenAutor.Click += new System.EventHandler(this.btnOpenAutor_Click);
            // 
            // btnOpenEditora
            // 
            this.btnOpenEditora.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOpenEditora.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenEditora.Image")));
            this.btnOpenEditora.Location = new System.Drawing.Point(601, 38);
            this.btnOpenEditora.Name = "btnOpenEditora";
            this.btnOpenEditora.Size = new System.Drawing.Size(50, 20);
            this.btnOpenEditora.TabIndex = 32;
            this.btnOpenEditora.UseVisualStyleBackColor = true;
            this.btnOpenEditora.Click += new System.EventHandler(this.btnOpenEditora_Click);
            // 
            // btnOpenSecao
            // 
            this.btnOpenSecao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOpenSecao.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenSecao.Image")));
            this.btnOpenSecao.Location = new System.Drawing.Point(601, 91);
            this.btnOpenSecao.Name = "btnOpenSecao";
            this.btnOpenSecao.Size = new System.Drawing.Size(50, 20);
            this.btnOpenSecao.TabIndex = 33;
            this.btnOpenSecao.UseVisualStyleBackColor = true;
            this.btnOpenSecao.Click += new System.EventHandler(this.btnOpenSecao_Click);
            // 
            // btnOpenNomeLocal
            // 
            this.btnOpenNomeLocal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOpenNomeLocal.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenNomeLocal.Image")));
            this.btnOpenNomeLocal.Location = new System.Drawing.Point(601, 117);
            this.btnOpenNomeLocal.Name = "btnOpenNomeLocal";
            this.btnOpenNomeLocal.Size = new System.Drawing.Size(50, 20);
            this.btnOpenNomeLocal.TabIndex = 34;
            this.btnOpenNomeLocal.UseVisualStyleBackColor = true;
            this.btnOpenNomeLocal.Click += new System.EventHandler(this.btnOpenNomeLocal_Click);
            // 
            // FrmItemAcervo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 548);
            this.Controls.Add(this.btnOpenNomeLocal);
            this.Controls.Add(this.btnOpenSecao);
            this.Controls.Add(this.btnOpenEditora);
            this.Controls.Add(this.btnOpenAutor);
            this.Controls.Add(this.txtTipoItem);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblSecao);
            this.Controls.Add(this.lblLocalizacao);
            this.Controls.Add(this.lblAnoEdicao);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.lblNumExemplar);
            this.Controls.Add(this.lblTipoItem);
            this.Controls.Add(this.lblNomeColecao);
            this.Controls.Add(this.lblNomeEditora);
            this.Controls.Add(this.lblNomeAutor);
            this.Controls.Add(this.lblNomeLocal);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.gridLayout);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtSecao);
            this.Controls.Add(this.txtLocalizacao);
            this.Controls.Add(this.txtAnoEdicao);
            this.Controls.Add(this.txtVolume);
            this.Controls.Add(this.txtNumExemplar);
            this.Controls.Add(this.txtNomeColecao);
            this.Controls.Add(this.txtNomeEditora);
            this.Controls.Add(this.txtNomeAutor);
            this.Controls.Add(this.txtNomeLocal);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCodigo);
            this.Name = "FrmItemAcervo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Item do Acervo";
            this.Load += new System.EventHandler(this.FrmItemAcervo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtNomeLocal;
        private System.Windows.Forms.TextBox txtNomeEditora;
        private System.Windows.Forms.TextBox txtNomeAutor;
        private System.Windows.Forms.TextBox txtSecao;
        private System.Windows.Forms.TextBox txtLocalizacao;
        private System.Windows.Forms.TextBox txtAnoEdicao;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.TextBox txtNumExemplar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView gridLayout;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblNomeAutor;
        private System.Windows.Forms.Label lblNomeLocal;
        private System.Windows.Forms.Label lblNumExemplar;
        private System.Windows.Forms.Label lblTipoItem;
        private System.Windows.Forms.Label lblNomeEditora;
        private System.Windows.Forms.Label lblLocalizacao;
        private System.Windows.Forms.Label lblAnoEdicao;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label lblSecao;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox txtStatus;
        private System.Windows.Forms.ComboBox txtTipoItem;
        private System.Windows.Forms.Label lblNomeColecao;
        private System.Windows.Forms.TextBox txtNomeColecao;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Button btnOpenAutor;
        private System.Windows.Forms.Button btnOpenEditora;
        private System.Windows.Forms.Button btnOpenSecao;
        private System.Windows.Forms.Button btnOpenNomeLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeEditora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeColecao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumExemplar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVolume;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnoEdicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocalizacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSecao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}

