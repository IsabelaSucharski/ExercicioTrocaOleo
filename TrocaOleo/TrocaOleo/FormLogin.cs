using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrocaOleo
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Usuario obj = new Usuario();
            obj.Email = txtEmail.Text;
            obj.Senha = txtSenha.Text;
            if (txtEmail.Text == "" && txtSenha.Text == "")
            {
                MessageBox.Show("Favor digitar e-mail e senha");
                txtEmail.Focus();
            }
            else
            {
                try
                {
                    var usuario = UsuarioDAO.Logar(obj);

                    if (!usuario.Senha.Equals(txtSenha.Text))
                    {
                        txtSenha.Clear();

                        MessageBox.Show("Senha Inválida", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtSenha.Focus();
                    }
                    if (!usuario.Email.Equals(txtEmail.Text))
                    {
                        txtEmail.Clear();

                        MessageBox.Show("E-mail Inválida", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtEmail.Focus();
                    }
                                        
                    else
                    {
                        MessageBox.Show("Logado com sucesso!");
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show("ERRO: " + er.Message);
                }
            }
        }
    }
}
