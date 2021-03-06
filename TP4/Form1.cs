using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP4
{
    public partial class SimulacionTP5 : Form
    {
        System.Data.DataTable dt;

        public SimulacionTP5()
        {
            InitializeComponent();
        }

        public double generarNumeroNormal(double media, double desviacion) 
        {
            Random rnd = new Random();
            Double suma = 0;
            for (int j = 0; j < 12; j++)
            {

                Double aleat = Math.Round(Convert.ToDouble(rnd.NextDouble()), 6);
                suma += aleat;
            }
            return ((suma - 6) * desviacion) + media;
        }

        public double generarNumeroUniforme(double desde, double hasta) 
        {
            Random rnd = new Random();
            return desde + (rnd.NextDouble() * (hasta - desde));
        }

        public double generarNumeroExponencial(double media)
        {
            Random rnd = new Random();
            Double nro = Convert.ToDouble(rnd.NextDouble());
            Double lambda = 1 / media;
            Double log = Convert.ToDouble(Math.Log(Convert.ToDouble(1 - nro)));
            return (-1 / lambda) * log;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            simulacion();
        }

        private void simulacion() 
        {
            Random rnd = new Random();
            List<Aeroplane> colaLlegada = new List<Aeroplane>();
            List<Aeroplane> colaDespegue = new List<Aeroplane>();
            DateTime clock = new DateTime();
            string eventoActual = "";
            IList<Aeroplane> zonasAterrizaje = new Aeroplane[30];



            return;
        }

        public class Aeroplane 
        {
            public string nombre;
            public double horaLlegada;
            public double horaAterrizaje;
            public double horaInicioDespegue;
            public double horaDespegue;

            public Aeroplane(string nombre, double horaLlegada)
            {
                this.nombre = nombre;
                this.horaLlegada = horaLlegada;
            }

        }
    }
}
