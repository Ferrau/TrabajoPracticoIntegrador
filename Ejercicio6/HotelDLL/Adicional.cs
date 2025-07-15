using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelDLL
{
    public class Adicional
    {
        public Adicional(string nombre, float valor)
        {
            _nombre = nombre;
            _valor = valor;
        }

        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
          
        }

        private float _valor;

        public float Valor
        {
            get { return _valor; }
            
        }

    }
}