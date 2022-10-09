using System;

namespace Herencia
{
    ///<summary>
    ///Un usuario abstracto
    ///</summary>
    public abstract class Usuario
    {
        public string Nombre {get ; set ;}
        public string Apellido {get ; set ;}
        public string CI {get ; set ;}
        public string Foto {get ; set ;}

        protected Usuario(string newNombre, string newApellido, string newCI, string newFoto)
        {
            this.Nombre = newNombre;
            this.Apellido = newApellido;
            this.CI = newCI;
            this.Foto = newFoto;
        }

        ///AddVehiculo
        ///RemoveVehiculo
        ///
    }
}