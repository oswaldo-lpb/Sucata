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
    public partial class frmDespesa : Form
    {
        public frmDespesa()
        {
            InitializeComponent();
        }

        private void frmDespesa_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDSucataDataSet.tbPagar'. Você pode movê-la ou removê-la conforme necessário.
            this.tbPagarTableAdapter.Fill(this.bDSucataDataSet.tbPagar);

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
