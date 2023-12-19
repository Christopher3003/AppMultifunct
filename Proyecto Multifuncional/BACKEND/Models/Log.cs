using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    internal class Log
    {
        private static Log loggeo { get; set; }
        public static string user { get; set; }
        public static string valorEntrada { get; set; }
        public static string valor2Entrada { get; set; }
        public static string valorSalida { get; set; }
        public static string operacion { get; set; }
        
        private Log()
        {
        }
        public static Log getLog()
        {
            if (loggeo == null)
            {
                loggeo = new Log();
            }
            return loggeo;
        }
        public static string loggear()
        {
            string pathTxt = @"C:\Users\eldes\Desktop\Proyecto Multifuncional\BACKEND\Models\Log.txt";
            string nombreUsuario = user;
            string valEntrada = valorEntrada;
            string secValEntrada = valor2Entrada;
            string valSalida = valorSalida;
            string tipoOperacion = operacion;
           

            string nuevoLog = $"-------------------------------------\n" +
                $"Usuario: {nombreUsuario} \n Fecha: {DateTime.Now} \n Tipo de operacion: {tipoOperacion} \n Valores de entrada: {valEntrada},{secValEntrada} \n Valor de salida: {valSalida}\n" +
                $"-------------------------------------\n";

            File.AppendAllText(pathTxt, nuevoLog);

            Console.WriteLine("Logeo exitoso");
            return "Registro hecho";
        }
    }
}
