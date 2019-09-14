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
    public partial class MenuTarea3form : Form
    {
        public MenuTarea3form()
        {
            InitializeComponent();
        }

        private void MenuTarea3form_Load(object sender, EventArgs e)
        {
        }

        private void TiposDeNeumaticosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario1 = new EnumNeumaticos();
            formulario1.MdiParent = this;
            formulario1.Show();
        }

        private void InformacionMascotaDueñoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario1 = new MascotaYDueno();
            formulario1.MdiParent = this;
            formulario1.Show();
        }

        private void ProductosDeUnaTiendaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form formulario1 = new ProductosTienda();
            formulario1.MdiParent = this;
            formulario1.Show();
        }

        private void SobreCargaPoligonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario1 = new SobreCargaPoligono();
            formulario1.MdiParent = this;
            formulario1.Show();
        }

        private void InventarioTiendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario1 = new InventarioTienda();
            formulario1.MdiParent = this;
            formulario1.Show();
        }

        private void EstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario1 = new Estudiantes();
            formulario1.MdiParent = this;
            formulario1.Show();
        }

        private void ValoresValidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario1 = new SobreCargaPoligono();
            formulario1.MdiParent = this;
            formulario1.Show();
        }

        private void MetodoToStringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario1 = new SobreCargaPoligono();
            formulario1.MdiParent = this;
            formulario1.Show();
        }

        private void Capitulo12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario1 = new Factorial2();
            formulario1.MdiParent = this;
            formulario1.Show();
        }
    }
}
