using System;
namespace MiProyecto.App
{
    public class Mascota
    {
        private string Nombre;
        private int Edad;
        private string Tipo;
        private double Peso;

        public void EstablecerNombre(string nombre)
        {
            Nombre = nombre;
        }
        public void EstablecerEdad(int edad)
        {
            if (edad <= 0)
            {
                Console.WriteLine("La edad no puede ser negativa o 0.");
            }
            else
            {
                Edad = edad;
            }

        }
        public void EstablecerTipo(string tipo)
        {
            if (tipo.ToLower() == "perro" || tipo.ToLower() == "gato" || tipo.ToLower() == "pajaro" || tipo.ToLower() == "otro")
            {
                Tipo = tipo;
            }
            else
            {
                Console.WriteLine("Tipo inválido. Debe ser 'Perro', 'Gato', 'Pájaro' o 'Otro'.");
            }
        }
        public void EstablecerPeso(double peso)
        {
            Peso = peso;
        }
        public string ObtenerNombre()
        {
            Console.WriteLine("Nombre: " + Nombre);
        }
}    public int ObtenerEdad()
        {
            Console.WriteLine("Edad: " + Edad);
        }
        public string ObtenerTipo()
        {
            Console.WriteLine("Tipo: " + Tipo);
        }
        public double ObtenerPeso()
        {
            Console.WriteLine("Peso: " + Peso);


    public void MostrarInfo()
        {
            Console.WriteLine("Información de la mascota:");
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Edad: " + Edad);
            Console.WriteLine("Tipo: " + Tipo);
            Console.WriteLine("Peso: " + Peso + " kg");
        }

        public void CalcularEdad()
        {
            if (Tipo == "gato")
            {
                Console.WriteLine($"La edad de su gato ({edad})en años humanos es: " + (Edad * 6));
            }
            else if (Tipo == "perro")
            {
                Console.WriteLine($"La edad de su perro ({edad}) en años humanos es: " + (Edad * 7));
            }
            else
            {
                Console.WriteLine($"La edad de su mascota ({edad}) en años humanos es: " + Edad);
            }
        }
    }

