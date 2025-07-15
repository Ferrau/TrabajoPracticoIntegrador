using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObservatorioDLL
{
    public class Registro
    {
        public Registro(CuerpoCeleste objeto, Descubridor persona, DateTime fecha, int distancia)
        {
			_fechaEncuentro = fecha;
			_persona = persona;
			_objetoEncontrado = objeto;
			_distancia = distancia;
        }

        private DateTime _fechaEncuentro;

		public DateTime fechaEncuentro
		{
			get { return _fechaEncuentro; }
		}

		private Descubridor _persona;

		public Descubridor persona
		{
			get { return _persona; }
		}

		private CuerpoCeleste _objetoEncontrado;

		public CuerpoCeleste objetoEncontrado
		{
			get { return _objetoEncontrado; }
		}

		private double _distancia;

		public double distancia
		{
			get { return _distancia; }
		}
	}
}