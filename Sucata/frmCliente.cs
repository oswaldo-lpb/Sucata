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
    public partial class frmCliente : Form
    {
        private void HabilitaEdicao()
        {
            nmClienteTextBox.Enabled = true;
            dsEnderecoTextBox.Enabled = true;
            nrNumeroTextBox.Enabled = true;
            nmBairroTextBox.Enabled = true;
            nmCidadeTextBox.Enabled = true;
            sgEstadoTextBox.Enabled = true;
            cdCEPMaskedTextBox.Enabled = true;
            sgFIJUTextBox.Enabled = true;
//            cdCPFMaskedTextBox.Enabled = true;
//            cdRGTextBox.Enabled = true;
//            cdCNPJMaskedTextBox.Enabled = true;
//            cdIEMaskedTextBox.Enabled = true;
            dsTelefoneTextBox.Enabled = true;
            vlSaldoTextBox.Enabled = true;
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
            nmClienteTextBox.Enabled = false;
            dsEnderecoTextBox.Enabled = false;
            nrNumeroTextBox.Enabled = false;
            nmBairroTextBox.Enabled = false;
            nmCidadeTextBox.Enabled = false;
            sgEstadoTextBox.Enabled = false;
            cdCEPMaskedTextBox.Enabled = false;
            sgFIJUTextBox.Enabled = false;
            cdCPFMaskedTextBox.Enabled = false;
            cdRGTextBox.Enabled = false;
            cdCNPJMaskedTextBox.Enabled = false;
            cdIEMaskedTextBox.Enabled = false;
            dsTelefoneTextBox.Enabled = false;
            vlSaldoTextBox.Enabled = false;
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

        private bool VerificaCPF(string cpf)
        {
            bool resp = false;

            return resp;
        }

        private bool VerificaCNPJ(string cnpj)
        {
            bool resp = false;

            return resp;
        }

        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDSucataDataSet.tbCliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tbClienteTableAdapter.Fill(this.bDSucataDataSet.tbCliente);
            DesabilitaEdicao();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tbClienteBindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tbClienteBindingSource.MoveNext();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tbClienteBindingSource.AddNew();
            vlSaldoTextBox.Text = string.Format("{0:N2}", 0);
            HabilitaEdicao();
            nmClienteTextBox.Focus();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (tbClienteBindingSource.Count > 0)
            {
                HabilitaEdicao();
                nmClienteTextBox.Focus();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tbClienteBindingSource.Count > 0)
            {
                if (MessageBox.Show("Confirma exclusão?", "Excluir Funcionário", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    tbClienteBindingSource.RemoveCurrent();
                    Validate();
                    tbClienteTableAdapter.Update(bDSucataDataSet.tbCliente);
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (cdCPFMaskedTextBox.Text.Substring(0,4)!="   ." && !VerificaCPF(cdCPFMaskedTextBox.Text))
            {
                MessageBox.Show("CPF inválido!!!");
                cdCPFMaskedTextBox.Focus();
            }
            else if (cdCNPJMaskedTextBox.Text.Substring(0, 3) != "  ." && !VerificaCNPJ(cdCNPJMaskedTextBox.Text))
            {
                MessageBox.Show("CNPJ inválido!!!");
                cdCNPJMaskedTextBox.Focus();
            }
            else {
                Validate();
                tbClienteBindingSource.EndEdit();
                tbClienteTableAdapter.Update(bDSucataDataSet.tbCliente);
                DesabilitaEdicao();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tbClienteBindingSource.CancelEdit();
            DesabilitaEdicao();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int cod = 0, reg;
            frmClientePesquisa fcp = new frmClientePesquisa();
            fcp.ShowDialog();
            cod = fcp.getCodigo();
            if (cod > 0)
            {
                reg = tbClienteBindingSource.Find("cdCliente", cod);
                tbClienteBindingSource.Position = reg;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.SetBounds(0, 0, Screen.GetBounds(this).Width, Screen.GetBounds(this).Height);
            printPreviewDialog1.ShowDialog();
        }

        private void vlSaldoTextBox_TextChanged(object sender, EventArgs e)
        {
            //Verifica se tem 4 decimais e passa para 2 decimais
            if (vlSaldoTextBox.Text.Length - 5 == vlSaldoTextBox.Text.IndexOf(','))
            {
                vlSaldoTextBox.Text = string.Format("{0:N2}", Convert.ToDouble(vlSaldoTextBox.Text));
            }
            //Remova a formatação anterior ou a verificação decimal falhará incluindo zeros à esquerda
            string value = vlSaldoTextBox.Text.Replace(",", "")
                .Replace("R$", "").Replace(".", "").TrimStart('0');
            decimal ul;
            //Verifique se estamos realmente lidando com um número
            if (decimal.TryParse(value, out ul))
            {
                ul /= 100;
                //Remova o evento para não entrar em um loop
                vlSaldoTextBox.TextChanged -= vlSaldoTextBox_TextChanged;
                //Formate o texto como valor
                vlSaldoTextBox.Text = string.Format("{0:N2}", ul);
                //Insere o evento novamente
                vlSaldoTextBox.TextChanged += vlSaldoTextBox_TextChanged;
                vlSaldoTextBox.Select(vlSaldoTextBox.Text.Length, 0);
            }
        }

        private void nmClienteTextBox_Enter(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                ((TextBox)sender).ForeColor = Color.White;
                ((TextBox)sender).BackColor = Color.Blue;
            }
            else
            {
                ((MaskedTextBox)sender).ForeColor = Color.White;
                ((MaskedTextBox)sender).BackColor = Color.Blue;
            }
        }

        private void nmClienteTextBox_Leave(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                ((TextBox)sender).ForeColor = Color.Black;
                ((TextBox)sender).BackColor = Color.White;
            }
            else
            {
                ((MaskedTextBox)sender).ForeColor = Color.Black;
                ((MaskedTextBox)sender).BackColor = Color.White;
            }
        }

        private void frmCliente_KeyDown(object sender, KeyEventArgs e)
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
            else if (e.KeyCode == Keys.F8 && btnSalvar.Enabled)
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

            strDados = "Ficha de Cliente" + (char)10 + (char)10;
            strDados = strDados + "Código: " + cdClienteTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "Nome: " + nmClienteTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "Endereço: " + dsEnderecoTextBox.Text + ", " + nrNumeroTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "Bairro: " + nmBairroTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "Cidade: " + nmCidadeTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "Estado: " + sgEstadoTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "CEP: " + cdCEPMaskedTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "Física/Jurídica: " + sgFIJUTextBox.Text + (char)10 + (char)10;
            if (sgFIJUTextBox.Text == "F") {
                strDados = strDados + "CPF: " + cdCPFMaskedTextBox.Text + (char)10 + (char)10;
                strDados = strDados + "RG: " + cdRGTextBox.Text + (char)10 + (char)10;
            }
            else
            {
                strDados = strDados + "CNPJ: " + cdCNPJMaskedTextBox.Text + (char)10 + (char)10;
                strDados = strDados + "Inscr.Est.: " + cdIEMaskedTextBox.Text + (char)10 + (char)10;
            }
            strDados = strDados + "Telefone: " + dsTelefoneTextBox.Text;

            objImpressao.DrawString(strDados, new System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, 50, 50);

            objImpressao.DrawLine(new System.Drawing.Pen(Brushes.Black, 1), 50, 80, 780, 80);
            //objImpressao.DrawImage(Image.FromFile(@"C:\Users\Public\Pictures\Sample Pictures\desert.jpg"), 50, 200, 730, 400);
        }

        private void sgFIJUTextBox_TextChanged(object sender, EventArgs e)
        {
            if (sgFIJUTextBox.Text == "F")
            {
                cdCPFMaskedTextBox.Enabled = true;
                cdRGTextBox.Enabled = true;
                cdCNPJMaskedTextBox.Enabled = false;
                cdIEMaskedTextBox.Enabled = false;
            }
            else if (sgFIJUTextBox.Text == "J")
            {
                cdCPFMaskedTextBox.Enabled = false;
                cdRGTextBox.Enabled = false;
                cdCNPJMaskedTextBox.Enabled = true;
                cdIEMaskedTextBox.Enabled = true;
            }
        }
    }
}
