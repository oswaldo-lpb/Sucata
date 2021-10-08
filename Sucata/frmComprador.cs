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
    public partial class frmComprador : Form
    {
        public frmComprador()
        {
            InitializeComponent();
        }

        private void tbCompradorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbCompradorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDSucataDataSet);

        }

        private void frmComprador_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDSucataDataSet.tbComprador'. Você pode movê-la ou removê-la conforme necessário.
            this.tbCompradorTableAdapter.Fill(this.bDSucataDataSet.tbComprador);

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
