using System;
using System.Collections;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            En éste método deberas mostrar un ejemplo de funcionamiento de tu programa an pseudocódigo. A continuación te 
            planteamos un ejemplo de como hacerlo. Esto no significa que te limites a hacer solamente esto, debes pensar 
            en grande!

            Usuario pasajero1 = nuevo Pasajero()
            Usuario pasajero2 = nuevo Pasajero()
            Usuario pasajero3 = nuevo Pasajero()
            Usuario conductor1 = nuevo Conductor()
            Usuario conductorPool1 = nuevo ConductorPool(maxPasajeros = 3)
            UcuRideShare rideShare = nuevo UcuRideShare()
            
            rideShare.Add(conductor1)
            Se publica en Twitter un nuevo conductor!

            rideShare.Add(conductorPool1)
            Se publica en Twitter un nuevo conductor!
            
            rideShare.Add(pasajero1)
            Se publica en Twitter nuevo registro de pasajero!
            
            rideShare.Add(pasajero2)
            Se publica en Twitter nuevo registro de pasajero!

            rideShare.Add(pasajero3)
            Se publica en Twitter nuevo registro de pasajero!

            */
            Usuario pasajero1 = new Pasajero("Jorge","Messi","111111-1", "C:/Users/aaran/OneDrive/Documentos/Programacion II/Programas/Repositorios/Ejercicio-Herencia/asset/foto_01_test_noCognitvecompliant.jpg");
            Usuario pasajero2 = new Pasajero("Pericles","Nose","222222-2","C:/Users/aaran/OneDrive/Documentos/Programacion II/Programas/Repositorios/Ejercicio-Herencia/asset/foto_02_test_Cognitivecompliant.jfif");
            Usuario pasajero3 = new Pasajero("Eh","Neymar","333333-3","C:/Users/aaran/OneDrive/Documentos/Programacion II/Programas/Repositorios/Ejercicio-Herencia/asset/foto_03_test_200px_png");

            Usuario conductor1 = new Conductor("Manejador", "Solouno", "444444-4", "C:/Users/aaran/OneDrive/Documentos/Programacion II/Programas/Repositorios/Ejercicio-Herencia/asset/foto_04_exceptionimage.png");
            Usuario conductor2 = new ConductorPool("Manejador", "Multiple", "555555-5", "C:/Users/aaran/OneDrive/Documentos/Programacion II/Programas/Repositorios/Ejercicio-Herencia/asset/foto_04_exceptionimage.png", 4);

            UcuRideShare rideShare = new UcuRideShare();

            rideShare.Add(pasajero1);
            rideShare.Add(pasajero2);
            rideShare.Add(pasajero3);
            rideShare.Add(conductor1);
            rideShare.Add(conductor2);
        }
    }
}
