namespace Sucata
{
    partial class frmFuncionarioPesquisa
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
            this.bDSucataDataSet = new Sucata.BDSucataDataSet();
            this.tbFuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbFuncionarioTableAdapter = new Sucata.BDSucataDataSetTableAdapters.tbFuncionarioTableAdapter();
            this.tbFuncionarioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDSucataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFuncionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFuncionarioDataGridView)).BeginInit();
            this.SuspendLayout();
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
            // tbFuncionarioDataGridView
            // 
            this.tbFuncionarioDataGridView.AllowUserToAddRows = false;
            this.tbFuncionarioDataGridView.AllowUserToDeleteRows = false;
            this.tbFuncionarioDataGridView.AutoGenerateColumns = false;
            this.tbFuncionarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbFuncionarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tbFuncionarioDataGridView.DataSource = this.tbFuncionarioBindingSource;
            this.tbFuncionarioDataGridView.Location = new System.Drawing.Point(168, 137);
            this.tbFuncionarioDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbFuncionarioDataGridView.Name = "tbFuncionarioDataGridView";
            this.tbFuncionarioDataGridView.ReadOnly = true;
            this.tbFuncionarioDataGridView.Size = new System.Drawing.Size(869, 379);
            this.tbFuncionarioDataGridView.TabIndex = 1;
            this.tbFuncionarioDataGridView.DoubleClick += new System.EventHandler(this.tbFuncionarioDataGridView_DoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cdFuncionario";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nmFuncionario";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 700;
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = true;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(672, 582);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(112, 46);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnOk
            // 
            this.btnOk.AutoSize = true;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(456, 582);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(112, 46);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.White;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.Black;
            this.txtNome.Location = new System.Drawing.Point(250, 64);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(787, 26);
            this.txtNome.TabIndex = 7;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome";
            // 
            // frmFuncionarioPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.ControlBox = false;
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFuncionarioDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmFuncionarioPesquisa";
            this.Text = "Pesquisar Funcionário";
            this.Load += new System.EventHandler(this.frmFuncionarioPesquisa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDSucataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFuncionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFuncionarioDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDSucataDataSet bDSucataDataSet;
        private System.Windows.Forms.BindingSource tbFuncionarioBindingSource;
        private BDSucataDataSetTableAdapters.tbFuncionarioTableAdapter tbFuncionarioTableAdapter;
        private System.Windows.Forms.DataGridView tbFuncionarioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
    }
}