﻿using System;
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
            //if (cmbOleo.Text != null)
            //{
            //    txtEmailCliente.Text = Enabled
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCliente.DisplayMember = "Cliente";
            cmbCategoria.DisplayMember = "Categoria";
            cmbOleo.DisplayMember = "Oleo";
            cmbTipo.DisplayMember = "Tipo";
            cmbFabricante.DisplayMember = "Fabricante";

            ClienteDAO clienteDAO = new ClienteDAO();
            List<Cliente> clientes = clienteDAO.CarregarCliente();

            foreach (var cli in clientes)
            {
                cmbCliente.Items.Add(cli);
            }

            OleoDAO oleoDAO = new OleoDAO();
            List<Oleo> oleo = oleoDAO.CarregarNome();
            foreach(var nome in oleo)
            {
                cmbOleo.Items.Add(nome);
            }
                        
            List<Oleo> Otipo = oleoDAO.CarregarTipo();
            foreach (var tipo in Otipo)
            {
                cmbTipo.Items.Add(tipo);
            }

            List<Oleo> Ocategoria = oleoDAO.CarregarCategoria();
            foreach (var cat in Ocategoria)
            {
                cmbCategoria.Items.Add(cat);
            }

            List<Oleo> Ofabricante = oleoDAO.CarregarFabricante();
            foreach (var fab in Ocategoria)
            {
                cmbFabricante.Items.Add(fab);
            }
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void lblVTotal_Click(object sender, EventArgs e)
        {

        }

        private void txtValorTotal_TextChanged(object sender, EventArgs e)
        {
            Convert.ToInt32(txtValorTotal = txtValorLitro + txtQtdeLitro); 
        }

        private void lblEmailCliente_Click(object sender, EventArgs e)
        {

        }

        private void txtEmailCliente_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
