using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelDLL
{
    public class Habitacion
    {
        //Constructor inicializamos cada una de las habitaciones
        public Habitacion( TipoHabitacion tipo, bool vistaAlMar = false)
        {
            
            _tipo = tipo;
            countNumero++;
            _numero = countNumero;
            _cantidadVecesReservado = 0;


            if (_tipo == TipoHabitacion.Simple)
            {
                _valor = 200;
               

            }else if(_tipo == TipoHabitacion.Doble)
            {
                _valor = 350;
               
            }else if(_tipo == TipoHabitacion.Tiple)
            {
                _valor = 550;
                
            }
            else
            {
                _valor = 700;

            }
            _vistaAlMar = vistaAlMar;
            if (vistaAlMar)
            {
                _descuento = 0.15f; // 15% de descuento
                _valor -= _valor * _descuento;
            }
          
            
        }

        private TipoHabitacion _tipo;

        public TipoHabitacion Tipo
        {
            get { return _tipo; }
           
        }

        private float _valor;

        public float Valor
        {
            get { return _valor; }
           
        }

        private static int countNumero = 0;

        private int _numero;

        public int Numero
        {
            get { return _numero; }
       
        }


        private bool _vistaAlMar;

        public bool VistaAlMar
        {
            get { return _vistaAlMar; }
         
        }

        private float _descuento;

        public float Descuento
        {
            get { return _descuento; }

        }
        private int _cantidadVecesReservado;

        public int CantidadVecesReservado
        {
            get { return _cantidadVecesReservado; }
           
        }


        public void Reservar()
        {
            _cantidadVecesReservado++;
        }
    }
}