using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeraConsola.models
{
    class Vehiculos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public string Matricula { get; set; }
        public string Transmision { get; set; }
        public string Kilometraje { get; set; }
        public string Direccion { get; set; }
        public string NumRuedas { get; set; }

        public virtual string Acelerar()
        {
            return $"El vehiculo {this.Nombre} del la marca {this.Marca} esta acelerandose";
        }

        public virtual string Frenar()
        {
            return $"El vehiculo {this.Nombre} del la marca {this.Marca} el modelo {this.Modelo} esta frenando";
        }

        public virtual string Chocar()
        {
            return $"El vehiculo {this.Nombre} se choco";
        }

        public virtual string Encender()
        {
            return $"El vehiculo {this.Nombre} esta encendido";
        }

        public virtual string Apagar()
        {
            return $"El vehiculo {this.Nombre} esta apagado";
        }

    }
}
