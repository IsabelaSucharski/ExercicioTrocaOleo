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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();  
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtValorTotal.Text != null)
            {
                txtEmailCliente.Enabled = true;
            }
        }
        public void CarregarClienteCombo()
        {
             cmbCliente.DisplayMember = "cliente";
            ClienteDAO clienteDao = new ClienteDAO();
            List<Cliente> cliente = clienteDao.CarregarCliente();

            foreach (var cli in cliente)
            {
                cmbCliente.Items.Add(cli.Nome);
            }
        }

        public void CarregarOleoCombo()
        {
            OleoDAO oleoDao = new OleoDAO();
            List<Oleo> oleo = oleoDao.CarregarOleo();

            foreach (var ole in oleo)
            {
                cmbOleo.Items.Add(ole.Nome);
                cmbCategoria.Items.Add(ole.Categoria);
                cmbTipo.Items.Add(ole.Tipo);
                cmbFabricante.Items.Add(ole.Fabricante);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            txtValorLitro.Focus();
            CarregarClienteCombo();
            CarregarOleoCombo();                                     
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteDAO clienteDao = new ClienteDAO();

                if (clienteDao.ValidarEmail(txtEmailCliente.Text) == false)
                {
                    txtEmailCliente.Clear();
                    MessageBox.Show("Email inválido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmailCliente.Focus();
                }
                else
                {
                    var obj = new ServicoTrocaOleo();
                    obj.Data = dateTimePicker1.Value;
                    obj.Cliente = cmbCliente.Text;
                    obj.Oleo = cmbOleo.Text;
                    obj.Categoria = cmbCategoria.Text;
                    obj.Tipo = cmbTipo.Text;
                    obj.Fabricante = cmbFabricante.Text;
                    obj.ValorLitro = Convert.ToDecimal(txtValorLitro.Text);
                    obj.QtdeLitro = Convert.ToInt32(txtQtdeLitro.Text);
                    obj.ValorTotal = Convert.ToDecimal(txtValorTotal.Text);
                    obj.Email = txtEmailCliente.Text;

                    new ServicoDAO().Inserir(obj);

                    MessageBox.Show("Dados salvos com sucesso");
                    this.Hide();
                    new Form1().Show();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("ERRO: " + er.Message);
            }
        }

        private void lblVTotal_Click(object sender, EventArgs e)
        {

        }

        private void txtValorTotal_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblEmailCliente_Click(object sender, EventArgs e)
        {

        }

        private void txtEmailCliente_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtQtdeLitro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQtdeLitro_Validating(object sender, CancelEventArgs e)
        {
            decimal qtde_litro = 0, valor_litro = 0, valor_total = 0;

            if(txtValorLitro.Text != "" && txtQtdeLitro.Text != "")
            {
                qtde_litro = Convert.ToDecimal(txtQtdeLitro.Text);
                valor_litro = Convert.ToDecimal(txtValorLitro.Text);

                valor_total = qtde_litro * valor_litro;
            }  

            txtValorTotal.Text = valor_total.ToString();
        }
    }
}
