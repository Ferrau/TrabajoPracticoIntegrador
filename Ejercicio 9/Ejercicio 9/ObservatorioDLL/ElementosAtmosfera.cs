using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObservatorioDLL
{
    public class ElementosAtmosfera
    {
        public ElementosAtmosfera(float oxigeno, float nitrogeno, float dioxidoDeCarbono)
        {
			_oxigeno = oxigeno;
			_nitrogeno = nitrogeno;
			_dioxidoDeCarbono = dioxidoDeCarbono;
        }

        private float _oxigeno;

		public float oxigeno
		{
			get { return _oxigeno; }
		}

		private float _nitrogeno;

		public float nitrogeno
		{
			get { return _nitrogeno; }
		}

		private float _dioxidoDeCarbono;

		public float dioxidoDeCarbono
		{
			get { return _dioxidoDeCarbono; }
		}
	}
}