using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruteria
{
    class Fruta
    {

        private int id;
        private string nombre;
        private string tipo;
        private decimal precio;
        private decimal peso;
        
        
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public decimal Peso
        {
            get { return peso; }
            set { peso = value; }
        }

    }
}
