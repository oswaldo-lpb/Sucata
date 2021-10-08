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
    public partial class frmCompra : Form
    {
        public frmCompra()
        {
            InitializeComponent();
        }

        private void frmCompra_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDSucataDataSet.tbCompra'. Você pode movê-la ou removê-la conforme necessário.
            this.tbCompraTableAdapter.Fill(this.bDSucataDataSet.tbCompra);
            // TODO: esta linha de código carrega dados na tabela 'bDSucataDataSet.tbCompraPag'. Você pode movê-la ou removê-la conforme necessário.
            this.tbCompraPagTableAdapter.Fill(this.bDSucataDataSet.tbCompraPag);
            // TODO: esta linha de código carrega dados na tabela 'bDSucataDataSet.tbCompraItem'. Você pode movê-la ou removê-la conforme necessário.
            this.tbCompraItemTableAdapter.Fill(this.bDSucataDataSet.tbCompraItem);

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
