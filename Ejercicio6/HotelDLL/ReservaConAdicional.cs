using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelDLL
{
    public class ReservaConAdicional : Reserva
    {
        public ReservaConAdicional(List<Huesped> huesped, Habitacion habitacion, DateTime checkIn, int duracion, float deposito, List<Adicional> adicionales) : base(huesped, habitacion, checkIn, duracion, deposito)
        {

            _listAdicionales = adicionales;

        }

        private List<Adicional> _listAdicionales;

        public List<Adicional> ListAdicionales
        {
            get { return _listAdicionales; }
           
        }

        //Se agrega el valor del adicional al total de la reserva
        public override bool Pagar()
        {
            if(!_abonado)
            {
                foreach (Adicional adicional in _listAdicionales)
                {
                   _montoTotal += adicional.Valor * _duracion;
                }
                
            }
            return base.Pagar();

        }


    }
}