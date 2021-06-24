using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TP4
{
    public partial class SimulacionTP5 : Form
    {
        TimeSpan probabilidad1, probabilidad2, probabilidad3;

        public SimulacionTP5()
        {
            InitializeComponent();
        }

        public double generarNumeroNormal(double media, double desviacion, double random)
        {
            double suma = 0;
            for (Int64 j = 0; j < 12; j++)
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
            dgvSimulacion.Rows.Clear();
            dgvRungeKutta.Rows.Clear();
            dgvRungeKuttaLimpieza.Rows.Clear();
            simulacion2();
        }

        public class Aeroplane
        {
            public Int64 id;
            public TimeSpan horaLlegada;
            public TimeSpan horaAterrizaje;
            public TimeSpan horaInicioDespegue;
            public TimeSpan horaDespegue;
            public string evento;

            public Aeroplane(Int64 id, TimeSpan horaLlegada)
            {
                this.id = id;
                this.horaLlegada = horaLlegada;
            }
        }


        public TimeSpan nextEvent(TimeSpan tiempoProximaLlegada, Queue<Aeroplane> colaAterrizaje, Queue<Aeroplane> colaDespegue, List<Aeroplane> zonasAterrizaje, Aeroplane naveEnPista, TimeSpan tiempoFinPistaMantenimiento, TimeSpan tiempoInicioPistaMantenimiento, TimeSpan relojSistema, bool pistaMantenimiento)
        {
            Int64 i = 1;
            TimeSpan next = new TimeSpan(0, 0, 0);

            while (i <= 7)
            {
                switch (i)
                {
                    case 1:
                        // PROXIMA LLEGADA DE NAVE
                        next = tiempoProximaLlegada;
                        break;
                    case 2:
                        // ATERRIZAJE NAVE => ZONA ATERRIZAJE
                        if (naveEnPista != null && naveEnPista.evento == "Aterrizaje" && !pistaMantenimiento)
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
                        if (naveEnPista != null && naveEnPista.evento == "Despegue" && !pistaMantenimiento)
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
                        // AUTORIZACION DESPEGUE/ATERRIZAJE
                        if ((colaDespegue.Count > 0 || colaAterrizaje.Count > 0) && naveEnPista == null && !pistaMantenimiento)
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

                    case 6:
                        // Pista de vuelta en servicio.
                        if (pistaMantenimiento && tiempoFinPistaMantenimiento < next)
                        {
                            next = tiempoFinPistaMantenimiento;
                        }
                        break;

                    case 7:
                        if (!pistaMantenimiento && tiempoInicioPistaMantenimiento < next)
                        {
                            next = tiempoInicioPistaMantenimiento;
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
            TimeSpan menorTiempo = new TimeSpan(9999, 0, 0);

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

                }
                else if (naveADespegar != null)
                {
                    if (naveEnZona != null && naveADespegar.horaDespegue > naveEnZona.horaDespegue)
                    {
                        naveADespegar = naveEnZona;
                    }
                }
            }

            return naveADespegar;
        }

        public double eC(double a, double E)
        {
            return a * E;
        }

        public double rungeKutta(TimeSpan tiempoInicial, double tope)
        {
            double h = 1;
            double t = 0;
            double E, k1, k2, k3, k4;
            double a = Convert.ToDouble(textBox1.Text);

            E = 15;

            while (E < tope)
            {
                k1 = eC(a, E);

                k2 = eC(a, E + k1 * h / 2);

                k3 = eC(a, E + k2 * h / 2);

                k4 = eC(a, E + k3 * h);

                dgvRungeKutta.Rows.Add(t, Math.Round(E, 4), Math.Round(k1, 4), Math.Round(k2, 4), Math.Round(k3, 4), Math.Round(k4, 4));

                // Et+1
                E += (k1 + (2 * k2) + (2 * k3) + k4) * h / 6;

                // t+1
                t += h;
            }
            return t;
        }


        public TimeSpan rungeKuttaLimpieza(int cantidadLlegadas, TimeSpan tiempoActual, double modificarLlegadas = 1)
        {
            bool primera = true;
            double h = 1;
            double t = 0;
            double L, Lt = 0, k1 = 0, k2 = 0, k3 = 0, k4 = 0;
            double a = Convert.ToDouble(textBox1.Text);

            //Lt Seria Lt-1 para el calculo de L-Lt+1 < 0.02 / frenar el calculo.
            L = cantidadLlegadas * modificarLlegadas;

            while (Lt - L > 0.02 || primera)
            {
                primera = false;

                k1 = eC(-a * 0.5, L);

                k2 = eC(-a * 0.5, L + k1 * h / 2);

                k3 = eC(-a * 0.5, L + k2 * h / 2);

                k4 = eC(-a * 0.5, L + k3 * h);

                dgvRungeKuttaLimpieza.Rows.Add(t, Math.Round(L, 4), Math.Round(k1, 4), Math.Round(k2, 4), Math.Round(k3, 4), Math.Round(k4, 4), Lt - L);

                // Lt+1
                Lt = L;
                L += (k1 + (2 * k2) + (2 * k3) + k4) * h / 6;

                // t+1
                t += h;
            }

            dgvRungeKuttaLimpieza.Rows.Add(t, Math.Round(L, 4), Math.Round(k1, 4), Math.Round(k2, 4), Math.Round(k3, 4), Math.Round(k4, 4), Lt - L);

            dgvRungeKuttaLimpieza.Rows.Add();
            dgvRungeKuttaLimpieza.Rows.Add("Fin de calculo runge kutta limpieza.", getLocalHour(tiempoActual), "", "Cantidad de Llegadas:", cantidadLlegadas);
            dgvRungeKuttaLimpieza.Rows.Add();
            return tiempoActual + new TimeSpan(0, 0, Convert.ToInt32(t - 1));
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
            TimeSpan mostrarDesde = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(getMillisecondsFromMinutes(Convert.ToInt32(simularDesde.Text))));
            TimeSpan mostrarHasta = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(getMillisecondsFromMinutes(Convert.ToInt32(simularHasta.Text))));
            Int64 cantidadDeAviones = Convert.ToInt32(cantidadAvionesEnTierra.Text);
            Int64 minutosASimular = Convert.ToInt32(txtTiempoASimular.Text);
            double milisegundosASimular = getMillisecondsFromMinutes(minutosASimular);

            Int64 mediaLlegadaAeronaves = Convert.ToInt32(mediaExponencial.Text);

            Int64 desdeAterrizaje = Convert.ToInt32(aterrizajeDesde.Text);
            Int64 hastaAterrizaje = Convert.ToInt32(aterrizajeHasta.Text);

            Int64 desdeDespegue = Convert.ToInt32(despegueDesde.Text);
            Int64 hastaDespegue = Convert.ToInt32(despegueHasta.Text);

            Int64 esperaMedia = Convert.ToInt32(mediaEspera.Text);
            Int64 esperaDesviacion = Convert.ToInt32(desviacionEspera.Text);
            // -----------

            TimeSpan relojSimulacion = new TimeSpan(0, 0, 0);

            // ACUMULADORES 
            int contadorAterrizajesInstantaneos = 0;
            int contadorDespeguesInstantaneos = 0;
            TimeSpan tiempoLlegadaAcum = new TimeSpan(0, 0, 0);
            TimeSpan tiempoAterrizajeAcum = new TimeSpan(0, 0, 0);
            TimeSpan horaProximaLlegadaAcum = new TimeSpan(0, 0, 0);
            TimeSpan tiempoAcumuladoEsperaEnAire = new TimeSpan(0, 0, 0);
            TimeSpan tiempoAcumuladoEsperaEnTierra = new TimeSpan(0, 0, 0);
            TimeSpan horaFinMantenimientoPista = new TimeSpan(0, 0, 0);
            TimeSpan horaInicioMantenimientoPista = new TimeSpan(0, 0, 0);
            TimeSpan horaProximoEvento = new TimeSpan(0, 0, 0);
            Int64 contadorAeronavesEnTierra = 0;
            Int64 contadorAterrizajes = 0;
            Int64 contadorDespegues = 0;
            int contadorLlegadas = 0;

            // ------------

            bool pistaMantenimiento = false;
            string eventoActual;
            Int64 contadorNumeroNave = 1;

            while (relojSimulacion.TotalMilliseconds < milisegundosASimular)
            {
                if (relojSimulacion.TotalMilliseconds == 0)
                {
                    calcularRungeKutta(relojSimulacion);

                    // Primera fila
                    eventoActual = "Inicio";
                    double random = rnd.NextDouble();
                    double random2 = rnd.NextDouble();

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

                    //Proxima hora pista fuera de servicio.
                    horaInicioMantenimientoPista = getHoraMantenimiento(random2);
                    //----------------

                    dgvSimulacion.Rows.Add("0:00:00", eventoActual, random, tiempoLlegadaFormat, horaProximaLlegadaFormat, "", "", "", "", "", "", "", "", random2, getLocalHour(horaInicioMantenimientoPista), "", "", "", "", "", "", "", "");

                    horaProximoEvento = nextEvent(horaProximaLlegadaAcum, colaAterrizaje, colaDespegue, zonasAterrizaje, naveEnPista, horaFinMantenimientoPista, horaInicioMantenimientoPista, horaProximoEvento, pistaMantenimiento);
                }// Evento Inicio.
                else
                {
                    while (menorTiempoInicioDespegue(zonasAterrizaje) < horaProximoEvento)
                    {

                        // INGRESAR A LA COLA DE DESPEGUE

                        Aeroplane naveInicioDespegue = getAndDeleteAeroplaneMenorTiempoInicioDespegue(zonasAterrizaje);
                        colaDespegue.Enqueue(naveInicioDespegue);
                        contadorAeronavesEnTierra -= 1;
                        eventoActual = "Nave " + naveInicioDespegue.id.ToString() + " ingresa a la cola de despegue";
                        relojSimulacion = naveInicioDespegue.horaInicioDespegue;
                        horaProximoEvento = relojSimulacion;


                        if ((mostrarDesde.TotalSeconds < relojSimulacion.TotalSeconds) & (relojSimulacion.TotalSeconds < mostrarHasta.TotalSeconds))
                        {
                            dgvSimulacion.Rows.Add(getLocalHour(naveInicioDespegue.horaInicioDespegue), eventoActual, "", "", "", "", "", "", colaAterrizaje.Count, colaDespegue.Count, contadorAeronavesEnTierra.ToString(), naveEnPista != null ? "Nave " + naveEnPista.id.ToString() : "Pista Vacia", pistaMantenimiento ? "Pista en mantenimiento." : "Pista funcional.", "", "", "", "", "", "", "", "", contadorAterrizajes.ToString(), contadorDespegues.ToString(), tiempoAcumuladoEsperaEnAire.ToString(), tiempoAcumuladoEsperaEnTierra.ToString());
                        }
                    }

                    if ((horaProximoEvento >= horaFinMantenimientoPista) && pistaMantenimiento)
                    {
                        eventoActual = "Fin de mantenimiento de pista.";
                        pistaMantenimiento = false;
                        Double random = rnd.NextDouble();
                        horaInicioMantenimientoPista = horaFinMantenimientoPista + getHoraMantenimiento(random);
                        //Habria que tirar un random y definir a que hora sera el proximo congelamiento de pista / pista fuera de servicio.
                        if ((mostrarDesde.TotalSeconds < relojSimulacion.TotalSeconds) & (relojSimulacion.TotalSeconds < mostrarHasta.TotalSeconds))
                        {
                            dgvSimulacion.Rows.Add(getLocalHour(horaProximoEvento), eventoActual, "", "", "", "", "", "", colaAterrizaje.Count, colaDespegue.Count, contadorAeronavesEnTierra.ToString(), naveEnPista != null ? "Nave " + naveEnPista.id.ToString() : "Pista Vacia", pistaMantenimiento ? "Pista en mantenimiento." : "Pista funcional.", random, horaInicioMantenimientoPista, "", "", "", "", "", "", contadorAterrizajes.ToString(), contadorDespegues.ToString(), tiempoAcumuladoEsperaEnAire.ToString(), tiempoAcumuladoEsperaEnTierra.ToString());
                        }
                        horaFinMantenimientoPista = horaInicioMantenimientoPista;
                        horaProximoEvento = nextEvent(horaProximaLlegadaAcum, colaAterrizaje, colaDespegue, zonasAterrizaje, naveEnPista, horaFinMantenimientoPista, horaInicioMantenimientoPista, horaProximoEvento, pistaMantenimiento);

                    }

                    if ((horaProximoEvento >= horaInicioMantenimientoPista) && !pistaMantenimiento)
                    {
                        if (naveEnPista != null)
                        {

                        }
                        else
                        {
                            Double random = rnd.NextDouble();
                            eventoActual = "Inicio de mantenimiento de pista.";
                            horaFinMantenimientoPista = rungeKuttaLimpieza(contadorLlegadas, relojSimulacion);
                            pistaMantenimiento = true;
                            //Habria que tirar un random y definir a que hora sera el proximo congelamiento de pista / pista fuera de servicio.
                            if ((mostrarDesde.TotalSeconds < relojSimulacion.TotalSeconds) & (relojSimulacion.TotalSeconds < mostrarHasta.TotalSeconds))
                            {
                                dgvSimulacion.Rows.Add(getLocalHour(horaProximoEvento), eventoActual, "", "", "", "", "", "", colaAterrizaje.Count, colaDespegue.Count, contadorAeronavesEnTierra.ToString(), naveEnPista != null ? "Nave " + naveEnPista.id.ToString() : "Pista Vacia", pistaMantenimiento ? "Pista en mantenimiento." : "Pista funcional.", contadorLlegadas, horaFinMantenimientoPista, "", "", "", "", "", "", contadorAterrizajes.ToString(), contadorDespegues.ToString(), tiempoAcumuladoEsperaEnAire.ToString(), tiempoAcumuladoEsperaEnTierra.ToString());
                            }
                            contadorLlegadas = 0;
                            horaInicioMantenimientoPista = horaFinMantenimientoPista + getHoraMantenimiento(random);
                            horaProximoEvento = nextEvent(horaProximaLlegadaAcum, colaAterrizaje, colaDespegue, zonasAterrizaje, naveEnPista, horaFinMantenimientoPista, horaInicioMantenimientoPista, horaProximoEvento, pistaMantenimiento);
                        }

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
                                    contadorNumeroNave++;
                                    contadorLlegadas++;

                                    zonasAterrizaje.Add(nave);
                                    contadorAeronavesEnTierra += 1;

                                    double random = rnd.NextDouble();

                                    // Tiempo de llegada
                                    double tiempoLlegadaMinutos = generarNumeroExponencial(mediaLlegadaAeronaves, random);
                                    double tiempoLlegadaMilisegundos = getMillisecondsFromMinutes(tiempoLlegadaMinutos);
                                    TimeSpan tiempoLlegada = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(tiempoLlegadaMilisegundos));
                                    tiempoLlegadaAcum = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(tiempoLlegadaMilisegundos + tiempoLlegadaAcum.TotalMilliseconds));
                                    // -----------------

                                    // Hora de llegada
                                    TimeSpan horaProximaLlegada = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(tiempoLlegadaMilisegundos + horaProximoEvento.TotalMilliseconds));
                                    horaProximaLlegadaAcum = horaProximaLlegada;
                                    // ---------------



                                    // Lo agrego a la cola, ya que todavía no aterrizó y necesito buscarlo en el proximo evento
                                    colaAterrizaje.Enqueue(nave);

                                    if ((mostrarDesde.TotalSeconds < relojSimulacion.TotalSeconds) & (relojSimulacion.TotalSeconds < mostrarHasta.TotalSeconds))
                                    {

                                        string tiempoLlegadaFormat = getLocalHour(tiempoLlegada);
                                        string horaProximaLlegadaFormat = getLocalHour(horaProximaLlegada);
                                        string relojFila = getLocalHour(horaProximoEvento);
                                        dgvSimulacion.Rows.Add(relojFila, eventoActual, random, tiempoLlegadaFormat, horaProximaLlegadaFormat, "", "", "", colaAterrizaje.Count, colaDespegue.Count, contadorAeronavesEnTierra.ToString(), naveEnPista != null ? "Nave " + naveEnPista.id.ToString() : "Pista Vacia", pistaMantenimiento ? "Pista en mantenimiento." : "Pista funcional.", "", "", "", "", "", "", "", "", contadorAterrizajes.ToString(), contadorDespegues.ToString(), tiempoAcumuladoEsperaEnAire.ToString(), tiempoAcumuladoEsperaEnTierra.ToString());
                                    }

                                }
                                else
                                {
                                    //Redireccionar aeronave a otro aeropuerto, plazas/hangares llenos.
                                    double random = rnd.NextDouble();
                                    eventoActual = "Redireccionamiento de avion por hangares llenos";

                                    Tuple<TimeSpan, TimeSpan, TimeSpan> tupla = redireccionarAvion(random, mediaLlegadaAeronaves, tiempoLlegadaAcum, horaProximaLlegadaAcum, relojSimulacion, mostrarDesde, mostrarHasta);
                                    tiempoLlegadaAcum = tupla.Item1;
                                    horaProximaLlegadaAcum = tupla.Item2;
                                    TimeSpan tiempoLlegada = tupla.Item3;


                                    if ((mostrarDesde < relojSimulacion) & (relojSimulacion < mostrarHasta))
                                    {
                                        string tiempoLlegadaFormat = getLocalHour(tiempoLlegada);
                                        string horaProximaLlegadaFormat = getLocalHour(horaProximaLlegadaAcum);
                                        string relojFila = getLocalHour(relojSimulacion);

                                        dgvSimulacion.Rows.Add(relojFila, eventoActual, random, tiempoLlegadaFormat, horaProximaLlegadaFormat, "", "", "", colaAterrizaje.Count, colaDespegue.Count, contadorAeronavesEnTierra.ToString(), naveEnPista != null ? "Nave " + naveEnPista.id.ToString() : "Pista Vacia", pistaMantenimiento ? "Pista en mantenimiento." : "Pista funcional.", "", "", "", "", "", "", "", contadorAterrizajes.ToString(), contadorDespegues.ToString(), tiempoAcumuladoEsperaEnAire.ToString(), tiempoAcumuladoEsperaEnTierra.ToString());
                                    }
                                }

                                horaProximoEvento = nextEvent(horaProximaLlegadaAcum, colaAterrizaje, colaDespegue, zonasAterrizaje, naveEnPista, horaFinMantenimientoPista, horaInicioMantenimientoPista, horaProximoEvento, pistaMantenimiento);


                            }
                            else
                            {
                                // Proximo evento es el aterrizaje.
                                // Aterriza la nave => tiro random de estadía
                                contadorAterrizajes++;
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
                                // -----------------

                                // Hora de estadía
                                TimeSpan horaFinEstadia = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(tiempoEstadiaMilisegundos + relojSimulacion.TotalMilliseconds));
                                //horaProximaLlegadaAcum = horaProximaLlegada;
                                // ---------------

                                nave.horaInicioDespegue = horaFinEstadia;
                                nave.evento = "En Tierra";

                                naveEnPista = null;



                                if ((mostrarDesde.TotalSeconds < relojSimulacion.TotalSeconds) & (relojSimulacion.TotalSeconds < mostrarHasta.TotalSeconds))
                                {

                                    string tiempoEstadiaFormat = getLocalHour(tiempoEstadia);
                                    string horaFinEstadiaFormat = getLocalHour(horaFinEstadia);
                                    string relojFila = getLocalHour(relojSimulacion);
                                    dgvSimulacion.Rows.Add(relojFila, eventoActual, "", "", "", "", "", "", colaAterrizaje.Count, colaDespegue.Count, contadorAeronavesEnTierra.ToString(), naveEnPista != null ? "Nave " + naveEnPista.id.ToString() : "Pista Vacia", pistaMantenimiento ? "Pista en mantenimiento." : "Pista funcional.", "", "", random, tiempoEstadiaFormat, horaFinEstadiaFormat, "", "", "", contadorAterrizajes.ToString(), contadorDespegues.ToString(), tiempoAcumuladoEsperaEnAire.ToString(), tiempoAcumuladoEsperaEnTierra.ToString());
                                }


                                horaProximoEvento = nextEvent(horaProximaLlegadaAcum, colaAterrizaje, colaDespegue, zonasAterrizaje, naveEnPista, horaFinMantenimientoPista, horaInicioMantenimientoPista, horaProximoEvento, pistaMantenimiento);


                            }
                        }
                        else if (naveEnPista.evento == "Despegue")
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
                                    contadorNumeroNave++;
                                    contadorLlegadas++;

                                    zonasAterrizaje.Add(nave);
                                    contadorAeronavesEnTierra += 1;

                                    double random = rnd.NextDouble();

                                    // Tiempo de llegada
                                    double tiempoLlegadaMinutos = generarNumeroExponencial(mediaLlegadaAeronaves, random);
                                    double tiempoLlegadaMilisegundos = getMillisecondsFromMinutes(tiempoLlegadaMinutos);
                                    TimeSpan tiempoLlegada = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(tiempoLlegadaMilisegundos));
                                    tiempoLlegadaAcum = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(tiempoLlegadaMilisegundos + tiempoLlegadaAcum.TotalMilliseconds));
                                    // -----------------

                                    // Hora de llegada
                                    TimeSpan horaProximaLlegada = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(tiempoLlegadaMilisegundos + relojSimulacion.TotalMilliseconds));
                                    horaProximaLlegadaAcum = horaProximaLlegada;
                                    // ---------------

                                    // Lo agrego a la cola, ya que todavía no aterrizó y necesito buscarlo en el proximo evento
                                    colaAterrizaje.Enqueue(nave);

                                    if ((mostrarDesde.TotalSeconds < relojSimulacion.TotalSeconds) & (relojSimulacion.TotalSeconds < mostrarHasta.TotalSeconds))
                                    {
                                        string tiempoLlegadaFormat = getLocalHour(tiempoLlegada);
                                        string horaProximaLlegadaFormat = getLocalHour(horaProximaLlegada);
                                        string relojFila = getLocalHour(relojSimulacion);
                                        dgvSimulacion.Rows.Add(relojFila, eventoActual, random, tiempoLlegadaFormat, horaProximaLlegadaFormat, "", "", "", colaAterrizaje.Count, colaDespegue.Count, contadorAeronavesEnTierra.ToString(), naveEnPista != null ? "Nave " + naveEnPista.id.ToString() : "Pista Vacia", pistaMantenimiento ? "Pista en mantenimiento." : "Pista funcional.", "", "", "", "", "", "", "", "", contadorAterrizajes.ToString(), contadorDespegues.ToString(), tiempoAcumuladoEsperaEnAire.ToString(), tiempoAcumuladoEsperaEnTierra.ToString());
                                    }



                                }
                                else
                                {
                                    //Redireccionar aeronave a otro aeropuerto, plazas/hangares llenos.
                                    double random = rnd.NextDouble();
                                    eventoActual = "Redireccionamiento de avion por hangares llenos";

                                    Tuple<TimeSpan, TimeSpan, TimeSpan> tupla = redireccionarAvion(random, mediaLlegadaAeronaves, tiempoLlegadaAcum, horaProximaLlegadaAcum, relojSimulacion, mostrarDesde, mostrarHasta);
                                    tiempoLlegadaAcum = tupla.Item1;
                                    horaProximaLlegadaAcum = tupla.Item2;
                                    TimeSpan tiempoLlegada = tupla.Item3;


                                    if ((mostrarDesde < relojSimulacion) & (relojSimulacion < mostrarHasta))
                                    {
                                        string tiempoLlegadaFormat = getLocalHour(tiempoLlegada);
                                        string horaProximaLlegadaFormat = getLocalHour(horaProximaLlegadaAcum);
                                        string relojFila = getLocalHour(relojSimulacion);

                                        dgvSimulacion.Rows.Add(relojFila, eventoActual, random, tiempoLlegadaFormat, horaProximaLlegadaFormat, "", "", "", colaAterrizaje.Count, colaDespegue.Count, contadorAeronavesEnTierra.ToString(), naveEnPista != null ? "Nave " + naveEnPista.id.ToString() : "Pista Vacia", pistaMantenimiento ? "Pista en mantenimiento." : "Pista funcional.", "", "", "", "", "", "", "", contadorAterrizajes.ToString(), contadorDespegues.ToString(), tiempoAcumuladoEsperaEnAire.ToString(), tiempoAcumuladoEsperaEnTierra.ToString());
                                    }
                                }

                                horaProximoEvento = nextEvent(horaProximaLlegadaAcum, colaAterrizaje, colaDespegue, zonasAterrizaje, naveEnPista, horaFinMantenimientoPista, horaInicioMantenimientoPista, horaProximoEvento, pistaMantenimiento);

                                //
                            }
                            else
                            {
                                // Proximo evento es el despegue.

                                Aeroplane nave = naveEnPista;
                                contadorDespegues++;


                                eventoActual = "Despegue Nave " + nave.id;

                                relojSimulacion = naveEnPista.horaDespegue;

                                nave.evento = "Fuera de sistema";

                                naveEnPista = null;


                                if ((mostrarDesde.TotalSeconds < relojSimulacion.TotalSeconds) & (relojSimulacion.TotalSeconds < mostrarHasta.TotalSeconds))
                                {
                                    string relojFila = getLocalHour(relojSimulacion);
                                    dgvSimulacion.Rows.Add(relojFila, eventoActual, "", "", "", "", "", "", colaAterrizaje.Count, colaDespegue.Count, contadorAeronavesEnTierra.ToString(), naveEnPista != null ? "Nave " + naveEnPista.id.ToString() : "Pista Vacia", pistaMantenimiento ? "Pista en mantenimiento." : "Pista funcional.", "", "", "", "", "", "", "", "", contadorAterrizajes.ToString(), contadorDespegues.ToString(), tiempoAcumuladoEsperaEnAire.ToString(), tiempoAcumuladoEsperaEnTierra.ToString());
                                }

                                horaProximoEvento = nextEvent(horaProximaLlegadaAcum, colaAterrizaje, colaDespegue, zonasAterrizaje, naveEnPista, horaFinMantenimientoPista, horaInicioMantenimientoPista, horaProximoEvento, pistaMantenimiento);
                            }
                        }
                    }
                    else
                    {
                        // No hay nave en pista

                        // Prioridad cola de aterrizaje, la reviso primero
                        if (colaAterrizaje.Count != 0 && !pistaMantenimiento)
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
                            // -----------------

                            // Hora aterrizaje
                            TimeSpan horaProximoAterrizaje = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(tiempoAterrizajeMilisegundos + relojSimulacion.TotalMilliseconds));
                            // ---------------

                            nave.horaAterrizaje = horaProximoAterrizaje;

                            tiempoAcumuladoEsperaEnAire += (relojSimulacion - nave.horaLlegada);

                            if (relojSimulacion == nave.horaLlegada)
                            {
                                contadorAterrizajesInstantaneos++;
                            }


                            if ((mostrarDesde.TotalSeconds < relojSimulacion.TotalSeconds) & (relojSimulacion.TotalSeconds < mostrarHasta.TotalSeconds))
                            {

                                string tiempoAterrizajeFormat = getLocalHour(tiempoAterrizaje);
                                string horaAterrizajeFormat = getLocalHour(horaProximoAterrizaje);
                                string relojFila = getLocalHour(relojSimulacion);

                                dgvSimulacion.Rows.Add(relojFila, eventoActual, "", "", "", randomAterrizaje, tiempoAterrizajeFormat, horaAterrizajeFormat, colaAterrizaje.Count, colaDespegue.Count, contadorAeronavesEnTierra.ToString(), naveEnPista != null ? "Nave " + naveEnPista.id.ToString() : "Pista Vacia", pistaMantenimiento ? "Pista en mantenimiento." : "Pista funcional.", "", "", "", "", "", "", "", "", contadorAterrizajes.ToString(), contadorDespegues.ToString(), tiempoAcumuladoEsperaEnAire.ToString(), tiempoAcumuladoEsperaEnTierra.ToString());
                            }

                            // Como empieza a usar la pista, lo saco de la cola
                            colaAterrizaje.Dequeue();

                            horaProximoEvento = nextEvent(horaProximaLlegadaAcum, colaAterrizaje, colaDespegue, zonasAterrizaje, naveEnPista, horaFinMantenimientoPista, horaInicioMantenimientoPista, horaProximoEvento, pistaMantenimiento);

                        }
                        else if (colaDespegue.Count != 0 && !pistaMantenimiento)
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

                            tiempoAcumuladoEsperaEnTierra += (relojSimulacion - nave.horaInicioDespegue);

                            double random = rnd.NextDouble();


                            // Tiempo de despegue
                            double tiempoDespegueMinutos = generarNumeroUniforme(desdeDespegue, hastaDespegue, random);
                            double tiempoDespegueMilisegundos = getMillisecondsFromMinutes(tiempoDespegueMinutos);
                            TimeSpan tiempoDespegue = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(tiempoDespegueMilisegundos));
                            //tiempoLlegadaAcum = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(tiempoEstadiaMilisegundos + tiempoLlegadaAcum.TotalMilliseconds));
                            // -----------------

                            // Hora de despegue
                            TimeSpan horaDespegue = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(tiempoDespegueMilisegundos + relojSimulacion.TotalMilliseconds));
                            //horaProximaLlegadaAcum = horaProximaLlegada;

                            // ---------------

                            nave.horaDespegue = horaDespegue;

                            // Empiezo a usar la pista, sale de la cola y de la zona de aterrizaje
                            colaDespegue.Dequeue();

                            if (relojSimulacion == nave.horaInicioDespegue)
                            {
                                contadorDespeguesInstantaneos++;
                            }

                            if ((mostrarDesde.TotalSeconds < relojSimulacion.TotalSeconds) & (relojSimulacion.TotalSeconds < mostrarHasta.TotalSeconds))
                            {

                                string tiempoDespegueFormat = getLocalHour(tiempoDespegue);
                                string horaDespegueFormat = getLocalHour(horaDespegue);
                                string relojFila = getLocalHour(relojSimulacion);

                                dgvSimulacion.Rows.Add(relojFila, eventoActual, "", "", "", "", "", "", colaAterrizaje.Count, colaDespegue.Count, contadorAeronavesEnTierra.ToString(), naveEnPista != null ? "Nave " + naveEnPista.id.ToString() : "Pista Vacia", pistaMantenimiento ? "Pista en mantenimiento." : "Pista funcional.", "", "", "", "", "", random, tiempoDespegueFormat, horaDespegueFormat, contadorAterrizajes.ToString(), contadorDespegues.ToString(), tiempoAcumuladoEsperaEnAire.ToString(), tiempoAcumuladoEsperaEnTierra.ToString());
                            }

                            horaProximoEvento = nextEvent(horaProximaLlegadaAcum, colaAterrizaje, colaDespegue, zonasAterrizaje, naveEnPista, horaFinMantenimientoPista, horaInicioMantenimientoPista, horaProximoEvento, pistaMantenimiento);
                        }
                        else
                        {
                            if (horaProximoEvento == horaProximaLlegadaAcum)
                            {
           
                                eventoActual = "Llega Nave " + contadorNumeroNave;

                                if (contadorAeronavesEnTierra < cantidadDeAviones)
                                {
                                    Aeroplane nave = new Aeroplane(contadorNumeroNave, horaProximaLlegadaAcum);
                                    contadorNumeroNave++;
                                    contadorLlegadas++;

                                    zonasAterrizaje.Add(nave);
                                    contadorAeronavesEnTierra += 1;

                                    double random = rnd.NextDouble();

                                    // Tiempo de llegada
                                    double tiempoLlegadaMinutos = generarNumeroExponencial(mediaLlegadaAeronaves, random);
                                    double tiempoLlegadaMilisegundos = getMillisecondsFromMinutes(tiempoLlegadaMinutos);
                                    TimeSpan tiempoLlegada = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(tiempoLlegadaMilisegundos));
                                    tiempoLlegadaAcum = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(tiempoLlegadaMilisegundos + tiempoLlegadaAcum.TotalMilliseconds));
                                    // -----------------

                                    // Hora de llegada
                                    TimeSpan horaProximaLlegada = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(tiempoLlegadaMilisegundos + horaProximaLlegadaAcum.TotalMilliseconds));
                                    
                                    // ---------------

                                    colaAterrizaje.Enqueue(nave);
                                    if ((mostrarDesde < relojSimulacion) & (relojSimulacion < mostrarHasta))
                                    {
                                        string tiempoLlegadaFormat = getLocalHour(tiempoLlegada);
                                        string horaProximaLlegadaFormat = getLocalHour(horaProximaLlegada);
                                        string relojFila = getLocalHour(horaProximaLlegadaAcum);

                                        dgvSimulacion.Rows.Add(relojFila, eventoActual, random, tiempoLlegadaFormat, horaProximaLlegadaFormat, "", "", "", colaAterrizaje.Count, colaDespegue.Count, contadorAeronavesEnTierra.ToString(), naveEnPista != null ? "Nave " + naveEnPista.id.ToString() : "Pista Vacia", pistaMantenimiento ? "Pista en mantenimiento." : "Pista funcional.", "", "", "", "", "", "", "", "", contadorAterrizajes.ToString(), contadorDespegues.ToString(), tiempoAcumuladoEsperaEnAire.ToString(), tiempoAcumuladoEsperaEnTierra.ToString());
                                    }
                                    horaProximaLlegadaAcum = horaProximaLlegada;

                                }
                                else
                                {
                                    double random = rnd.NextDouble();

                                    eventoActual = "Redireccionamiento de avion por hangares llenos";

                                    // Tiempo de llegada
                                    double tiempoLlegadaMinutos = generarNumeroExponencial(mediaLlegadaAeronaves, random);
                                    double tiempoLlegadaMilisegundos = getMillisecondsFromMinutes(tiempoLlegadaMinutos);
                                    TimeSpan tiempoLlegada = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(tiempoLlegadaMilisegundos));
                                    tiempoLlegadaAcum = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(tiempoLlegadaMilisegundos + tiempoLlegadaAcum.TotalMilliseconds));
                                    // -----------------

                                    // Hora de llegada
                                    TimeSpan horaProximaLlegada = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(tiempoLlegadaMilisegundos + relojSimulacion.TotalMilliseconds));
                                    horaProximaLlegadaAcum = horaProximaLlegada;
                                    // ---------------


                                    if ((mostrarDesde.TotalSeconds < relojSimulacion.TotalSeconds) & (relojSimulacion.TotalSeconds < mostrarHasta.TotalSeconds))
                                    {
                                        string tiempoLlegadaFormat = getLocalHour(tiempoLlegada);
                                        string horaProximaLlegadaFormat = getLocalHour(horaProximaLlegada);
                                        string relojFila = getLocalHour(relojSimulacion);

                                        dgvSimulacion.Rows.Add(relojFila, eventoActual, random, tiempoLlegadaFormat, horaProximaLlegadaFormat, "", "", "", colaAterrizaje.Count, colaDespegue.Count, contadorAeronavesEnTierra.ToString(), naveEnPista != null ? "Nave " + naveEnPista.id.ToString() : "Pista Vacia", pistaMantenimiento ? "Pista en mantenimiento." : "Pista funcional.", "", "", "", "", "", contadorAterrizajes.ToString(), contadorDespegues.ToString(), tiempoAcumuladoEsperaEnAire.ToString(), tiempoAcumuladoEsperaEnTierra.ToString());
                                    }
                                }

                                horaProximoEvento = nextEvent(horaProximaLlegadaAcum, colaAterrizaje, colaDespegue, zonasAterrizaje, naveEnPista, horaFinMantenimientoPista, horaInicioMantenimientoPista, horaProximoEvento, pistaMantenimiento);
                            }
                        }

                    }
                }

                horaProximoEvento = nextEvent(horaProximaLlegadaAcum, colaAterrizaje, colaDespegue, zonasAterrizaje, naveEnPista, horaFinMantenimientoPista, horaInicioMantenimientoPista, horaProximoEvento, pistaMantenimiento);

                if (horaProximoEvento.TotalMilliseconds < 0)
                {
                    //error
                }

                relojSimulacion = horaProximoEvento;
            }
            TimeSpan horaFin = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(milisegundosASimular));
            dgvSimulacion.Rows.Add(getLocalHour(horaFin), "Fin de simulacion", "", "", "", "", "", "", colaAterrizaje.Count, colaDespegue.Count, contadorAeronavesEnTierra.ToString(), "", "", "", "", "", "", "", contadorAterrizajes.ToString(), contadorDespegues.ToString(), tiempoAcumuladoEsperaEnAire.ToString(), tiempoAcumuladoEsperaEnTierra.ToString());

            if (contadorAterrizajes == 0) { contadorAterrizajes = 1; }
            if (contadorDespegues == 0) { contadorDespegues = 1; }

            TimeSpan mediaEsperaAire = new TimeSpan(0, 0, 0, Convert.ToInt32(tiempoAcumuladoEsperaEnAire.TotalSeconds / contadorAterrizajes));
            TimeSpan mediaEsperaTierra = new TimeSpan(0, 0, 0, Convert.ToInt32(tiempoAcumuladoEsperaEnTierra.TotalSeconds / contadorDespegues));

            mediaEsperaEnAire.Text = mediaEsperaAire.Hours + ":" + mediaEsperaAire.Minutes + ":" + mediaEsperaAire.Seconds;
            mediaEsperaEnTierra.Text = mediaEsperaTierra.Hours + ":" + mediaEsperaTierra.Minutes + ":" + mediaEsperaTierra.Seconds;

            totalAterrizaron.Text = contadorAterrizajes.ToString();
            totalDespegaron.Text = contadorDespegues.ToString();

            porcentajeNavesAterrizaje.Text = Math.Round((Convert.ToDouble(contadorAterrizajesInstantaneos) / Convert.ToDouble(contadorAterrizajes)), 2).ToString();
            porcentajeNavesDespegue.Text = Math.Round((Convert.ToDouble(contadorDespeguesInstantaneos) / Convert.ToDouble(contadorDespegues)), 2).ToString();

        }

        private void calcularRungeKutta(TimeSpan relojSistema)
        {
            probabilidad3 = new TimeSpan(0, Convert.ToInt32(rungeKutta(relojSistema, 50)), 0);
            dgvRungeKutta.Rows.Clear();
            probabilidad2 = new TimeSpan(0, Convert.ToInt32(rungeKutta(relojSistema, 75)), 0);
            dgvRungeKutta.Rows.Clear();
            probabilidad1 = new TimeSpan(0, Convert.ToInt32(rungeKutta(relojSistema, 100)), 0);
        }

        private TimeSpan getHoraMantenimiento(double random)
        {
            if (random < 0.49)
            {
                return probabilidad1;
            }
            else if (random < 0.79)
            {
                return probabilidad2;
            }
            else
            {
                return probabilidad3;
            }
        }

        private Tuple<TimeSpan, TimeSpan, TimeSpan> redireccionarAvion(double random, Int64 mediaLlegadaAeronaves, TimeSpan tiempoLlegadaAcum, TimeSpan horaProximaLlegadaAcum, TimeSpan relojSimulacion, TimeSpan mostrarDesde, TimeSpan mostrarHasta)
        {
            // Si al llegar una aeronave en la estación aérea hay 30 unidades(entre las que “esperan en tierra” y las que se encuentran estacionadas), 
            // ésta es derivada a otra estación aérea

            // Tiempo de llegada
            double tiempoLlegadaMinutos = generarNumeroExponencial(mediaLlegadaAeronaves, random);
            double tiempoLlegadaMilisegundos = getMillisecondsFromMinutes(tiempoLlegadaMinutos);
            TimeSpan tiempoLlegada = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(tiempoLlegadaMilisegundos));
            tiempoLlegadaAcum = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(tiempoLlegadaMilisegundos + tiempoLlegadaAcum.TotalMilliseconds));
            // -----------------

            // Hora de llegada
            TimeSpan horaProximaLlegada = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(tiempoLlegadaMilisegundos + relojSimulacion.TotalMilliseconds));
            horaProximaLlegadaAcum = horaProximaLlegada;
            // ---------------

            return Tuple.Create(tiempoLlegadaAcum, horaProximaLlegadaAcum, tiempoLlegada);
        }

        public string getLocalHour(TimeSpan time)

        {
            string days = "";
            string hourString = "";
            string minuteString = "";
            string secondString = "";

            days = time.Days.ToString();

            if (Convert.ToString(time.Hours).Length == 1)
            {
                hourString = "0" + time.Hours;
            }
            else
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

            return "Dia: " + days + " " + hourString + ":" + minuteString + ":" + secondString;
        }
        public double getMillisecondsFromMinutes(double minutes)
        {
            return minutes * 60000;
        }

        private void txtTiempoASimular_TextChanged(object sender, EventArgs e)
        {
            simularHasta.Text = txtTiempoASimular.Text;
        }

        public class Fila
        {
            private Int64 nroFila;
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

            public Fila(Int64 nroFila, string reloj, string evento, string randomLlegada, string tiempoEntreLlegadas, string proximaLLegada, string randomAterrizaje, string tiempoAterrizaje,
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

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            textBox2.Text = "-" + textBox1.Text;
        }
    }
}
