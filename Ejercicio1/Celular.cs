using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class Celular
    {
        // Propiedades
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public double Precio { get; set; }
        public bool Encendido { get; private set; }

        // Constructor
        public Celular(string marca, string modelo, string color, double precio)
        {
            Marca = marca;
            Modelo = modelo;
            Color = color;
            Precio = precio;
            Encendido = false;
        }
        // Métodos
        public string Encender()
        {
            if (!Encendido)
            {
                Encendido = true;
                return "El celular está encendido.";
            }
            else
            {
                return "El celular ya está encendido.";
            }
        }

        public string Apagar()
        {
            if (Encendido)
            {
                Encendido = false;
                return "El celular está apagado.";
            }
            else
            {
                return "El celular ya está apagado.";
            }
        }

        public string Llamar(string numero)
        {
            if (Encendido)
            {
                return $"Llamando al número: {numero}...";
            }
            else
            {
                return "No se puede llamar porque el celular está apagado.";
            }
        }

        public string EnviarMensaje(string numero, string mensaje)
        {
            if (Encendido)
            {
                return $"Enviando mensaje a {numero}: {mensaje}";
            }
            else
            {
                return "No se puede enviar el mensaje porque el celular está apagado.";
            }
        }
    }
}
