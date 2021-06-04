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

        public SimulacionTP5()
        {
            InitializeComponent();
        }

        public double generarNumeroNormal(double media, double desviacion, double random) 
        {
            double suma = 0;
            for (int j = 0; j < 12; j++)
            {
                double aleat = Math.Round(random, 6);
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
            simulacion2();
        }

        public class Aeroplane
        {
            public int id;
            public TimeSpan horaLlegada;
            public TimeSpan horaAterrizaje;
            public TimeSpan horaInicioDespegue;
            public TimeSpan horaDespegue;
            public string evento;

            public Aeroplane(int id, TimeSpan horaLlegada)
            {
                this.id = id;
                this.horaLlegada = horaLlegada;
            }
        }


        public TimeSpan nextEvent(TimeSpan tiempoProximaLlegada, Queue<Aeroplane> colaAterrizaje, Queue<Aeroplane> colaDespegue, List<Aeroplane> zonasAterrizaje, Aeroplane naveEnPista, TimeSpan relojSistema)
        {
            int i = 1;
            TimeSpan next = new TimeSpan(0, 0, 0);

            //if (colaAterrizaje.Count == 0 && colaDespegue.Count == 0 && naveEnPista == null)
            //{
            //    next = relojSistema;
            //    return next;
            //}
            
            while (i < 6)
            {
                switch (i)
                {
                    case 1:
                        // PROXIMA LLEGADA DE NAVE
                        next = tiempoProximaLlegada;
                        break;
                    case 2:
                        // ATERRIZAJE NAVE => ZONA ATERRIZAJE
                        if (naveEnPista != null && naveEnPista.evento == "Aterrizaje")
                        {
                            if (next > naveEnPista.horaAterrizaje)
                            {
                                if (next > naveEnPista.horaAterrizaje)
                                {
                                    next = naveEnPista.horaAterrizaje;
                                }
                            }
                        }
                        
                        break;

                    case 3:
                        // DESPEGUE NAVE => SALE DEL SISTEMA
                        if (naveEnPista != null && naveEnPista.evento == "Despegue")
                        {
                            if (next > naveEnPista.horaDespegue)
                            {
                                if (next > naveEnPista.horaDespegue)
                                {
                                    next = naveEnPista.horaDespegue;
                                }
                            }
                        }

                        break;
                    case 4:
                        // AUTORIZACION DESPEGUE
                        if (colaDespegue.Count > 0 || colaAterrizaje.Count > 0)
                        {
                            next = relojSistema;
                        }
                        break;

                    case 5:
                        // SALIDA DEL SISTEMA
                        TimeSpan tiempoProximoInicioDespegue = menorTiempoDespegue(zonasAterrizaje);
                        if (tiempoProximoInicioDespegue.TotalMilliseconds != 0)
                        {
                            if (tiempoProximoInicioDespegue.TotalMilliseconds != relojSistema.TotalMilliseconds)
                            {
                                if (next > tiempoProximoInicioDespegue)
                                {
                                    next = tiempoProximoInicioDespegue;
                                }
                            }
                            
                        }
                        break;
                }
                i++;
            }

            return next;
        }

        public TimeSpan menorTiempoInicioDespegue(List<Aeroplane> zonasAterrizaje)
        {
            TimeSpan menorTiempoInicioDespegue = new TimeSpan(9999, 0, 0);

            if (zonasAterrizaje.Count > 0)
            { 
                for (int i = 0; i < zonasAterrizaje.Count; i++)
                {
                    Aeroplane naveEnZona = zonasAterrizaje[i];

                    if (naveEnZona != null && naveEnZona.horaInicioDespegue.TotalMilliseconds != 0 && naveEnZona.evento != "Despegue")
                    {
                        if (i == 0)
                        {
                            menorTiempoInicioDespegue = naveEnZona.horaInicioDespegue;

                        }
                        else
                        {
                            if (menorTiempoInicioDespegue > naveEnZona.horaInicioDespegue)
                            {
                                menorTiempoInicioDespegue = naveEnZona.horaInicioDespegue;
                            }
                        }
                    }
                }
            
            }

            return menorTiempoInicioDespegue;
        }

        public Aeroplane getAndDeleteAeroplaneMenorTiempoInicioDespegue(List<Aeroplane> zonasAterrizaje)
        {
            TimeSpan menorTiempoInicioDespegue = new TimeSpan(9999, 0, 0);
            Aeroplane nave = null;
            int j = 0;

            if (zonasAterrizaje.Count > 0)
            {
                for (int i = 0; i < zonasAterrizaje.Count; i++)
                {
                    Aeroplane naveEnZona = zonasAterrizaje[i];

                    if (naveEnZona != null && naveEnZona.horaInicioDespegue.TotalMilliseconds != 0 && naveEnZona.evento != "Despegue")
                    {
                        if (i == 0)
                        {
                            menorTiempoInicioDespegue = naveEnZona.horaInicioDespegue;
                            nave = naveEnZona;

                        }
                        else
                        {
                            if (menorTiempoInicioDespegue > naveEnZona.horaInicioDespegue)
                            {
                                menorTiempoInicioDespegue = naveEnZona.horaInicioDespegue;
                                nave = naveEnZona;
                                j = i;
                            }
                        }
                    }
                }

            }

            zonasAterrizaje[j] = null;

            return nave;
        }

        public TimeSpan menorTiempoDespegue(List<Aeroplane> zonasAterrizaje)
        {
            TimeSpan menorTiempo = new TimeSpan(9999,0,0);

            if (zonasAterrizaje.Count > 0)
            {
                for (int i = 0; i < zonasAterrizaje.Count; i++)
                {
                    Aeroplane naveEnZona = zonasAterrizaje[i];

                    if (naveEnZona != null && naveEnZona.horaDespegue.TotalMilliseconds != 0 && naveEnZona.evento == "Despegue")
                    {
                        if (i == 0)
                        {
                            menorTiempo = naveEnZona.horaDespegue;

                        }
                        else
                        {
                            if (menorTiempo > naveEnZona.horaDespegue)
                            {
                                menorTiempo = naveEnZona.horaDespegue;
                            }
                        }
                    }
                    
                } 
            }
            
            return menorTiempo;
        }

        public Aeroplane getNaveADespegar(List<Aeroplane> zonasAterrizaje)
        {
            Aeroplane naveADespegar = null;

            for (int i = 0; i < zonasAterrizaje.Count; i++)
            {
                Aeroplane naveEnZona = zonasAterrizaje[i];

                if (i == 0)
                {
                    naveADespegar = naveEnZona;
                    
                } else if(naveADespegar != null)
                {
                    if (naveEnZona != null && naveADespegar.horaDespegue > naveEnZona.horaDespegue)
                    {
                        naveADespegar = naveEnZona;
                    }
                }
            }

            return naveADespegar;
        }

        private void simulacion2()
        {
            Random rnd = new Random();

            Queue<Aeroplane> colaAterrizaje = new Queue<Aeroplane>();
            Queue<Aeroplane> colaDespegue = new Queue<Aeroplane>();
            //List<Aeroplane> colaAterrizaje = new List<Aeroplane>();
            //List<Aeroplane> colaDespegue = new List<Aeroplane>();
            List<Aeroplane> zonasAterrizaje = new List<Aeroplane>();

            Aeroplane naveEnPista = null;

            // DATOS INPUT
            int cantidadDeAviones = Convert.ToInt32(cantidadAvionesEnTierra.Text);
            int minutosASimular = Convert.ToInt32(txtTiempoASimular.Text);
            double milisegundosASimular = getMillisecondsFromMinutes(minutosASimular);

            int mediaLlegadaAeronaves = Convert.ToInt32(mediaExponencial.Text);

            int desdeAterrizaje = Convert.ToInt32(aterrizajeDesde.Text);
            int hastaAterrizaje = Convert.ToInt32(aterrizajeHasta.Text);

            int desdeDespegue = Convert.ToInt32(despegueDesde.Text);
            int hastaDespegue = Convert.ToInt32(despegueHasta.Text);

            int esperaMedia = Convert.ToInt32(mediaEspera.Text);
            int esperaDesviacion = Convert.ToInt32(desviacionEspera.Text);
            // -----------

            TimeSpan relojSimulacion = new TimeSpan(0, 0, 0);

            // ACUMULADORES 
            TimeSpan tiempoLlegadaAcum = new TimeSpan(0, 0, 0);
            TimeSpan tiempoAterrizajeAcum = new TimeSpan(0, 0, 0);
            TimeSpan horaProximaLlegadaAcum = new TimeSpan(0, 0, 0);
            TimeSpan horaProximoAterrizajeAcum = new TimeSpan(0, 0, 0);
            TimeSpan horaProximoEvento = new TimeSpan(0, 0, 0);
            int contadorAeronavesEnTierra = 0;
            // ------------

            string eventoActual = "";
            string proximoEvento = "";
            int contadorNumeroNave = 1;

            while (relojSimulacion.TotalMilliseconds < milisegundosASimular)
            {  
                if (relojSimulacion.TotalMilliseconds == 0)
                {
                    // Primera fila
                    eventoActual = "Inicio";
                    double random = rnd.NextDouble();

                    // Tiempo de llegada
                    double tiempoLlegadaMinutos = generarNumeroExponencial(mediaLlegadaAeronaves, random);
                    double tiempoLlegadaMilisegundos = getMillisecondsFromMinutes(tiempoLlegadaMinutos);
                    TimeSpan tiempoLlegada = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(tiempoLlegadaMilisegundos));
                    tiempoLlegadaAcum = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(tiempoLlegadaMilisegundos + tiempoLlegadaAcum.TotalMilliseconds));
                    string tiempoLlegadaFormat = tiempoLlegada.Hours + ":" + tiempoLlegada.Minutes + ":" + tiempoLlegada.Seconds;
                    // -----------------

                    // Hora de llegada
                    TimeSpan horaProximaLlegada = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(tiempoLlegadaMilisegundos + relojSimulacion.TotalMilliseconds));
                    horaProximaLlegadaAcum = horaProximaLlegada;
                    string horaProximaLlegadaFormat = (horaProximaLlegada.Hours) + ":" + (horaProximaLlegada.Minutes) + ":" + (horaProximaLlegada.Seconds);
                    // ---------------

                    // Proximo evento
                    horaProximoEvento = horaProximaLlegada;
                    proximoEvento = "Llega Nave " + contadorNumeroNave;
                    // --------------

                    dgvSimulacion.Rows.Add("0:00:00", eventoActual, random, tiempoLlegadaFormat, horaProximaLlegadaFormat, "", "", "", "", "", "", "", "", "", "", "", "");

                    horaProximoEvento = nextEvent(horaProximaLlegadaAcum, colaAterrizaje, colaDespegue, zonasAterrizaje, naveEnPista, relojSimulacion);
                }
                else
                {
                    while (menorTiempoInicioDespegue(zonasAterrizaje) < horaProximoEvento)
                    {

                        // INGRESAR A LA COLA DE DESPEGUE

                        Aeroplane naveInicioDespegue = getAndDeleteAeroplaneMenorTiempoInicioDespegue(zonasAterrizaje);
                        colaDespegue.Enqueue(naveInicioDespegue);
                        contadorAeronavesEnTierra -= 1;
                        eventoActual = "Nave "+ naveInicioDespegue.id.ToString() + " ingresa a la cola de despegue.";
                        relojSimulacion = naveInicioDespegue.horaInicioDespegue;
                        horaProximoEvento = relojSimulacion;
                        dgvSimulacion.Rows.Add(getLocalHour(naveInicioDespegue.horaInicioDespegue), eventoActual, "", "", "", "", "", "", colaAterrizaje.Count, colaDespegue.Count, naveEnPista != null ? "Nave " +naveEnPista.id.ToString() : "Pista Vacia", "", "", "", "", "");
                    }

                    
                    if (naveEnPista != null)
                    {
                        // Hay una nave en pista

                        if (naveEnPista.evento == "Aterrizaje")
                        {
                            // La nave en pista esta ATERRIZANDO.

                            // Posible Proximo Evento: Aterriza la Nave X o llegada de una nueva nave.

                            if (naveEnPista.horaAterrizaje.TotalMilliseconds > horaProximaLlegadaAcum.TotalMilliseconds)
                            {
                                // Proximo evento no es el aterrizaje, un avion ingresa al sistema antes e ira a la cola de aterrizaje.

                                // Proximo evento es la llegada de una nueva nave

                                eventoActual = "Llega Nave " + contadorNumeroNave;

                                if (contadorAeronavesEnTierra < cantidadDeAviones)
                                {
                                    Aeroplane nave = new Aeroplane(contadorNumeroNave, relojSimulacion);
                                    contadorNumeroNave += 1;

                                    zonasAterrizaje.Add(nave);
                                    contadorAeronavesEnTierra += 1;

                                    double random = rnd.NextDouble();

                                    // Tiempo de llegada
                                    double tiempoLlegadaMinutos = generarNumeroExponencial(mediaLlegadaAeronaves, random);
                                    double tiempoLlegadaMilisegundos = getMillisecondsFromMinutes(tiempoLlegadaMinutos);
                                    TimeSpan tiempoLlegada = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(tiempoLlegadaMilisegundos));
                                    tiempoLlegadaAcum = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(tiempoLlegadaMilisegundos + tiempoLlegadaAcum.TotalMilliseconds));
                                    string tiempoLlegadaFormat = getLocalHour(tiempoLlegada);
                                    // -----------------

                                    // Hora de llegada
                                    TimeSpan horaProximaLlegada = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(tiempoLlegadaMilisegundos + relojSimulacion.TotalMilliseconds));
                                    horaProximaLlegadaAcum = horaProximaLlegada;
                                    string horaProximaLlegadaFormat = getLocalHour(horaProximaLlegada);
                                    // ---------------

                                    nave.horaLlegada = horaProximaLlegada;

                                    string relojFila = getLocalHour(relojSimulacion);

                                    // Lo agrego a la cola, ya que todavía no aterrizó y necesito buscarlo en el proximo evento
                                    colaAterrizaje.Enqueue(nave);

                                    dgvSimulacion.Rows.Add(relojFila, eventoActual, random, tiempoLlegadaFormat, horaProximaLlegadaFormat, "", "", "", colaAterrizaje.Count, colaDespegue.Count, naveEnPista != null ? "Nave " + naveEnPista.id.ToString() : "Pista Vacia", "",  "", "", contadorAeronavesEnTierra.ToString());



                                } else
                                {
                                    // Si al llegar una aeronave en la estación aérea hay 30 unidades (entre las que “esperan en tierra” y las que se encuentran estacionadas), 
                                    // ésta es derivada a otra estación aérea
                                }
                                horaProximoEvento = nextEvent(horaProximaLlegadaAcum, colaAterrizaje, colaDespegue, zonasAterrizaje, naveEnPista, relojSimulacion);

                            }
                            else
                            {
                                // Proximo evento es el aterrizaje.
                                // Aterriza la nave => tiro random de estadía

                                Aeroplane nave = naveEnPista;

                                eventoActual = "Aterrizaje Nave " + nave.id;
                                relojSimulacion = naveEnPista.horaAterrizaje;
                                horaProximoEvento = relojSimulacion;

                                double random = rnd.NextDouble();

                                // Tiempo de estadía
                                double tiempoEstadiaMinutos = Math.Abs(generarNumeroNormal(esperaMedia, esperaDesviacion, random));
                                if (tiempoEstadiaMinutos < 15)
                                {
                                    tiempoEstadiaMinutos += generarNumeroUniforme(7, 15, rnd.NextDouble());
                                }
                                double tiempoEstadiaMilisegundos = getMillisecondsFromMinutes(tiempoEstadiaMinutos);
                                TimeSpan tiempoEstadia = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(tiempoEstadiaMilisegundos));
                                tiempoLlegadaAcum = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(tiempoEstadiaMilisegundos + tiempoLlegadaAcum.TotalMilliseconds));
                                string tiempoEstadiaFormat = getLocalHour(tiempoEstadia);
                                // -----------------

                                // Hora de estadía
                                TimeSpan horaFinEstadia = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(tiempoEstadiaMilisegundos + relojSimulacion.TotalMilliseconds));
                                //horaProximaLlegadaAcum = horaProximaLlegada;
                                string horaFinEstadiaFormat = getLocalHour(horaFinEstadia);
                                // ---------------

                                nave.horaInicioDespegue = horaFinEstadia;
                                nave.evento = "En Tierra";

                                naveEnPista = null;

                                string relojFila = getLocalHour(relojSimulacion);

                                dgvSimulacion.Rows.Add(relojFila, eventoActual, "", "", "", "", "", "", colaAterrizaje.Count, colaDespegue.Count, naveEnPista != null ? "Nave " + naveEnPista.id.ToString() : "Pista Vacia", random, tiempoEstadiaFormat, horaFinEstadiaFormat, "", "", "", contadorAeronavesEnTierra.ToString());


                                if (colaAterrizaje.Count == 0 && colaDespegue.Count == 0)
                                {
                                    horaProximoEvento = nextEvent(horaProximaLlegadaAcum, colaAterrizaje, colaDespegue, zonasAterrizaje, naveEnPista, relojSimulacion);
                                }


                            }
                        }
                        else if(naveEnPista.evento == "Despegue")
                        {
                            // El avion en pista esta despegando.
                            // Posible Proximo Evento: Despega Nave X.

                            if (naveEnPista.horaDespegue.TotalMilliseconds > horaProximaLlegadaAcum.TotalMilliseconds)
                            {
                                // Proximo evento no es el despegue, un avion ingresa al sistema antes e ira a la cola de aterrizaje
                                // Proximo evento => llegada de una nave

                                eventoActual = "Llega Nave " + contadorNumeroNave;

                                if (contadorAeronavesEnTierra < cantidadDeAviones)
                                {
                                    Aeroplane nave = new Aeroplane(contadorNumeroNave, relojSimulacion);
                                    contadorNumeroNave += 1;

                                    zonasAterrizaje.Add(nave);
                                    contadorAeronavesEnTierra += 1;

                                    double random = rnd.NextDouble();

                                    // Tiempo de llegada
                                    double tiempoLlegadaMinutos = generarNumeroExponencial(mediaLlegadaAeronaves, random);
                                    double tiempoLlegadaMilisegundos = getMillisecondsFromMinutes(tiempoLlegadaMinutos);
                                    TimeSpan tiempoLlegada = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(tiempoLlegadaMilisegundos));
                                    tiempoLlegadaAcum = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(tiempoLlegadaMilisegundos + tiempoLlegadaAcum.TotalMilliseconds));
                                    string tiempoLlegadaFormat = tiempoLlegada.Hours + ":" + tiempoLlegada.Minutes + ":" + tiempoLlegada.Seconds;
                                    // -----------------

                                    // Hora de llegada
                                    TimeSpan horaProximaLlegada = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(tiempoLlegadaMilisegundos + relojSimulacion.TotalMilliseconds));
                                    horaProximaLlegadaAcum = horaProximaLlegada;
                                    string horaProximaLlegadaFormat = (horaProximaLlegada.Hours) + ":" + (horaProximaLlegada.Minutes) + ":" + (horaProximaLlegada.Seconds);
                                    // ---------------

                                    nave.horaLlegada = horaProximaLlegada;

                                    string relojFila = getLocalHour(relojSimulacion);

                                    // Lo agrego a la cola, ya que todavía no aterrizó y necesito buscarlo en el proximo evento
                                    colaAterrizaje.Enqueue(nave); 

                                    dgvSimulacion.Rows.Add(relojFila, eventoActual, random, tiempoLlegadaFormat, horaProximaLlegadaFormat, "", "", "", colaAterrizaje.Count, colaDespegue.Count, naveEnPista != null ? "Nave " + naveEnPista.id.ToString() : "Pista Vacia", "", "", "", contadorAeronavesEnTierra.ToString());


                                } else
                                {
                                    // Si al llegar una aeronave en la estación aérea hay 30 unidades(entre las que “esperan en tierra” y las que se encuentran estacionadas), 
                                    // ésta es derivada a otra estación aérea
                                    double random = rnd.NextDouble();

                                    eventoActual = "Redireccionamiento de avion por hangares llenos";

                                    // Tiempo de llegada
                                    double tiempoLlegadaMinutos = generarNumeroExponencial(mediaLlegadaAeronaves, random);
                                    double tiempoLlegadaMilisegundos = getMillisecondsFromMinutes(tiempoLlegadaMinutos);
                                    TimeSpan tiempoLlegada = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(tiempoLlegadaMilisegundos));
                                    tiempoLlegadaAcum = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(tiempoLlegadaMilisegundos + tiempoLlegadaAcum.TotalMilliseconds));
                                    string tiempoLlegadaFormat = tiempoLlegada.Hours + ":" + tiempoLlegada.Minutes + ":" + tiempoLlegada.Seconds;
                                    // -----------------

                                    // Hora de llegada
                                    TimeSpan horaProximaLlegada = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(tiempoLlegadaMilisegundos + relojSimulacion.TotalMilliseconds));
                                    horaProximaLlegadaAcum = horaProximaLlegada;
                                    string horaProximaLlegadaFormat = (horaProximaLlegada.Hours) + ":" + (horaProximaLlegada.Minutes) + ":" + (horaProximaLlegada.Seconds);
                                    // ---------------

                                    string relojFila = getLocalHour(relojSimulacion);

                                    dgvSimulacion.Rows.Add(relojFila, eventoActual, random, tiempoLlegadaFormat, horaProximaLlegadaFormat, "", "", "", colaAterrizaje.Count, colaDespegue.Count, naveEnPista != null ? "Nave " + naveEnPista.id.ToString() : "Pista Vacia", "", "", "");
                                }


                                if (colaAterrizaje.Count == 0 && colaDespegue.Count == 0)
                                {
                                    horaProximoEvento = nextEvent(horaProximaLlegadaAcum, colaAterrizaje, colaDespegue, zonasAterrizaje, naveEnPista, relojSimulacion);
                                }


                                //
                            }
                            else
                            {
                                // Proximo evento es el despegue.

                                Aeroplane nave = naveEnPista;

                                //Aeroplane nave = colaDespegue.Peek();

                                eventoActual = "Despegue Nave " + nave.id;

                                relojSimulacion = naveEnPista.horaDespegue;
                                horaProximoEvento = relojSimulacion;
                                nave.evento = "Fuera de sistema";

                                naveEnPista = null;

                                string relojFila = getLocalHour(relojSimulacion);

                                dgvSimulacion.Rows.Add(relojFila, eventoActual, "", "", "", "", "", "", colaAterrizaje.Count, colaDespegue.Count, naveEnPista != null ? "Nave " + naveEnPista.id.ToString() : "Pista Vacia", "", "", "", "", "", "", "", "", "");

                                // Si cuando despega una nave y despeja la cola, hay otros en cola
                                //if (colaDespegue.Count > 0)
                                //{
                                //    // Entonces, el evento inmediatamente despues del despegue, es una autorizacion del que estaba en cola
                                //    horaProximoEvento = relojSimulacion;
                                //} else
                                //{
                                //    // Si no hay mas naves en cola, sigo con el proximo evento
                                //    horaProximoEvento = nextEvent(horaProximaLlegadaAcum, colaAterrizaje, colaDespegue, zonasAterrizaje, naveEnPista, relojSimulacion);
                                //}
                                horaProximoEvento = nextEvent(horaProximaLlegadaAcum, colaAterrizaje, colaDespegue, zonasAterrizaje, naveEnPista, relojSimulacion);
                            }
                        }
                    }
                    else
                    {
                        // No hay nave en pista

                        // Prioridad cola de aterrizaje, la reviso primero
                        if (colaAterrizaje.Count != 0)
                        {
                            // Nadie en pista, hay naves en cola de aterrizaje
                            // Proximo evento: Autorizacion Nave a Aterrizar.

                            Aeroplane nave = colaAterrizaje.Peek();

                            eventoActual = "Autorizacion Nave " + nave.id;

                            nave.evento = "Aterrizaje";

                            // Pido autorizacion y empiezo a usar la pista
                            naveEnPista = nave;

                            // Tiempo aterrizaje
                            double randomAterrizaje = rnd.NextDouble();
                            double tiempoAterrizajeMinutos = generarNumeroUniforme(desdeAterrizaje, hastaAterrizaje, randomAterrizaje);
                            double tiempoAterrizajeMilisegundos = getMillisecondsFromMinutes(tiempoAterrizajeMinutos);
                            TimeSpan tiempoAterrizaje = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(tiempoAterrizajeMilisegundos));
                            tiempoAterrizajeAcum = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(tiempoAterrizajeMilisegundos + tiempoAterrizajeAcum.TotalMilliseconds));
                            string tiempoAterrizajeFormat = getLocalHour(tiempoAterrizaje);
                            // -----------------

                            // Hora aterrizaje
                            TimeSpan horaProximoAterrizaje = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(tiempoAterrizajeMilisegundos + relojSimulacion.TotalMilliseconds));
                            string horaAterrizajeFormat = getLocalHour(horaProximoAterrizaje);
                            // ---------------

                            nave.horaAterrizaje = horaProximoAterrizaje;

                            string relojFila = getLocalHour(relojSimulacion);

                            dgvSimulacion.Rows.Add(relojFila, eventoActual, "", "", "", randomAterrizaje, tiempoAterrizajeFormat, horaAterrizajeFormat, colaAterrizaje.Count, colaDespegue.Count, naveEnPista != null ? "Nave " + naveEnPista.id.ToString() : "Pista Vacia", "", "", "", "", "", "");

                            // Como empieza a usar la pista, lo saco de la cola
                            colaAterrizaje.Dequeue();

                            // Si cuando aterriza una nave y despeja la cola, hay otros en cola
                            //if (colaAterrizaje.Count > 0)
                            //{
                            //    // Entonces, el evento inmediatamente despues del aterrizaje, es una autorizacion del que estaba en cola
                            //    horaProximoEvento = relojSimulacion;
                            //}
                            //else
                            //{
                            //    // Si no hay nadie mas en cola, sigo con el proximo evento
                            //    horaProximoEvento = nextEvent(horaProximaLlegadaAcum, colaAterrizaje, colaDespegue, zonasAterrizaje, naveEnPista, relojSimulacion);
                            //}

                            horaProximoEvento = nextEvent(horaProximaLlegadaAcum, colaAterrizaje, colaDespegue, zonasAterrizaje, naveEnPista, relojSimulacion);

                        }
                        else if (colaDespegue.Count != 0)
                        {
                            // Nadie en pista, Cola de Aterrizaje vacia. 
                            // Hay naves en la cola de despegue

                            // Proximo evento: Autorizacion Nave a Despegar.

                            //Aeroplane nave = colaDespegue.Peek();

                            // BUSCAR EN LA ZONA DE ATERRIZAJE, LA NAVE QUE SE TIENE QUE IR
                            Aeroplane nave = colaDespegue.Peek();

                            eventoActual = "Autorizacion Despegue Nave " + nave.id;

                            nave.evento = "Despegue";

                            naveEnPista = nave;

                            double random = rnd.NextDouble();

                            // Tiempo de despegue
                            double tiempoDespegueMinutos = generarNumeroUniforme(desdeDespegue, hastaDespegue, random);
                            double tiempoDespegueMilisegundos = getMillisecondsFromMinutes(tiempoDespegueMinutos);
                            TimeSpan tiempoDespegue = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(tiempoDespegueMilisegundos));
                            //tiempoLlegadaAcum = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(tiempoEstadiaMilisegundos + tiempoLlegadaAcum.TotalMilliseconds));
                            string tiempoDespegueFormat = getLocalHour(tiempoDespegue);
                            // -----------------

                            // Hora de despegue
                            TimeSpan horaDespegue = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(tiempoDespegueMilisegundos + relojSimulacion.TotalMilliseconds));
                            //horaProximaLlegadaAcum = horaProximaLlegada;
                            string horaDespegueFormat = getLocalHour(horaDespegue);
                            // ---------------

                            nave.horaDespegue = horaDespegue;

                            // Empiezo a usar la pista, sale de la cola y de la zona de aterrizaje
                            colaDespegue.Dequeue();
                            zonasAterrizaje.Remove(nave);

                            string relojFila = getLocalHour(relojSimulacion);

                            dgvSimulacion.Rows.Add(relojFila, eventoActual, "", "", "", "", "", "", colaAterrizaje.Count, colaDespegue.Count, naveEnPista != null ? "Nave " + naveEnPista.id.ToString() : "Pista Vacia", "", "", "", random, tiempoDespegueFormat, horaDespegueFormat, "", "", "");

                            horaProximoEvento = nextEvent(horaProximaLlegadaAcum, colaAterrizaje, colaDespegue, zonasAterrizaje, naveEnPista, relojSimulacion);
                        }
                        else
                        {
                            // Nadie en pista. Nadie en Cola de aterrizaje y despegue
                            // Proximo evento: Llegada de aeronave

                            eventoActual = "Llega Nave " + contadorNumeroNave;

                            if (contadorAeronavesEnTierra < cantidadDeAviones)
                            {
                                Aeroplane nave = new Aeroplane(contadorNumeroNave, relojSimulacion);
                                contadorNumeroNave += 1;

                                zonasAterrizaje.Add(nave);
                                contadorAeronavesEnTierra += 1;

                                double random = rnd.NextDouble();

                                // Tiempo de llegada
                                double tiempoLlegadaMinutos = generarNumeroExponencial(mediaLlegadaAeronaves, random);
                                double tiempoLlegadaMilisegundos = getMillisecondsFromMinutes(tiempoLlegadaMinutos);
                                TimeSpan tiempoLlegada = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(tiempoLlegadaMilisegundos));
                                tiempoLlegadaAcum = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(tiempoLlegadaMilisegundos + tiempoLlegadaAcum.TotalMilliseconds));
                                string tiempoLlegadaFormat = tiempoLlegada.Hours + ":" + tiempoLlegada.Minutes + ":" + tiempoLlegada.Seconds;
                                // -----------------

                                // Hora de llegada
                                TimeSpan horaProximaLlegada = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(tiempoLlegadaMilisegundos + relojSimulacion.TotalMilliseconds));
                                horaProximaLlegadaAcum = horaProximaLlegada;
                                string horaProximaLlegadaFormat = (horaProximaLlegada.Hours) + ":" + (horaProximaLlegada.Minutes) + ":" + (horaProximaLlegada.Seconds);
                                // ---------------

                                nave.horaLlegada = horaProximaLlegada;

                                string relojFila = getLocalHour(relojSimulacion);

                                colaAterrizaje.Enqueue(nave);

                                dgvSimulacion.Rows.Add(relojFila, eventoActual, random, tiempoLlegadaFormat, horaProximaLlegadaFormat, "", "", "", colaAterrizaje.Count, colaDespegue.Count, naveEnPista != null ? "Nave " + naveEnPista.id.ToString() : "Pista Vacia", "", "", "");



                            } else
                            {
                                double random = rnd.NextDouble();

                                eventoActual = "Redireccionamiento de avion por hangares llenos";

                                // Tiempo de llegada
                                double tiempoLlegadaMinutos = generarNumeroExponencial(mediaLlegadaAeronaves, random);
                                double tiempoLlegadaMilisegundos = getMillisecondsFromMinutes(tiempoLlegadaMinutos);
                                TimeSpan tiempoLlegada = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(tiempoLlegadaMilisegundos));
                                tiempoLlegadaAcum = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(tiempoLlegadaMilisegundos + tiempoLlegadaAcum.TotalMilliseconds));
                                string tiempoLlegadaFormat = tiempoLlegada.Hours + ":" + tiempoLlegada.Minutes + ":" + tiempoLlegada.Seconds;
                                // -----------------

                                // Hora de llegada
                                TimeSpan horaProximaLlegada = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(tiempoLlegadaMilisegundos + relojSimulacion.TotalMilliseconds));
                                horaProximaLlegadaAcum = horaProximaLlegada;
                                string horaProximaLlegadaFormat = (horaProximaLlegada.Hours) + ":" + (horaProximaLlegada.Minutes) + ":" + (horaProximaLlegada.Seconds);
                                // ---------------

                                string relojFila = getLocalHour(relojSimulacion);

                                dgvSimulacion.Rows.Add(relojFila, eventoActual, random, tiempoLlegadaFormat, horaProximaLlegadaFormat, "", "", "", colaAterrizaje.Count, colaDespegue.Count, naveEnPista != null ? "Nave " + naveEnPista.id.ToString() : "Pista Vacia", "", "", "");
                            }

                            // Como no hay naves en ninguna cola, y nadie usa la pista
                            // Sigo con el evento inmediado (Autorizacion)

                            horaProximoEvento = relojSimulacion;
                        }
                    }

                }
                if (horaProximoEvento.TotalMilliseconds < 0)
                {
                    //error
                }

                TimeSpan proximoEventoClock = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(horaProximoEvento.TotalMilliseconds));

                relojSimulacion = proximoEventoClock;
            }
        }

        public string getLocalHour(TimeSpan time)

        {
            string hourString = "";
            string minuteString = "";
            string secondString = "";

            if (Convert.ToString(time.Hours).Length == 1)
            {
                hourString = "0" + time.Hours;
            } else
            {
                hourString = time.Hours.ToString();
            }

            if (Convert.ToString(time.Minutes).Length == 1)
            {
                minuteString = "0" + time.Minutes;
            }
            else
            {
                minuteString = time.Minutes.ToString();
            }

            if (Convert.ToString(time.Seconds).Length == 1)
            {
                secondString = "0" + time.Seconds;
            }
            else
            {
                secondString = time.Seconds.ToString();
            }

            return hourString + ":" + minuteString + ":" + secondString;
        }
        public double getMillisecondsFromMinutes(double minutes)
        {
            return minutes * 60000;
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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void mediaEspera_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
