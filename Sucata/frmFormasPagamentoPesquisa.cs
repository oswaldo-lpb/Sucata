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
    public partial class frmFormasPagamentoPesquisa : Form
    {
        private int codigo;

        public frmFormasPagamentoPesquisa()
        {
            InitializeComponent();
        }

        public int getCodigo()
        {
            return codigo;
        }

        private void frmFormasPagamentoPesquisa_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDSucataDataSet.tbFormaPag'. Você pode movê-la ou removê-la conforme necessário.
            this.tbFormaPagTableAdapter.Fill(this.bDSucataDataSet.tbFormaPag);
            codigo = 0;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            codigo = int.Parse(tbFormaPagDataGridView.CurrentRow.Cells[0].Value.ToString());
            this.Close();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                this.tbFormaPagTableAdapter.Fill(this.bDSucataDataSet.tbFormaPag);
            }
            else
            {
                this.tbFormaPagTableAdapter.FillNome(this.bDSucataDataSet.tbFormaPag, "%" + txtNome.Text + "%");
            }
        }

        private void tbFormaPagDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigo = int.Parse(tbFormaPagDataGridView.CurrentRow.Cells[0].Value.ToString());
            this.Close();
        }
    }
}
