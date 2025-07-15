using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObservatorioDLL
{
    public class Satelite : CuerpoCeleste
    {
        public Satelite(string nombre, int edad, int masa, bool poseeAcoplamiento = false) : base(nombre, edad, masa)
        {
            _acoplamientoMarea = poseeAcoplamiento;
        }

        private bool _acoplamientoMarea;

        public bool acoplamientoMarea
        {
            get { return _acoplamientoMarea; }
        }

        public override string ToString()
        {
            return $"N°{_id} Satelite {_nombre}";
        }
    }
}