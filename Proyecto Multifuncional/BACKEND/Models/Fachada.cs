using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Fachada
    {
        private Divisas divi;
        private temperatura temp;
        private registro regist;
        private Sumar sum;
        

        public double convertD(int valDolar)
        {
            divi = new Divisas();
            return divi.conversorDivi(valDolar);

        }

        public double convertT(double valTemp)
        {
            temp = new temperatura();
            return temp.converCelcius(valTemp);
        }

        public object registrar(string nombreUsuario, string password) 
        {
            regist = new registro();
            return regist.registrarse(nombreUsuario, password);
        }

        public double suma(double val1, double val2) 
        {
            sum = new Sumar();
            return sum.operacionSuma(val1, val2);   
        } 
    }
}
