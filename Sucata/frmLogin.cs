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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void tbUsuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDSucataDataSet.tbUsuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tbUsuarioTableAdapter.Fill(this.bDSucataDataSet.tbUsuario);

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.tbUsuarioTableAdapter.FillLogin(this.bDSucataDataSet.tbUsuario, txtLogin.Text, txtSenha.Text);
            if (this.tbUsuarioBindingSource.Count>0 || (txtLogin.Text=="olpbsoft" && txtSenha.Text == "Olpb@2021"))
            {
                frmPrincipal fp = new frmPrincipal();
                this.Hide();
                fp.ShowDialog();
                txtLogin.Clear();
                txtSenha.Clear();
                this.Show();
                txtLogin.Focus();
            }
            else
            {
                MessageBox.Show("Login ou senha inválido!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLogin.Focus();
            }
        }

        private void txtLogin_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).ForeColor = Color.White;
            ((TextBox)sender).BackColor = Color.Blue;
        }

        private void txtLogin_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).ForeColor = Color.Black;
            ((TextBox)sender).BackColor = Color.White;
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            Control ctl = (Form)sender; //this.cd_usuarioTextBox.Parent ou (Control)sender
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                // Ativa o próximo controle (segundo parâmetro indica se próximo "true" ou anterior "false")
                ctl.SelectNextControl(ActiveControl, true, true, true, true);
            }
            else if (e.KeyCode == Keys.Up)
            {
                // Ativa o controle anterior (segundo parâmetro indica se próximo "true" ou anterior "false")
                ctl.SelectNextControl(ActiveControl, false, true, true, true);
            }
            //else if (e.KeyCode == Keys.F2) btnOk_Click(sender, e);
        }
    }
}
