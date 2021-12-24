namespace Sucata
{
    partial class frmVenda
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
            System.Windows.Forms.Label cdVendaLabel;
            System.Windows.Forms.Label dtVendaLabel;
            System.Windows.Forms.Label cdCompradorLabel;
            System.Windows.Forms.Label vlVendaLabel;
            System.Windows.Forms.Label dtPagamentoLabel;
            this.bDSucataDataSet = new Sucata.BDSucataDataSet();
            this.tbVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbVendaTableAdapter = new Sucata.BDSucataDataSetTableAdapters.tbVendaTableAdapter();
            this.cdVendaTextBox = new System.Windows.Forms.TextBox();
            this.dtVendaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cdCompradorTextBox = new System.Windows.Forms.TextBox();
            this.vlVendaTextBox = new System.Windows.Forms.TextBox();
            this.dtPagamentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tbVendaItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbVendaItemTableAdapter = new Sucata.BDSucataDataSetTableAdapters.tbVendaItemTableAdapter();
            this.tbVendaItemDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbVendaPagBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbVendaPagTableAdapter = new Sucata.BDSucataDataSetTableAdapters.tbVendaPagTableAdapter();
            this.tbVendaPagDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.btnPgto = new System.Windows.Forms.Button();
            cdVendaLabel = new System.Windows.Forms.Label();
            dtVendaLabel = new System.Windows.Forms.Label();
            cdCompradorLabel = new System.Windows.Forms.Label();
            vlVendaLabel = new System.Windows.Forms.Label();
            dtPagamentoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDSucataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVendaItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVendaItemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVendaPagBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVendaPagDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cdVendaLabel
            // 
            cdVendaLabel.AutoSize = true;
            cdVendaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cdVendaLabel.Location = new System.Drawing.Point(74, 17);
            cdVendaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cdVendaLabel.Name = "cdVendaLabel";
            cdVendaLabel.Size = new System.Drawing.Size(59, 20);
            cdVendaLabel.TabIndex = 1;
            cdVendaLabel.Text = "Código";
            // 
            // dtVendaLabel
            // 
            dtVendaLabel.AutoSize = true;
            dtVendaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dtVendaLabel.Location = new System.Drawing.Point(74, 59);
            dtVendaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dtVendaLabel.Name = "dtVendaLabel";
            dtVendaLabel.Size = new System.Drawing.Size(44, 20);
            dtVendaLabel.TabIndex = 3;
            dtVendaLabel.Text = "Data";
            // 
            // cdCompradorLabel
            // 
            cdCompradorLabel.AutoSize = true;
            cdCompradorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cdCompradorLabel.Location = new System.Drawing.Point(74, 97);
            cdCompradorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cdCompradorLabel.Name = "cdCompradorLabel";
            cdCompradorLabel.Size = new System.Drawing.Size(88, 20);
            cdCompradorLabel.TabIndex = 5;
            cdCompradorLabel.Text = "Comprador";
            // 
            // vlVendaLabel
            // 
            vlVendaLabel.AutoSize = true;
            vlVendaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vlVendaLabel.Location = new System.Drawing.Point(74, 137);
            vlVendaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            vlVendaLabel.Name = "vlVendaLabel";
            vlVendaLabel.Size = new System.Drawing.Size(46, 20);
            vlVendaLabel.TabIndex = 7;
            vlVendaLabel.Text = "Valor";
            // 
            // dtPagamentoLabel
            // 
            dtPagamentoLabel.AutoSize = true;
            dtPagamentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dtPagamentoLabel.Location = new System.Drawing.Point(74, 179);
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
            // tbVendaBindingSource
            // 
            this.tbVendaBindingSource.DataMember = "tbVenda";
            this.tbVendaBindingSource.DataSource = this.bDSucataDataSet;
            // 
            // tbVendaTableAdapter
            // 
            this.tbVendaTableAdapter.ClearBeforeFill = true;
            // 
            // cdVendaTextBox
            // 
            this.cdVendaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbVendaBindingSource, "cdVenda", true));
            this.cdVendaTextBox.Enabled = false;
            this.cdVendaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdVendaTextBox.Location = new System.Drawing.Point(170, 14);
            this.cdVendaTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cdVendaTextBox.Name = "cdVendaTextBox";
            this.cdVendaTextBox.Size = new System.Drawing.Size(80, 26);
            this.cdVendaTextBox.TabIndex = 2;
            // 
            // dtVendaDateTimePicker
            // 
            this.dtVendaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbVendaBindingSource, "dtVenda", true));
            this.dtVendaDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtVendaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtVendaDateTimePicker.Location = new System.Drawing.Point(170, 54);
            this.dtVendaDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtVendaDateTimePicker.Name = "dtVendaDateTimePicker";
            this.dtVendaDateTimePicker.Size = new System.Drawing.Size(121, 26);
            this.dtVendaDateTimePicker.TabIndex = 4;
            // 
            // cdCompradorTextBox
            // 
            this.cdCompradorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbVendaBindingSource, "cdComprador", true));
            this.cdCompradorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdCompradorTextBox.Location = new System.Drawing.Point(170, 94);
            this.cdCompradorTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cdCompradorTextBox.Name = "cdCompradorTextBox";
            this.cdCompradorTextBox.Size = new System.Drawing.Size(455, 26);
            this.cdCompradorTextBox.TabIndex = 6;
            // 
            // vlVendaTextBox
            // 
            this.vlVendaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbVendaBindingSource, "vlVenda", true));
            this.vlVendaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vlVendaTextBox.Location = new System.Drawing.Point(170, 134);
            this.vlVendaTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vlVendaTextBox.Name = "vlVendaTextBox";
            this.vlVendaTextBox.Size = new System.Drawing.Size(202, 26);
            this.vlVendaTextBox.TabIndex = 8;
            // 
            // dtPagamentoDateTimePicker
            // 
            this.dtPagamentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbVendaBindingSource, "dtPagamento", true));
            this.dtPagamentoDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPagamentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPagamentoDateTimePicker.Location = new System.Drawing.Point(170, 174);
            this.dtPagamentoDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtPagamentoDateTimePicker.Name = "dtPagamentoDateTimePicker";
            this.dtPagamentoDateTimePicker.Size = new System.Drawing.Size(121, 26);
            this.dtPagamentoDateTimePicker.TabIndex = 10;
            // 
            // tbVendaItemBindingSource
            // 
            this.tbVendaItemBindingSource.DataMember = "FK_tbVendaItem_tbVenda";
            this.tbVendaItemBindingSource.DataSource = this.tbVendaBindingSource;
            // 
            // tbVendaItemTableAdapter
            // 
            this.tbVendaItemTableAdapter.ClearBeforeFill = true;
            // 
            // tbVendaItemDataGridView
            // 
            this.tbVendaItemDataGridView.AllowUserToAddRows = false;
            this.tbVendaItemDataGridView.AllowUserToDeleteRows = false;
            this.tbVendaItemDataGridView.AutoGenerateColumns = false;
            this.tbVendaItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbVendaItemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tbVendaItemDataGridView.DataSource = this.tbVendaItemBindingSource;
            this.tbVendaItemDataGridView.Location = new System.Drawing.Point(78, 226);
            this.tbVendaItemDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbVendaItemDataGridView.Name = "tbVendaItemDataGridView";
            this.tbVendaItemDataGridView.ReadOnly = true;
            this.tbVendaItemDataGridView.Size = new System.Drawing.Size(764, 291);
            this.tbVendaItemDataGridView.TabIndex = 32;
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
            // tbVendaPagBindingSource
            // 
            this.tbVendaPagBindingSource.DataMember = "FK_tbVendaPag_tbVenda";
            this.tbVendaPagBindingSource.DataSource = this.tbVendaBindingSource;
            // 
            // tbVendaPagTableAdapter
            // 
            this.tbVendaPagTableAdapter.ClearBeforeFill = true;
            // 
            // tbVendaPagDataGridView
            // 
            this.tbVendaPagDataGridView.AllowUserToAddRows = false;
            this.tbVendaPagDataGridView.AllowUserToDeleteRows = false;
            this.tbVendaPagDataGridView.AutoGenerateColumns = false;
            this.tbVendaPagDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbVendaPagDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.tbVendaPagDataGridView.DataSource = this.tbVendaPagBindingSource;
            this.tbVendaPagDataGridView.Location = new System.Drawing.Point(452, 130);
            this.tbVendaPagDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbVendaPagDataGridView.Name = "tbVendaPagDataGridView";
            this.tbVendaPagDataGridView.ReadOnly = true;
            this.tbVendaPagDataGridView.Size = new System.Drawing.Size(390, 86);
            this.tbVendaPagDataGridView.TabIndex = 32;
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
            this.panel1.TabIndex = 33;
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
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImprimir.UseVisualStyleBackColor = true;
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
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
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
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = true;
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
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvar.UseVisualStyleBackColor = true;
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
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluir.UseVisualStyleBackColor = true;
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
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAlterar.UseVisualStyleBackColor = true;
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
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNovo.UseVisualStyleBackColor = true;
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
            this.btnProximo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProximo.UseVisualStyleBackColor = true;
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
            this.btnAnterior.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAnterior.UseVisualStyleBackColor = true;
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
            // 
            // frmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(900, 692);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbVendaPagDataGridView);
            this.Controls.Add(this.tbVendaItemDataGridView);
            this.Controls.Add(cdVendaLabel);
            this.Controls.Add(this.cdVendaTextBox);
            this.Controls.Add(dtVendaLabel);
            this.Controls.Add(this.dtVendaDateTimePicker);
            this.Controls.Add(cdCompradorLabel);
            this.Controls.Add(this.cdCompradorTextBox);
            this.Controls.Add(vlVendaLabel);
            this.Controls.Add(this.vlVendaTextBox);
            this.Controls.Add(dtPagamentoLabel);
            this.Controls.Add(this.dtPagamentoDateTimePicker);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.frmVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDSucataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVendaItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVendaItemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVendaPagBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVendaPagDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDSucataDataSet bDSucataDataSet;
        private System.Windows.Forms.BindingSource tbVendaBindingSource;
        private BDSucataDataSetTableAdapters.tbVendaTableAdapter tbVendaTableAdapter;
        private System.Windows.Forms.TextBox cdVendaTextBox;
        private System.Windows.Forms.DateTimePicker dtVendaDateTimePicker;
        private System.Windows.Forms.TextBox cdCompradorTextBox;
        private System.Windows.Forms.TextBox vlVendaTextBox;
        private System.Windows.Forms.DateTimePicker dtPagamentoDateTimePicker;
        private System.Windows.Forms.BindingSource tbVendaItemBindingSource;
        private BDSucataDataSetTableAdapters.tbVendaItemTableAdapter tbVendaItemTableAdapter;
        private System.Windows.Forms.DataGridView tbVendaItemDataGridView;
        private BDSucataDataSetTableAdapters.tbVendaPagTableAdapter tbVendaPagTableAdapter;
        private System.Windows.Forms.BindingSource tbVendaPagBindingSource;
        private System.Windows.Forms.DataGridView tbVendaPagDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
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
        private System.Windows.Forms.Button btnPgto;
    }
}