using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class registro
    { 
        public string nombreUsuario { get; set; }
        public string password { get; set; }
        public object registrarse(string userName, string pass)
        {
            Log.user = userName;
            string path = @"C:\Users\eldes\Desktop\Proyecto Multifuncional\BACKEND\Models\registros.json";
            List<registro> registrosTotales;
            registro registrarse = new registro
            {
                nombreUsuario = userName,
                password = pass
            };

            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                registrosTotales = JsonConvert.DeserializeObject<List<registro>>(json);
            }
            else
            {
                registrosTotales = new List<registro>();
            }

            registrosTotales.Add(registrarse);

            string newJson = JsonConvert.SerializeObject(registrosTotales);

            File.WriteAllText(path, newJson);

            var resultado = new
            {
                mensaje = "Usuario registrado exitosamente",
                nombreUsuario = userName
            };

            return resultado;
        }

    }
}
