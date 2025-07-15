using HotelDLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio6
{
    public partial class Form1 : Form
    {
        #region Consgina
        /*
         Un hotel turístico requiere de un programa que le permita
           administrar y gestionar las reservas de las diferentes habitaciones que maneja.
           De cada habitación se conoce el número, los diferentes artefactos que posee
           (televisión, aire, frigo bar, etc.), y se categorizan por:
               • Habitación Simple: Posee una cama de una plaza y tiene un costo de $200 por Noche.
               • Habitación Doble Matrimonial: Tiene un costo de $350 por noche y posee una cama de dos plazas.
               • Habitación Triple: Tiene un costo de $550 por noche y posee una cama matrimonial plus y una cama extra.
               • Habitación Cuádruple: Tiene un costo de $700 por noche y posee una cama matrimonial y cama-cucheta.
       
           Hay habitaciones que poseen vista al mar que carecen en un 15% el valor de la misma.
           El adicional de la reserva de la cuna añade $50 por noche.
       
           Desarrollar una aplicación Orientada a Objetos utilizando C# que permita:
           1) OK - Registrar una reserva por habitación con cada uno de los integrantes,
                de los integrantes se conoce el nombre, apellido, la fecha de nacimiento, el DNI y la edad.
           2) Registrar la ocupación de la habitación
           (Primero se realiza la reserva y después tiene que tener otro mecanismo que concrete dicha reserva).
           3) Cargar el depósito de la reserva, el mismo será a partir como mínimo un 10% del total del paquete contratado.
           4) Formulario de cancelación de reserva teniendo en cuenta los siguientes puntos:
               a) Si la cancelación de la reserva es inferior a los dos días el valor del depósito se pierde
               (sólo el 10% de mínimo) el resto se devuelve.
               b) Si se encuentra dentro de la semana, se reintegra el 50% del mínimo más el excedente de ese depósito.
               c) Si es mayor de una semana se reintegra el total del valor depositado.
           5) Cada reserva debe registrar la fecha de checkin, la fecha del checkout, la habitación,
           los integrantes y los adicionales (Por ejemplo: la cuna, el consumo del frigobar, otros consumos).
           6) Los pagos de todos los totales se imputan a la hora de registrar el checkout.
           7) Mostrar que habitación se solicitó más en el lapso de un periodo de fechas.
           8) Mostrar el integrante que se hospedó mayor cantidad de veces en el hotel.
           9) Obtener la recaudación total del hotel filtrada por períodos de fechas.
           10) Obtener la habitación que se ocupó mayor cantidad de veces total y filtrada por fechas.
           11) OK- Controlar que las reservas no se superpongan.
         */

        /*TRY-CATCH: Aca es donde podes capturar los errores que se puedan producir en el programa.*/
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private HotelTuristico _hotelTuristico = new HotelTuristico();

        public HotelTuristico HotelTuristico
        {
            get { return _hotelTuristico; }
           
        }

        //Le voy pasando cada uno de los parametros que necesito para crear una reserva y esto los va a tomar desde el formulario desde los elementos de datos de entrada
        public void AgregarReservas(List<Huesped> huespedes, Habitacion habitacion, DateTime inicio, int duracion, float deposito)
        {
            Reserva reserva = new Reserva(habitacion, huespedes, inicio, duracion, deposito);
            bool ok = _hotelTuristico.RegistrarReserva(reserva);
            if (ok)
            {
                MessageBox.Show("Reserva registrada correctamente.");
            }
            else
            {
                MessageBox.Show("La reserva no se pudo registrar, ya que la habitacion ya esta ocupada en ese periodo.");
            }

        }


        public void RegistratHuesped(long dni, string nombre, string apellido, DateTime fechaNacimeinto)
        {
            Huesped huesped = new Huesped(dni, nombre, apellido, fechaNacimeinto);
            /*Verificamos si no existe en la lista de integrantes, entonce lo registramos*/
            if (!_hotelTuristico.Huespedes.Contains(huesped))
            {
                _hotelTuristico.Huespedes.Add(huesped);
                MessageBox.Show("El Huesped se ha registrado correctamente.");
            }
            else
            {
                MessageBox.Show("El Huesped ya se encuentra registrado.");
            }

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!(MessageBox.Show("Desea salir de la aplicacion?", "Salir de la aplicacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)== DialogResult.Cancel)) 
            {
                Application.Exit();
            }
        }

        private void huespedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHuesped formHuesped = new FormHuesped();
            formHuesped.HotelAdmin = _hotelTuristico; //Le paso la referencia del hotel turistico al formulario de huesped
            formHuesped.MdiParent = this; //Le digo que este formulario es hijo del formulario principal
            formHuesped.Show();

        }

        private void habitaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHabitacion frm = new FormHabitacion();
            frm.HotelAdmin = _hotelTuristico; //Le paso la referencia del hotel turistico al formulario de habitacion
            frm.MdiParent = this; //Le digo que este formulario es hijo del formulario principal
            frm.Show();
        }

        private void reservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionReserva frmGestionReserva = new GestionReserva();
            frmGestionReserva.HotelAdmin = _hotelTuristico; //Le paso la referencia del hotel turistico al formulario de gestion de reserva
            frmGestionReserva.MdiParent = this; //Le digo que este formulario es hijo del formulario principal
            frmGestionReserva.Show();
        }
    }
}