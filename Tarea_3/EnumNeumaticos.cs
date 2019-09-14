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
    public partial class EnumNeumaticos : Form
    {
        public EnumNeumaticos()
        {
            InitializeComponent();
        }

        private void SeleccionarButtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usted ha elegido Neumaticos tipo" + (NeumaticoCombobox.Text), "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
