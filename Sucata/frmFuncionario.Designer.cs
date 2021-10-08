namespace Sucata
{
    partial class frmFuncionario
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
            System.Windows.Forms.Label cdFuncionarioLabel;
            System.Windows.Forms.Label nmFuncionarioLabel;
            System.Windows.Forms.Label dsEnderecoLabel;
            System.Windows.Forms.Label nrNumeroLabel;
            System.Windows.Forms.Label nmBairroLabel;
            System.Windows.Forms.Label nmCidadeLabel;
            System.Windows.Forms.Label sgEstadoLabel;
            System.Windows.Forms.Label cdCEPLabel;
            System.Windows.Forms.Label cdCPFLabel;
            System.Windows.Forms.Label cdRGLabel;
            System.Windows.Forms.Label vlSaldoLabel;
            System.Windows.Forms.Label dsTelefoneLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFuncionario));
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
            this.bDSucataDataSet = new Sucata.BDSucataDataSet();
            this.tbFuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbFuncionarioTableAdapter = new Sucata.BDSucataDataSetTableAdapters.tbFuncionarioTableAdapter();
            this.cdFuncionarioTextBox = new System.Windows.Forms.TextBox();
            this.nmFuncionarioTextBox = new System.Windows.Forms.TextBox();
            this.dsEnderecoTextBox = new System.Windows.Forms.TextBox();
            this.nrNumeroTextBox = new System.Windows.Forms.TextBox();
            this.nmBairroTextBox = new System.Windows.Forms.TextBox();
            this.nmCidadeTextBox = new System.Windows.Forms.TextBox();
            this.sgEstadoTextBox = new System.Windows.Forms.TextBox();
            this.cdRGTextBox = new System.Windows.Forms.TextBox();
            this.dsTelefoneTextBox = new System.Windows.Forms.TextBox();
            this.cdCEPMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cdCPFMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.vlSaldoTextBox = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            cdFuncionarioLabel = new System.Windows.Forms.Label();
            nmFuncionarioLabel = new System.Windows.Forms.Label();
            dsEnderecoLabel = new System.Windows.Forms.Label();
            nrNumeroLabel = new System.Windows.Forms.Label();
            nmBairroLabel = new System.Windows.Forms.Label();
            nmCidadeLabel = new System.Windows.Forms.Label();
            sgEstadoLabel = new System.Windows.Forms.Label();
            cdCEPLabel = new System.Windows.Forms.Label();
            cdCPFLabel = new System.Windows.Forms.Label();
            cdRGLabel = new System.Windows.Forms.Label();
            vlSaldoLabel = new System.Windows.Forms.Label();
            dsTelefoneLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bDSucataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFuncionarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cdFuncionarioLabel
            // 
            cdFuncionarioLabel.AutoSize = true;
            cdFuncionarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cdFuncionarioLabel.Location = new System.Drawing.Point(69, 23);
            cdFuncionarioLabel.Name = "cdFuncionarioLabel";
            cdFuncionarioLabel.Size = new System.Drawing.Size(59, 20);
            cdFuncionarioLabel.TabIndex = 14;
            cdFuncionarioLabel.Text = "Código";
            // 
            // nmFuncionarioLabel
            // 
            nmFuncionarioLabel.AutoSize = true;
            nmFuncionarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nmFuncionarioLabel.Location = new System.Drawing.Point(69, 59);
            nmFuncionarioLabel.Name = "nmFuncionarioLabel";
            nmFuncionarioLabel.Size = new System.Drawing.Size(51, 20);
            nmFuncionarioLabel.TabIndex = 16;
            nmFuncionarioLabel.Text = "Nome";
            // 
            // dsEnderecoLabel
            // 
            dsEnderecoLabel.AutoSize = true;
            dsEnderecoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dsEnderecoLabel.Location = new System.Drawing.Point(69, 95);
            dsEnderecoLabel.Name = "dsEnderecoLabel";
            dsEnderecoLabel.Size = new System.Drawing.Size(78, 20);
            dsEnderecoLabel.TabIndex = 18;
            dsEnderecoLabel.Text = "Endereço";
            // 
            // nrNumeroLabel
            // 
            nrNumeroLabel.AutoSize = true;
            nrNumeroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nrNumeroLabel.Location = new System.Drawing.Point(571, 95);
            nrNumeroLabel.Name = "nrNumeroLabel";
            nrNumeroLabel.Size = new System.Drawing.Size(65, 20);
            nrNumeroLabel.TabIndex = 20;
            nrNumeroLabel.Text = "Número";
            // 
            // nmBairroLabel
            // 
            nmBairroLabel.AutoSize = true;
            nmBairroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nmBairroLabel.Location = new System.Drawing.Point(69, 131);
            nmBairroLabel.Name = "nmBairroLabel";
            nmBairroLabel.Size = new System.Drawing.Size(51, 20);
            nmBairroLabel.TabIndex = 22;
            nmBairroLabel.Text = "Bairro";
            // 
            // nmCidadeLabel
            // 
            nmCidadeLabel.AutoSize = true;
            nmCidadeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nmCidadeLabel.Location = new System.Drawing.Point(69, 167);
            nmCidadeLabel.Name = "nmCidadeLabel";
            nmCidadeLabel.Size = new System.Drawing.Size(59, 20);
            nmCidadeLabel.TabIndex = 24;
            nmCidadeLabel.Text = "Cidade";
            // 
            // sgEstadoLabel
            // 
            sgEstadoLabel.AutoSize = true;
            sgEstadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sgEstadoLabel.Location = new System.Drawing.Point(69, 203);
            sgEstadoLabel.Name = "sgEstadoLabel";
            sgEstadoLabel.Size = new System.Drawing.Size(60, 20);
            sgEstadoLabel.TabIndex = 26;
            sgEstadoLabel.Text = "Estado";
            // 
            // cdCEPLabel
            // 
            cdCEPLabel.AutoSize = true;
            cdCEPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cdCEPLabel.Location = new System.Drawing.Point(595, 203);
            cdCEPLabel.Name = "cdCEPLabel";
            cdCEPLabel.Size = new System.Drawing.Size(41, 20);
            cdCEPLabel.TabIndex = 28;
            cdCEPLabel.Text = "CEP";
            // 
            // cdCPFLabel
            // 
            cdCPFLabel.AutoSize = true;
            cdCPFLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cdCPFLabel.Location = new System.Drawing.Point(69, 239);
            cdCPFLabel.Name = "cdCPFLabel";
            cdCPFLabel.Size = new System.Drawing.Size(40, 20);
            cdCPFLabel.TabIndex = 30;
            cdCPFLabel.Text = "CPF";
            // 
            // cdRGLabel
            // 
            cdRGLabel.AutoSize = true;
            cdRGLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cdRGLabel.Location = new System.Drawing.Point(559, 239);
            cdRGLabel.Name = "cdRGLabel";
            cdRGLabel.Size = new System.Drawing.Size(34, 20);
            cdRGLabel.TabIndex = 32;
            cdRGLabel.Text = "RG";
            // 
            // vlSaldoLabel
            // 
            vlSaldoLabel.AutoSize = true;
            vlSaldoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vlSaldoLabel.Location = new System.Drawing.Point(69, 311);
            vlSaldoLabel.Name = "vlSaldoLabel";
            vlSaldoLabel.Size = new System.Drawing.Size(75, 20);
            vlSaldoLabel.TabIndex = 34;
            vlSaldoLabel.Text = "Saldo R$";
            // 
            // dsTelefoneLabel
            // 
            dsTelefoneLabel.AutoSize = true;
            dsTelefoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dsTelefoneLabel.Location = new System.Drawing.Point(69, 275);
            dsTelefoneLabel.Name = "dsTelefoneLabel";
            dsTelefoneLabel.Size = new System.Drawing.Size(71, 20);
            dsTelefoneLabel.TabIndex = 36;
            dsTelefoneLabel.Text = "Telefone";
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
            this.panel1.Location = new System.Drawing.Point(0, 357);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 142);
            this.panel1.TabIndex = 13;
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
            // bDSucataDataSet
            // 
            this.bDSucataDataSet.DataSetName = "BDSucataDataSet";
            this.bDSucataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbFuncionarioBindingSource
            // 
            this.tbFuncionarioBindingSource.DataMember = "tbFuncionario";
            this.tbFuncionarioBindingSource.DataSource = this.bDSucataDataSet;
            // 
            // tbFuncionarioTableAdapter
            // 
            this.tbFuncionarioTableAdapter.ClearBeforeFill = true;
            // 
            // cdFuncionarioTextBox
            // 
            this.cdFuncionarioTextBox.BackColor = System.Drawing.Color.White;
            this.cdFuncionarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbFuncionarioBindingSource, "cdFuncionario", true));
            this.cdFuncionarioTextBox.Enabled = false;
            this.cdFuncionarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdFuncionarioTextBox.ForeColor = System.Drawing.Color.Black;
            this.cdFuncionarioTextBox.Location = new System.Drawing.Point(162, 20);
            this.cdFuncionarioTextBox.Name = "cdFuncionarioTextBox";
            this.cdFuncionarioTextBox.Size = new System.Drawing.Size(64, 26);
            this.cdFuncionarioTextBox.TabIndex = 15;
            // 
            // nmFuncionarioTextBox
            // 
            this.nmFuncionarioTextBox.BackColor = System.Drawing.Color.White;
            this.nmFuncionarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbFuncionarioBindingSource, "nmFuncionario", true));
            this.nmFuncionarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmFuncionarioTextBox.ForeColor = System.Drawing.Color.Black;
            this.nmFuncionarioTextBox.Location = new System.Drawing.Point(162, 56);
            this.nmFuncionarioTextBox.MaxLength = 50;
            this.nmFuncionarioTextBox.Name = "nmFuncionarioTextBox";
            this.nmFuncionarioTextBox.Size = new System.Drawing.Size(386, 26);
            this.nmFuncionarioTextBox.TabIndex = 17;
            this.nmFuncionarioTextBox.Enter += new System.EventHandler(this.nmFuncionarioTextBox_Enter);
            this.nmFuncionarioTextBox.Leave += new System.EventHandler(this.nmFuncionarioTextBox_Leave);
            // 
            // dsEnderecoTextBox
            // 
            this.dsEnderecoTextBox.BackColor = System.Drawing.Color.White;
            this.dsEnderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbFuncionarioBindingSource, "dsEndereco", true));
            this.dsEnderecoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dsEnderecoTextBox.ForeColor = System.Drawing.Color.Black;
            this.dsEnderecoTextBox.Location = new System.Drawing.Point(162, 92);
            this.dsEnderecoTextBox.MaxLength = 50;
            this.dsEnderecoTextBox.Name = "dsEnderecoTextBox";
            this.dsEnderecoTextBox.Size = new System.Drawing.Size(386, 26);
            this.dsEnderecoTextBox.TabIndex = 19;
            this.dsEnderecoTextBox.Enter += new System.EventHandler(this.nmFuncionarioTextBox_Enter);
            this.dsEnderecoTextBox.Leave += new System.EventHandler(this.nmFuncionarioTextBox_Leave);
            // 
            // nrNumeroTextBox
            // 
            this.nrNumeroTextBox.BackColor = System.Drawing.Color.White;
            this.nrNumeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbFuncionarioBindingSource, "nrNumero", true));
            this.nrNumeroTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nrNumeroTextBox.ForeColor = System.Drawing.Color.Black;
            this.nrNumeroTextBox.Location = new System.Drawing.Point(642, 92);
            this.nrNumeroTextBox.MaxLength = 10;
            this.nrNumeroTextBox.Name = "nrNumeroTextBox";
            this.nrNumeroTextBox.Size = new System.Drawing.Size(100, 26);
            this.nrNumeroTextBox.TabIndex = 21;
            this.nrNumeroTextBox.Enter += new System.EventHandler(this.nmFuncionarioTextBox_Enter);
            this.nrNumeroTextBox.Leave += new System.EventHandler(this.nmFuncionarioTextBox_Leave);
            // 
            // nmBairroTextBox
            // 
            this.nmBairroTextBox.BackColor = System.Drawing.Color.White;
            this.nmBairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbFuncionarioBindingSource, "nmBairro", true));
            this.nmBairroTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmBairroTextBox.ForeColor = System.Drawing.Color.Black;
            this.nmBairroTextBox.Location = new System.Drawing.Point(162, 128);
            this.nmBairroTextBox.MaxLength = 30;
            this.nmBairroTextBox.Name = "nmBairroTextBox";
            this.nmBairroTextBox.Size = new System.Drawing.Size(196, 26);
            this.nmBairroTextBox.TabIndex = 23;
            this.nmBairroTextBox.Enter += new System.EventHandler(this.nmFuncionarioTextBox_Enter);
            this.nmBairroTextBox.Leave += new System.EventHandler(this.nmFuncionarioTextBox_Leave);
            // 
            // nmCidadeTextBox
            // 
            this.nmCidadeTextBox.BackColor = System.Drawing.Color.White;
            this.nmCidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbFuncionarioBindingSource, "nmCidade", true));
            this.nmCidadeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmCidadeTextBox.ForeColor = System.Drawing.Color.Black;
            this.nmCidadeTextBox.Location = new System.Drawing.Point(162, 164);
            this.nmCidadeTextBox.MaxLength = 40;
            this.nmCidadeTextBox.Name = "nmCidadeTextBox";
            this.nmCidadeTextBox.Size = new System.Drawing.Size(320, 26);
            this.nmCidadeTextBox.TabIndex = 25;
            this.nmCidadeTextBox.Enter += new System.EventHandler(this.nmFuncionarioTextBox_Enter);
            this.nmCidadeTextBox.Leave += new System.EventHandler(this.nmFuncionarioTextBox_Leave);
            // 
            // sgEstadoTextBox
            // 
            this.sgEstadoTextBox.BackColor = System.Drawing.Color.White;
            this.sgEstadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbFuncionarioBindingSource, "sgEstado", true));
            this.sgEstadoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sgEstadoTextBox.ForeColor = System.Drawing.Color.Black;
            this.sgEstadoTextBox.Location = new System.Drawing.Point(162, 200);
            this.sgEstadoTextBox.MaxLength = 2;
            this.sgEstadoTextBox.Name = "sgEstadoTextBox";
            this.sgEstadoTextBox.Size = new System.Drawing.Size(34, 26);
            this.sgEstadoTextBox.TabIndex = 27;
            this.sgEstadoTextBox.Enter += new System.EventHandler(this.nmFuncionarioTextBox_Enter);
            this.sgEstadoTextBox.Leave += new System.EventHandler(this.nmFuncionarioTextBox_Leave);
            // 
            // cdRGTextBox
            // 
            this.cdRGTextBox.BackColor = System.Drawing.Color.White;
            this.cdRGTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbFuncionarioBindingSource, "cdRG", true));
            this.cdRGTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdRGTextBox.ForeColor = System.Drawing.Color.Black;
            this.cdRGTextBox.Location = new System.Drawing.Point(606, 236);
            this.cdRGTextBox.MaxLength = 15;
            this.cdRGTextBox.Name = "cdRGTextBox";
            this.cdRGTextBox.Size = new System.Drawing.Size(136, 26);
            this.cdRGTextBox.TabIndex = 33;
            this.cdRGTextBox.Enter += new System.EventHandler(this.nmFuncionarioTextBox_Enter);
            this.cdRGTextBox.Leave += new System.EventHandler(this.nmFuncionarioTextBox_Leave);
            // 
            // dsTelefoneTextBox
            // 
            this.dsTelefoneTextBox.BackColor = System.Drawing.Color.White;
            this.dsTelefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbFuncionarioBindingSource, "dsTelefone", true));
            this.dsTelefoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dsTelefoneTextBox.ForeColor = System.Drawing.Color.Black;
            this.dsTelefoneTextBox.Location = new System.Drawing.Point(162, 272);
            this.dsTelefoneTextBox.MaxLength = 40;
            this.dsTelefoneTextBox.Name = "dsTelefoneTextBox";
            this.dsTelefoneTextBox.Size = new System.Drawing.Size(320, 26);
            this.dsTelefoneTextBox.TabIndex = 35;
            this.dsTelefoneTextBox.Enter += new System.EventHandler(this.nmFuncionarioTextBox_Enter);
            this.dsTelefoneTextBox.Leave += new System.EventHandler(this.nmFuncionarioTextBox_Leave);
            // 
            // cdCEPMaskedTextBox
            // 
            this.cdCEPMaskedTextBox.BackColor = System.Drawing.Color.White;
            this.cdCEPMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbFuncionarioBindingSource, "cdCEP", true));
            this.cdCEPMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdCEPMaskedTextBox.ForeColor = System.Drawing.Color.Black;
            this.cdCEPMaskedTextBox.Location = new System.Drawing.Point(642, 200);
            this.cdCEPMaskedTextBox.Mask = "00000-000";
            this.cdCEPMaskedTextBox.Name = "cdCEPMaskedTextBox";
            this.cdCEPMaskedTextBox.Size = new System.Drawing.Size(100, 26);
            this.cdCEPMaskedTextBox.TabIndex = 29;
            this.cdCEPMaskedTextBox.Enter += new System.EventHandler(this.nmFuncionarioTextBox_Enter);
            this.cdCEPMaskedTextBox.Leave += new System.EventHandler(this.nmFuncionarioTextBox_Leave);
            // 
            // cdCPFMaskedTextBox
            // 
            this.cdCPFMaskedTextBox.BackColor = System.Drawing.Color.White;
            this.cdCPFMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbFuncionarioBindingSource, "cdCPF", true));
            this.cdCPFMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdCPFMaskedTextBox.ForeColor = System.Drawing.Color.Black;
            this.cdCPFMaskedTextBox.Location = new System.Drawing.Point(162, 236);
            this.cdCPFMaskedTextBox.Mask = "000,000,000-00";
            this.cdCPFMaskedTextBox.Name = "cdCPFMaskedTextBox";
            this.cdCPFMaskedTextBox.Size = new System.Drawing.Size(126, 26);
            this.cdCPFMaskedTextBox.TabIndex = 31;
            this.cdCPFMaskedTextBox.Enter += new System.EventHandler(this.nmFuncionarioTextBox_Enter);
            this.cdCPFMaskedTextBox.Leave += new System.EventHandler(this.nmFuncionarioTextBox_Leave);
            // 
            // vlSaldoTextBox
            // 
            this.vlSaldoTextBox.BackColor = System.Drawing.Color.White;
            this.vlSaldoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbFuncionarioBindingSource, "vlSaldo", true));
            this.vlSaldoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vlSaldoTextBox.ForeColor = System.Drawing.Color.Black;
            this.vlSaldoTextBox.Location = new System.Drawing.Point(162, 308);
            this.vlSaldoTextBox.MaxLength = 15;
            this.vlSaldoTextBox.Name = "vlSaldoTextBox";
            this.vlSaldoTextBox.Size = new System.Drawing.Size(126, 26);
            this.vlSaldoTextBox.TabIndex = 37;
            this.vlSaldoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.vlSaldoTextBox.TextChanged += new System.EventHandler(this.vlSaldoTextBox_TextChanged);
            this.vlSaldoTextBox.Enter += new System.EventHandler(this.nmFuncionarioTextBox_Enter);
            this.vlSaldoTextBox.Leave += new System.EventHandler(this.nmFuncionarioTextBox_Leave);
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
            // frmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(803, 499);
            this.ControlBox = false;
            this.Controls.Add(this.vlSaldoTextBox);
            this.Controls.Add(this.cdCPFMaskedTextBox);
            this.Controls.Add(this.cdCEPMaskedTextBox);
            this.Controls.Add(cdFuncionarioLabel);
            this.Controls.Add(this.cdFuncionarioTextBox);
            this.Controls.Add(nmFuncionarioLabel);
            this.Controls.Add(this.nmFuncionarioTextBox);
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
            this.Controls.Add(cdCPFLabel);
            this.Controls.Add(cdRGLabel);
            this.Controls.Add(this.cdRGTextBox);
            this.Controls.Add(vlSaldoLabel);
            this.Controls.Add(dsTelefoneLabel);
            this.Controls.Add(this.dsTelefoneTextBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "frmFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionários";
            this.Load += new System.EventHandler(this.frmFuncionario_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmFuncionario_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bDSucataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFuncionarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private BDSucataDataSet bDSucataDataSet;
        private System.Windows.Forms.BindingSource tbFuncionarioBindingSource;
        private BDSucataDataSetTableAdapters.tbFuncionarioTableAdapter tbFuncionarioTableAdapter;
        private System.Windows.Forms.TextBox cdFuncionarioTextBox;
        private System.Windows.Forms.TextBox nmFuncionarioTextBox;
        private System.Windows.Forms.TextBox dsEnderecoTextBox;
        private System.Windows.Forms.TextBox nrNumeroTextBox;
        private System.Windows.Forms.TextBox nmBairroTextBox;
        private System.Windows.Forms.TextBox nmCidadeTextBox;
        private System.Windows.Forms.TextBox sgEstadoTextBox;
        private System.Windows.Forms.TextBox cdRGTextBox;
        private System.Windows.Forms.TextBox dsTelefoneTextBox;
        private System.Windows.Forms.MaskedTextBox cdCEPMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cdCPFMaskedTextBox;
        private System.Windows.Forms.TextBox vlSaldoTextBox;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}