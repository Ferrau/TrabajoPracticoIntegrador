using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObservatorioDLL
{
    public interface IBinario : ISistemaPlanetario
    {
        Estrella segundaEstrella { get; set; }

        double distanciaSegundaEstrella { get; set; }
    }
}