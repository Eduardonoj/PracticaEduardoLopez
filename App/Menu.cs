
using static System.Console;
using System;
using eduardolopez.Model;
using System.Collections.Generic;
namespace eduardolopez.App
{

    public class Menu
    {
        

        public void MostrarMenu(){
           

            WriteLine ("1. Crear objeto Avion");
            WriteLine ("2. Crear objeto Submarino");
            WriteLine ("3 Mostrar informacion de los aviones");
            WriteLine ("4 Mostrar informacion de los submarinos");
            WriteLine ("5. Salir");
        }
        
        public void CrearVehiculo(int opcion){
             string velocidadMax = "";
            string velocidadMin = "";
             string marcaV = "";
            string modeloV = "";
            string profundidadMax = "";
            

            Vehiculo Avion= null;
            Vehiculo Submarino= null;
            WriteLine("Ingrese Velocidad Maxima");
            velocidadMax =ReadLine();
            WriteLine("Ingrese Velocidad Minima");
            velocidadMin =ReadLine();
             WriteLine("Ingrese Marca Avion");
            marcaV =ReadLine();
            WriteLine("Ingrese Modelo Avion");
            modeloV =ReadLine();
            if (opcion == 1){
                 ((Avion)Avion).AlturaMaxima = Convert.ToSingle(velocidadMax);
                 ((Avion)Avion).AlturaMinima = Convert.ToSingle(velocidadMin);
                 ((Avion)Avion).Marca = marcaV;
                 ((Avion)Avion).Modelo = modeloV;
            }else if(opcion == 2){
                ((Submarino)Submarino).Marca = marcaV;
                ((Submarino)Submarino).Modelo = modeloV;
                ((Submarino)Submarino).ProfundidadMaxima = Convert.ToSingle(profundidadMax);


            }
        }
    }
}


