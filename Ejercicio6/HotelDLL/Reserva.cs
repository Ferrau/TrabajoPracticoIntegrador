using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace HotelDLL
{
    public class Reserva
    {
        public Reserva( List<Huesped> huesped, Habitacion habitacion, DateTime checkIn, int duracion, float deposito)
        {
            _habitacion = habitacion;
            _listHuespedes = huesped;
            _fechaReserva = DateTime.Now;
            _checkIn = checkIn;
            _duracion = duracion;
            _deposito = deposito;
            _abonado = false;
            _montoTotal = 0.0f;
            

        
        }
        
        private Habitacion _habitacion;

        public Habitacion Habitacion
        {
            get { return _habitacion; }
            set { _habitacion = value; }
        }

        private List<Huesped> _listHuespedes;

        public List<Huesped> ListHuespedes
        {
            get { return _listHuespedes; }
            set { _listHuespedes = value; }
        }


        private DateTime _checkIn;

        public DateTime CheckIn
        {
            get { return _checkIn; }
        }

        private DateTime _checkOut;

        //PREGUNTAR 
        public DateTime CheckOut
        {
            //Se calcula automaticamente en el get
            get { return _checkIn.AddDays(_duracion); }
           
          
        }
        private DateTime _fechaReserva;

        public DateTime FechaReserva
        {
            get { return _fechaReserva; }
            
        }

        private float _deposito;

        public float Deposito
        {
            get { return _deposito; }
            
        }

        //LO CONOCE LA CLASE PRINCIPAL Y SUS HERENCIAS
        protected float _montoTotal;

        public float MontoTotal
        {
            get { return _montoTotal; }
           
        }

        protected int _duracion;

        public int Duracion
        {
            get { return _duracion; }
            set { _duracion = value; }
        }

        //PROTECTED: Solo lo conoce la clase principal y sus herencias.
        protected bool _abonado;

        public bool Abonado
        {
            get { return _abonado; }
           
        }


        //Se hace un polimorfismo con VIRTUAL porque la reserva puede ser de un tipo o de otro, pero el pago es el mismo.
        public virtual bool Pagar()
        {
            //Se tiene que realizar el pago
            if (!_abonado)
            {
                _montoTotal += _habitacion.Valor * _duracion; //lo multiplicamos asi porque es por noche y restamos el depósito al monto total
                _abonado = true;

            }
            return _abonado;
            
        }


        public float Cancelar()
        {
            float minimo = _montoTotal * 0.1f;
            TimeSpan diferencia = _checkIn - DateTime.Now;
            //a) inferior a los dos días el valor del depósito se pierde
            //(sólo el 10 % de mínimo) el resto se devuelve.
            if (diferencia.TotalDays < 2)
            {
                return _deposito - minimo;

            }else if (diferencia.TotalDays < 7 && diferencia.TotalDays >= 2)
            {
                //b) Si se encuentra dentro de la semana, se reintegra el 50 % del mínimo más el excedente de ese depósito.
                minimo = _deposito * 0.5f;
                return _deposito - minimo;
            }
            else
            {
                //c) Si es mayor de una semana se reintegra el total del valor depositado.
                return _deposito;

            }




        }



    }
}