using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelDLL
{
    public class HotelTuristico
    {
        public HotelTuristico()
        {
            _reservas = new List<Reserva>();
            _habitaciones = new List<Habitacion>();
            _huespedes = new List<Huesped>();
            _recaudacion = 0.0f;
            _abonada = false;
        }
        private List<Reserva> _reservas;

		public List<Reserva> Reservas
		{
			get { return _reservas; }
			
		}

		private List<Habitacion> _habitaciones;

		public List<Habitacion> Habitaciones
		{
			get { return _habitaciones; }
			
		}

		private List<Huesped> _huespedes;

		public List<Huesped> Huespedes
		{
			get { return _huespedes; }
			set { _huespedes = value; }
        }

        private float _recaudacion;

        public float Recaudacion
        {
            get { return _recaudacion; }
        }

        protected bool _abonada;

        public bool Abonada
        {
            get { return _abonada; }
        }


        //11) Controlar que las reservas no se superpongan.
        public bool ValidarReserva(Reserva nuevaReserva)
        {
            //PARKINSON: Que la habitacion este ocupada no es un atributo de la habitacion sino de su contexto. Porque lo sabe la reserva.


            //Verifico si tengo al menos una reserva en mi lista de reservas
            bool ok = !(_reservas.Count > 0);

            if (!ok)
            {
                foreach (Reserva reserva in _reservas)
				{
                    //Verifico si la habitacion de la nueva reserva es igual a la habitacion de la reserva actual
                    if (reserva.Habitacion.Numero == nuevaReserva.Habitacion.Numero)
                    {
                        ok = nuevaReserva.CheckIn >= reserva.CheckOut || nuevaReserva.CheckOut <= reserva.CheckIn;
                    }

                } 
			}
            return ok;
        }


		public bool RegistrarReserva(Reserva nuevaReserva)
		{
			bool ok = nuevaReserva != null;
			if (ok)
            {
                ok = ValidarReserva(nuevaReserva);
				if (ok)
				{
					foreach (Huesped huesped in nuevaReserva.ListHuespedes)
					{
						huesped.Hospedar();
					}
					nuevaReserva.Habitacion.Reservar();
                    _reservas.Add(nuevaReserva);
                }
				


            }
			return ok;
		}

        public bool RegistrarCancelacion(Reserva reservaCancelada)
        {
            bool ok = false;
            if (!reservaCancelada.Abonado && DateTime.Now < reservaCancelada.CheckIn)
            {
                _recaudacion = reservaCancelada.Cancelar();
                _reservas.Remove(reservaCancelada);
                ok = true;
            }
            return ok;
        }

        public bool RegistrarPago(Reserva reservaPagoPendiente)
        {
            bool ok = reservaPagoPendiente.Abonado;
            if (!ok)
            {
                reservaPagoPendiente.Pagar();
                _recaudacion = reservaPagoPendiente.MontoTotal;
            }
            return ok;
        }

        //7) Mostrar que habitación se solicitó más en el lapso de un periodo de fechas.
        public Habitacion MostrarHabitacionMasSolicitada(DateTime fechaInicio, DateTime fechaFin)
		{
            Habitacion habitacionMasSolicitada = null;

            var reservasPeriodo = (from Reserva reserva in _reservas
                                   where reserva.CheckIn < fechaFin && reserva.CheckOut > fechaInicio
                                   select reserva).ToList();
			List<Habitacion> habitacionesValidas = new List<Habitacion>();
            foreach (Reserva reserva in reservasPeriodo)
            {
                habitacionesValidas.Add(reserva.Habitacion);
            }
            if (habitacionesValidas.Count > 0)
            {
                var habitaciones = (from Habitacion habitacion in habitacionesValidas
                         orderby habitacion.CantidadVecesReservado descending
                         select habitacion).Take(1).ToList();
                 habitacionMasSolicitada = habitaciones.FirstOrDefault();
            }
           
            return habitacionMasSolicitada;
        }



        //8) Mostrar el integrante que se hospedó mayor cantidad de veces en el hotel.
        public Huesped MostrarHuespedMayorVecesHospedado()
		{

			Huesped huespedMasHospedado = null;
			foreach (Huesped huesped in _huespedes)
			{
                if (huesped.CantidadVecesHospedado > huespedMasHospedado.CantidadVecesHospedado)
                {
                    huespedMasHospedado = huesped;
                }
            }
            return huespedMasHospedado;
        
        }

        //9) Obtener la recaudación total del hotel filtrada por períodos de fechas.
        public float RecaudacionPorFecha(DateTime inicio, DateTime fin)
        {
            var reservasPeriodo = (from Reserva reserva in _reservas
                                   where reserva.CheckIn < fin && reserva.CheckOut > inicio
                                   select reserva).ToList();

            float recaudacion = 0.0f;
            foreach (Reserva reserva in reservasPeriodo)
            {
                recaudacion += reserva.MontoTotal;
            }
            return recaudacion;
        }


    }
}