using System;
using System.Windows.Forms;

namespace CalculadoraDelegates
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int valor1;
        int valor2;

        static Calculadora calc = new Calculadora();

        Calcular Somar = calc.Somar;
        Calcular Subtrair = calc.Subtrair;
        Calcular Multiplicar = calc.Multiplicar;
        Calcular Dividir = calc.Dividir;

        #region Validacoes das entradas
        private void txtValor1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permite somente numeros e o backspace
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != '\b'))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtValor2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permite somente numeros e o backspace
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != '\b'))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }

        }

        private void txtValor1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        #endregion
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
                if (c is TextBox)
                    (c as TextBox).Clear();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToInt32(txtValor1.Text);
            valor2 = Convert.ToInt32(txtValor2.Text);
            txtResultado.Text = Somar(valor1, valor2).ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToInt32(txtValor1.Text);
            valor2 = Convert.ToInt32(txtValor2.Text);
            txtResultado.Text = Subtrair(valor1, valor2).ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {

            valor1 = Convert.ToInt32(txtValor1.Text);
            valor2 = Convert.ToInt32(txtValor2.Text);
            txtResultado.Text = Multiplicar(valor1, valor2).ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToInt32(txtValor1.Text);
            valor2 = Convert.ToInt32(txtValor2.Text);
            txtResultado.Text = Dividir(valor1, valor2).ToString();
        }

    }
}
