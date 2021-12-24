namespace Sucata
{
    partial class frmCompra
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label cdCompraLabel;
            System.Windows.Forms.Label dtCompraLabel;
            System.Windows.Forms.Label cdClienteLabel;
            System.Windows.Forms.Label vlCompraLabel;
            System.Windows.Forms.Label dtPagamentoLabel;
            this.bDSucataDataSet = new Sucata.BDSucataDataSet();
            this.tbCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbCompraTableAdapter = new Sucata.BDSucataDataSetTableAdapters.tbCompraTableAdapter();
            this.cdCompraTextBox = new System.Windows.Forms.TextBox();
            this.vlCompraTextBox = new System.Windows.Forms.TextBox();
            this.tbCompraItemTableAdapter = new Sucata.BDSucataDataSetTableAdapters.tbCompraItemTableAdapter();
            this.tbCompraItemDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbCompraItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbCompraPagTableAdapter = new Sucata.BDSucataDataSetTableAdapters.tbCompraPagTableAdapter();
            this.tbCompraPagDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbCompraPagBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPgto = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.cdClienteTextBox = new System.Windows.Forms.TextBox();
            this.tbClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbClienteTableAdapter = new Sucata.BDSucataDataSetTableAdapters.tbClienteTableAdapter();
            this.nmClienteComboBox = new System.Windows.Forms.ComboBox();
            cdCompraLabel = new System.Windows.Forms.Label();
            dtCompraLabel = new System.Windows.Forms.Label();
            cdClienteLabel = new System.Windows.Forms.Label();
            vlCompraLabel = new System.Windows.Forms.Label();
            dtPagamentoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDSucataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCompraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCompraItemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCompraItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCompraPagDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCompraPagBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cdCompraLabel
            // 
            cdCompraLabel.AutoSize = true;
            cdCompraLabel.Location = new System.Drawing.Point(91, 18);
            cdCompraLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cdCompraLabel.Name = "cdCompraLabel";
            cdCompraLabel.Size = new System.Drawing.Size(59, 20);
            cdCompraLabel.TabIndex = 1;
            cdCompraLabel.Text = "Código";
            // 
            // dtCompraLabel
            // 
            dtCompraLabel.AutoSize = true;
            dtCompraLabel.Location = new System.Drawing.Point(91, 60);
            dtCompraLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dtCompraLabel.Name = "dtCompraLabel";
            dtCompraLabel.Size = new System.Drawing.Size(44, 20);
            dtCompraLabel.TabIndex = 3;
            dtCompraLabel.Text = "Data";
            // 
            // cdClienteLabel
            // 
            cdClienteLabel.AutoSize = true;
            cdClienteLabel.Location = new System.Drawing.Point(91, 98);
            cdClienteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cdClienteLabel.Name = "cdClienteLabel";
            cdClienteLabel.Size = new System.Drawing.Size(58, 20);
            cdClienteLabel.TabIndex = 5;
            cdClienteLabel.Text = "Cliente";
            // 
            // vlCompraLabel
            // 
            vlCompraLabel.AutoSize = true;
            vlCompraLabel.Location = new System.Drawing.Point(91, 138);
            vlCompraLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            vlCompraLabel.Name = "vlCompraLabel";
            vlCompraLabel.Size = new System.Drawing.Size(46, 20);
            vlCompraLabel.TabIndex = 7;
            vlCompraLabel.Text = "Valor";
            // 
            // dtPagamentoLabel
            // 
            dtPagamentoLabel.AutoSize = true;
            dtPagamentoLabel.Location = new System.Drawing.Point(91, 180);
            dtPagamentoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dtPagamentoLabel.Name = "dtPagamentoLabel";
            dtPagamentoLabel.Size = new System.Drawing.Size(91, 20);
            dtPagamentoLabel.TabIndex = 9;
            dtPagamentoLabel.Text = "Pagamento";
            // 
            // bDSucataDataSet
            // 
            this.bDSucataDataSet.DataSetName = "BDSucataDataSet";
            this.bDSucataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbCompraBindingSource
            // 
            this.tbCompraBindingSource.DataMember = "tbCompra";
            this.tbCompraBindingSource.DataSource = this.bDSucataDataSet;
            // 
            // tbCompraTableAdapter
            // 
            this.tbCompraTableAdapter.ClearBeforeFill = true;
            // 
            // cdCompraTextBox
            // 
            this.cdCompraTextBox.BackColor = System.Drawing.Color.White;
            this.cdCompraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbCompraBindingSource, "cdCompra", true));
            this.cdCompraTextBox.Enabled = false;
            this.cdCompraTextBox.ForeColor = System.Drawing.Color.Black;
            this.cdCompraTextBox.Location = new System.Drawing.Point(214, 14);
            this.cdCompraTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cdCompraTextBox.Name = "cdCompraTextBox";
            this.cdCompraTextBox.Size = new System.Drawing.Size(80, 26);
            this.cdCompraTextBox.TabIndex = 2;
            // 
            // vlCompraTextBox
            // 
            this.vlCompraTextBox.BackColor = System.Drawing.Color.White;
            this.vlCompraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbCompraBindingSource, "vlCompra", true));
            this.vlCompraTextBox.Enabled = false;
            this.vlCompraTextBox.ForeColor = System.Drawing.Color.Black;
            this.vlCompraTextBox.Location = new System.Drawing.Point(214, 134);
            this.vlCompraTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vlCompraTextBox.Name = "vlCompraTextBox";
            this.vlCompraTextBox.Size = new System.Drawing.Size(146, 26);
            this.vlCompraTextBox.TabIndex = 8;
            // 
            // tbCompraItemTableAdapter
            // 
            this.tbCompraItemTableAdapter.ClearBeforeFill = true;
            // 
            // tbCompraItemDataGridView
            // 
            this.tbCompraItemDataGridView.AllowUserToAddRows = false;
            this.tbCompraItemDataGridView.AllowUserToDeleteRows = false;
            this.tbCompraItemDataGridView.AutoGenerateColumns = false;
            this.tbCompraItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbCompraItemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tbCompraItemDataGridView.DataSource = this.tbCompraItemBindingSource;
            this.tbCompraItemDataGridView.Location = new System.Drawing.Point(94, 228);
            this.tbCompraItemDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCompraItemDataGridView.Name = "tbCompraItemDataGridView";
            this.tbCompraItemDataGridView.ReadOnly = true;
            this.tbCompraItemDataGridView.Size = new System.Drawing.Size(748, 293);
            this.tbCompraItemDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "cdProduto";
            this.dataGridViewTextBoxColumn2.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 450;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "qtProduto";
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "vlProduto";
            this.dataGridViewTextBoxColumn4.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // tbCompraItemBindingSource
            // 
            this.tbCompraItemBindingSource.DataMember = "FK_tbCompraItem_tbCompra";
            this.tbCompraItemBindingSource.DataSource = this.tbCompraBindingSource;
            // 
            // tbCompraPagTableAdapter
            // 
            this.tbCompraPagTableAdapter.ClearBeforeFill = true;
            // 
            // tbCompraPagDataGridView
            // 
            this.tbCompraPagDataGridView.AllowUserToAddRows = false;
            this.tbCompraPagDataGridView.AllowUserToDeleteRows = false;
            this.tbCompraPagDataGridView.AutoGenerateColumns = false;
            this.tbCompraPagDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbCompraPagDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.tbCompraPagDataGridView.DataSource = this.tbCompraPagBindingSource;
            this.tbCompraPagDataGridView.Location = new System.Drawing.Point(453, 132);
            this.tbCompraPagDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCompraPagDataGridView.Name = "tbCompraPagDataGridView";
            this.tbCompraPagDataGridView.ReadOnly = true;
            this.tbCompraPagDataGridView.Size = new System.Drawing.Size(389, 86);
            this.tbCompraPagDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "dtPgto";
            this.dataGridViewTextBoxColumn6.HeaderText = "Data";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "cdFormaPag";
            this.dataGridViewTextBoxColumn7.HeaderText = "Forma Pag.";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 120;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "vlPago";
            this.dataGridViewTextBoxColumn8.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // tbCompraPagBindingSource
            // 
            this.tbCompraPagBindingSource.DataMember = "FK_tbCompraPag_tbCompra";
            this.tbCompraPagBindingSource.DataSource = this.tbCompraBindingSource;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnPgto);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnImprimir);
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnAlterar);
            this.panel1.Controls.Add(this.btnNovo);
            this.panel1.Controls.Add(this.btnProximo);
            this.panel1.Controls.Add(this.btnAnterior);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 548);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 144);
            this.panel1.TabIndex = 14;
            // 
            // btnPgto
            // 
            this.btnPgto.AutoSize = true;
            this.btnPgto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPgto.Image = global::Sucata.Properties.Resources.Dinheiro2;
            this.btnPgto.Location = new System.Drawing.Point(800, 0);
            this.btnPgto.Name = "btnPgto";
            this.btnPgto.Size = new System.Drawing.Size(96, 140);
            this.btnPgto.TabIndex = 28;
            this.btnPgto.Text = "F11 - Pgto";
            this.btnPgto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPgto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPgto.UseVisualStyleBackColor = true;
            this.btnPgto.Click += new System.EventHandler(this.btnPgto_Click);
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = true;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = global::Sucata.Properties.Resources.porta7;
            this.btnSair.Location = new System.Drawing.Point(640, 70);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(160, 70);
            this.btnSair.TabIndex = 21;
            this.btnSair.Text = "Esc - Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.AutoSize = true;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Image = global::Sucata.Properties.Resources.impress2;
            this.btnImprimir.Location = new System.Drawing.Point(480, 70);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(160, 70);
            this.btnImprimir.TabIndex = 20;
            this.btnImprimir.Text = "F10 - Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.AutoSize = true;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = global::Sucata.Properties.Resources.pesquisar;
            this.btnPesquisar.Location = new System.Drawing.Point(320, 70);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(160, 70);
            this.btnPesquisar.TabIndex = 19;
            this.btnPesquisar.Text = "F9 - Pequisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::Sucata.Properties.Resources.botaoxcolor;
            this.btnCancelar.Location = new System.Drawing.Point(160, 70);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(160, 70);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "F8 - Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSize = true;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = global::Sucata.Properties.Resources.Ok;
            this.btnSalvar.Location = new System.Drawing.Point(0, 70);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(160, 70);
            this.btnSalvar.TabIndex = 17;
            this.btnSalvar.Text = "F7 - Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.AutoSize = true;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = global::Sucata.Properties.Resources.excluir;
            this.btnExcluir.Location = new System.Drawing.Point(640, 0);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(160, 70);
            this.btnExcluir.TabIndex = 16;
            this.btnExcluir.Text = "F6 - Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.AutoSize = true;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = global::Sucata.Properties.Resources.alterar;
            this.btnAlterar.Location = new System.Drawing.Point(480, 0);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(160, 70);
            this.btnAlterar.TabIndex = 15;
            this.btnAlterar.Text = "F5 - Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.AutoSize = true;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = global::Sucata.Properties.Resources.gravar;
            this.btnNovo.Location = new System.Drawing.Point(320, 0);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(160, 70);
            this.btnNovo.TabIndex = 14;
            this.btnNovo.Text = "F4 - Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.AutoSize = true;
            this.btnProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.Image = global::Sucata.Properties.Resources.setadire;
            this.btnProximo.Location = new System.Drawing.Point(160, 0);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(160, 70);
            this.btnProximo.TabIndex = 13;
            this.btnProximo.Text = "F3 - Próximo";
            this.btnProximo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProximo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.AutoSize = true;
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.Image = global::Sucata.Properties.Resources.setaesq;
            this.btnAnterior.Location = new System.Drawing.Point(0, 0);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(160, 70);
            this.btnAnterior.TabIndex = 12;
            this.btnAnterior.Text = "F2 - Anterior";
            this.btnAnterior.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAnterior.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Enabled = false;
            this.maskedTextBox1.Location = new System.Drawing.Point(214, 54);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(80, 26);
            this.maskedTextBox1.TabIndex = 4;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Enabled = false;
            this.maskedTextBox2.Location = new System.Drawing.Point(214, 174);
            this.maskedTextBox2.Mask = "00/00/0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(80, 26);
            this.maskedTextBox2.TabIndex = 10;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // cdClienteTextBox
            // 
            this.cdClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbCompraBindingSource, "cdCliente", true));
            this.cdClienteTextBox.Location = new System.Drawing.Point(214, 95);
            this.cdClienteTextBox.Name = "cdClienteTextBox";
            this.cdClienteTextBox.Size = new System.Drawing.Size(80, 26);
            this.cdClienteTextBox.TabIndex = 16;
            this.cdClienteTextBox.TextChanged += new System.EventHandler(this.cdClienteTextBox_TextChanged);
            // 
            // tbClienteBindingSource
            // 
            this.tbClienteBindingSource.DataMember = "tbCliente";
            this.tbClienteBindingSource.DataSource = this.bDSucataDataSet;
            // 
            // tbClienteTableAdapter
            // 
            this.tbClienteTableAdapter.ClearBeforeFill = true;
            // 
            // nmClienteComboBox
            // 
            this.nmClienteComboBox.DataSource = this.tbClienteBindingSource;
            this.nmClienteComboBox.DisplayMember = "nmCliente";
            this.nmClienteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nmClienteComboBox.FormattingEnabled = true;
            this.nmClienteComboBox.Location = new System.Drawing.Point(300, 95);
            this.nmClienteComboBox.Name = "nmClienteComboBox";
            this.nmClienteComboBox.Size = new System.Drawing.Size(542, 28);
            this.nmClienteComboBox.TabIndex = 17;
            this.nmClienteComboBox.ValueMember = "cdCliente";
            this.nmClienteComboBox.SelectedIndexChanged += new System.EventHandler(this.nmClienteComboBox_SelectedIndexChanged);
            // 
            // frmCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(900, 692);
            this.ControlBox = false;
            this.Controls.Add(this.nmClienteComboBox);
            this.Controls.Add(this.cdClienteTextBox);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbCompraPagDataGridView);
            this.Controls.Add(this.tbCompraItemDataGridView);
            this.Controls.Add(cdCompraLabel);
            this.Controls.Add(this.cdCompraTextBox);
            this.Controls.Add(dtCompraLabel);
            this.Controls.Add(cdClienteLabel);
            this.Controls.Add(vlCompraLabel);
            this.Controls.Add(this.vlCompraTextBox);
            this.Controls.Add(dtPagamentoLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.frmCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDSucataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCompraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCompraItemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCompraItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCompraPagDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCompraPagBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDSucataDataSet bDSucataDataSet;
        private System.Windows.Forms.BindingSource tbCompraBindingSource;
        private BDSucataDataSetTableAdapters.tbCompraTableAdapter tbCompraTableAdapter;
        private System.Windows.Forms.TextBox cdCompraTextBox;
        private System.Windows.Forms.TextBox vlCompraTextBox;
        private System.Windows.Forms.BindingSource tbCompraItemBindingSource;
        private BDSucataDataSetTableAdapters.tbCompraItemTableAdapter tbCompraItemTableAdapter;
        private System.Windows.Forms.DataGridView tbCompraItemDataGridView;
        private System.Windows.Forms.BindingSource tbCompraPagBindingSource;
        private BDSucataDataSetTableAdapters.tbCompraPagTableAdapter tbCompraPagTableAdapter;
        private System.Windows.Forms.DataGridView tbCompraPagDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button btnPgto;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.TextBox cdClienteTextBox;
        private BDSucataDataSetTableAdapters.tbClienteTableAdapter tbClienteTableAdapter;
        private System.Windows.Forms.BindingSource tbClienteBindingSource;
        private System.Windows.Forms.ComboBox nmClienteComboBox;
    }
}