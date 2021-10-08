namespace Sucata
{
    partial class frmDespesa
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
            System.Windows.Forms.Label cdContaLabel;
            System.Windows.Forms.Label dtContaLabel;
            System.Windows.Forms.Label nrContaLabel;
            System.Windows.Forms.Label vlContaLabel;
            System.Windows.Forms.Label dtVencimentoLabel;
            System.Windows.Forms.Label dtPagamentoLabel;
            System.Windows.Forms.Label vlPagoLabel;
            this.bDSucataDataSet = new Sucata.BDSucataDataSet();
            this.tbPagarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbPagarTableAdapter = new Sucata.BDSucataDataSetTableAdapters.tbPagarTableAdapter();
            this.cdContaTextBox = new System.Windows.Forms.TextBox();
            this.nrContaTextBox = new System.Windows.Forms.TextBox();
            this.vlContaTextBox = new System.Windows.Forms.TextBox();
            this.dtVencimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dtPagamentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.vlPagoTextBox = new System.Windows.Forms.TextBox();
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
            this.tableAdapterManager = new Sucata.BDSucataDataSetTableAdapters.TableAdapterManager();
            this.dtContaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            cdContaLabel = new System.Windows.Forms.Label();
            dtContaLabel = new System.Windows.Forms.Label();
            nrContaLabel = new System.Windows.Forms.Label();
            vlContaLabel = new System.Windows.Forms.Label();
            dtVencimentoLabel = new System.Windows.Forms.Label();
            dtPagamentoLabel = new System.Windows.Forms.Label();
            vlPagoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDSucataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPagarBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cdContaLabel
            // 
            cdContaLabel.AutoSize = true;
            cdContaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cdContaLabel.Location = new System.Drawing.Point(175, 29);
            cdContaLabel.Name = "cdContaLabel";
            cdContaLabel.Size = new System.Drawing.Size(59, 20);
            cdContaLabel.TabIndex = 1;
            cdContaLabel.Text = "Código";
            // 
            // dtContaLabel
            // 
            dtContaLabel.AutoSize = true;
            dtContaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dtContaLabel.Location = new System.Drawing.Point(175, 68);
            dtContaLabel.Name = "dtContaLabel";
            dtContaLabel.Size = new System.Drawing.Size(44, 20);
            dtContaLabel.TabIndex = 3;
            dtContaLabel.Text = "Data";
            // 
            // nrContaLabel
            // 
            nrContaLabel.AutoSize = true;
            nrContaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nrContaLabel.Location = new System.Drawing.Point(175, 107);
            nrContaLabel.Name = "nrContaLabel";
            nrContaLabel.Size = new System.Drawing.Size(65, 20);
            nrContaLabel.TabIndex = 5;
            nrContaLabel.Text = "Número";
            // 
            // vlContaLabel
            // 
            vlContaLabel.AutoSize = true;
            vlContaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vlContaLabel.Location = new System.Drawing.Point(175, 146);
            vlContaLabel.Name = "vlContaLabel";
            vlContaLabel.Size = new System.Drawing.Size(46, 20);
            vlContaLabel.TabIndex = 7;
            vlContaLabel.Text = "Valor";
            // 
            // dtVencimentoLabel
            // 
            dtVencimentoLabel.AutoSize = true;
            dtVencimentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dtVencimentoLabel.Location = new System.Drawing.Point(175, 185);
            dtVencimentoLabel.Name = "dtVencimentoLabel";
            dtVencimentoLabel.Size = new System.Drawing.Size(94, 20);
            dtVencimentoLabel.TabIndex = 9;
            dtVencimentoLabel.Text = "Vencimento";
            // 
            // dtPagamentoLabel
            // 
            dtPagamentoLabel.AutoSize = true;
            dtPagamentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dtPagamentoLabel.Location = new System.Drawing.Point(175, 224);
            dtPagamentoLabel.Name = "dtPagamentoLabel";
            dtPagamentoLabel.Size = new System.Drawing.Size(91, 20);
            dtPagamentoLabel.TabIndex = 11;
            dtPagamentoLabel.Text = "Pagamento";
            // 
            // vlPagoLabel
            // 
            vlPagoLabel.AutoSize = true;
            vlPagoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vlPagoLabel.Location = new System.Drawing.Point(175, 263);
            vlPagoLabel.Name = "vlPagoLabel";
            vlPagoLabel.Size = new System.Drawing.Size(86, 20);
            vlPagoLabel.TabIndex = 13;
            vlPagoLabel.Text = "Valor pago";
            // 
            // bDSucataDataSet
            // 
            this.bDSucataDataSet.DataSetName = "BDSucataDataSet";
            this.bDSucataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbPagarBindingSource
            // 
            this.tbPagarBindingSource.DataMember = "tbPagar";
            this.tbPagarBindingSource.DataSource = this.bDSucataDataSet;
            // 
            // tbPagarTableAdapter
            // 
            this.tbPagarTableAdapter.ClearBeforeFill = true;
            // 
            // cdContaTextBox
            // 
            this.cdContaTextBox.BackColor = System.Drawing.Color.White;
            this.cdContaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbPagarBindingSource, "cdConta", true));
            this.cdContaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdContaTextBox.ForeColor = System.Drawing.Color.Black;
            this.cdContaTextBox.Location = new System.Drawing.Point(272, 26);
            this.cdContaTextBox.Name = "cdContaTextBox";
            this.cdContaTextBox.Size = new System.Drawing.Size(83, 26);
            this.cdContaTextBox.TabIndex = 2;
            // 
            // nrContaTextBox
            // 
            this.nrContaTextBox.BackColor = System.Drawing.Color.White;
            this.nrContaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbPagarBindingSource, "nrConta", true));
            this.nrContaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nrContaTextBox.ForeColor = System.Drawing.Color.Black;
            this.nrContaTextBox.Location = new System.Drawing.Point(272, 104);
            this.nrContaTextBox.Name = "nrContaTextBox";
            this.nrContaTextBox.Size = new System.Drawing.Size(124, 26);
            this.nrContaTextBox.TabIndex = 6;
            // 
            // vlContaTextBox
            // 
            this.vlContaTextBox.BackColor = System.Drawing.Color.White;
            this.vlContaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbPagarBindingSource, "vlConta", true));
            this.vlContaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vlContaTextBox.ForeColor = System.Drawing.Color.Black;
            this.vlContaTextBox.Location = new System.Drawing.Point(272, 143);
            this.vlContaTextBox.Name = "vlContaTextBox";
            this.vlContaTextBox.Size = new System.Drawing.Size(124, 26);
            this.vlContaTextBox.TabIndex = 8;
            // 
            // dtVencimentoDateTimePicker
            // 
            this.dtVencimentoDateTimePicker.CalendarForeColor = System.Drawing.Color.Black;
            this.dtVencimentoDateTimePicker.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtVencimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbPagarBindingSource, "dtVencimento", true));
            this.dtVencimentoDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtVencimentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtVencimentoDateTimePicker.Location = new System.Drawing.Point(272, 182);
            this.dtVencimentoDateTimePicker.Name = "dtVencimentoDateTimePicker";
            this.dtVencimentoDateTimePicker.Size = new System.Drawing.Size(124, 26);
            this.dtVencimentoDateTimePicker.TabIndex = 10;
            // 
            // dtPagamentoDateTimePicker
            // 
            this.dtPagamentoDateTimePicker.CalendarForeColor = System.Drawing.Color.Black;
            this.dtPagamentoDateTimePicker.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtPagamentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbPagarBindingSource, "dtPagamento", true));
            this.dtPagamentoDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPagamentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPagamentoDateTimePicker.Location = new System.Drawing.Point(272, 221);
            this.dtPagamentoDateTimePicker.Name = "dtPagamentoDateTimePicker";
            this.dtPagamentoDateTimePicker.Size = new System.Drawing.Size(124, 26);
            this.dtPagamentoDateTimePicker.TabIndex = 12;
            // 
            // vlPagoTextBox
            // 
            this.vlPagoTextBox.BackColor = System.Drawing.Color.White;
            this.vlPagoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbPagarBindingSource, "vlPago", true));
            this.vlPagoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vlPagoTextBox.ForeColor = System.Drawing.Color.Black;
            this.vlPagoTextBox.Location = new System.Drawing.Point(272, 260);
            this.vlPagoTextBox.Name = "vlPagoTextBox";
            this.vlPagoTextBox.Size = new System.Drawing.Size(124, 26);
            this.vlPagoTextBox.TabIndex = 14;
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
            this.panel1.TabIndex = 32;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbClienteTableAdapter = null;
            this.tableAdapterManager.tbCompradorTableAdapter = null;
            this.tableAdapterManager.tbCompraItemTableAdapter = null;
            this.tableAdapterManager.tbCompraPagTableAdapter = null;
            this.tableAdapterManager.tbCompraTableAdapter = null;
            this.tableAdapterManager.tbFormaPagTableAdapter = null;
            this.tableAdapterManager.tbFuncionarioTableAdapter = null;
            this.tableAdapterManager.tbMovCliTableAdapter = null;
            this.tableAdapterManager.tbMovComTableAdapter = null;
            this.tableAdapterManager.tbPagarTableAdapter = this.tbPagarTableAdapter;
            this.tableAdapterManager.tbProdutoTableAdapter = null;
            this.tableAdapterManager.tbUsuarioTableAdapter = null;
            this.tableAdapterManager.tbVendaItemTableAdapter = null;
            this.tableAdapterManager.tbVendaPagTableAdapter = null;
            this.tableAdapterManager.tbVendaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Sucata.BDSucataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dtContaDateTimePicker
            // 
            this.dtContaDateTimePicker.CalendarForeColor = System.Drawing.Color.Black;
            this.dtContaDateTimePicker.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtContaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbPagarBindingSource, "dtConta", true));
            this.dtContaDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtContaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtContaDateTimePicker.Location = new System.Drawing.Point(272, 63);
            this.dtContaDateTimePicker.Name = "dtContaDateTimePicker";
            this.dtContaDateTimePicker.Size = new System.Drawing.Size(124, 26);
            this.dtContaDateTimePicker.TabIndex = 4;
            // 
            // frmDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.ControlBox = false;
            this.Controls.Add(this.dtContaDateTimePicker);
            this.Controls.Add(this.panel1);
            this.Controls.Add(cdContaLabel);
            this.Controls.Add(this.cdContaTextBox);
            this.Controls.Add(dtContaLabel);
            this.Controls.Add(nrContaLabel);
            this.Controls.Add(this.nrContaTextBox);
            this.Controls.Add(vlContaLabel);
            this.Controls.Add(this.vlContaTextBox);
            this.Controls.Add(dtVencimentoLabel);
            this.Controls.Add(this.dtVencimentoDateTimePicker);
            this.Controls.Add(dtPagamentoLabel);
            this.Controls.Add(this.dtPagamentoDateTimePicker);
            this.Controls.Add(vlPagoLabel);
            this.Controls.Add(this.vlPagoTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "frmDespesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Despesas";
            this.Load += new System.EventHandler(this.frmDespesa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDSucataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPagarBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDSucataDataSet bDSucataDataSet;
        private System.Windows.Forms.BindingSource tbPagarBindingSource;
        private BDSucataDataSetTableAdapters.tbPagarTableAdapter tbPagarTableAdapter;
        private System.Windows.Forms.TextBox cdContaTextBox;
        private System.Windows.Forms.TextBox nrContaTextBox;
        private System.Windows.Forms.TextBox vlContaTextBox;
        private System.Windows.Forms.DateTimePicker dtVencimentoDateTimePicker;
        private System.Windows.Forms.DateTimePicker dtPagamentoDateTimePicker;
        private System.Windows.Forms.TextBox vlPagoTextBox;
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
        private BDSucataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker dtContaDateTimePicker;
    }
}