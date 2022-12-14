using System;
using System.Collections.Generic;

namespace Herencia
{
    public class Pasajero : Usuario
    {
        public List<Calificacion> Calificaciones {get ; set ;}
        public int CalificacionTotal {get ; set ;}
        public Pasajero(string newNombre, string newApellido, string newCI, string newFoto)
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
    }
}