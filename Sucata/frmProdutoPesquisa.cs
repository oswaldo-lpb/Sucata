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
    public partial class frmProdutoPesquisa : Form
    {
        private int codigo;

        public frmProdutoPesquisa()
        {
            InitializeComponent();
        }

        public int getCodigo()
        {
            return codigo;
        }

        private void frmProdutoPesquisa_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDSucataDataSet.tbProduto'. Você pode movê-la ou removê-la conforme necessário.
            this.tbProdutoTableAdapter.Fill(this.bDSucataDataSet.tbProduto);
            codigo = 0;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            codigo = int.Parse(tbProdutoDataGridView.CurrentRow.Cells[0].Value.ToString());
            this.Close();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                this.tbProdutoTableAdapter.Fill(this.bDSucataDataSet.tbProduto);
            }
            else
            {
                this.tbProdutoTableAdapter.FillNome(this.bDSucataDataSet.tbProduto, "%" + txtNome.Text + "%");
            }
        }

        private void tbProdutoDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigo = int.Parse(tbProdutoDataGridView.CurrentRow.Cells[0].Value.ToString());
            this.Close();
        }
    }
}
