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
    public partial class frmVenda : Form
    {
        public frmVenda()
        {
            InitializeComponent();
        }

        private void frmVenda_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDSucataDataSet.tbVenda'. Você pode movê-la ou removê-la conforme necessário.
            this.tbVendaTableAdapter.Fill(this.bDSucataDataSet.tbVenda);
            // TODO: esta linha de código carrega dados na tabela 'bDSucataDataSet.tbVendaPag'. Você pode movê-la ou removê-la conforme necessário.
            this.tbVendaPagTableAdapter.Fill(this.bDSucataDataSet.tbVendaPag);
            // TODO: esta linha de código carrega dados na tabela 'bDSucataDataSet.tbVendaItem'. Você pode movê-la ou removê-la conforme necessário.
            this.tbVendaItemTableAdapter.Fill(this.bDSucataDataSet.tbVendaItem);

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
