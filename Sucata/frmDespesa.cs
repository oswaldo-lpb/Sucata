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
        private void HabilitaEdicao()
        {
            dtContaMaskedTextBox.Enabled = true;
            dtContaDateTimePicker.Enabled = true;
            nrContaTextBox.Enabled = true;
            dsContaTextBox.Enabled = true;
            dtVencimentoMaskedTextBox.Enabled = true;
            dtVencimentoDateTimePicker.Enabled = true;
            vlContaTextBox.Enabled = true;
            dtPagamentoMaskedTextBox.Enabled = true;
            dtPagamentoDateTimePicker.Enabled = true;
            vlPagoTextBox.Enabled = true;
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
            btnPgto.Enabled = false;
        }

        private void DesabilitaEdicao()
        {
            dtContaMaskedTextBox.Enabled = false;
            dtContaDateTimePicker.Enabled = false;
            nrContaTextBox.Enabled = false;
            dsContaTextBox.Enabled = false;
            dtVencimentoMaskedTextBox.Enabled = false;
            dtVencimentoDateTimePicker.Enabled = false;
            vlContaTextBox.Enabled = false;
            dtPagamentoMaskedTextBox.Enabled = false;
            dtPagamentoDateTimePicker.Enabled = false;
            vlPagoTextBox.Enabled = false;
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
            btnPgto.Enabled = true;
        }

        public frmDespesa()
        {
            InitializeComponent();
        }

        private void frmDespesa_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDSucataDataSet.tbPagar'. Você pode movê-la ou removê-la conforme necessário.
            this.tbPagarTableAdapter.Fill(this.bDSucataDataSet.tbPagar);
            DesabilitaEdicao();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tbPagarBindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tbPagarBindingSource.MoveNext();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tbPagarBindingSource.AddNew();
            vlContaTextBox.Text = string.Format("{0:N2}", 0);
            vlPagoTextBox.Text = string.Format("{0:N2}", 0);
            HabilitaEdicao();
            dtContaDateTimePicker.Value = DateTime.Now;
            dtContaMaskedTextBox.Focus();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (tbPagarBindingSource.Count > 0 && dtPagamentoMaskedTextBox.Text=="  ")
            {
                HabilitaEdicao();
                dtContaMaskedTextBox.Focus();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tbPagarBindingSource.Count > 0 && dtPagamentoMaskedTextBox.Text == "  ")
            {
                if (MessageBox.Show("Confirma exclusão?", "Excluir Comprador", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    tbPagarBindingSource.RemoveCurrent();
                    Validate();
                    tbPagarTableAdapter.Update(bDSucataDataSet.tbPagar);
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Validate();
            tbPagarBindingSource.EndEdit();
            tbPagarTableAdapter.Update(bDSucataDataSet.tbPagar);
            DesabilitaEdicao();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tbPagarBindingSource.CancelEdit();
            DesabilitaEdicao();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int cod = 0, reg;
            frmDespesaPesquisa fdp = new frmDespesaPesquisa();
            fdp.ShowDialog();
            cod = fdp.getCodigo();
            if (cod > 0)
            {
                reg = tbPagarBindingSource.Find("cdConta", cod);
                tbPagarBindingSource.Position = reg;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.SetBounds(0, 0, Screen.GetBounds(this).Width, Screen.GetBounds(this).Height);
            printPreviewDialog1.ShowDialog();
        }

        private void btnPgto_Click(object sender, EventArgs e)
        {
            if (tbPagarBindingSource.Count > 0 && dtPagamentoMaskedTextBox.Text == "  ")
            {
                HabilitaEdicao();
                dtContaMaskedTextBox.Enabled = false;
                dtContaDateTimePicker.Enabled = false;
                nrContaTextBox.Enabled = false;
                dsContaTextBox.Enabled = false;
                dtVencimentoMaskedTextBox.Enabled = false;
                dtVencimentoDateTimePicker.Enabled = false;
                vlContaTextBox.Enabled = false;
                dtPagamentoDateTimePicker.Value = DateTime.Now;
                vlPagoTextBox.Text = vlContaTextBox.Text;
                dtPagamentoMaskedTextBox.Focus();
            }
        }

        private void dtContaDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dtContaMaskedTextBox.Text = dtContaDateTimePicker.Text;
        }

        private void dtVencimentoDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dtVencimentoMaskedTextBox.Text = dtVencimentoDateTimePicker.Text;
        }

        private void dtPagamentoDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dtPagamentoMaskedTextBox.Text = dtPagamentoDateTimePicker.Text;
        }

        private void vlContaTextBox_TextChanged(object sender, EventArgs e)
        {
            //Verifica se decimais é diferente de 2 e passa para 2 decimais
            if (vlContaTextBox.Text.Length - 5 == vlContaTextBox.Text.IndexOf(','))
            {
                vlContaTextBox.Text = string.Format("{0:N2}", Convert.ToDouble(vlContaTextBox.Text));
            }
            //Remova a formatação anterior ou a verificação decimal falhará incluindo zeros à esquerda
            string value = vlContaTextBox.Text.Replace(",", "")
                .Replace("R$", "").Replace(".", "").TrimStart('0');
            decimal ul;
            //Verifique se estamos realmente lidando com um número
            if (decimal.TryParse(value, out ul))
            {
                ul /= 100;
                //Remova o evento para não entrar em um loop
                vlContaTextBox.TextChanged -= vlContaTextBox_TextChanged;
                //Formate o texto como valor
                vlContaTextBox.Text = string.Format("{0:N2}", ul);
                //Insere o evento novamente
                vlContaTextBox.TextChanged += vlContaTextBox_TextChanged;
                vlContaTextBox.Select(vlContaTextBox.Text.Length, 0);
            }
        }

        private void vlPagoTextBox_TextChanged(object sender, EventArgs e)
        {
            //Verifica se decimais é diferente de 2 e passa para 2 decimais
            if (vlPagoTextBox.Text.Length - 5 == vlPagoTextBox.Text.IndexOf(','))
            {
                vlPagoTextBox.Text = string.Format("{0:N2}", Convert.ToDouble(vlPagoTextBox.Text));
            }
            //Remova a formatação anterior ou a verificação decimal falhará incluindo zeros à esquerda
            string value = vlPagoTextBox.Text.Replace(",", "")
                .Replace("R$", "").Replace(".", "").TrimStart('0');
            decimal ul;
            //Verifique se estamos realmente lidando com um número
            if (decimal.TryParse(value, out ul))
            {
                ul /= 100;
                //Remova o evento para não entrar em um loop
                vlPagoTextBox.TextChanged -= vlPagoTextBox_TextChanged;
                //Formate o texto como valor
                vlPagoTextBox.Text = string.Format("{0:N2}", ul);
                //Insere o evento novamente
                vlPagoTextBox.TextChanged += vlPagoTextBox_TextChanged;
                vlPagoTextBox.Select(vlPagoTextBox.Text.Length, 0);
            }
        }

        private void nrContaTextBox_Enter(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                ((TextBox)sender).ForeColor = Color.White;
                ((TextBox)sender).BackColor = Color.Blue;
            }
            else if (sender is MaskedTextBox)
            {
                ((MaskedTextBox)sender).ForeColor = Color.White;
                ((MaskedTextBox)sender).BackColor = Color.Blue;
            }
        }

        private void nrContaTextBox_Leave(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                ((TextBox)sender).ForeColor = Color.Black;
                ((TextBox)sender).BackColor = Color.White;
            }
            else if (sender is MaskedTextBox)
            {
                ((MaskedTextBox)sender).ForeColor = Color.Black;
                ((MaskedTextBox)sender).BackColor = Color.White;
            }
        }

        private void frmDespesa_KeyDown(object sender, KeyEventArgs e)
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
            else if (e.KeyCode == Keys.F11 && !btnPgto.Enabled) btnPgto_Click(sender, e);
            else if (e.KeyCode == Keys.Escape && !btnSalvar.Enabled) btnSair_Click(sender, e);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics objImpressao = e.Graphics;
            string strDados;

            strDados = "Ficha de Despesa" + (char)10 + (char)10;
            strDados = strDados + "Código: " + cdContaTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "Emissão: " + dtContaMaskedTextBox.Text;
            strDados = strDados + "                    Número: " + nrContaTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "Descrição: " + dsContaTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "Vencimento: " + dtVencimentoMaskedTextBox.Text;
            strDados = strDados + "                    Valor: " + vlContaTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "Pagamento: " + dtPagamentoMaskedTextBox.Text;
            strDados = strDados + "                    Valor pago: " + vlPagoTextBox.Text;

            objImpressao.DrawString(strDados, new System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, 50, 50);

            objImpressao.DrawLine(new System.Drawing.Pen(Brushes.Black, 1), 50, 80, 780, 80);
            //objImpressao.DrawImage(Image.FromFile(@"C:\Users\Public\Pictures\Sample Pictures\desert.jpg"), 50, 200, 730, 400);
        }
    }
}
