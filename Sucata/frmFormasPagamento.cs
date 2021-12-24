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
        private void HabilitaEdicao()
        {
            nmFormaPagTextBox.Enabled = true;
            //sgContaTextBox.Enabled = true;
            btnAnterior.Enabled = false;
            btnProximo.Enabled = false;
            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnPesquisar.Enabled = false;
            btnImprimir.Enabled = false;
            btnSair.Enabled = false;
        }

        private void DesabilitaEdicao()
        {
            nmFormaPagTextBox.Enabled = false;
            //sgContaTextBox.Enabled = false;
            btnAnterior.Enabled = true;
            btnProximo.Enabled = true;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnPesquisar.Enabled = true;
            btnImprimir.Enabled = true;
            btnSair.Enabled = true;
        }

        public frmFormasPagamento()
        {
            InitializeComponent();
        }

        private void frmFormasPagamento_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDSucataDataSet.tbFormaPag'. Você pode movê-la ou removê-la conforme necessário.
            this.tbFormaPagTableAdapter.Fill(this.bDSucataDataSet.tbFormaPag);
            DesabilitaEdicao();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tbFormaPagBindingSource.Count > 0)
            {
                if (MessageBox.Show("Confirma exclusão?", "Excluir Comprador", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    tbFormaPagBindingSource.RemoveCurrent();
                    Validate();
                    tbFormaPagTableAdapter.Update(bDSucataDataSet.tbFormaPag);
                }
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tbFormaPagBindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tbFormaPagBindingSource.MovePrevious();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tbFormaPagBindingSource.AddNew();
            HabilitaEdicao();
            nmFormaPagTextBox.Focus();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (tbFormaPagBindingSource.Count > 0)
            {
                HabilitaEdicao();
                nmFormaPagTextBox.Focus();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Validate();
            tbFormaPagBindingSource.EndEdit();
            tbFormaPagTableAdapter.Update(bDSucataDataSet.tbFormaPag);
            DesabilitaEdicao();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tbFormaPagBindingSource.CancelEdit();
            DesabilitaEdicao();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int cod = 0, reg;
            frmFormasPagamentoPesquisa ffpp = new frmFormasPagamentoPesquisa();
            ffpp.ShowDialog();
            cod = ffpp.getCodigo();
            if (cod > 0)
            {
                reg = tbFormaPagBindingSource.Find("cdFormaPag", cod);
                tbFormaPagBindingSource.Position = reg;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.SetBounds(0, 0, Screen.GetBounds(this).Width, Screen.GetBounds(this).Height);
            printPreviewDialog1.ShowDialog();
        }

        private void nmFormaPagTextBox_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).ForeColor = Color.White;
            ((TextBox)sender).BackColor = Color.Blue;
        }

        private void nmFormaPagTextBox_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).ForeColor = Color.Black;
            ((TextBox)sender).BackColor = Color.White;
        }

        private void frmFormasPagamento_KeyDown(object sender, KeyEventArgs e)
        {
            Control ctl = (Form)sender; //this.TextBox.Parent ou (Control)sender
            if ((e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down) && btnSalvar.Enabled)
            {
                // Ativa o próximo controle (segundo parâmetro indica se próximo "true" ou anterior "false")
                ctl.SelectNextControl(ActiveControl, true, true, true, true);
            }
            else if (e.KeyCode == Keys.Up && btnSalvar.Enabled)
            {
                // Ativa o controle anterior (segundo parâmetro indica se próximo "true" ou anterior "false")
                ctl.SelectNextControl(ActiveControl, false, true, true, true);
            }
            else if (e.KeyCode == Keys.F2 && !btnSalvar.Enabled) btnAnterior_Click(sender, e);
            else if (e.KeyCode == Keys.F3 && !btnSalvar.Enabled) btnProximo_Click(sender, e);
            else if (e.KeyCode == Keys.F4 && !btnSalvar.Enabled) btnNovo_Click(sender, e);
            else if (e.KeyCode == Keys.F5 && !btnSalvar.Enabled) btnAlterar_Click(sender, e);
            else if (e.KeyCode == Keys.F6 && !btnSalvar.Enabled) btnExcluir_Click(sender, e);
            else if (e.KeyCode == Keys.F7 && btnSalvar.Enabled)
            {
                btnSalvar.Focus();
                btnSalvar_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F8 && btnCancelar.Enabled)
            {
                btnCancelar.Focus();
                btnCancelar_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F9 && !btnSalvar.Enabled) btnPesquisar_Click(sender, e);
            else if (e.KeyCode == Keys.F10 && !btnSalvar.Enabled) btnImprimir_Click(sender, e);
            else if (e.KeyCode == Keys.Escape && !btnSalvar.Enabled) btnSair_Click(sender, e);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics objImpressao = e.Graphics;
            string strDados;

            strDados = "Ficha Forma de Pagamento" + (char)10 + (char)10;
            strDados = strDados + "Código: " + cdFormaPagTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "Nome: " + nmFormaPagTextBox.Text;

            objImpressao.DrawString(strDados, new System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, 50, 50);

            objImpressao.DrawLine(new System.Drawing.Pen(Brushes.Black, 1), 50, 80, 780, 80);
            //objImpressao.DrawImage(Image.FromFile(@"C:\Users\Public\Pictures\Sample Pictures\desert.jpg"), 50, 200, 730, 400);

        }
    }
}
