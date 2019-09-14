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
    public partial class SobreCargaPoligono : Form
    {
        public SobreCargaPoligono()
        {
            InitializeComponent();
        }

        public class Poligono2
        {
            public int lados { get; set; }
            public float perimetro { get; set; }
            public float valorLados { get; set; }
            public float apotema { get; set; }
            
            public Poligono2()
            {

            }

            public Poligono2(int lados, float valorLados)
            {
                lados = this.lados;
                valorLados = this.valorLados;
            }
            public Poligono2(int lados, float perimetro, float valorLados, float apotema)
            {
                lados = this.lados;
                perimetro = this.perimetro;
                valorLados = this.valorLados;
                apotema = this.apotema;
            }
            public float CalcularArea(float apotema, float perimetro)
            {
                return (apotema* perimetro)/2;
            }

            public float CalcularPerimetro(int lados, float valorlados)
            {
                return (lados * valorLados);
            }
    }

        public void validar()
        {
            if (string.IsNullOrWhiteSpace(CantidadTextBox.Text) || Convert.ToInt32(CantidadTextBox.Text) < 1)
            {
                MyErrorProvider.SetError(CantidadTextBox, "El campo lados no puede estar vacio");
                CantidadTextBox.Focus();
            }
            if (string.IsNullOrWhiteSpace(ValorTextBox.Text) || Convert.ToInt32(ValorTextBox.Text) < 1) 
            {
                MyErrorProvider.SetError(ValorTextBox, "El campo valor no puede estar vacio");
                ValorTextBox.Focus();
            }
            if (string.IsNullOrWhiteSpace(ApotemaTextBox.Text) || Convert.ToInt32(ApotemaTextBox.Text) < 1)
            {
                MyErrorProvider.SetError(ApotemaTextBox, "El campo apotema no puede estar vacio");
                ApotemaTextBox.Focus();
            }
        }
        public override string ToString() //Tostring metodo
        {
            Poligono2 p2 = new Poligono2();
            String mensaje = "";
            mensaje += "Lados" + p2.lados.ToString() + "valor Lados" + p2.valorLados.ToString() +
            "Apotema" + p2.apotema;
            
            return mensaje;
        }

        private void PerimetroButton_Click(object sender, EventArgs e)
        {
            Poligono2 poligono = new Poligono2();
            validar();
            poligono.lados = Convert.ToInt32(CantidadTextBox.Text);
            poligono.valorLados = Convert.ToSingle(ValorTextBox.Text);
            poligono.perimetro = poligono.CalcularPerimetro(poligono.lados, poligono.valorLados);

            PerimetroTextBox.Text = Convert.ToString(poligono.perimetro);
   
        }

        private void AreaButton_Click(object sender, EventArgs e)
        {
            Poligono2 poligono = new Poligono2();
            validar();
            poligono.lados = Convert.ToInt32(CantidadTextBox.Text);
            poligono.valorLados = Convert.ToSingle(ValorTextBox.Text);
            poligono.perimetro = poligono.CalcularPerimetro(poligono.lados, poligono.valorLados);
            poligono.apotema = Convert.ToSingle(ApotemaTextBox.Text);

            AreaTextBox.Text = Convert.ToString(poligono.CalcularArea(poligono.apotema, poligono.perimetro));
        }

    }

}

