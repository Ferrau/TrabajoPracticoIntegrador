using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;

namespace ObservatorioDLL
{
    public class Observatorio
    {
        public Observatorio()
        {
			_registros = new List<Registro>();
			_objetosEncontrados = new List<CuerpoCeleste>();
			_descubridores = new List<Descubridor>();
        }

        private List<Registro> _registros;

		public List<Registro> registros
		{
			get { return _registros; }
			set { _registros = value; }
		}

		private List<CuerpoCeleste> _objetosEncontrados;

		public List<CuerpoCeleste> objetosEncontrados
		{
			get { return _objetosEncontrados; }
			set { _objetosEncontrados = value; }
		}

		private List<Descubridor> _descubridores;

		public List<Descubridor> descubridores
		{
			get { return _descubridores; }
			set { _descubridores = value; }
		}

		public delEditarRegistro EditarRegistro;

		public void CargaCuerpoCeleste(CuerpoCeleste objeto)
		{
			if(objeto is Estrella estrella && estrella != null)
			{
				_objetosEncontrados.Add(estrella);
			}
			if(objeto is Planeta planeta && planeta != null)
			{
				_objetosEncontrados.Add(planeta);
			}
			if(objeto is Satelite satelite && satelite != null)
			{
				_objetosEncontrados.Add(satelite);
			}
		}
	}
}