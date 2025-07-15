using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObservatorioDLL
{
    public class Planeta : CuerpoCeleste, ISistemaPlanetario, IBinario
    {
        public Planeta(string nombre, int edad, int masa, int temperatura, bool tipoBinario = false) : base(nombre, edad, masa)
        {
            _temperatura = temperatura;
            _esBinario = tipoBinario;
            if(!_esBinario)
            {
                _segundaEstrella = null;
                _distanciaSegundaEstrella = 0;
            }
        }

        private double _temperatura;

        public double temperatura
        {
            get { return _temperatura; }
        }

        private bool _esBinario;

        public bool esBinario
        {
            get { return _esBinario; }
        }

        private Estrella _primerEstrella;

        public Estrella primerEstrella
        {
            get { return _primerEstrella; }
            set { _primerEstrella = value; }
        }

        private double _distanciaPrimerEstrella;

        public double distanciaPrimerEstrella
        {
            get { return _distanciaPrimerEstrella; }
            set { _distanciaPrimerEstrella = value; }
        }

        private List<Satelite> _satelites;

        public List<Satelite> satelites
        {
            get { return _satelites; }
            set { _satelites = value; }
        }

        private Estrella _segundaEstrella;

        public Estrella segundaEstrella
        {
            get { return _segundaEstrella; }
            set { _segundaEstrella = value; }
        }

        private double _distanciaSegundaEstrella;

        public double distanciaSegundaEstrella
        {
            get { return _distanciaSegundaEstrella; }
            set { _distanciaSegundaEstrella = value; }
        }

        public double ConvertirDistancia(double distancia, string unidad)
        {
            double total = 0.0, kmEnAl = 9460730472580;
            if(unidad == "km")
            {
                total = distancia / kmEnAl;
            }
            else if(unidad == "al")
            {
                total = distancia * kmEnAl;
            }
            return total;
        }

        public double ConvertirTemperatura(double temperatura, string unidad)
        {
            double total = 0.0;
            if(unidad == "C")
            {
                total = (temperatura * 1.8) + 32;
            }
            else if(unidad == "F")
            {
                total = (temperatura - 32) * 0.55555555555555555555555555555556;
            }
            return total;
        }

        public bool EsHabitable(double temperaturaCelsius, ElementosAtmosfera elementos)
        {
            bool condicion1 = temperaturaCelsius >= -20 && temperaturaCelsius <= 50;

            bool condicion2 = elementos.oxigeno >= 19.5f && elementos.oxigeno <= 23.5f;
            if (condicion2)
            {
                condicion2 = elementos.nitrogeno >= 76f && elementos.nitrogeno <= 80f;
                if (condicion2)
                {
                    condicion2 = elementos.dioxidoDeCarbono < 0.05f;
                    if (condicion2)
                    {
                        condicion2 = true;
                    }
                    else
                    {
                        condicion2 = false;
                    }
                }
                else
                {
                    condicion2 = false;
                }
            }
            else
            {
                condicion2 = false;
            }

            bool condicion3;
            if(!_esBinario)
            {
                condicion3 = ConvertirDistancia(_distanciaPrimerEstrella, "al") >= _primerEstrella.limiteInferiorKM && ConvertirDistancia(_distanciaPrimerEstrella, "al") <= _primerEstrella.limiteSuperiorKM;
            }
            else
            {
                condicion3 = ConvertirDistancia(_distanciaPrimerEstrella, "al") >= _primerEstrella.limiteInferiorKM && ConvertirDistancia(_distanciaPrimerEstrella, "al") <= _primerEstrella.limiteSuperiorKM
                        || ConvertirDistancia(_distanciaSegundaEstrella, "al") >= _segundaEstrella.limiteInferiorKM && ConvertirDistancia(_distanciaSegundaEstrella, "al") <= _segundaEstrella.limiteSuperiorKM;
            }

            if (condicion1 && condicion2 && condicion3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return $"N°{_id} Planeta {_nombre}";
        }
    }
}