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
    public partial class InventarioTienda : Form
    {
        public InventarioTienda()
        {
            InitializeComponent();
        }

        public class Inventario
        {
            public int codigo;
            public string descripcion;
            public int ExistenciasIniciales;
            public int Entradas;
            public int salidas;
            public int stock;
        }

        private void Limpiar()
        {
            CodigoTextBox.Text = string.Empty;
            DescripcionTextBox.Text = string.Empty;
            ExistenciasTextBox.Text = string.Empty;
            EntradasTextBox.Text = string.Empty;
            SalidasTextBox.Text = string.Empty;
            StockTextBox.Text = string.Empty;
        }
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Inventario inv = new Inventario();

            inv.codigo = Convert.ToInt32(CodigoTextBox.Text);
            inv.descripcion = DescripcionTextBox.Text;
            inv.ExistenciasIniciales = Convert.ToInt32(ExistenciasTextBox.Text);
            inv.Entradas = Convert.ToInt32(EntradasTextBox.Text);
            inv.salidas = Convert.ToInt32(SalidasTextBox.Text);
            inv.stock = Convert.ToInt32(StockTextBox.Text);

            Limpiar();    
            InventarioDataGridView.Rows.Add(inv.codigo, inv.descripcion, inv.ExistenciasIniciales, inv.Entradas, inv.salidas, inv.stock);
              
                   
        }
    }
}
