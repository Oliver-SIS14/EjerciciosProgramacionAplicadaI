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
    public partial class ProductosTienda : Form
    {
        public ProductosTienda()
        {
            InitializeComponent();
        }

        public struct Productos //Estructura para guardar los productos
        {
            public int codigo;
            public string nombre;
            public string marca;
            public decimal precio;
        }
        
        void Limpiar()
        {
            CodigoTextBox.Text = string.Empty;
            NombreTextBox.Text = string.Empty;
            MarcaTextBox.Text = string.Empty;
            PrecioTextBox.Text = string.Empty;
        }
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Productos prod = new Productos();

            prod.codigo = Convert.ToInt32(prod.codigo);
            prod.marca = MarcaTextBox.Text;
            prod.nombre = NombreTextBox.Text;
            prod.precio = Convert.ToDecimal(PrecioTextBox.Text);

            Limpiar();

            DataGridViewProductos.Rows.Add(prod.codigo, prod.nombre, prod.marca, prod.precio);
        }
    }
}
