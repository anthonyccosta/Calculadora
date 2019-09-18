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
        private double Valor1;
        private double Valor2;
        private string operacao;


        private void ButtonCalcular_Clicked(object sender, EventArgs e)
        {
            // this.Valor1 para representar que a variavel pertence a classe mainpage
            Valor1 = Convert.ToDouble(entryNumero.Text);
            entryNumero.Text = "";
            this.operacao = "SOMA";
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
            // this.Valor1 para representar que a variavel pertence a classe mainpage
            Valor1 = Convert.ToDouble(entryNumero.Text);
            entryNumero.Text = "";
            this.operacao = "MULTIPLICAR";
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
            // this.Valor1 para representar que a variavel pertence a classe mainpage
            Valor1 = Convert.ToDouble(entryNumero.Text);
            entryNumero.Text = "";
            this.operacao = "SUBTRAIR";
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
            calculadora c = new calculadora();
            this.Valor2 = Convert.ToDouble(entryNumero.Text);

            switch(this.operacao)
            {
                case "SOMA":                    
                    entryNumero.Text = c.Somar(this.Valor1, this.Valor2).ToString();
                    break;
                case "SUBTRACAO":
                    entryNumero.Text = c.Subtrair(this.Valor1, this.Valor2).ToString();
                    break;
                case "DIVISAO":
                    entryNumero.Text = c.Dividir(this.Valor1, this.Valor2).ToString();
                    break;
                case "MULTIPLICACAO":
                    entryNumero.Text = c.Multiplicar(this.Valor1, this.Valor2).ToString();
                    break;
                default:
                    DisplayAlert("EITA!", "A CALCULADORA OBTEVE UM ERRO!\n TENTE NOVAMENTE", "OK");
                    break;
            }
            
        }

        private void BtnDividir_Clicked(object sender, EventArgs e)
        {
            // this.Valor1 para representar que a variavel pertence a classe mainpage
            Valor1 = Convert.ToDouble(entryNumero.Text);
            entryNumero.Text = "";
            this.operacao = "DIVIDR";
        }
    }
}
