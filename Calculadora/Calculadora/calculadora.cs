using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    public class calculadora
    {
        double valor1;
        double valor2;
        double resultado;
        string op;
        string label;

        public void Somar()
        {
            
            valor1 = Convert.ToDouble(label);
            label = "";
            op = "+";
            
        }
    }
}
