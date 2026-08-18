namespace Exemplo_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double n1, n2, resultado;
            n1 = double.Parse(txtNum1.Text.Replace(".", ","));
            n2 = double.Parse(txtNum2.Text.Replace(".", ","));

            if (rbSoma.Checked)
            {
                resultado = n1 + n2;
            }
            else if (rbSub.Checked)
            {
                resultado = n1 - n2;
            }
            else if (rbMult.Checked)
            {
                resultado = n1 * n2;
            }
            else
            {
                resultado = n1 / n2;
            }

            //Exibição do resultado

            txtResultado.Text = resultado.ToString();
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {
            if (txtNum1.Text != "" & txtNum2.Text != "")
            {
                btnCalcular.Enabled = true;
            }
            else
            {
                btnCalcular.Enabled = false;
            }
        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {
            if (txtNum2.Text != "" & txtNum1.Text != "")
            {
                btnCalcular.Enabled = true;
            }
            else
            {
                btnCalcular.Enabled = false;
            }
        }
    }
}
