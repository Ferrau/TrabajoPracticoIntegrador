using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObservatorioDLL
{
    public interface ISistemaPlanetario
    {
        Estrella primerEstrella { get; set; }

        double distanciaPrimerEstrella { get; set; }

        List<Satelite> satelites { get; set; }

        double ConvertirDistancia(double distancia, string unidad);

        double ConvertirTemperatura(double temperatura, string unidad);

        bool EsHabitable(double temperatura, ElementosAtmosfera elementos);
    }
}