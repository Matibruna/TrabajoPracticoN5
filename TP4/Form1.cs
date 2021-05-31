using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        public double generarNumeroUniforme(double desde, double hasta, double random) 
        {
            return desde + (random * (hasta - desde));
        }

        public double generarNumeroExponencial(double media, double random)
        {
            Double lambda = 1 / media;
            Double log = Convert.ToDouble(Math.Log(Convert.ToDouble(1 - random)));
            return (-1 / lambda) * log;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            simulacion();
        }

        private void simulacion() 
        {
            // Se llama directamente al nombre de la tabla del Form
            /*dt = new System.Data.DataTable();
            dt.Columns.Add("Nro Intervalo", typeof(Double));
            dt.Columns.Add("Reloj", typeof(string));
            dt.Columns.Add("Evento", typeof(string));
            dt.Columns.Add("RND Llegada", typeof(Double));
            dt.Columns.Add("Tiempo Entre Llegadas", typeof(string));
            dt.Columns.Add("Proxima LLegada", typeof(string));
            dt.Columns.Add("RND Aterrizaje", typeof(Double));
            dt.Columns.Add("Tiempo de Aterrizaje", typeof(string));
            dt.Columns.Add("Hora de Aterrizaje", typeof(string));
            dt.Columns.Add("Cola espera aterrizaje", typeof(string));
            dt.Columns.Add("Cola espera despegue", typeof(string));
            dt.Columns.Add("En pista", typeof(string));
            dt.Columns.Add("RND Despegue", typeof(Double));
            dt.Columns.Add("Tiempo de Despegue", typeof(string));
            dt.Columns.Add("Proximo evento", typeof(string));*/

            Random rnd = new Random();

            List<Aeroplane> colaLlegada = new List<Aeroplane>();
            List<Aeroplane> colaDespegue = new List<Aeroplane>();

            string eventoActual = "";

            IList<Aeroplane> zonasAterrizaje = new Aeroplane[30];
            //List<Aeroplane> zonasAterrizaje = new List<Aeroplane>(30);

            Aeroplane enPista;

            int minutosASimular = Convert.ToInt32(txtTiempoASimular.Text);

            double milisegundosASimular = getMillisecondsFromMinutes(minutosASimular);

            var tiempoASimular = new System.TimeSpan(0, minutosASimular, 0);

            int mediaLlegadaAeronaves = Convert.ToInt32(mediaExponencial.Text);

            int desdeAterrizaje = Convert.ToInt32(aterrizajeDesde.Text);
            int hastaAterrizaje = Convert.ToInt32(aterrizajeHasta.Text);

            int desdeDespegue = Convert.ToInt32(despegueDesde.Text);
            int hastaDespegue = Convert.ToInt32(despegueHasta.Text);

            int esperaMedia = Convert.ToInt32(mediaEspera.Text);
            int esperaDesviacion = Convert.ToInt32(desviacionEspera.Text);;

            var clock = new TimeSpan(0, 0, 0);

            //Stopwatch clock = new Stopwatch();

            // ACUMULADORES 
            TimeSpan tiempoLlegadaAcum = new TimeSpan(0,0,0);
            TimeSpan tiempoAterrizajeAcum = new TimeSpan(0, 0, 0);
            TimeSpan horaProximoEvento = new TimeSpan(0, 0, 0);
            // ------------

            while (clock.TotalMilliseconds < milisegundosASimular )
            {
                if (clock.TotalMilliseconds == 0)
                {
                    //clock.Start();

                    eventoActual = "Inicio";

                    double random = rnd.NextDouble();

                    double tiempoLlegadaMinutos = generarNumeroExponencial(mediaLlegadaAeronaves, random);

                    double tiempoLlegadaMilisegundos = getMillisecondsFromMinutes(tiempoLlegadaMinutos);

                    var tiempoLlegada = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(tiempoLlegadaMilisegundos));

                    tiempoLlegadaAcum = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(tiempoLlegadaMilisegundos + tiempoLlegadaAcum.TotalMilliseconds)); ;

                    string tiempoLlegadaFormat = tiempoLlegada.Hours + ":" + tiempoLlegada.Minutes + ":" + tiempoLlegada.Seconds;

                    TimeSpan horaProximaLlegada = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(tiempoLlegadaMilisegundos + clock.TotalMilliseconds));

                    string horaProximaLlegadaFormat = (horaProximaLlegada.Hours) + ":" + (horaProximaLlegada.Minutes) + ":" + (horaProximaLlegada.Seconds);

                    horaProximoEvento = horaProximaLlegada;

                    dgvSimulacion.Rows.Add("0:00:00", eventoActual, random, tiempoLlegadaFormat, horaProximaLlegadaFormat, 0, "", "", "", "", "", 0, "", "");
                }
                else
                {
                    eventoActual = "Llega Nave 1 / Autorizacion Nave 1";

                    double random = rnd.NextDouble();

                    double tiempoAterrizajeMinutos = generarNumeroUniforme(desdeAterrizaje, hastaAterrizaje, random);

                    double tiempoAterrizajeMilisegundos = getMillisecondsFromMinutes(tiempoAterrizajeMinutos);

                    TimeSpan tiempoAterrizaje = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(tiempoAterrizajeMilisegundos));

                    tiempoAterrizajeAcum = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(tiempoAterrizajeMilisegundos + tiempoAterrizajeAcum.TotalMilliseconds));

                    string tiempoAterrizajeFormat = tiempoAterrizaje.Hours + ":" + tiempoAterrizaje.Minutes + ":" + tiempoAterrizaje.Seconds;

                    string relojFila = clock.Hours + ":" + clock.Minutes + ":" + clock.Seconds;

                    TimeSpan horaProximoAterrizaje = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(tiempoAterrizajeMilisegundos + clock.TotalMilliseconds));

                    string horaAterrizajeFormat = (horaProximoAterrizaje.Hours) + ":" + (horaProximoAterrizaje.Minutes) + ":" + (horaProximoAterrizaje.Seconds);

                    dgvSimulacion.Rows.Add(relojFila, eventoActual, "-", "-", "-", random, tiempoAterrizajeFormat, horaAterrizajeFormat, 0, 0, "Nave 1", 0, "", "");

                    if (horaProximoAterrizaje.TotalMilliseconds > horaProximoEvento.TotalMilliseconds)
                    {
                        horaProximoEvento = horaProximoAterrizaje;
                    }
                }

                TimeSpan proximoEvento = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(horaProximoEvento.TotalMilliseconds));

                clock = proximoEvento;
            }

            /*for (Stopwatch clock = new Stopwatch(); clock.ElapsedMilliseconds < milisegundosASimular; clock.Elapsed.Add(tiempoTranscurrido))
                //for (int i = 0; i < 1; i++)
                {
                //if (!clock.IsRunning)
                //if (i == 0)
                if (clock.ElapsedMilliseconds == 0)
                {
                    eventoActual = "Inicio";

                    double random = rnd.NextDouble();

                    double tiempoLlegadaMinutos = generarNumeroExponencial(mediaLlegadaAeronaves, random);

                    double tiempoLlegadaMilisegundos = getMillisecondsFromMinutes(tiempoLlegadaMinutos);

                    var tiempoLlegada = new System.TimeSpan(0, 0, 0, 0, Convert.ToInt32(tiempoLlegadaMilisegundos));

                    string tiempoLlegadaFormat = "" + tiempoLlegada.Hours + ":" + tiempoLlegada.Minutes + ":" + tiempoLlegada.Seconds;

                    //DataRow row = new DataRow("0:00:00", eventoActual, random, tiempoLlegadaFormat, tiempoLlegadaFormat, "", "", "", "", "", "", "", "", "");

                    dgvSimulacion.Rows.Add("0:00:00", eventoActual, random, tiempoLlegadaFormat, tiempoLlegadaFormat, 0, "", "", "", "", "", 0, "", "");

                   //clock.Start();
                }

                //var x = new System.TimeSpan(0, 0, 0, 0, Convert.ToInt32(clock.ElapsedMilliseconds));
                var x = new System.TimeSpan(0, 0, 0, 0, milisegundosASimular);
                tiempoTranscurrido = x;
            }*/
        }

        public double getMillisecondsFromMinutes(double minutes)
        {
            return minutes * 60000;
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

        public class Fila
        {
            private int nroFila;
            private string reloj;
            private string evento;
            private string randomLlegada;
            private string tiempoEntreLlegadas;
            private string proximaLLegada;
            private string randomAterrizaje;
            private string tiempoAterrizaje;
            private string horaAterrizaje;
            private string colaEsperaAterrizaje;
            private string colaEsperaDespegue;
            private string enPista;
            private string randomDespegue;
            private string tiempoDespegue;
            private string proximoEvento;

            public Fila()
            {
                
            }

            public Fila(int nroFila, string reloj, string evento, string randomLlegada, string tiempoEntreLlegadas, string proximaLLegada, string randomAterrizaje, string tiempoAterrizaje,
             string horaAterrizaje,
            string colaEsperaAterrizaje,
            string colaEsperaDespegue,
            string enPista,
           string randomDespegue,
           string tiempoDespegue,
           string proximoEvento)
            {
                this.nroFila = nroFila;
                this.reloj = reloj;
                this.evento = evento;
                this.randomLlegada = randomLlegada;
                this.tiempoEntreLlegadas = tiempoEntreLlegadas;
                this.proximaLLegada = proximaLLegada;
                this.randomAterrizaje = randomAterrizaje;
                this.tiempoAterrizaje = tiempoAterrizaje;
                this.horaAterrizaje = horaAterrizaje;
                this.colaEsperaAterrizaje = colaEsperaAterrizaje;
                this.colaEsperaDespegue = colaEsperaDespegue;
                this.enPista = enPista;
                this.randomDespegue = randomDespegue;
                this.tiempoDespegue = tiempoDespegue;
                this.proximoEvento = proximoEvento;
        }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvSimulacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SimulacionTP5_Load(object sender, EventArgs e)
        {

        }
    }
}
