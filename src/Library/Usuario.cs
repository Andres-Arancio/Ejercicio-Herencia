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
        public string Bio {get ; set ;}

        protected Usuario(string newNombre, string newApellido, string newCI, string newFoto)
        {
            this.Nombre = newNombre;
            this.Apellido = newApellido;
            this.CI = newCI;
            this.Foto = ValidarFoto(newFoto);
        }
        public void ChangeBio(string newBio)
        {
            this.Bio = newBio;
        }

        /// <summary>
        /// Retorna la foto del usuario si esta es valida (tiene una cara sonriendo), sino devuelve null
        /// </summary>
        /// <param name="newFoto"></param>
        /// <returns></returns>
        private static string ValidarFoto(string newFoto)
        {
            CognitiveCoreUCU.CognitiveFace cog = new CognitiveCoreUCU.CognitiveFace(true);
            string defaultImage = "C:/Users/aaran/OneDrive/Documentos/Programacion II/Programas/Repositorios/Ejercicio-Herencia/asset/foto_04_exceptionimage.png";
            
            if(newFoto.Equals(""))
            {
                Console.WriteLine("No picture found. Providing default profile picture");
                return defaultImage;
            }
            
            cog.Recognize(newFoto);

            if(!cog.FaceFound || !cog.SmileFound)
            {
                Console.WriteLine("Face not valid. Providing default profile picture");
                return defaultImage;
            }
            else
            {
                Console.WriteLine("Face recognized and validated");
                return newFoto;
            }
        }

    }
}