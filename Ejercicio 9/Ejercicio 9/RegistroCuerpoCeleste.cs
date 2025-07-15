using ObservatorioDLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ejercicio_9
{
    public partial class RegistroCuerpoCeleste: Form
    {
        public RegistroCuerpoCeleste()
        {
            InitializeComponent();
        }

        private void RegistroCuerpoCeleste_Load(object sender, EventArgs e)
        {

        }

        private Observatorio _obsRegistroCuerpoCeleste = new Observatorio();

        public Observatorio observatorioRegistroCuerpoCeleste
        {
            get { return _obsRegistroCuerpoCeleste; }
            set { _obsRegistroCuerpoCeleste = value;
                InicializarMenuCarga();
            }
        }

        public CuerpoCeleste CuerpoCelesteActual()
        {
            if (dgvObjetosEncontrados.SelectedCells.Count > 0)
            {
                var celda = dgvObjetosEncontrados.SelectedCells[0];
                var fila = dgvObjetosEncontrados.Rows[celda.RowIndex];
                CuerpoCeleste objetoActual = fila.DataBoundItem as CuerpoCeleste;
                return objetoActual;
            }
            else
            {
                txtCuerpoCelesteAEditar.Clear();
                return null;
            }
        }

        public Registro RegistrarObjetoEncontrado(Descubridor descubridor, CuerpoCeleste objetoEncontrado)
        {
            Registro nuevoRegistro = new Registro(objetoEncontrado, descubridor, DateTime.Now, 0);
            return nuevoRegistro;
        }

        public void InicializarMenuCarga()
        {
            dgvObjetosEncontrados.DataSource = null;
            dgvObjetosEncontrados.DataSource = _obsRegistroCuerpoCeleste.objetosEncontrados.ToArray();

            cmbCuerpoCelesteCarga.Items.Clear();
            cmbCuerpoCelesteCarga.Items.Add("Estrella");
            cmbCuerpoCelesteCarga.Items.Add("Planeta");
            cmbCuerpoCelesteCarga.Items.Add("Satelite");

            cmbObservadorCarga.DataSource = null;
            cmbObservadorCarga.DataSource = _obsRegistroCuerpoCeleste.descubridores.ToArray();

            bloquearTabCarga = false;
            bloquearTabEstrella = true;
            bloquearTabPlaneta = true;
            bloquearTabSatelite = true;
            tabControl1.SelectTab(tabCargaCuerpoCeleste);
        }

        bool bloquearTabCarga = false;
        bool bloquearTabEstrella = true;
        bool bloquearTabPlaneta = true;
        bool bloquearTabSatelite = true;

        bool esCarga = false;
        bool esEditar = false;
        bool esPlaneta = false;

        private void PrepararEdicionEstrella()
        {
            bloquearTabCarga = true;
            bloquearTabPlaneta = true;
            bloquearTabEstrella = false;
            tabControl1.SelectTab(tabEditarEstrella);

            cmbColorEstrella.Items.Clear();
            cmbColorEstrella.Items.Add(ObservatorioDLL.Color.Rojo);
            cmbColorEstrella.Items.Add(ObservatorioDLL.Color.Naranja);
            cmbColorEstrella.Items.Add(ObservatorioDLL.Color.Amarillo);
            cmbColorEstrella.Items.Add(ObservatorioDLL.Color.Blanco);
            cmbColorEstrella.Items.Add(ObservatorioDLL.Color.Azul);

            cmbTipoEstrella.Items.Clear();
            cmbTipoEstrella.Items.Add(TipoEstrella.Enana);
            cmbTipoEstrella.Items.Add(TipoEstrella.Gigante);
        }

        private void PrepararEdicionPlaneta()
        {
            bloquearTabCarga = true;
            bloquearTabEstrella = true;
            bloquearTabSatelite = true;
            bloquearTabPlaneta = false;
            tabControl1.SelectTab(tabEditarPlaneta);
        }

        private void PrepararEdicionSatelite()
        {
            bloquearTabCarga = true;
            bloquearTabPlaneta = true;
            bloquearTabSatelite = false;
            tabControl1.SelectTab(tabEditarSatelite);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if(cmbObservadorCarga.SelectedItem == null)
            {
                MessageBox.Show("Por favor, indique qué descubridor encontró el cuerpo celeste.", "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(cmbCuerpoCelesteCarga.SelectedItem == null)
            {
                MessageBox.Show("Por favor, indique qué cuerpo celeste se encontró.", "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txtNombre.Text)
                    || string.IsNullOrWhiteSpace(txtEdad.Text)
                    || string.IsNullOrWhiteSpace(txtMasa.Text))
            {
                MessageBox.Show("Por favor, completar los campos de datos del objeto encontrado", "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!(int.TryParse(txtEdad.Text, out int numero)
                    && int.TryParse(txtMasa.Text, out int numero2)))
            {
                MessageBox.Show("Los valores no son numericos", "Error de operación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                esCarga = true;
                if (cmbCuerpoCelesteCarga.SelectedItem is "Estrella")
                {
                    PrepararEdicionEstrella();
                }
                else if (cmbCuerpoCelesteCarga.SelectedItem is "Planeta")
                {
                    PrepararEdicionPlaneta();
                }
                if (cmbCuerpoCelesteCarga.SelectedItem is "Satelite")
                {
                    PrepararEdicionSatelite();
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtNombreAEditar.Text)
                || string.IsNullOrWhiteSpace(txtEdadAEditar.Text)
                || string.IsNullOrWhiteSpace(txtMasaAEditar.Text))
            {
                MessageBox.Show("Por favor, completar los campos de datos del objeto que quieres editar", "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(!(int.TryParse(txtEdadAEditar.Text,out int numero)
                && int.TryParse(txtMasaAEditar.Text,out int numero2)))
            {
                MessageBox.Show("Los valores no son numericos", "Error de operación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (CuerpoCelesteActual() == null)
            {
                MessageBox.Show("Por favor, seleccionar un objeto de la tabla para editarlo", "Error de operación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                esEditar = true;
                CuerpoCeleste objetoAEditar = CuerpoCelesteActual();

                if (objetoAEditar is Estrella)
                {
                    PrepararEdicionEstrella();
                }
                else if (objetoAEditar is Planeta)
                {
                    PrepararEdicionPlaneta();
                }
                if (objetoAEditar is Satelite)
                {
                    PrepararEdicionSatelite();
                }
            }
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (bloquearTabCarga && e.TabPage == tabCargaCuerpoCeleste)
            {
                e.Cancel = true;
                MessageBox.Show("Esta pestaña está deshabilitada", "Error de Operación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (bloquearTabEstrella && e.TabPage == tabEditarEstrella)
            {
                e.Cancel = true;
                MessageBox.Show("Esta pestaña está deshabilitada", "Error de Operación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (bloquearTabPlaneta && e.TabPage == tabEditarPlaneta)
            {
                e.Cancel = true;
                MessageBox.Show("Esta pestaña está deshabilitada", "Error de Operación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (bloquearTabSatelite && e.TabPage == tabEditarSatelite)
            {
                e.Cancel = true;
                MessageBox.Show("Esta pestaña está deshabilitada", "Error de Operación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvObjetosEncontrados_SelectionChanged(object sender, EventArgs e)
        {
            CuerpoCeleste objetoActual = CuerpoCelesteActual();
            if (objetoActual != null)
            {
                txtCuerpoCelesteAEditar.Text = objetoActual.ToString();
            }
        }

        private void btnEditarEstrella_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtTemperaturaEstrella.Text)
                || string.IsNullOrWhiteSpace(txtDiametroEstrella.Text)
                || string.IsNullOrWhiteSpace(txtConstelacion.Text))
            {
                MessageBox.Show("Por favor, completar los campos de datos de la estrella", "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(cmbColorEstrella.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un color", "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(cmbTipoEstrella.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un  tipo", "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(!(double.TryParse(txtTemperaturaEstrella.Text, out double numero)
                && int.TryParse(txtDiametroEstrella.Text, out int numero2)))
            {
                MessageBox.Show("Los valores no son numericos", "Error de operación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(esCarga)
                {
                    CuerpoCeleste nuevaEstrella = new Estrella(txtNombre.Text, Convert.ToInt32(txtEdad.Text), Convert.ToInt32(txtMasa.Text), Convert.ToDouble(txtTemperaturaEstrella.Text), Convert.ToInt32(txtDiametroEstrella.Text), (ObservatorioDLL.Color)cmbColorEstrella.SelectedItem, (TipoEstrella)cmbTipoEstrella.SelectedItem)
                    {
                        nombreConstelacion = txtConstelacion.Text
                    };
                    _obsRegistroCuerpoCeleste.registros.Add(RegistrarObjetoEncontrado((Descubridor)cmbObservadorCarga.SelectedItem, nuevaEstrella));
                    _obsRegistroCuerpoCeleste.objetosEncontrados.Add(nuevaEstrella);
                    MessageBox.Show("Se guardó la nueva estrella con éxito!", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InicializarMenuCarga();
                    esCarga = false;
                }
                else if(esEditar)
                {
                    if (_obsRegistroCuerpoCeleste.objetosEncontrados.Contains(CuerpoCelesteActual()))
                    {
                        int indice = _obsRegistroCuerpoCeleste.objetosEncontrados.FindIndex(o => o.id == CuerpoCelesteActual().id);
                        _obsRegistroCuerpoCeleste.objetosEncontrados[indice] = new Estrella(txtNombreAEditar.Text, Convert.ToInt32(txtEdadAEditar.Text), Convert.ToInt32(txtMasaAEditar.Text), Convert.ToDouble(txtTemperaturaEstrella.Text), Convert.ToInt32(txtDiametroEstrella.Text), (ObservatorioDLL.Color)cmbColorEstrella.SelectedItem, (TipoEstrella)cmbTipoEstrella.SelectedItem)
                        {
                            nombreConstelacion = txtConstelacion.Text
                        };
                        MessageBox.Show("Se editó la estrella con éxito!", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        InicializarMenuCarga();
                    }
                    esEditar = false;
                }
                else if(esPlaneta)
                {
                    CuerpoCeleste nuevaEstrella = new Estrella($"Estrella empty from Planeta", 0, 0, Convert.ToDouble(txtTemperaturaEstrella.Text), Convert.ToInt32(txtDiametroEstrella.Text), (ObservatorioDLL.Color)cmbColorEstrella.SelectedItem, (TipoEstrella)cmbTipoEstrella.SelectedItem)
                    {
                        nombreConstelacion = txtConstelacion.Text
                    };
                    _obsRegistroCuerpoCeleste.objetosEncontrados.Add(nuevaEstrella);
                    _obsRegistroCuerpoCeleste.registros.Add(RegistrarObjetoEncontrado((Descubridor)cmbObservadorCarga.SelectedItem, nuevaEstrella));
                    MessageBox.Show("Se guardó la nueva estrella con éxito!", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PrepararEdicionPlaneta();

                    int cantidadDeEstrellas = _obsRegistroCuerpoCeleste.objetosEncontrados.Count(est => est is Estrella);

                    if (cantidadDeEstrellas > 0)
                    {
                        lstEstrellasNoAsignadas.DataSource = null;
                        List<Estrella> listaFiltrada = _obsRegistroCuerpoCeleste.objetosEncontrados.OfType<Estrella>().OrderBy(est => est.id).ToList();
                            /*(from Estrella estrella in _obsRegistroCuerpoCeleste.objetosEncontrados
                            where estrella is Estrella
                            orderby estrella.id ascending
                            select (Estrella)estrella).ToList();
                            */
                        lstEstrellasNoAsignadas.DataSource = listaFiltrada;
                    }

                    esPlaneta = false;
                    esCarga = true;
                }
                txtTemperaturaEstrella.Clear();
                txtDiametroEstrella.Clear();
                txtConstelacion.Clear();
            }
        }

        private void checkConstelacion_CheckedChanged(object sender, EventArgs e)
        {
            if(checkConstelacion.Checked == true)
            {
                groupBox5.Visible = true;
            }
            else
            {
                groupBox5.Visible = false;
            }
        }

        private void btnCrearConstelacion_Click(object sender, EventArgs e)
        {
            if (!lstConstelaciones.Items.Contains(txtNuevaConstelacion.Text))
            {
                lstConstelaciones.Items.Add(txtNuevaConstelacion.Text);
                txtNuevaConstelacion.Clear();
            }
            else
            {
                MessageBox.Show("Ya existe esta constelación", "Error de operación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAsignarConstelación_Click(object sender, EventArgs e)
        {
            if(lstConstelaciones.SelectedItem != null)
            {
                txtConstelacion.Text = lstConstelaciones.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una constelación de la lista", "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdEstrella_CheckedChanged(object sender, EventArgs e)
        {
            if(rdEstrella.Checked == true)
            {
                List<Estrella> listaFiltrada = _obsRegistroCuerpoCeleste.objetosEncontrados.OfType<Estrella>().OrderBy(est => est.id).ToList();
                dgvObjetosEncontrados.DataSource = listaFiltrada;
                dgvObjetosEncontrados.Columns["limiteInferiorKM"].Visible = false;
                dgvObjetosEncontrados.Columns["limiteSuperiorKM"].Visible = false;
            }
        }

        private void rdPlaneta_CheckedChanged(object sender, EventArgs e)
        {
            if (rdPlaneta.Checked == true)
            {
                List<Planeta> listaFiltrada = _obsRegistroCuerpoCeleste.objetosEncontrados.OfType<Planeta>().OrderBy(p => p.id).ToList();
                dgvObjetosEncontrados.DataSource = listaFiltrada;
                dgvObjetosEncontrados.Columns["distanciaPrimerEstrella"].Visible = false;
                dgvObjetosEncontrados.Columns["distanciaSegundaEstrella"].Visible = false;
            }
        }

        private void rdSatelite_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSatelite.Checked == true)
            {
                List<Satelite> listaFiltrada = _obsRegistroCuerpoCeleste.objetosEncontrados.OfType<Satelite>().OrderBy(s => s.id).ToList();
                dgvObjetosEncontrados.DataSource = listaFiltrada;
            }
        }

        private void rdDefault_CheckedChanged(object sender, EventArgs e)
        {
            if(rdDefault.Checked == true)
            {
                InicializarMenuCarga();
            }
        }

        private void lnkAgregarEstrella_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            esCarga = false;
            esPlaneta = true;
            PrepararEdicionEstrella();
        }

        private void lnkAgregarSatelite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            esCarga = false;
            esPlaneta = true;
            PrepararEdicionSatelite();
        }

        private void rdSimple_CheckedChanged(object sender, EventArgs e)
        {
            if(rdSimple.Checked == true)
            {

            }
        }

        private void rdBinario_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBinario.Checked == true)
            {
                label22.Visible = true;
                txtDistanciaSegundaEstrella.Visible = true;
            }
            else
            {
                label22.Visible = false;
                txtDistanciaSegundaEstrella.Visible = false;
            }
        }

        private void btnConfirmarPlaneta_Click(object sender, EventArgs e)
        {
            if(rdBinario.Checked == true)
            {
                if (lstEstrellasAsignadas.Items.Count == 2
                    && lstSatelitesAsignados.Items.Count > 0)
                {
                    if (!string.IsNullOrWhiteSpace(txtTemperaturaPlaneta.Text)
                        && !string.IsNullOrWhiteSpace(txtDistanciaPrimerEstrella.Text)
                        && !string.IsNullOrWhiteSpace(txtDistanciaSegundaEstrella.Text)
                        && int.TryParse(txtTemperaturaPlaneta.Text, out int numero)
                        && double.TryParse(txtDistanciaPrimerEstrella.Text, out double numero2)
                        && double.TryParse(txtDistanciaSegundaEstrella.Text, out double numero3))
                    {
                        Estrella primerEstrella = lstEstrellasAsignadas.Items[0] as Estrella;
                        Estrella segundaEstrella = lstEstrellasAsignadas.Items[1] as Estrella;
                        double distanciaPrimerEstrella = Convert.ToDouble(txtDistanciaPrimerEstrella.Text);
                        double distanciaSegundaEstrella = Convert.ToDouble(txtDistanciaSegundaEstrella.Text);
                        List<Satelite> satelitesAsignados = lstSatelitesAsignados.Items.Cast<Satelite>().ToList();

                        if (esCarga)
                        {
                            CuerpoCeleste nuevoPlaneta = new Planeta(txtNombre.Text, Convert.ToInt32(txtEdad.Text), Convert.ToInt32(txtMasa.Text), Convert.ToInt32(txtTemperaturaPlaneta.Text), true)
                            {
                                primerEstrella = primerEstrella,
                                segundaEstrella = segundaEstrella,
                                distanciaPrimerEstrella = distanciaPrimerEstrella,
                                distanciaSegundaEstrella = distanciaSegundaEstrella,
                                satelites = satelitesAsignados
                            };

                            _obsRegistroCuerpoCeleste.registros.Add(RegistrarObjetoEncontrado((Descubridor)cmbObservadorCarga.SelectedItem, nuevoPlaneta));
                            _obsRegistroCuerpoCeleste.objetosEncontrados.Add(nuevoPlaneta);
                            MessageBox.Show("Se guardó el nuevo planeta con éxito!", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            InicializarMenuCarga();
                            esCarga = false;
                        }
                        else if(esEditar)
                        {
                            if (_obsRegistroCuerpoCeleste.objetosEncontrados.Contains(CuerpoCelesteActual()))
                            {
                                int indice = _obsRegistroCuerpoCeleste.objetosEncontrados.FindIndex(o => o.id == CuerpoCelesteActual().id);
                                _obsRegistroCuerpoCeleste.objetosEncontrados[indice] = new Planeta(txtNombreAEditar.Text, Convert.ToInt32(txtEdadAEditar.Text), Convert.ToInt32(txtMasaAEditar.Text), Convert.ToInt32(txtTemperaturaPlaneta.Text), true)
                                {
                                    primerEstrella = primerEstrella,
                                    segundaEstrella = segundaEstrella,
                                    distanciaPrimerEstrella = distanciaPrimerEstrella,
                                    distanciaSegundaEstrella = distanciaSegundaEstrella,
                                    satelites = satelitesAsignados
                                };
                                MessageBox.Show("Se editó el planeta con éxito!", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                InicializarMenuCarga();
                            }
                            esEditar = false;
                        }
                    }
                }
            }
            else
            {
                if (lstEstrellasAsignadas.Items.Count == 1
                    && lstSatelitesAsignados.Items.Count > 0)
                {
                    if (!string.IsNullOrWhiteSpace(txtTemperaturaPlaneta.Text)
                        && !string.IsNullOrWhiteSpace(txtDistanciaPrimerEstrella.Text)
                        && int.TryParse(txtTemperaturaPlaneta.Text, out int numero)
                        && double.TryParse(txtDistanciaPrimerEstrella.Text, out double numero2))
                    {
                        Estrella primerEstrella = lstEstrellasAsignadas.Items[0] as Estrella;
                        double distanciaPrimerEstrella = Convert.ToDouble(txtDistanciaPrimerEstrella.Text);
                        List<Satelite> satelitesAsignados = lstSatelitesAsignados.Items.Cast<Satelite>().ToList();

                        if (esCarga)
                        {
                            CuerpoCeleste nuevoPlaneta = new Planeta(txtNombre.Text, Convert.ToInt32(txtEdad.Text), Convert.ToInt32(txtMasa.Text), Convert.ToInt32(txtTemperaturaPlaneta.Text))
                            {
                                primerEstrella = primerEstrella,
                                distanciaPrimerEstrella = distanciaPrimerEstrella,
                                satelites = satelitesAsignados
                            };

                            _obsRegistroCuerpoCeleste.registros.Add(RegistrarObjetoEncontrado((Descubridor)cmbObservadorCarga.SelectedItem, nuevoPlaneta));
                            _obsRegistroCuerpoCeleste.objetosEncontrados.Add(nuevoPlaneta);
                            MessageBox.Show("Se guardó el nuevo planeta con éxito!", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            InicializarMenuCarga();
                            esCarga = false;

                        }
                        else if (esEditar)
                        {
                            if (_obsRegistroCuerpoCeleste.objetosEncontrados.Contains(CuerpoCelesteActual()))
                            {
                                int indice = _obsRegistroCuerpoCeleste.objetosEncontrados.FindIndex(o => o.id == CuerpoCelesteActual().id);
                                _obsRegistroCuerpoCeleste.objetosEncontrados[indice] = new Planeta(txtNombreAEditar.Text, Convert.ToInt32(txtEdadAEditar.Text), Convert.ToInt32(txtMasaAEditar.Text), Convert.ToInt32(txtTemperaturaPlaneta.Text))
                                {
                                    primerEstrella = primerEstrella,
                                    distanciaPrimerEstrella = distanciaPrimerEstrella,
                                    satelites = satelitesAsignados
                                };
                                MessageBox.Show("Se editó el planeta con éxito!", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                InicializarMenuCarga();
                            }
                            esEditar = false;
                        }
                    }
                }
            }
        }

        private void btnAsignarEstrella_Click(object sender, EventArgs e)
        {
            if (lstEstrellasNoAsignadas.SelectedItems.Count > 0)
            {
                if(rdBinario.Checked == true && lstEstrellasAsignadas.Items.Count == 1)
                {
                    lstEstrellasAsignadas.Items.Add(lstEstrellasNoAsignadas.SelectedItem);
                }
                else if(lstEstrellasAsignadas.Items.Count == 0)
                {
                    lstEstrellasAsignadas.Items.Add(lstEstrellasNoAsignadas.SelectedItem);
                }
                else
                {
                    MessageBox.Show("No se ha podido asignar la estrella.", "Error de operación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No has seleccionado una estrella para asignarla.", "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAsignarSatelite_Click(object sender, EventArgs e)
        {
            if(lstSatelitesNoAsignados.SelectedItems.Count > 0)
            {
                foreach (var item in lstSatelitesNoAsignados.SelectedItems)
                {
                    if (!lstSatelitesAsignados.Items.Contains(item))
                    {
                        lstSatelitesAsignados.Items.Add(item);
                    }
                }
            }
        }

        private void btnEditarSatelite_Click(object sender, EventArgs e)
        {
            bool poseeAcoplamiento = rdSi.Checked == true;

            if (esCarga)
            {
                CuerpoCeleste nuevoSatelite = new Satelite(txtNombre.Text, Convert.ToInt32(txtEdad.Text), Convert.ToInt32(txtMasa.Text), poseeAcoplamiento);
                _obsRegistroCuerpoCeleste.registros.Add(RegistrarObjetoEncontrado((Descubridor)cmbObservadorCarga.SelectedItem, nuevoSatelite));
                _obsRegistroCuerpoCeleste.objetosEncontrados.Add(nuevoSatelite);
                MessageBox.Show("Se guardó el nuevo satelite con éxito!", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InicializarMenuCarga();
                esCarga = false;
            }
            else if (esEditar)
            {
                if (_obsRegistroCuerpoCeleste.objetosEncontrados.Contains(CuerpoCelesteActual()))
                {
                    int indice = _obsRegistroCuerpoCeleste.objetosEncontrados.FindIndex(o => o.id == CuerpoCelesteActual().id);
                    _obsRegistroCuerpoCeleste.objetosEncontrados[indice] = new Satelite(txtNombreAEditar.Text, Convert.ToInt32(txtEdadAEditar.Text), Convert.ToInt32(txtMasaAEditar.Text), poseeAcoplamiento);
                    MessageBox.Show("Se editó el satelite con éxito!", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InicializarMenuCarga();
                }
                esEditar = false;
            }
            else if (esPlaneta)
            {
                CuerpoCeleste nuevoSatelite = new Satelite($"Satelite empty from Planeta", 0, 0, poseeAcoplamiento);
                _obsRegistroCuerpoCeleste.objetosEncontrados.Add(nuevoSatelite);
                _obsRegistroCuerpoCeleste.registros.Add(RegistrarObjetoEncontrado((Descubridor)cmbObservadorCarga.SelectedItem, nuevoSatelite));
                MessageBox.Show("Se guardó el nuevo satelite con éxito!", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PrepararEdicionPlaneta();

                int cantidadDeSatelites = _obsRegistroCuerpoCeleste.objetosEncontrados.Count(s => s is Satelite);

                if (cantidadDeSatelites > 0)
                {
                    lstSatelitesNoAsignados.DataSource = null;
                    List<Satelite> listaFiltrada2 = _obsRegistroCuerpoCeleste.objetosEncontrados.OfType<Satelite>().OrderBy(s => s.id).ToList();
                        /*(from Satelite satelite in _obsRegistroCuerpoCeleste.objetosEncontrados
                        where satelite is Satelite
                        orderby satelite.id ascending
                        select (Satelite)satelite).ToList();
                        */
                    lstSatelitesNoAsignados.DataSource = listaFiltrada2;
                }

                esPlaneta = false;
                esCarga = true;
            }
        }
    }
}
