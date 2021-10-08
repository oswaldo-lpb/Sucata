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
    public partial class frmFuncionarioPesquisa : Form
    {
        private int codigo;

        public frmFuncionarioPesquisa()
        {
            InitializeComponent();
        }

        public int getCodigo()
        {
            return codigo;
        }

        private void frmFuncionarioPesquisa_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDSucataDataSet.tbFuncionario'. Você pode movê-la ou removê-la conforme necessário.
            this.tbFuncionarioTableAdapter.Fill(this.bDSucataDataSet.tbFuncionario);
            codigo = 0;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            codigo = int.Parse(tbFuncionarioDataGridView.CurrentRow.Cells[0].Value.ToString());
            this.Close();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                this.tbFuncionarioTableAdapter.Fill(this.bDSucataDataSet.tbFuncionario);
            }
            else
            {
                this.tbFuncionarioTableAdapter.FillNome(this.bDSucataDataSet.tbFuncionario, "%" + txtNome.Text + "%");
            }
        }

        private void tbFuncionarioDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigo = int.Parse(tbFuncionarioDataGridView.CurrentRow.Cells[0].Value.ToString());
            this.Close();
        }
    }
}
