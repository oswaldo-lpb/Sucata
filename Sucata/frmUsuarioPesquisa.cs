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
    public partial class frmUsuarioPesquisa : Form
    {
        private int codigo;

        public frmUsuarioPesquisa()
        {
            InitializeComponent();
        }

        private void frmUsuarioPesquisa_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDSucataDataSet.tbUsuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tbUsuarioTableAdapter.Fill(this.bDSucataDataSet.tbUsuario);
            codigo = 0;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            codigo = int.Parse(tbUsuarioDataGridView.CurrentRow.Cells[0].Value.ToString());
            this.Close();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                this.tbUsuarioTableAdapter.Fill(this.bDSucataDataSet.tbUsuario);
            }
            else
            {
                this.tbUsuarioTableAdapter.FillNome(this.bDSucataDataSet.tbUsuario,"%"+txtNome.Text+"%");
            }
        }

        private void tbUsuarioDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigo = int.Parse(tbUsuarioDataGridView.CurrentRow.Cells[0].Value.ToString());
            this.Close();
        }

        public int getCodigo()
        {
            return codigo;
        }
    }
}
