using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculadora
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();           
        }

        public double resultado;
        public double Valor1;
        public double Valor2;
        public string operacao;


        private void ButtonCalcular_Clicked(object sender, EventArgs e)
        {          

            calculadora cal = new calculadora();
            resultado = cal.Somar(Valor1, Valor2);
            entryNumero.Text = Convert.ToString(resultado);
            
        }

        private void Btn7_Clicked(object sender, EventArgs e)
        {
            entryNumero.Text += "7";
        }

        private void Btn8_Clicked(object sender, EventArgs e)
        {
            entryNumero.Text += "8";
        }

        private void Btn9_Clicked(object sender, EventArgs e)
        {
            entryNumero.Text += "9";
        }

        private void Btn6_Clicked(object sender, EventArgs e)
        {
            entryNumero.Text += "6";
        }

        private void Btn5_Clicked(object sender, EventArgs e)
        {
            entryNumero.Text += "5";
        }

        private void Btn4_Clicked(object sender, EventArgs e)
        {
            entryNumero.Text += "4";
        }

        private void BtnMultiplicar_Clicked(object sender, EventArgs e)
        {
            calculadora cal = new calculadora();
            resultado = cal.Multiplicar(Valor1, Valor2);
            entryNumero.Text = Convert.ToString(resultado);
        }

        private void Btn3_Clicked(object sender, EventArgs e)
        {
            entryNumero.Text += "3";
            
        }

        private void Btn2_Clicked(object sender, EventArgs e)
        {
            entryNumero.Text += "2";
        }

        private void Btn1_Clicked(object sender, EventArgs e)
        {
            entryNumero.Text += "1";
        }

        private void BtnSubtrair_Clicked(object sender, EventArgs e)
        {
            calculadora cal = new calculadora();
            resultado = cal.Subtrair(Valor1, Valor2);
            entryNumero.Text = Convert.ToString(resultado);
        }

        private void Btn0_Clicked(object sender, EventArgs e)
        {
            entryNumero.Text += "0";
        }

        private void BtnLimpar_Clicked(object sender, EventArgs e)
        {
            entryNumero.Text = "";
        }

        private void BtnIgual_Clicked(object sender, EventArgs e)
        {
            switch(operacao)
            {
                case "SOMA":
                    resultado = Valor1 + Valor2;
                    break;

                case "SUBTRAIR":
                    resultado = Valor1 - Valor2;
                    break;

                case "DIVIDIR":
                    resultado = Valor1 / Valor2;
                    break;

                case "MULTIPLICAR":
                    resultado = Valor1 * Valor2;
                    break;
            }
            entryNumero.Text = resultado.ToString();
            
        }

        private void BtnDividir_Clicked(object sender, EventArgs e)
        {
            calculadora cal = new calculadora();
            resultado = cal.Dividir(Valor1, Valor2);
            entryNumero.Text = Convert.ToString(resultado);
        }
    }
}
