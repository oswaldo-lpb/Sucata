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
    public partial class frmDespesaPesquisa : Form
    {
        private int codigo;

        public frmDespesaPesquisa()
        {
            InitializeComponent();
        }

        public int getCodigo()
        {
            return codigo;
        }

        private void frmDespesaPesquisa_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDSucataDataSet.tbPagar'. Você pode movê-la ou removê-la conforme necessário.
            this.tbPagarTableAdapter.Fill(this.bDSucataDataSet.tbPagar);
            codigo = 0;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            codigo = int.Parse(tbPagarDataGridView.CurrentRow.Cells[0].Value.ToString());
            this.Close();
        }

        private void tbPagarDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigo = int.Parse(tbPagarDataGridView.CurrentRow.Cells[0].Value.ToString());
            this.Close();
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            if (txtNumero.Text == "")
            {
                this.tbPagarTableAdapter.Fill(this.bDSucataDataSet.tbPagar);
            }
            else
            {
                this.tbPagarTableAdapter.FillNumero(this.bDSucataDataSet.tbPagar, txtNumero.Text);
            }
        }

        private void txtEmissao_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtVencimento_TextChanged(object sender, EventArgs e)
        {
        }

        private void dtpEmissao_ValueChanged(object sender, EventArgs e)
        {
//            if (dtpEmissao.Text == "")
//            {
//                this.tbPagarTableAdapter.Fill(this.bDSucataDataSet.tbPagar);
//            }
//            else
//            {
                this.tbPagarTableAdapter.FillEmissao(this.bDSucataDataSet.tbPagar, dtpEmissao.Value);
//            }
        }

        private void dtpVencimento_ValueChanged(object sender, EventArgs e)
        {
//            if (dtpVencimento.Text == "")
//            {
//                this.tbPagarTableAdapter.Fill(this.bDSucataDataSet.tbPagar);
//            }
//            else
//            {
                this.tbPagarTableAdapter.FillVencimento(this.bDSucataDataSet.tbPagar, dtpVencimento.Value);
//            }
        }
    }
}
