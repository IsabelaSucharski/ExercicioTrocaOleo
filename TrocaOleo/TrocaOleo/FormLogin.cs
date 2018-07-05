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

            try
            {
                var usuario = new UsuarioDAO().Logar(obj);
                ClienteDAO clienteDao = new ClienteDAO();

                if (!usuario.Senha.Equals(txtSenha.Text))
                {
                    txtSenha.Clear();
                    MessageBox.Show("LOGIN INVALIDO", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSenha.Focus();
                }
                else if (!usuario.Email.Equals(txtEmail.Text))
                {
                    UsuarioDAO.Inserir(obj);
                    MessageBox.Show("NOVA CONTA SALVA");
                    this.Hide();
                    new Form1().Show();
                }
                else
                {
                    MessageBox.Show("LOGADO COM SUCESSO");
                    this.Hide();
                    new Form1().Show();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("ERRO: " + er.Message);
            }
        }
    }
}
