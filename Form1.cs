using System;
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
        // variaveis globaius:
        bool operadorClicado = true;
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

            // "abaixar a bandeirinha"
            operadorClicado = false;
        }
        private void operador_click(object sender, EventArgs e)
        {
            // verificar se o operador ainda não foi clicado:
            if(operadorClicado == false)

            {
                // Obter o botão que está chamando esse evento:
                Button botaoClicado = (Button)sender;

                // Adicionar o Text do botão clicado no TextBox:
                txbTela.Text += botaoClicado.Text;

                // Mudar o operadorClicado para true (Levantar a bandeirinha):
                operadorClicado = true;

            }



        }


        private void btnApagar_Click(object sender, EventArgs e)
        {
            // Limpar a tela:
            txbTela.Text = "";
            // Voltar o operador clicado para true:
            operadorClicado = true;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                // Obter o resultados de todos os operadores:
                string expressao = txbTela.Text;

                // Criar um DataTable para usar o método Compute:
                var dt = new System.Data.DataTable();

                // Calcular a expressão:
                var resultado = dt.Compute(expressao, "");
                // Mostrar na tela:
                txbTela.Text = resultado.ToString();

                // Verificar se a divisão foi feita por zero, e mostrar o erro:
                if (txbTela.Text == "∞")
                {
                    btnApagar.PerformClick();
                    MessageBox.Show("Impossível divir por zero!", "Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // "levantar a bandeirinha"
                operadorClicado = true;
            }
            catch
            {
                MessageBox.Show("Expressão inválida!");
                txbTela.Text = "";
            }
        }
    }
}
