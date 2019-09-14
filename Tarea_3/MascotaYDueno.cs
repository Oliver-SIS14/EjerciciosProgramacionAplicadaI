using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios_programacionAplicadaI.Tarea_3
{
    public partial class MascotaYDueno : Form
    {
        public MascotaYDueno()
        {
            InitializeComponent();
        }
        public struct Dueño //Estructura a enlazar
        {
            public string nombreDueño;
            public string ApellidoDueño;
            public string telefono;
            public string direccion;
        }


        public struct Mascota //Estructura principal
        {
            public string nombre;
            public string marca;
            public Dueño informacionDeDueño;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();

            mascota.nombre = NombreMascotaTextBox.Text;
            mascota.marca = MarcaMascotaTextBox.Text;
            mascota.informacionDeDueño.nombreDueño = NombreDuenoTextBox.Text;
            mascota.informacionDeDueño.ApellidoDueño = ApellidoTextBox.Text;
            mascota.informacionDeDueño.direccion = DireccionTextBox.Text;
            mascota.informacionDeDueño.telefono = TelefonoTextBox.Text;

            MessageBox.Show("Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
