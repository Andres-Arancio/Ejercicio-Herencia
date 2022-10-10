using System;
using System.Collections.Generic;

namespace Herencia
{
    public abstract class Conductor : Usuario
    {
        public List<Calificacion> Calificaciones {get ; set ;}
        public int CalificacionTotal {get ; set ;}
        public Vehiculo Vehiculo {get ; set ;}

        public Conductor(string newNombre, string newApellido, string newCI, string newFoto)
            : base(newNombre, newApellido, newCI, newFoto)
        {
            this.Nombre = newNombre;
            this.Apellido = newApellido;
            this.CI = newCI;
            this.Foto = newFoto;
        }
        public void AddCalificacion(int Value)
        {
            Calificacion newCalificacion = new Calificacion(Value);
            this.Calificaciones.Add(newCalificacion);
            this.CalculateCalificacionTotal();
        }

        private void CalculateCalificacionTotal()
        {
            int auxval = 0;
            foreach (Calificacion CalificacionIndividual in this.Calificaciones)
            {
                auxval = auxval + CalificacionIndividual.Value;
            }
            this.CalificacionTotal = auxval / this.Calificaciones.Count;
        }

        public void AddVehiculo(string newMatricula)
        {
            Vehiculo newVehiculo = new Vehiculo();
            newVehiculo.Matricula = newMatricula;
            this.Vehiculo = newVehiculo;
        }
        
        public void RemoveVehiculo(string oldMatricula)
        {
            this.Vehiculo = null;
            Console.WriteLine($"Vehiculo {this.Vehiculo.Matricula} de {this.Nombre} {this.Apellido} ha sido eliminado.");
        }
        
    }
}