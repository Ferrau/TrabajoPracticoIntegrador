using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelDLL;

namespace Ejercicio6
{
    public partial class GestionReserva : Form
    {
        public GestionReserva()
        {
            InitializeComponent();
        }

        private void GestionReserva_Load(object sender, EventArgs e)
        {
            ActualizarHabitaciones();
            ActualizarHuespedes();
        }

        private HotelTuristico _gReservas = new HotelTuristico();

        public HotelTuristico gReservas
        {
            get { return _gReservas; }
            set
            {
                _gReservas = value;
                InicializarReservas();
            }
        }

        private void btnReservarConAdicionales_Click(object sender, EventArgs e)
        {
            if (ValidarReserva() && ValidarAdicionales())
            {
                List<Huesped> integrantes = new List<Huesped>();
                foreach (Huesped huesped in lstHuespedes.SelectedItems)
                {
                    integrantes.Add(huesped);
                }
                Habitacion habitacion = HabitacionActual();
                DateTime inicio = dtFechaInicio.Value;
                int duracion = Convert.ToInt32(numDuracion.Value);
                float deposito = (float)numDeposito.Value;
                List<Adicional> adicionales = new List<Adicional>();
                foreach (Adicional ad in lstAdicionales.SelectedItems)
                {
                    adicionales.Add(ad);
                }
                lstAdicionales.Items.Clear();

                ReservaConAdicional nuevaReserva = new ReservaConAdicional(integrantes, habitacion, inicio, duracion, deposito, adicionales);
                bool ok = _gReservas.RegistrarReserva(nuevaReserva);
                if (!ok)
                {
                    MessageBox.Show("Ya se encuentra esta habitación ocupada. Por favor seleccionar otra fecha", "Error de operación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    InicializarReservas();
                    lstHuespedes.Items.Clear();
                }
            }
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            if (ValidarReserva())
            {
                List<Huesped> integrantes = new List<Huesped>();
                foreach (Huesped huesped in lstHuespedes.SelectedItems)
                {
                    integrantes.Add(huesped);
                }
                Habitacion habitacion = HabitacionActual();
                DateTime inicio = dtFechaInicio.Value;
                int duracion = Convert.ToInt32(numDuracion.Value);
                float deposito = (float)numDeposito.Value;

                Reserva nuevaReserva = new Reserva(integrantes, habitacion, inicio, duracion, deposito);
                bool ok = _gReservas.RegistrarReserva(nuevaReserva);
                if (!ok)
                {
                    MessageBox.Show("Ya se encuentra esta habitación ocupada. Por favor seleccionar otra fecha", "Error de operación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    InicializarReservas();
                    lstHuespedes.Items.Clear();
                }
            }
        }

        public bool ValidarAdicionales()
        {
            bool ok = lstAdicionales.Items.Count > 0;
            if (!ok)
            {
                MessageBox.Show("Por favor, agregue los adicionales que desee", "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ok;
        }

        private bool ValidarReserva()
        {
            bool ok;
            if (!(dtFechaInicio.Value > DateTime.Now))
            {
                MessageBox.Show("Por favor, seleccione una fecha posterior a la actual.", "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ok = false;
            }
            else if (!(lstHuespedes.Items.Count > 0))
            {
                MessageBox.Show("No has asignado huespedes para la reserva.", "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ok = false;
            }
            else if (string.IsNullOrWhiteSpace(txtHabitacionSeleccionada.Text))
            {
                MessageBox.Show("No has seleccionado la habitacion a reservar.", "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ok = false;
            }
            else if (!(CalcularDeposito() > 0))
            {
                MessageBox.Show("Ha ocurrido un error al calcular el deposito.", "Error de operación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ok = false;
            }
            else if (!((float)numDeposito.Value >= CalcularDeposito()))
            {
                MessageBox.Show("El deposito que has ingresado es menor al 10%.", "Error de operación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ok = false;
            }
            else
            {
                ok = true;
            }
            return ok;
        }

        private float CalcularDeposito()
        {
            Habitacion habitacionActual = HabitacionActual();
            if (habitacionActual != null)
            {
                int duracionActual = Convert.ToInt32(numDuracion.Value);
                float deposito = (habitacionActual.Valor * duracionActual) * 0.1f;
                numDeposito.Maximum = (decimal)(deposito / 0.1f);
                return deposito;
            }
            else
            {
                return 0;
            }
        }

        private Habitacion HabitacionActual()
        {
            if (dgvHabitaciones.SelectedCells.Count > 0)
            {
                var celda = dgvHabitaciones.SelectedCells[0];
                var fila = dgvHabitaciones.Rows[celda.RowIndex];
                Habitacion habitacionActual = fila.DataBoundItem as Habitacion;
                return habitacionActual;
            }
            else
            {
                //txtHabitacionSeleccionada.Clear();
                return null;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvReservas.SelectedCells.Count > 0)
            {
                var celda = dgvReservas.SelectedCells[0];
                var fila = dgvReservas.Rows[celda.RowIndex];
                Reserva reservaActual = fila.DataBoundItem as Reserva;

                if (_gReservas.RegistrarCancelacion(reservaActual))
                {
                    MessageBox.Show("Se ha cancelado la reserva con exito.", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                InicializarReservas();
            }
        }

        private void InicializarReservas()
        {
            dgvReservas.DataSource = null;
            dgvReservas.DataSource = _gReservas.Reservas.ToList();
        }

        private void ActualizarHuespedes()
        {
            dgvHuespedes.DataSource = null;
            dgvHuespedes.DataSource = _gReservas.Huespedes.ToList();
            dgvHuespedes.Columns["FechaNacimiento"].Visible = false;
            dgvHuespedes.Columns["Edad"].Visible = false;
            dgvHuespedes.Columns["CantidadVecesHospedado"].Visible = false;
            /*
            var datosHuespedes = _gReservas.huespedes.Select(h => new
            {
                h.DNI,
                h.Nombre,
                h.Apellido
            }).ToList();

            dgvHuespedes.DataSource = datosHuespedes;
            */
        }

        private void ActualizarHabitaciones()
        {
            dgvHabitaciones.DataSource = null;
            dgvHabitaciones.DataSource = _gReservas.Habitaciones.ToList();
            dgvHabitaciones.Columns["Valor"].Visible = false;
            dgvHabitaciones.Columns["CantidadVecesReservada"].Visible = false;
            /*
            var datosHabitaciones = _gReservas.habitaciones.Select(h => new
            {
                h.Numero,
                h.Tipo,
                h.VistaAlMar
            }).ToList();

            dgvHabitaciones.DataSource = datosHabitaciones;
            */
        }

        private void dgvHabitaciones_SelectionChanged(object sender, EventArgs e)
        {
            Habitacion habitacionActual = HabitacionActual();
            txtHabitacionSeleccionada.Text = habitacionActual.ToString();
            CalcularDeposito();
            numDeposito.Value = (decimal)CalcularDeposito();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if (dgvHuespedes.Rows.Count > 0)
            {
                foreach (DataGridViewCell celda in dgvHuespedes.SelectedCells)
                {
                    var filasUnicas = dgvHuespedes.SelectedCells
                                      .Cast<DataGridViewCell>()
                                      .Select(c => dgvHuespedes.Rows[c.RowIndex])
                                      .Distinct(); // Evita duplicados

                    foreach (var fila in filasUnicas)
                    {
                        if (fila.DataBoundItem is Huesped huesped)
                        {
                            bool existe = lstHuespedes.Items.Cast<Huesped>().Any(h => h.DNI == huesped.DNI);
                            if (!existe)
                            {
                                lstHuespedes.Items.Add(huesped);
                                MessageBox.Show($"Huésped {huesped.Nombre} listado correctamente!", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay huéspedes registrados aún!", "Error de operación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNombre.Text) && numValor.Value > 0)
            {
                Adicional ad = new Adicional(txtNombre.Text, (float)numValor.Value);
                lstAdicionales.Items.Add(ad);
            }
        }

        private void numDuracion_ValueChanged(object sender, EventArgs e)
        {
            numDeposito.Value = (decimal)CalcularDeposito();
        }
    }
}
