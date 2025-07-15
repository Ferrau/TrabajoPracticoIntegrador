using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObservatorioDLL
{
    public class Descubridor
    {
        public Descubridor(string nombre, string apellido, DateTime fechaNacimiento)
        {
			_nombre = nombre;
			_apellido = apellido;
			_fechaNacimiento = fechaNacimiento;
        }

        private string _nombre;

		public string nombre
		{
			get { return _nombre; }
		}

		private string _apellido;

		public string apellido
		{
			get { return _apellido; }
		}

		private DateTime _fechaNacimiento;

		public DateTime fechaNacimiento
		{
			get { return _fechaNacimiento; }
		}

        public override string ToString()
        {
			return $"{_nombre} {_apellido}";
        }
    }
}