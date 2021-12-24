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
    public partial class frmCompradorPesquisa : Form
    {
        private int codigo;

        public frmCompradorPesquisa()
        {
            InitializeComponent();
        }

        public int getCodigo()
        {
            return codigo;
        }

        private void frmCompradorPesquisa_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDSucataDataSet.tbComprador'. Você pode movê-la ou removê-la conforme necessário.
            this.tbCompradorTableAdapter.Fill(this.bDSucataDataSet.tbComprador);
            codigo = 0;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            codigo = int.Parse(tbCompradorDataGridView.CurrentRow.Cells[0].Value.ToString());
            this.Close();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                this.tbCompradorTableAdapter.Fill(this.bDSucataDataSet.tbComprador);
            }
            else
            {
                this.tbCompradorTableAdapter.FillNome(this.bDSucataDataSet.tbComprador, "%" + txtNome.Text + "%");
            }
        }

        private void tbCompradorDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigo = int.Parse(tbCompradorDataGridView.CurrentRow.Cells[0].Value.ToString());
            this.Close();
        }
    }
}
