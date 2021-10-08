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
    public partial class frmFormasPagamento : Form
    {
        public frmFormasPagamento()
        {
            InitializeComponent();
        }

        private void frmFormasPagamento_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDSucataDataSet.tbFormaPag'. Você pode movê-la ou removê-la conforme necessário.
            this.tbFormaPagTableAdapter.Fill(this.bDSucataDataSet.tbFormaPag);

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
