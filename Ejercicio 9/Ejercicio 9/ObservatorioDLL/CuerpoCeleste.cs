using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObservatorioDLL
{
    public abstract class CuerpoCeleste
    {
        protected CuerpoCeleste(string nombre, int edad, int masa)
        {
			contID++;
			_id = contID;
			_nombre = nombre;
			_masa = masa;
			_edad = edad;
        }

		private static int contID = 0;

		protected int _id;

		public int id
		{
			get { return _id; }
			set { _id = value; }
		}

		private int _masa;

		public int masa
		{
			get { return _masa; }
		}

		private int _edad;

		public int edad
		{
			get { return _edad; }
		}

		protected string _nombre;

		public string nombre
		{
			get { return _nombre; }
		}
    }
}