using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObservatorioDLL
{
    public class Personal : Descubridor
    {
        public Personal(int legajo, string nombre, string apellido, DateTime fechaNacimiento) : base(nombre, apellido, fechaNacimiento)
        {
            _legajo = legajo;
        }

        private int _legajo;

        public int legajo
        {
            get { return _legajo; }
        }

        public override string ToString()
        {
            return $"N°{legajo} - " + base.ToString();
        }
    }
}