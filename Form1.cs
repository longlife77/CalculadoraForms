﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numero_Click(object sender, EventArgs e)
        {
            // Obter o botão que está chamando esse evento:
            Button botaoClicado = (Button)sender;   

            // Adicionar o Text do botão clicado no TextBox:
            txbTela.Text += botaoClicado.Text;
        }
        private void operador_click(object sender, EventArgs e)
        {

            // Obter o botão que está chamando esse evento:
            Button botaoClicado = (Button)sender;

            // Adicionar o Text do botão clicado no TextBox:
            txbTela.Text += botaoClicado.Text;
        }


        private void btnApagar_Click(object sender, EventArgs e)
        {

        }
    }
}
