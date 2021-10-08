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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario fu = new frmUsuario();
            fu.ShowDialog();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFuncionario ff = new frmFuncionario();
            ff.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente fc = new frmCliente();
            fc.ShowDialog();
        }

        private void compradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmComprador fc = new frmComprador();
            fc.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduto fp = new frmProduto();
            fp.ShowDialog();
        }

        private void formasDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFormasPagamento ffp = new frmFormasPagamento();
            ffp.ShowDialog();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompra fc = new frmCompra();
            fc.ShowDialog();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVenda fv = new frmVenda();
            fv.ShowDialog();
        }

        private void despesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDespesa fd = new frmDespesa();
            fd.ShowDialog();
        }
    }
}
