using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sucata
{
    public partial class frmCompra : Form
    {
        BindingSource bs;
        public frmCompra()
        {
            InitializeComponent();
        }

        private void frmCompra_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDSucataDataSet.tbCliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tbClienteTableAdapter.Fill(this.bDSucataDataSet.tbCliente);
            // TODO: esta linha de código carrega dados na tabela 'bDSucataDataSet.tbCompra'. Você pode movê-la ou removê-la conforme necessário.
            this.tbCompraTableAdapter.Fill(this.bDSucataDataSet.tbCompra);
            // TODO: esta linha de código carrega dados na tabela 'bDSucataDataSet.tbCompraPag'. Você pode movê-la ou removê-la conforme necessário.
            this.tbCompraPagTableAdapter.Fill(this.bDSucataDataSet.tbCompraPag);
            // TODO: esta linha de código carrega dados na tabela 'bDSucataDataSet.tbCompraItem'. Você pode movê-la ou removê-la conforme necessário.
            this.tbCompraItemTableAdapter.Fill(this.bDSucataDataSet.tbCompraItem);
            bs = tbCompraPagBindingSource;
            tbCompraPagDataGridView.Columns[0].
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {

        }

        private void btnProximo_Click(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tbCompraBindingSource.AddNew();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnPgto_Click(object sender, EventArgs e)
        {

        }

        private void nmClienteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nmClienteComboBox.Text != "")
                cdClienteTextBox.Text = nmClienteComboBox.SelectedValue.ToString();
        }

        private void cdClienteTextBox_TextChanged(object sender, EventArgs e)
        {
            if (cdClienteTextBox.Text != "")
                nmClienteComboBox.SelectedValue = cdClienteTextBox.Text;
        }
    }
}
