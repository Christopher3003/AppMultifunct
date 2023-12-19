using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Controllers;

namespace WebApplication1.Models
{
    internal class Divisas
    {
        public double conversorDivi(int dolar)
        {
            Log.operacion = "Dolar a Peso";
            Log.valorEntrada = dolar.ToString();
            double valorPeso = dolar * 56.55;
            Log.valorSalida = valorPeso.ToString();
            Log.loggear();
            return valorPeso;
        }
    }
}
