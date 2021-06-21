using System;
using PrimeraConsola.models;

namespace PrimeraConsola
{
    class Program
    {
        static void Main(string[] args)
        {

            if (args.Length > 0) {
                for (var i = 0;i < args.Length; i++)
                {
                    Console.WriteLine(args[i]);
                }
            }

            var Carro = new Vehiculos();
            var Perro = new Animales();
            var Zapato = new Ropa();
            var Pistola = new Armas();
            var Personaje = new Personajes();

            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Ingrese los datos de us vehiculo favorito de GTA");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese el nombre del vehiculo");
            Carro.Nombre = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese el marca del vehiculo");
            Carro.Marca = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese el modelo del vehiculo");
            Carro.Modelo = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese el Color del vehiculo");
            Carro.Color = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese el Matricula del vehiculo");
            Carro.Modelo = Console.ReadLine();

            Console.WriteLine(Carro.Encender());//toma solo la primera propiedas
            Console.WriteLine(Carro.Acelerar());//debe tomar la primera y la seg7ujnda
            Console.WriteLine(Carro.Frenar());
            Console.WriteLine(Carro.Chocar());
            Console.WriteLine(Carro.Apagar());


            Console.WriteLine("Ingrese los datos de su personaje favorito de GTA");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese el nombre del vehiculo");
            Personaje.Nombre = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese el marca del vehiculo");
            Carro.Marca = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese el marca del vehiculo");

            Console.WriteLine(Carro.Encender());
            Console.WriteLine(Carro.Acelerar());
            Console.WriteLine(Carro.Frenar());
            Console.WriteLine(Carro.Chocar());
            Console.WriteLine(Carro.Apagar());
            Console.WriteLine(" ");
            Console.WriteLine("Toque cualquer ecla para culminar el progrma");
            Console.ReadKey();

        }
    }
}
