using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Fruteria
{
    class RepoFruta
    {
        
        public void Mostrar_Fruta(Fruta Object)
        {
           Console.WriteLine("Numero de fruta: {0}\tNombre: {1}\tTipo de fruta: {2}\tCon un peso de: {3}Gr\tCon un valor de: ${4}\t\n",Object.Id, Object.Nombre, Object.Tipo, Object.Peso, Object.Precio);
            //Solo muestro los datos de una fruta.
        }
        public void Listar_Fruta(Fruta[] frutas)
        {
            foreach(Fruta Object in frutas)
            {
                Console.WriteLine("///////////////////////////////////////////////////////////////////////////////////////////////////////////////");
                Console.WriteLine("Numero de fruta: {0}\tNombre: {1}\tTipo de fruta: {2}\t\nCon un peso de: {3}Gr\tCon un valor de: ${4}\t\n  ", Object.Id, Object.Nombre, Object.Tipo, Object.Peso, Object.Precio);
                //Muestro los datos de todas las frutas en el arreglo
            }
        }
        public void Vender_Fruta(Fruta[] frutas)
        {
            //Declaré estas variables con las que haré operaciones más adelante solo en este método
            int Cantidad;       //Cantidad de unidades de una fruta que el cliente compró
            decimal Precio_Total = 0;   //Precio determinado mediante la cantidad de un tipo de fruta y su precio
            decimal Precio_Final = 0;   //Sumatoria de los precios totales de cada tipo de fruta.
            decimal Peso_Total;            //Peso determinado mediante la cantidad de un tipo de fruta y su peso individual
            string respuesta = "";         //Respuesta que el usuario dará al terminar cada ticket en caso de que quiera realizar otra venta.

            do
            {
                Console.WriteLine("//////////////////////////////////////////TICKET {0}//////////////////////////////////////", DateTime.Now); //Utilize el método DateTime para mostrar la fecha y hora en que se realiza la compra
                
                foreach (Fruta x in frutas) //El ciclo servirá para realizar las operaciones sin reescribir cada sentencia para cada fruta, creando así optimización del código
                    {
                        Console.WriteLine("Ingrese la cantidad de {0}", x.Nombre);
                        Cantidad = Int32.Parse(Console.ReadLine());  //Convierte la cantidad registrada del usuario en un tipo entero para poder trabajar con este dato

                    //Operaciones que determinan el precio y peso total de cada fruta
                        Precio_Total = Cantidad * x.Precio;
                        Peso_Total = Cantidad * x.Peso;

                    //Muestro los datos de cada fruta con su información complementaria 
                        Console.WriteLine("Numero de fruta: {0}\tNombre: {1}\tTipo de fruta: {2}\t\nCon un peso de: {3}Gr\tCon un valor de: ${4}\tCantidad: {5}\tPrecio Total: ${6}\tPeso Total: {7}gr\n", x.Id, x.Nombre, x.Tipo, x.Peso, x.Precio, Cantidad, Precio_Total, Peso_Total);
                    //Esta operación sirve para sumar los precios de todas las frutas para al final mostrar el resultado en pantalla
                    Precio_Final = Precio_Total + Precio_Final;
                }
                    
                    Console.WriteLine("El precio final de la compra es de: $" + Precio_Final + "\n");
                Console.WriteLine("//////////////////////////////////////////GRACIAS POR SU COMPRA, VUELVA PRONTO //////////////////////////////////////");
                Console.WriteLine("Desea Registrar otra venta?: ");
                //Según la respuesta será si se sigue ejecutando o no el ciclo
                respuesta = Console.ReadLine();


            } while (respuesta != "no"); //Mientras la respuesta a la pregunta sea diferente de no, el ciclo seguirá ejecutándose

            

        }


    }
}
