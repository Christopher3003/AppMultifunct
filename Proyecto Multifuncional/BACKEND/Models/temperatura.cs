using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Controllers;

namespace WebApplication1.Models
{
    internal class temperatura
    {

        public double converCelcius(double valFarenheit)
        {
            Log.operacion = "Farenheit a Celsius";
            double resultado; 
            resultado = (valFarenheit - 32) * 5 / 9;
            Log.valorEntrada = valFarenheit.ToString();
            Log.valorSalida = resultado.ToString();
            Log.loggear();
            return resultado;
        }
    }
}
