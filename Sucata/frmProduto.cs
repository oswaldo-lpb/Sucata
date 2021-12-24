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
    public partial class frmProduto : Form
    {
        private void HabilitaEdicao()
        {
            nmProdutoTextBox.Enabled = true;
            vlCompraTextBox.Enabled = true;
            vlVendaTextBox.Enabled = true;
            qtProdutoTextBox.Enabled = true;
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
            nmProdutoTextBox.Enabled = false;
            vlCompraTextBox.Enabled = false;
            vlVendaTextBox.Enabled = false;
            qtProdutoTextBox.Enabled = false;
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

        public frmProduto()
        {
            InitializeComponent();
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDSucataDataSet.tbProduto'. Você pode movê-la ou removê-la conforme necessário.
            this.tbProdutoTableAdapter.Fill(this.bDSucataDataSet.tbProduto);
            DesabilitaEdicao();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tbProdutoBindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tbProdutoBindingSource.MoveNext();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tbProdutoBindingSource.AddNew();
            vlCompraTextBox.Text = string.Format("{0:N2}", 0);
            vlVendaTextBox.Text = string.Format("{0:N2}", 0);
            qtProdutoTextBox.Text = string.Format("{0:N3}", 0);
            HabilitaEdicao();
            nmProdutoTextBox.Focus();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (tbProdutoBindingSource.Count > 0)
            {
                HabilitaEdicao();
                nmProdutoTextBox.Focus();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tbProdutoBindingSource.Count > 0)
            {
                if (MessageBox.Show("Confirma exclusão?", "Excluir Comprador", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    tbProdutoBindingSource.RemoveCurrent();
                    Validate();
                    tbProdutoTableAdapter.Update(bDSucataDataSet.tbProduto);
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Validate();
            tbProdutoBindingSource.EndEdit();
            tbProdutoTableAdapter.Update(bDSucataDataSet.tbProduto);
            DesabilitaEdicao();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tbProdutoBindingSource.CancelEdit();
            DesabilitaEdicao();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int cod = 0, reg;
            frmProdutoPesquisa fpp = new frmProdutoPesquisa();
            fpp.ShowDialog();
            cod = fpp.getCodigo();
            if (cod > 0)
            {
                reg = tbProdutoBindingSource.Find("cdProduto", cod);
                tbProdutoBindingSource.Position = reg;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.SetBounds(0, 0, Screen.GetBounds(this).Width, Screen.GetBounds(this).Height);
            printPreviewDialog1.ShowDialog();
        }

        private void vlCompraTextBox_TextChanged(object sender, EventArgs e)
        {
            //Verifica se decimais é diferente de 2 e passa para 2 decimais
            if (vlCompraTextBox.Text.Length - 5 == vlCompraTextBox.Text.IndexOf(','))
            {
                vlCompraTextBox.Text = string.Format("{0:N2}", Convert.ToDouble(vlCompraTextBox.Text));
            }
            //Remova a formatação anterior ou a verificação decimal falhará incluindo zeros à esquerda
            string value = vlCompraTextBox.Text.Replace(",", "")
                .Replace("R$", "").Replace(".", "").TrimStart('0');
            decimal ul;
            //Verifique se estamos realmente lidando com um número
            if (decimal.TryParse(value, out ul))
            {
                ul /= 100;
                //Remova o evento para não entrar em um loop
                vlCompraTextBox.TextChanged -= vlCompraTextBox_TextChanged;
                //Formate o texto como valor
                vlCompraTextBox.Text = string.Format("{0:N2}", ul);
                //Insere o evento novamente
                vlCompraTextBox.TextChanged += vlCompraTextBox_TextChanged;
                vlCompraTextBox.Select(vlCompraTextBox.Text.Length, 0);
            }
        }

        private void vlVendaTextBox_TextChanged(object sender, EventArgs e)
        {
            //Verifica se decimais é diferente de 2 e passa para 2 decimais
            if (vlVendaTextBox.Text.Length - 5 == vlVendaTextBox.Text.IndexOf(','))
            {
                vlVendaTextBox.Text = string.Format("{0:N2}", Convert.ToDouble(vlVendaTextBox.Text));
            }
            //Remova a formatação anterior ou a verificação decimal falhará incluindo zeros à esquerda
            string value = vlVendaTextBox.Text.Replace(",", "")
                .Replace("R$", "").Replace(".", "").TrimStart('0');
            decimal ul;
            //Verifique se estamos realmente lidando com um número
            if (decimal.TryParse(value, out ul))
            {
                ul /= 100;
                //Remova o evento para não entrar em um loop
                vlVendaTextBox.TextChanged -= vlVendaTextBox_TextChanged;
                //Formate o texto como valor
                vlVendaTextBox.Text = string.Format("{0:N2}", ul);
                //Insere o evento novamente
                vlVendaTextBox.TextChanged += vlVendaTextBox_TextChanged;
                vlVendaTextBox.Select(vlVendaTextBox.Text.Length, 0);
            }
        }

        private void qtProdutoTextBox_TextChanged(object sender, EventArgs e)
        {
            //Verifica se decimais é diferente de 3 e passa para 3 decimais
            if (qtProdutoTextBox.Text.Length - 6 == qtProdutoTextBox.Text.IndexOf(','))
            {
                qtProdutoTextBox.Text = string.Format("{0:N3}", Convert.ToDecimal(qtProdutoTextBox.Text));
            }
            //Remova a formatação anterior ou a verificação decimal falhará incluindo zeros à esquerda
            string value = qtProdutoTextBox.Text.Replace(",", "")
                .Replace("R$", "").Replace(".", "").TrimStart('0');
            decimal ul;
            //Verifique se estamos realmente lidando com um número
            if (decimal.TryParse(value, out ul))
            {
                ul /= 1000;
                //Remova o evento para não entrar em um loop
                qtProdutoTextBox.TextChanged -= qtProdutoTextBox_TextChanged;
                //Formate o texto como valor
                qtProdutoTextBox.Text = string.Format("{0:N3}", ul);
                //Insere o evento novamente
                qtProdutoTextBox.TextChanged += qtProdutoTextBox_TextChanged;
                qtProdutoTextBox.Select(qtProdutoTextBox.Text.Length, 0);
            }

        }

        private void nmProdutoTextBox_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).ForeColor = Color.White;
            ((TextBox)sender).BackColor = Color.Blue;
        }

        private void nmProdutoTextBox_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).ForeColor = Color.Black;
            ((TextBox)sender).BackColor = Color.White;
        }

        private void frmProduto_KeyDown(object sender, KeyEventArgs e)
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

            strDados = "Ficha de Produto" + (char)10 + (char)10;
            strDados = strDados + "Código: " + cdProdutoTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "Nome: " + nmProdutoTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "Valor de compra: " + vlCompraTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "Valor de venda: " + vlVendaTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "Quantidade: " + qtProdutoTextBox.Text;

            objImpressao.DrawString(strDados, new System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, 50, 50);

            objImpressao.DrawLine(new System.Drawing.Pen(Brushes.Black, 1), 50, 80, 780, 80);
            //objImpressao.DrawImage(Image.FromFile(@"C:\Users\Public\Pictures\Sample Pictures\desert.jpg"), 50, 200, 730, 400);
        }
    }
}
