using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    internal class Sumar
    {
        public double operacionSuma(double val1, double val2)
        {
            Log.operacion = "Suma";
            Log.valorEntrada = val1.ToString();
            Log.valor2Entrada = val2.ToString();
            double resultado;
            resultado = val1 + val2;
            Log.valorSalida = resultado.ToString();
            Log.loggear();
            return resultado;
        }
    }
}
