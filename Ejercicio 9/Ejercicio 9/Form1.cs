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

namespace Ejercicio_9
{
    public partial class Form1: Form
    {
        #region Consigna
        /*
         Un observatorio astronómico necesita un sistema para poder registrar los diferentes cuerpos celestes encontrados.
		 Los diferentes elementos observados son: estrellas, planetas y satélites naturales.
		 Cada registro debe dejar asentado: fecha del encuentro, persona que lo observó,
		 objeto encontrado y la distancia expresada en años luz desde la tierra. Los objetos a registrar se describen a continuación:
			• Estrellas:
				o Masa.
				o Temperatura expresada en grados Celsius.
				o Edad.
				o Diámetro.
				o Nombre.
				o Color (Roja, Naranja , Amarilla, Blanca , Azul)
				o Tipo de estrella (Enana - Gigante)
			• Planetas:
				o Masa.
				o Edad.
				o Temperatura.
				o En caso de pertenecer a un sistema planetario, pueden contener satélites.
			• Planetas dentro de un sistema planetario simple:
				o Orbita alrededor de 1 estrella.
				o Distancia en años luz a con respecto a la estrella que orbita.
				o Satélites.
				o Determinar si se encuentra en la zona “Ricitos de oro”
				o Determinar si en función de la temperatura, elementos de la atmosfera y la zona es potencialmente habitable.
			• Planetas dentro de un sistema planetario Binario:
				o Orbita alrededor de 2 estrellas.
				o Determina también la distancia con respecto a la segunda estrella.
			• Satélites:
				o Nombre.
				o Indicar si posee acoplamiento de marea.
				o Masa.
				o Edad.
		 Cada sistema de estrellas se deberá agrupar dentro de una constelación.
		 Del descubridor del cuerpo celeste se registrará el nombre, apellido, fecha de nacimiento
		 y por último el legajo en caso de ser personal del observatorio.

		 Desarrollar una aplicación Orientada a Objetos utilizando C# que permita:
				1) Carga y edición de los diferentes cuerpos celestes. {OK}
				2) Convertir dinámicamente años luz en kilómetros y viceversa. {OK}
				3) Convertir dinámicamente las temperaturas de Grados Celsius a Fanrenheit y viceversa. {OK}
				4) Buscar planetas por:
					a. Nombre.
					b. Estrella en la que orbita.
					c. Potencialmente habitables.
				5) Buscar estrellas por:
					a. Tipo basado en el color y Tipo.
					b. Temperatura.
					c. Constelación.
				6) De cada búsqueda mostrar toda la información con de dicho cuerpo celeste.
         */
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

		private Observatorio _obsAstronomico = new Observatorio();

		public Observatorio observatorioAstronomico
		{
			get { return _obsAstronomico; }
			set { _obsAstronomico = value; }
		}

		private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
			Application.Exit();
        }

        private void administracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
			Administracion frmAdm = new Administracion();
			frmAdm.observatorioAdm = _obsAstronomico;
			frmAdm.MdiParent = this;
			frmAdm.Show();
        }

        private void descubridorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroDescubridor frmAdm = new RegistroDescubridor();
            frmAdm.observatorioRegistroDescubridor = _obsAstronomico;
            frmAdm.MdiParent = this;
            frmAdm.Show();
        }

        private void cuerpoCelesteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroCuerpoCeleste frmAdm = new RegistroCuerpoCeleste();
            frmAdm.observatorioRegistroCuerpoCeleste = _obsAstronomico;
            frmAdm.MdiParent = this;
            frmAdm.Show();
        }
    }
}
