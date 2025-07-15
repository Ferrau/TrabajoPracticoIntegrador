using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelDLL
{
    public class Huesped
    {

		public Huesped(long dni, string nombre, string apellido, DateTime fechaNacimiento)
        {
            _dni = dni;
            _nombre = nombre;
            _apellido = apellido;
            _fechaNacimiento = fechaNacimiento;
            _edad = CalcularEdad();      
			_cantidadVecesHospedado = 0;
            
        }
        private string _nombre;

		public string Nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}
		private string _apellido;

		public string Apellido
		{
			get { return _apellido; }
			set { _apellido = value; }
		}

		private DateTime _fechaNacimiento;

		public DateTime FechaNacimiento
		{
			get { return _fechaNacimiento; }
			set { _fechaNacimiento = value; }
		}

		private byte _edad;

		public byte Edad
		{
			get { return _edad; }
			set { _edad = value; }
		}


		public byte CalcularEdad()
		{
			byte edad = 0;
			edad = Convert.ToByte(DateTime.Now.Year - _fechaNacimiento.Year);
			return edad;
		}


		private long _dni;

		public long DNI
		{
			get { return _dni; }
			set { _dni = value; }
		}

		private int _cantidadVecesHospedado;

		public int CantidadVecesHospedado
		{
			get { return _cantidadVecesHospedado; }
			
		}


		public void Hospedar()
		{
            _cantidadVecesHospedado++;
		}

        public override string ToString()
        {
			return $"{_nombre + " " + _apellido + " " + _dni}";
        }
		
			
		

	}
}