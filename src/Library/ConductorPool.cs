using System;
using System.Collections.Generic;

namespace Herencia
{
    public class ConductorPool : Conductor
    {
        public int maxPasajeros;
        public ConductorPool(string newNombre, string newApellido, string newCI, string newFoto, int newmaxPasajeros)
            : base(newNombre, newApellido, newCI, newFoto)
        {
            this.Nombre = newNombre;
            this.Apellido = newApellido;
            this.CI = newCI;
            this.Foto = newFoto;
            this.maxPasajeros = newmaxPasajeros;
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