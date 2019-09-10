using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruteria
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruta a = new Fruta();      
            Fruta b = new Fruta();
            Fruta c = new Fruta();
            Fruta[] Frutas = { a, b, c };
            //Instanciación de los objetos y del arreglo que contendrá todas las frutas.
            a.Id = 25663;
            a.Nombre = "Manzana";
            a.Tipo = "Golden Delicious";
            a.Peso = 252M;
            a.Precio = 7.50M;

            b.Id = 156633;
            b.Nombre = "Platano";
            b.Tipo = "Macho";
            b.Peso = 120.855M;
            b.Precio = 5.75M;

            c.Id = 285010;
            c.Nombre = "Naranja";
            c.Tipo = "Valencia";
            c.Peso = 200.420M;
            c.Precio = 8.75M;


            RepoFruta Op = new RepoFruta(); //Instanciación del objeto con el que realizaré los cálculos


            



            Op.Mostrar_Fruta(a); //En este método solo imprimo los datos de la fruta seleccionada
            Op.Listar_Fruta(Frutas);    //Muestro los datos de todas las frutas registradas
            Op.Vender_Fruta(Frutas);    //Método que realiza un ticket de compra mediante los datos introducidos por el usario
            

        }
    }
}
