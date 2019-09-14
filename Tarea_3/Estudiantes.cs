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
    public partial class Estudiantes : Form
    {
        public Estudiantes()
        {
            InitializeComponent();
        }

        public class Estudiante
        {
            public string Matricula { get; set; }
            public string Nombre { get; set; }
            public string Carrera { get; set; }
            
            public Estudiante()
            {

            }
            public void AnadirEstudiante(Estudiante est)
            {
                Matricula = est.Matricula;
                Nombre = est.Nombre;
                Carrera = est.Carrera;
            }
        }
        private void Limpiar()
        {
            NombreTextBox.Text = string.Empty;
            MatriculaTextBox.Text = string.Empty;
            CarreraTextBox.Text = string.Empty;
        }
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Estudiante est = new Estudiante();

            est.Nombre = NombreTextBox.Text;
            est.Matricula = MatriculaTextBox.Text;
            est.Carrera = CarreraTextBox.Text;

            Limpiar();

            EstudiantesDataGridView.Rows.Add(est.Nombre, est.Matricula, est.Carrera);
        }
    }
}
