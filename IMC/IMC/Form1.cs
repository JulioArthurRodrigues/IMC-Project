using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso, altura, imc;
            
            //Atribuir para as variáveis os valores digitados e convertidos
            peso = double.Parse (txtPeso.Text);
            altura = double.Parse (txtAltura.Text);


            //Cálculo do IMC
            imc = peso / Math.Pow(altura, 2);

            //Exibir as informações
            txtIMC.Text = imc.ToString("N1");

            //Classificação
            if (imc < 20)
            {
                txtClassificacao.Text = "Magro";
            }
            else if (imc <=25)
            {
                txtClassificacao.Text = "Peso Normal";
            }
            else
            {
                txtClassificacao.Text = "Obeso";
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPeso.Text = "";
            txtAltura.Clear();
            txtIMC.Clear();
            txtClassificacao.Clear();

            //Mudança do foco para o TXTPESO
            txtPeso.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "Sair do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                Application.Exit();
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Permite números
            if (char.IsDigit(e.KeyChar))
                return;
            
            //Permite Backspace
            if (e.KeyChar == (char)Keys.Back)
                return;

            //Permite somente uma Vírgula
            if ((e.KeyChar == ',' && !((TextBox)sender).Text.Contains(",")))
                return;
            e.Handled = true;
        }
    }
}
