using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;

namespace ObservatorioDLL
{
    public class Estrella : CuerpoCeleste, IConstelacion
    {
        public Estrella(string nombre, int edad, int masa, double temperatura, int diametro, Color color, TipoEstrella tipo) : base(nombre, edad, masa)
        {
            _temperatura = temperatura;
            _diametro = diametro;
            _color = color;
            _tipo = tipo;
            if(_tipo == TipoEstrella.Gigante)
            {
                _limiteInferiorKM = 750000000;
                _limiteSuperiorKM = 1500000000;
            }
            else
            {
                _limiteInferiorKM = 15000000;
                _limiteSuperiorKM = 45000000;
            }
        }

        private double _temperatura;

        public double temperatura
        {
            get { return _temperatura; }
        }

        private int _diametro;

        public int diametro
        {
            get { return _diametro; }
        }

        private Color _color;

        public Color color
        {
            get { return _color; }
        }

        private TipoEstrella _tipo;

        public TipoEstrella tipo
        {
            get { return _tipo; }
        }

        private double _limiteInferiorKM;

        public double limiteInferiorKM
        {
            get { return _limiteInferiorKM; }
            set { _limiteInferiorKM = value; }
        }

        private double _limiteSuperiorKM;

        public double limiteSuperiorKM
        {
            get { return _limiteSuperiorKM; }
            set { _limiteSuperiorKM = value; }
        }

        private string _nombreConstelacion;

        public string nombreConstelacion
        {
            get { return _nombreConstelacion; }
            set { _nombreConstelacion = value; }
        }

        public override string ToString()
        {
            return $"N°{_id} Estrella {_nombre} : {_tipo} {_color}";
        }
    }
}