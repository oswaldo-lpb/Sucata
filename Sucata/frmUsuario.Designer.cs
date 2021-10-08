namespace Sucata
{
    partial class frmUsuario
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
            System.Windows.Forms.Label cdUsuarioLabel;
            System.Windows.Forms.Label nmUsuarioLabel;
            System.Windows.Forms.Label cdNivelLabel;
            System.Windows.Forms.Label nmLoginLabel;
            System.Windows.Forms.Label cdSenhaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            this.bDSucataDataSet = new Sucata.BDSucataDataSet();
            this.tbUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbUsuarioTableAdapter = new Sucata.BDSucataDataSetTableAdapters.tbUsuarioTableAdapter();
            this.nmUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.nmLoginTextBox = new System.Windows.Forms.TextBox();
            this.cdSenhaTextBox = new System.Windows.Forms.TextBox();
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
            this.cdUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            cdUsuarioLabel = new System.Windows.Forms.Label();
            nmUsuarioLabel = new System.Windows.Forms.Label();
            cdNivelLabel = new System.Windows.Forms.Label();
            nmLoginLabel = new System.Windows.Forms.Label();
            cdSenhaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDSucataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cdUsuarioLabel
            // 
            cdUsuarioLabel.AutoSize = true;
            cdUsuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cdUsuarioLabel.Location = new System.Drawing.Point(116, 45);
            cdUsuarioLabel.Name = "cdUsuarioLabel";
            cdUsuarioLabel.Size = new System.Drawing.Size(59, 20);
            cdUsuarioLabel.TabIndex = 1;
            cdUsuarioLabel.Text = "Código";
            // 
            // nmUsuarioLabel
            // 
            nmUsuarioLabel.AutoSize = true;
            nmUsuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nmUsuarioLabel.Location = new System.Drawing.Point(116, 108);
            nmUsuarioLabel.Name = "nmUsuarioLabel";
            nmUsuarioLabel.Size = new System.Drawing.Size(51, 20);
            nmUsuarioLabel.TabIndex = 3;
            nmUsuarioLabel.Text = "Nome";
            // 
            // cdNivelLabel
            // 
            cdNivelLabel.AutoSize = true;
            cdNivelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cdNivelLabel.Location = new System.Drawing.Point(116, 114);
            cdNivelLabel.Name = "cdNivelLabel";
            cdNivelLabel.Size = new System.Drawing.Size(0, 20);
            cdNivelLabel.TabIndex = 5;
            // 
            // nmLoginLabel
            // 
            nmLoginLabel.AutoSize = true;
            nmLoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nmLoginLabel.Location = new System.Drawing.Point(116, 171);
            nmLoginLabel.Name = "nmLoginLabel";
            nmLoginLabel.Size = new System.Drawing.Size(48, 20);
            nmLoginLabel.TabIndex = 7;
            nmLoginLabel.Text = "Login";
            // 
            // cdSenhaLabel
            // 
            cdSenhaLabel.AutoSize = true;
            cdSenhaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cdSenhaLabel.Location = new System.Drawing.Point(116, 234);
            cdSenhaLabel.Name = "cdSenhaLabel";
            cdSenhaLabel.Size = new System.Drawing.Size(56, 20);
            cdSenhaLabel.TabIndex = 9;
            cdSenhaLabel.Text = "Senha";
            // 
            // bDSucataDataSet
            // 
            this.bDSucataDataSet.DataSetName = "BDSucataDataSet";
            this.bDSucataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbUsuarioBindingSource
            // 
            this.tbUsuarioBindingSource.DataMember = "tbUsuario";
            this.tbUsuarioBindingSource.DataSource = this.bDSucataDataSet;
            // 
            // tbUsuarioTableAdapter
            // 
            this.tbUsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // nmUsuarioTextBox
            // 
            this.nmUsuarioTextBox.BackColor = System.Drawing.Color.White;
            this.nmUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "nmUsuario", true));
            this.nmUsuarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmUsuarioTextBox.ForeColor = System.Drawing.Color.Black;
            this.nmUsuarioTextBox.Location = new System.Drawing.Point(182, 105);
            this.nmUsuarioTextBox.MaxLength = 50;
            this.nmUsuarioTextBox.Name = "nmUsuarioTextBox";
            this.nmUsuarioTextBox.Size = new System.Drawing.Size(517, 26);
            this.nmUsuarioTextBox.TabIndex = 4;
            this.nmUsuarioTextBox.Enter += new System.EventHandler(this.nmUsuarioTextBox_Enter);
            this.nmUsuarioTextBox.Leave += new System.EventHandler(this.nmUsuarioTextBox_Leave);
            // 
            // nmLoginTextBox
            // 
            this.nmLoginTextBox.BackColor = System.Drawing.Color.White;
            this.nmLoginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "nmLogin", true));
            this.nmLoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmLoginTextBox.ForeColor = System.Drawing.Color.Black;
            this.nmLoginTextBox.Location = new System.Drawing.Point(182, 168);
            this.nmLoginTextBox.MaxLength = 15;
            this.nmLoginTextBox.Name = "nmLoginTextBox";
            this.nmLoginTextBox.Size = new System.Drawing.Size(140, 26);
            this.nmLoginTextBox.TabIndex = 8;
            this.nmLoginTextBox.Enter += new System.EventHandler(this.nmUsuarioTextBox_Enter);
            this.nmLoginTextBox.Leave += new System.EventHandler(this.nmUsuarioTextBox_Leave);
            // 
            // cdSenhaTextBox
            // 
            this.cdSenhaTextBox.BackColor = System.Drawing.Color.White;
            this.cdSenhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "cdSenha", true));
            this.cdSenhaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdSenhaTextBox.ForeColor = System.Drawing.Color.Black;
            this.cdSenhaTextBox.Location = new System.Drawing.Point(182, 231);
            this.cdSenhaTextBox.MaxLength = 15;
            this.cdSenhaTextBox.Name = "cdSenhaTextBox";
            this.cdSenhaTextBox.Size = new System.Drawing.Size(140, 26);
            this.cdSenhaTextBox.TabIndex = 10;
            this.cdSenhaTextBox.UseSystemPasswordChar = true;
            this.cdSenhaTextBox.Enter += new System.EventHandler(this.nmUsuarioTextBox_Enter);
            this.cdSenhaTextBox.Leave += new System.EventHandler(this.nmUsuarioTextBox_Leave);
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
            this.panel1.TabIndex = 12;
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
            // cdUsuarioTextBox
            // 
            this.cdUsuarioTextBox.BackColor = System.Drawing.Color.White;
            this.cdUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "cdUsuario", true));
            this.cdUsuarioTextBox.Enabled = false;
            this.cdUsuarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdUsuarioTextBox.ForeColor = System.Drawing.Color.Black;
            this.cdUsuarioTextBox.Location = new System.Drawing.Point(182, 42);
            this.cdUsuarioTextBox.Name = "cdUsuarioTextBox";
            this.cdUsuarioTextBox.Size = new System.Drawing.Size(58, 26);
            this.cdUsuarioTextBox.TabIndex = 2;
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
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.ControlBox = false;
            this.Controls.Add(this.cdUsuarioTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(cdUsuarioLabel);
            this.Controls.Add(nmUsuarioLabel);
            this.Controls.Add(this.nmUsuarioTextBox);
            this.Controls.Add(cdNivelLabel);
            this.Controls.Add(nmLoginLabel);
            this.Controls.Add(this.nmLoginTextBox);
            this.Controls.Add(cdSenhaLabel);
            this.Controls.Add(this.cdSenhaTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "frmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuários";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmUsuario_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.bDSucataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDSucataDataSet bDSucataDataSet;
        private System.Windows.Forms.BindingSource tbUsuarioBindingSource;
        private BDSucataDataSetTableAdapters.tbUsuarioTableAdapter tbUsuarioTableAdapter;
        private System.Windows.Forms.TextBox nmUsuarioTextBox;
        private System.Windows.Forms.TextBox nmLoginTextBox;
        private System.Windows.Forms.TextBox cdSenhaTextBox;
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
        private System.Windows.Forms.TextBox cdUsuarioTextBox;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}