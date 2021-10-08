namespace Sucata
{
    partial class frmCliente
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
            System.Windows.Forms.Label cdClienteLabel;
            System.Windows.Forms.Label nmClienteLabel;
            System.Windows.Forms.Label dsEnderecoLabel;
            System.Windows.Forms.Label nrNumeroLabel;
            System.Windows.Forms.Label nmBairroLabel;
            System.Windows.Forms.Label nmCidadeLabel;
            System.Windows.Forms.Label sgEstadoLabel;
            System.Windows.Forms.Label cdCEPLabel;
            System.Windows.Forms.Label sgFIJULabel;
            System.Windows.Forms.Label cdCPFLabel;
            System.Windows.Forms.Label cdRGLabel;
            System.Windows.Forms.Label cdCNPJLabel;
            System.Windows.Forms.Label cdIELabel;
            System.Windows.Forms.Label vlSaldoLabel;
            System.Windows.Forms.Label dsTelefoneLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            this.bDSucataDataSet = new Sucata.BDSucataDataSet();
            this.tbClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbClienteTableAdapter = new Sucata.BDSucataDataSetTableAdapters.tbClienteTableAdapter();
            this.tableAdapterManager = new Sucata.BDSucataDataSetTableAdapters.TableAdapterManager();
            this.cdClienteTextBox = new System.Windows.Forms.TextBox();
            this.nmClienteTextBox = new System.Windows.Forms.TextBox();
            this.dsEnderecoTextBox = new System.Windows.Forms.TextBox();
            this.nrNumeroTextBox = new System.Windows.Forms.TextBox();
            this.nmBairroTextBox = new System.Windows.Forms.TextBox();
            this.nmCidadeTextBox = new System.Windows.Forms.TextBox();
            this.sgEstadoTextBox = new System.Windows.Forms.TextBox();
            this.cdCEPMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.sgFIJUTextBox = new System.Windows.Forms.TextBox();
            this.cdCPFMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cdRGTextBox = new System.Windows.Forms.TextBox();
            this.cdCNPJMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cdIEMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.vlSaldoTextBox = new System.Windows.Forms.TextBox();
            this.dsTelefoneTextBox = new System.Windows.Forms.TextBox();
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            cdClienteLabel = new System.Windows.Forms.Label();
            nmClienteLabel = new System.Windows.Forms.Label();
            dsEnderecoLabel = new System.Windows.Forms.Label();
            nrNumeroLabel = new System.Windows.Forms.Label();
            nmBairroLabel = new System.Windows.Forms.Label();
            nmCidadeLabel = new System.Windows.Forms.Label();
            sgEstadoLabel = new System.Windows.Forms.Label();
            cdCEPLabel = new System.Windows.Forms.Label();
            sgFIJULabel = new System.Windows.Forms.Label();
            cdCPFLabel = new System.Windows.Forms.Label();
            cdRGLabel = new System.Windows.Forms.Label();
            cdCNPJLabel = new System.Windows.Forms.Label();
            cdIELabel = new System.Windows.Forms.Label();
            vlSaldoLabel = new System.Windows.Forms.Label();
            dsTelefoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDSucataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cdClienteLabel
            // 
            cdClienteLabel.AutoSize = true;
            cdClienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cdClienteLabel.Location = new System.Drawing.Point(60, 15);
            cdClienteLabel.Name = "cdClienteLabel";
            cdClienteLabel.Size = new System.Drawing.Size(59, 20);
            cdClienteLabel.TabIndex = 1;
            cdClienteLabel.Text = "Código";
            // 
            // nmClienteLabel
            // 
            nmClienteLabel.AutoSize = true;
            nmClienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nmClienteLabel.Location = new System.Drawing.Point(60, 47);
            nmClienteLabel.Name = "nmClienteLabel";
            nmClienteLabel.Size = new System.Drawing.Size(51, 20);
            nmClienteLabel.TabIndex = 3;
            nmClienteLabel.Text = "Nome";
            // 
            // dsEnderecoLabel
            // 
            dsEnderecoLabel.AutoSize = true;
            dsEnderecoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dsEnderecoLabel.Location = new System.Drawing.Point(60, 79);
            dsEnderecoLabel.Name = "dsEnderecoLabel";
            dsEnderecoLabel.Size = new System.Drawing.Size(78, 20);
            dsEnderecoLabel.TabIndex = 5;
            dsEnderecoLabel.Text = "Endereço";
            // 
            // nrNumeroLabel
            // 
            nrNumeroLabel.AutoSize = true;
            nrNumeroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nrNumeroLabel.Location = new System.Drawing.Point(576, 79);
            nrNumeroLabel.Name = "nrNumeroLabel";
            nrNumeroLabel.Size = new System.Drawing.Size(65, 20);
            nrNumeroLabel.TabIndex = 7;
            nrNumeroLabel.Text = "Número";
            // 
            // nmBairroLabel
            // 
            nmBairroLabel.AutoSize = true;
            nmBairroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nmBairroLabel.Location = new System.Drawing.Point(60, 111);
            nmBairroLabel.Name = "nmBairroLabel";
            nmBairroLabel.Size = new System.Drawing.Size(51, 20);
            nmBairroLabel.TabIndex = 9;
            nmBairroLabel.Text = "Bairro";
            // 
            // nmCidadeLabel
            // 
            nmCidadeLabel.AutoSize = true;
            nmCidadeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nmCidadeLabel.Location = new System.Drawing.Point(60, 143);
            nmCidadeLabel.Name = "nmCidadeLabel";
            nmCidadeLabel.Size = new System.Drawing.Size(59, 20);
            nmCidadeLabel.TabIndex = 11;
            nmCidadeLabel.Text = "Cidade";
            // 
            // sgEstadoLabel
            // 
            sgEstadoLabel.AutoSize = true;
            sgEstadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sgEstadoLabel.Location = new System.Drawing.Point(60, 175);
            sgEstadoLabel.Name = "sgEstadoLabel";
            sgEstadoLabel.Size = new System.Drawing.Size(60, 20);
            sgEstadoLabel.TabIndex = 13;
            sgEstadoLabel.Text = "Estado";
            // 
            // cdCEPLabel
            // 
            cdCEPLabel.AutoSize = true;
            cdCEPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cdCEPLabel.Location = new System.Drawing.Point(595, 175);
            cdCEPLabel.Name = "cdCEPLabel";
            cdCEPLabel.Size = new System.Drawing.Size(41, 20);
            cdCEPLabel.TabIndex = 15;
            cdCEPLabel.Text = "CEP";
            // 
            // sgFIJULabel
            // 
            sgFIJULabel.AutoSize = true;
            sgFIJULabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sgFIJULabel.Location = new System.Drawing.Point(60, 207);
            sgFIJULabel.Name = "sgFIJULabel";
            sgFIJULabel.Size = new System.Drawing.Size(116, 20);
            sgFIJULabel.TabIndex = 17;
            sgFIJULabel.Text = "Física / Jurídica";
            // 
            // cdCPFLabel
            // 
            cdCPFLabel.AutoSize = true;
            cdCPFLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cdCPFLabel.Location = new System.Drawing.Point(276, 207);
            cdCPFLabel.Name = "cdCPFLabel";
            cdCPFLabel.Size = new System.Drawing.Size(40, 20);
            cdCPFLabel.TabIndex = 19;
            cdCPFLabel.Text = "CPF";
            // 
            // cdRGLabel
            // 
            cdRGLabel.AutoSize = true;
            cdRGLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cdRGLabel.Location = new System.Drawing.Point(566, 207);
            cdRGLabel.Name = "cdRGLabel";
            cdRGLabel.Size = new System.Drawing.Size(34, 20);
            cdRGLabel.TabIndex = 21;
            cdRGLabel.Text = "RG";
            // 
            // cdCNPJLabel
            // 
            cdCNPJLabel.AutoSize = true;
            cdCNPJLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cdCNPJLabel.Location = new System.Drawing.Point(267, 239);
            cdCNPJLabel.Name = "cdCNPJLabel";
            cdCNPJLabel.Size = new System.Drawing.Size(49, 20);
            cdCNPJLabel.TabIndex = 23;
            cdCNPJLabel.Text = "CNPJ";
            // 
            // cdIELabel
            // 
            cdIELabel.AutoSize = true;
            cdIELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cdIELabel.Location = new System.Drawing.Point(530, 239);
            cdIELabel.Name = "cdIELabel";
            cdIELabel.Size = new System.Drawing.Size(76, 20);
            cdIELabel.TabIndex = 25;
            cdIELabel.Text = "Inscr.Est.";
            // 
            // vlSaldoLabel
            // 
            vlSaldoLabel.AutoSize = true;
            vlSaldoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vlSaldoLabel.Location = new System.Drawing.Point(566, 271);
            vlSaldoLabel.Name = "vlSaldoLabel";
            vlSaldoLabel.Size = new System.Drawing.Size(75, 20);
            vlSaldoLabel.TabIndex = 27;
            vlSaldoLabel.Text = "Saldo R$";
            // 
            // dsTelefoneLabel
            // 
            dsTelefoneLabel.AutoSize = true;
            dsTelefoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dsTelefoneLabel.Location = new System.Drawing.Point(60, 271);
            dsTelefoneLabel.Name = "dsTelefoneLabel";
            dsTelefoneLabel.Size = new System.Drawing.Size(71, 20);
            dsTelefoneLabel.TabIndex = 29;
            dsTelefoneLabel.Text = "Telefone";
            // 
            // bDSucataDataSet
            // 
            this.bDSucataDataSet.DataSetName = "BDSucataDataSet";
            this.bDSucataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbClienteTableAdapter = this.tbClienteTableAdapter;
            this.tableAdapterManager.tbCompradorTableAdapter = null;
            this.tableAdapterManager.tbCompraItemTableAdapter = null;
            this.tableAdapterManager.tbCompraPagTableAdapter = null;
            this.tableAdapterManager.tbCompraTableAdapter = null;
            this.tableAdapterManager.tbFormaPagTableAdapter = null;
            this.tableAdapterManager.tbFuncionarioTableAdapter = null;
            this.tableAdapterManager.tbMovCliTableAdapter = null;
            this.tableAdapterManager.tbMovComTableAdapter = null;
            this.tableAdapterManager.tbPagarTableAdapter = null;
            this.tableAdapterManager.tbProdutoTableAdapter = null;
            this.tableAdapterManager.tbUsuarioTableAdapter = null;
            this.tableAdapterManager.tbVendaItemTableAdapter = null;
            this.tableAdapterManager.tbVendaPagTableAdapter = null;
            this.tableAdapterManager.tbVendaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Sucata.BDSucataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cdClienteTextBox
            // 
            this.cdClienteTextBox.BackColor = System.Drawing.Color.White;
            this.cdClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "cdCliente", true));
            this.cdClienteTextBox.Enabled = false;
            this.cdClienteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdClienteTextBox.ForeColor = System.Drawing.Color.Black;
            this.cdClienteTextBox.Location = new System.Drawing.Point(176, 12);
            this.cdClienteTextBox.Name = "cdClienteTextBox";
            this.cdClienteTextBox.Size = new System.Drawing.Size(62, 26);
            this.cdClienteTextBox.TabIndex = 2;
            // 
            // nmClienteTextBox
            // 
            this.nmClienteTextBox.BackColor = System.Drawing.Color.White;
            this.nmClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "nmCliente", true));
            this.nmClienteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmClienteTextBox.ForeColor = System.Drawing.Color.Black;
            this.nmClienteTextBox.Location = new System.Drawing.Point(176, 44);
            this.nmClienteTextBox.MaxLength = 50;
            this.nmClienteTextBox.Name = "nmClienteTextBox";
            this.nmClienteTextBox.Size = new System.Drawing.Size(384, 26);
            this.nmClienteTextBox.TabIndex = 4;
            this.nmClienteTextBox.Enter += new System.EventHandler(this.nmClienteTextBox_Enter);
            this.nmClienteTextBox.Leave += new System.EventHandler(this.nmClienteTextBox_Leave);
            // 
            // dsEnderecoTextBox
            // 
            this.dsEnderecoTextBox.BackColor = System.Drawing.Color.White;
            this.dsEnderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "dsEndereco", true));
            this.dsEnderecoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dsEnderecoTextBox.ForeColor = System.Drawing.Color.Black;
            this.dsEnderecoTextBox.Location = new System.Drawing.Point(176, 76);
            this.dsEnderecoTextBox.MaxLength = 50;
            this.dsEnderecoTextBox.Name = "dsEnderecoTextBox";
            this.dsEnderecoTextBox.Size = new System.Drawing.Size(384, 26);
            this.dsEnderecoTextBox.TabIndex = 6;
            this.dsEnderecoTextBox.Enter += new System.EventHandler(this.nmClienteTextBox_Enter);
            this.dsEnderecoTextBox.Leave += new System.EventHandler(this.nmClienteTextBox_Leave);
            // 
            // nrNumeroTextBox
            // 
            this.nrNumeroTextBox.BackColor = System.Drawing.Color.White;
            this.nrNumeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "nrNumero", true));
            this.nrNumeroTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nrNumeroTextBox.ForeColor = System.Drawing.Color.Black;
            this.nrNumeroTextBox.Location = new System.Drawing.Point(642, 76);
            this.nrNumeroTextBox.MaxLength = 10;
            this.nrNumeroTextBox.Name = "nrNumeroTextBox";
            this.nrNumeroTextBox.Size = new System.Drawing.Size(100, 26);
            this.nrNumeroTextBox.TabIndex = 8;
            this.nrNumeroTextBox.Enter += new System.EventHandler(this.nmClienteTextBox_Enter);
            this.nrNumeroTextBox.Leave += new System.EventHandler(this.nmClienteTextBox_Leave);
            // 
            // nmBairroTextBox
            // 
            this.nmBairroTextBox.BackColor = System.Drawing.Color.White;
            this.nmBairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "nmBairro", true));
            this.nmBairroTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmBairroTextBox.ForeColor = System.Drawing.Color.Black;
            this.nmBairroTextBox.Location = new System.Drawing.Point(176, 108);
            this.nmBairroTextBox.MaxLength = 30;
            this.nmBairroTextBox.Name = "nmBairroTextBox";
            this.nmBairroTextBox.Size = new System.Drawing.Size(243, 26);
            this.nmBairroTextBox.TabIndex = 10;
            this.nmBairroTextBox.Enter += new System.EventHandler(this.nmClienteTextBox_Enter);
            this.nmBairroTextBox.Leave += new System.EventHandler(this.nmClienteTextBox_Leave);
            // 
            // nmCidadeTextBox
            // 
            this.nmCidadeTextBox.BackColor = System.Drawing.Color.White;
            this.nmCidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "nmCidade", true));
            this.nmCidadeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmCidadeTextBox.ForeColor = System.Drawing.Color.Black;
            this.nmCidadeTextBox.Location = new System.Drawing.Point(176, 140);
            this.nmCidadeTextBox.MaxLength = 40;
            this.nmCidadeTextBox.Name = "nmCidadeTextBox";
            this.nmCidadeTextBox.Size = new System.Drawing.Size(324, 26);
            this.nmCidadeTextBox.TabIndex = 12;
            this.nmCidadeTextBox.Enter += new System.EventHandler(this.nmClienteTextBox_Enter);
            this.nmCidadeTextBox.Leave += new System.EventHandler(this.nmClienteTextBox_Leave);
            // 
            // sgEstadoTextBox
            // 
            this.sgEstadoTextBox.BackColor = System.Drawing.Color.White;
            this.sgEstadoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.sgEstadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "sgEstado", true));
            this.sgEstadoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sgEstadoTextBox.ForeColor = System.Drawing.Color.Black;
            this.sgEstadoTextBox.Location = new System.Drawing.Point(176, 172);
            this.sgEstadoTextBox.MaxLength = 2;
            this.sgEstadoTextBox.Name = "sgEstadoTextBox";
            this.sgEstadoTextBox.Size = new System.Drawing.Size(35, 26);
            this.sgEstadoTextBox.TabIndex = 14;
            this.sgEstadoTextBox.Enter += new System.EventHandler(this.nmClienteTextBox_Enter);
            this.sgEstadoTextBox.Leave += new System.EventHandler(this.nmClienteTextBox_Leave);
            // 
            // cdCEPMaskedTextBox
            // 
            this.cdCEPMaskedTextBox.BackColor = System.Drawing.Color.White;
            this.cdCEPMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "cdCEP", true));
            this.cdCEPMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdCEPMaskedTextBox.ForeColor = System.Drawing.Color.Black;
            this.cdCEPMaskedTextBox.Location = new System.Drawing.Point(642, 172);
            this.cdCEPMaskedTextBox.Mask = "00000-000";
            this.cdCEPMaskedTextBox.Name = "cdCEPMaskedTextBox";
            this.cdCEPMaskedTextBox.Size = new System.Drawing.Size(100, 26);
            this.cdCEPMaskedTextBox.TabIndex = 16;
            this.cdCEPMaskedTextBox.Enter += new System.EventHandler(this.nmClienteTextBox_Enter);
            this.cdCEPMaskedTextBox.Leave += new System.EventHandler(this.nmClienteTextBox_Leave);
            // 
            // sgFIJUTextBox
            // 
            this.sgFIJUTextBox.BackColor = System.Drawing.Color.White;
            this.sgFIJUTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.sgFIJUTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "sgFIJU", true));
            this.sgFIJUTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sgFIJUTextBox.ForeColor = System.Drawing.Color.Black;
            this.sgFIJUTextBox.Location = new System.Drawing.Point(176, 204);
            this.sgFIJUTextBox.MaxLength = 1;
            this.sgFIJUTextBox.Name = "sgFIJUTextBox";
            this.sgFIJUTextBox.Size = new System.Drawing.Size(23, 26);
            this.sgFIJUTextBox.TabIndex = 18;
            this.sgFIJUTextBox.TextChanged += new System.EventHandler(this.sgFIJUTextBox_TextChanged);
            this.sgFIJUTextBox.Enter += new System.EventHandler(this.nmClienteTextBox_Enter);
            this.sgFIJUTextBox.Leave += new System.EventHandler(this.nmClienteTextBox_Leave);
            // 
            // cdCPFMaskedTextBox
            // 
            this.cdCPFMaskedTextBox.BackColor = System.Drawing.Color.White;
            this.cdCPFMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "cdCPF", true));
            this.cdCPFMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdCPFMaskedTextBox.ForeColor = System.Drawing.Color.Black;
            this.cdCPFMaskedTextBox.Location = new System.Drawing.Point(322, 204);
            this.cdCPFMaskedTextBox.Mask = "000,000,000-00";
            this.cdCPFMaskedTextBox.Name = "cdCPFMaskedTextBox";
            this.cdCPFMaskedTextBox.Size = new System.Drawing.Size(128, 26);
            this.cdCPFMaskedTextBox.TabIndex = 20;
            this.cdCPFMaskedTextBox.Enter += new System.EventHandler(this.nmClienteTextBox_Enter);
            this.cdCPFMaskedTextBox.Leave += new System.EventHandler(this.nmClienteTextBox_Leave);
            // 
            // cdRGTextBox
            // 
            this.cdRGTextBox.BackColor = System.Drawing.Color.White;
            this.cdRGTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "cdRG", true));
            this.cdRGTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdRGTextBox.ForeColor = System.Drawing.Color.Black;
            this.cdRGTextBox.Location = new System.Drawing.Point(606, 204);
            this.cdRGTextBox.MaxLength = 15;
            this.cdRGTextBox.Name = "cdRGTextBox";
            this.cdRGTextBox.Size = new System.Drawing.Size(136, 26);
            this.cdRGTextBox.TabIndex = 22;
            this.cdRGTextBox.Enter += new System.EventHandler(this.nmClienteTextBox_Enter);
            this.cdRGTextBox.Leave += new System.EventHandler(this.nmClienteTextBox_Leave);
            // 
            // cdCNPJMaskedTextBox
            // 
            this.cdCNPJMaskedTextBox.BackColor = System.Drawing.Color.White;
            this.cdCNPJMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "cdCNPJ", true));
            this.cdCNPJMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdCNPJMaskedTextBox.ForeColor = System.Drawing.Color.Black;
            this.cdCNPJMaskedTextBox.Location = new System.Drawing.Point(322, 236);
            this.cdCNPJMaskedTextBox.Mask = "00,000,000/0000-00";
            this.cdCNPJMaskedTextBox.Name = "cdCNPJMaskedTextBox";
            this.cdCNPJMaskedTextBox.Size = new System.Drawing.Size(178, 26);
            this.cdCNPJMaskedTextBox.TabIndex = 24;
            this.cdCNPJMaskedTextBox.Enter += new System.EventHandler(this.nmClienteTextBox_Enter);
            this.cdCNPJMaskedTextBox.Leave += new System.EventHandler(this.nmClienteTextBox_Leave);
            // 
            // cdIEMaskedTextBox
            // 
            this.cdIEMaskedTextBox.BackColor = System.Drawing.Color.White;
            this.cdIEMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "cdIE", true));
            this.cdIEMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdIEMaskedTextBox.ForeColor = System.Drawing.Color.Black;
            this.cdIEMaskedTextBox.Location = new System.Drawing.Point(606, 236);
            this.cdIEMaskedTextBox.Mask = "000,000,000,000";
            this.cdIEMaskedTextBox.Name = "cdIEMaskedTextBox";
            this.cdIEMaskedTextBox.Size = new System.Drawing.Size(136, 26);
            this.cdIEMaskedTextBox.TabIndex = 26;
            this.cdIEMaskedTextBox.Enter += new System.EventHandler(this.nmClienteTextBox_Enter);
            this.cdIEMaskedTextBox.Leave += new System.EventHandler(this.nmClienteTextBox_Leave);
            // 
            // vlSaldoTextBox
            // 
            this.vlSaldoTextBox.BackColor = System.Drawing.Color.White;
            this.vlSaldoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "vlSaldo", true));
            this.vlSaldoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vlSaldoTextBox.ForeColor = System.Drawing.Color.Black;
            this.vlSaldoTextBox.Location = new System.Drawing.Point(642, 268);
            this.vlSaldoTextBox.MaxLength = 15;
            this.vlSaldoTextBox.Name = "vlSaldoTextBox";
            this.vlSaldoTextBox.Size = new System.Drawing.Size(100, 26);
            this.vlSaldoTextBox.TabIndex = 30;
            this.vlSaldoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.vlSaldoTextBox.TextChanged += new System.EventHandler(this.vlSaldoTextBox_TextChanged);
            this.vlSaldoTextBox.Enter += new System.EventHandler(this.nmClienteTextBox_Enter);
            this.vlSaldoTextBox.Leave += new System.EventHandler(this.nmClienteTextBox_Leave);
            // 
            // dsTelefoneTextBox
            // 
            this.dsTelefoneTextBox.BackColor = System.Drawing.Color.White;
            this.dsTelefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "dsTelefone", true));
            this.dsTelefoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dsTelefoneTextBox.ForeColor = System.Drawing.Color.Black;
            this.dsTelefoneTextBox.Location = new System.Drawing.Point(176, 268);
            this.dsTelefoneTextBox.MaxLength = 40;
            this.dsTelefoneTextBox.Name = "dsTelefoneTextBox";
            this.dsTelefoneTextBox.Size = new System.Drawing.Size(324, 26);
            this.dsTelefoneTextBox.TabIndex = 28;
            this.dsTelefoneTextBox.Enter += new System.EventHandler(this.nmClienteTextBox_Enter);
            this.dsTelefoneTextBox.Leave += new System.EventHandler(this.nmClienteTextBox_Leave);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.panel1.Location = new System.Drawing.Point(0, 308);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 142);
            this.panel1.TabIndex = 31;
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
            this.btnAnterior.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(60, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 19);
            this.label1.TabIndex = 32;
            this.label1.Text = "F";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(112, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 19);
            this.label2.TabIndex = 33;
            this.label2.Text = "J";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(cdClienteLabel);
            this.Controls.Add(this.cdClienteTextBox);
            this.Controls.Add(nmClienteLabel);
            this.Controls.Add(this.nmClienteTextBox);
            this.Controls.Add(dsEnderecoLabel);
            this.Controls.Add(this.dsEnderecoTextBox);
            this.Controls.Add(nrNumeroLabel);
            this.Controls.Add(this.nrNumeroTextBox);
            this.Controls.Add(nmBairroLabel);
            this.Controls.Add(this.nmBairroTextBox);
            this.Controls.Add(nmCidadeLabel);
            this.Controls.Add(this.nmCidadeTextBox);
            this.Controls.Add(sgEstadoLabel);
            this.Controls.Add(this.sgEstadoTextBox);
            this.Controls.Add(cdCEPLabel);
            this.Controls.Add(this.cdCEPMaskedTextBox);
            this.Controls.Add(sgFIJULabel);
            this.Controls.Add(this.sgFIJUTextBox);
            this.Controls.Add(cdCPFLabel);
            this.Controls.Add(this.cdCPFMaskedTextBox);
            this.Controls.Add(cdRGLabel);
            this.Controls.Add(this.cdRGTextBox);
            this.Controls.Add(cdCNPJLabel);
            this.Controls.Add(this.cdCNPJMaskedTextBox);
            this.Controls.Add(cdIELabel);
            this.Controls.Add(this.cdIEMaskedTextBox);
            this.Controls.Add(vlSaldoLabel);
            this.Controls.Add(this.vlSaldoTextBox);
            this.Controls.Add(dsTelefoneLabel);
            this.Controls.Add(this.dsTelefoneTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCliente_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.bDSucataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDSucataDataSet bDSucataDataSet;
        private System.Windows.Forms.BindingSource tbClienteBindingSource;
        private BDSucataDataSetTableAdapters.tbClienteTableAdapter tbClienteTableAdapter;
        private BDSucataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cdClienteTextBox;
        private System.Windows.Forms.TextBox nmClienteTextBox;
        private System.Windows.Forms.TextBox dsEnderecoTextBox;
        private System.Windows.Forms.TextBox nrNumeroTextBox;
        private System.Windows.Forms.TextBox nmBairroTextBox;
        private System.Windows.Forms.TextBox nmCidadeTextBox;
        private System.Windows.Forms.TextBox sgEstadoTextBox;
        private System.Windows.Forms.MaskedTextBox cdCEPMaskedTextBox;
        private System.Windows.Forms.TextBox sgFIJUTextBox;
        private System.Windows.Forms.MaskedTextBox cdCPFMaskedTextBox;
        private System.Windows.Forms.TextBox cdRGTextBox;
        private System.Windows.Forms.MaskedTextBox cdCNPJMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cdIEMaskedTextBox;
        private System.Windows.Forms.TextBox vlSaldoTextBox;
        private System.Windows.Forms.TextBox dsTelefoneTextBox;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}