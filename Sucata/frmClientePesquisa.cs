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
    public partial class frmClientePesquisa : Form
    {
        private int codigo;

        public frmClientePesquisa()
        {
            InitializeComponent();
        }

        public int getCodigo()
        {
            return codigo;
        }

        private void frmClientePesquisa_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDSucataDataSet.tbCliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tbClienteTableAdapter.Fill(this.bDSucataDataSet.tbCliente);
            codigo = 0;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            codigo = int.Parse(tbClienteDataGridView.CurrentRow.Cells[0].Value.ToString());
            this.Close();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                this.tbClienteTableAdapter.Fill(this.bDSucataDataSet.tbCliente);
            }
            else
            {
                this.tbClienteTableAdapter.FillNome(this.bDSucataDataSet.tbCliente, "%" + txtNome.Text + "%");
            }
        }

        private void tbClienteDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigo = int.Parse(tbClienteDataGridView.CurrentRow.Cells[0].Value.ToString());
            this.Close();
        }
    }
}
