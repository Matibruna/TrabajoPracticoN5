﻿namespace TP4
{
    partial class SimulacionTP5
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimulacionTP5));
            this.dgvSimulacion = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RNDDemora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Demora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Orden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.navesTierra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RNDMantenimientoPista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RNDEstadia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoEstadia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFinEstadia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esperaEnAire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esperaTierra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aterrizajeDesde = new System.Windows.Forms.TextBox();
            this.aterrizajeHasta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.despegueHasta = new System.Windows.Forms.TextBox();
            this.despegueDesde = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.mediaEspera = new System.Windows.Forms.TextBox();
            this.desviacionEspera = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.mediaExponencial = new System.Windows.Forms.TextBox();
            this.iniciarSimulacion = new System.Windows.Forms.Button();
            this.txtTiempoASimular = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.simularHasta = new System.Windows.Forms.TextBox();
            this.simularDesde = new System.Windows.Forms.TextBox();
            this.cantidadAvionesEnTierra = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.mediaEsperaEnAire = new System.Windows.Forms.TextBox();
            this.mati = new System.Windows.Forms.Label();
            this.totalAterrizaron = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.totalDespegaron = new System.Windows.Forms.TextBox();
            this.mediaEsperaEnTierra = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.porcentajeNavesDespegue = new System.Windows.Forms.TextBox();
            this.porcentajeNavesAterrizaje = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Simulacion = new System.Windows.Forms.TabPage();
            this.Runge = new System.Windows.Forms.TabPage();
            this.dgvRungeKutta = new System.Windows.Forms.DataGridView();
            this.t = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.k1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.k2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.k3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.k4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvRungeKuttaLimpieza = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LLt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.rk1 = new System.Windows.Forms.TextBox();
            this.rk2 = new System.Windows.Forms.TextBox();
            this.rk3 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimulacion)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Simulacion.SuspendLayout();
            this.Runge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRungeKutta)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRungeKuttaLimpieza)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSimulacion
            // 
            this.dgvSimulacion.AllowUserToAddRows = false;
            this.dgvSimulacion.AllowUserToDeleteRows = false;
            this.dgvSimulacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSimulacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.RNDDemora,
            this.Demora,
            this.Orden,
            this.Disponible,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn6,
            this.navesTierra,
            this.dataGridViewTextBoxColumn7,
            this.Column1,
            this.RNDMantenimientoPista,
            this.Column2,
            this.RNDEstadia,
            this.TiempoEstadia,
            this.HoraFinEstadia,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.esperaEnAire,
            this.esperaTierra});
            this.dgvSimulacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSimulacion.Location = new System.Drawing.Point(3, 3);
            this.dgvSimulacion.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSimulacion.Name = "dgvSimulacion";
            this.dgvSimulacion.ReadOnly = true;
            this.dgvSimulacion.RowTemplate.Height = 28;
            this.dgvSimulacion.Size = new System.Drawing.Size(1843, 561);
            this.dgvSimulacion.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Reloj";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Evento";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "RNDllegada";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // RNDDemora
            // 
            this.RNDDemora.HeaderText = "Tiempo Entre Llegada";
            this.RNDDemora.Name = "RNDDemora";
            this.RNDDemora.ReadOnly = true;
            // 
            // Demora
            // 
            this.Demora.HeaderText = "Proxima Llegada";
            this.Demora.Name = "Demora";
            this.Demora.ReadOnly = true;
            // 
            // Orden
            // 
            this.Orden.HeaderText = "RNDaterrizaje";
            this.Orden.Name = "Orden";
            this.Orden.ReadOnly = true;
            // 
            // Disponible
            // 
            this.Disponible.HeaderText = "Tiempo de Aterrizaje";
            this.Disponible.Name = "Disponible";
            this.Disponible.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Hora de aterrizaje";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Cola Espera Aterrizaje";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Cola Espera Despegue";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // navesTierra
            // 
            this.navesTierra.HeaderText = "Naves en Tierra";
            this.navesTierra.Name = "navesTierra";
            this.navesTierra.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "En Pista";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Pista En Mantenimiento";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // RNDMantenimientoPista
            // 
            this.RNDMantenimientoPista.HeaderText = "RND Mantenimiento";
            this.RNDMantenimientoPista.Name = "RNDMantenimientoPista";
            this.RNDMantenimientoPista.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tiempo Inicio/Fin Mantenimiento";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // RNDEstadia
            // 
            this.RNDEstadia.HeaderText = "RNDEstadia";
            this.RNDEstadia.Name = "RNDEstadia";
            this.RNDEstadia.ReadOnly = true;
            // 
            // TiempoEstadia
            // 
            this.TiempoEstadia.HeaderText = "Tiempo Estadia";
            this.TiempoEstadia.Name = "TiempoEstadia";
            this.TiempoEstadia.ReadOnly = true;
            // 
            // HoraFinEstadia
            // 
            this.HoraFinEstadia.HeaderText = "Hora Fin Estadia";
            this.HoraFinEstadia.Name = "HoraFinEstadia";
            this.HoraFinEstadia.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "RNDespegue";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Tiempo de Despegue";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Hora Despegue";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Cantidad de Aterrizajes";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "Cantidad de Despegues";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // esperaEnAire
            // 
            this.esperaEnAire.HeaderText = "Acumulado Espera en Aire";
            this.esperaEnAire.Name = "esperaEnAire";
            this.esperaEnAire.ReadOnly = true;
            // 
            // esperaTierra
            // 
            this.esperaTierra.HeaderText = "Acumulado Espera en Tierra";
            this.esperaTierra.Name = "esperaTierra";
            this.esperaTierra.ReadOnly = true;
            // 
            // aterrizajeDesde
            // 
            this.aterrizajeDesde.Location = new System.Drawing.Point(23, 36);
            this.aterrizajeDesde.Name = "aterrizajeDesde";
            this.aterrizajeDesde.Size = new System.Drawing.Size(80, 20);
            this.aterrizajeDesde.TabIndex = 0;
            this.aterrizajeDesde.Text = "5";
            this.aterrizajeDesde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // aterrizajeHasta
            // 
            this.aterrizajeHasta.Location = new System.Drawing.Point(125, 36);
            this.aterrizajeHasta.Name = "aterrizajeHasta";
            this.aterrizajeHasta.Size = new System.Drawing.Size(80, 20);
            this.aterrizajeHasta.TabIndex = 1;
            this.aterrizajeHasta.Text = "6";
            this.aterrizajeHasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "minutos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "minutos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "-";
            // 
            // despegueHasta
            // 
            this.despegueHasta.Location = new System.Drawing.Point(127, 37);
            this.despegueHasta.Name = "despegueHasta";
            this.despegueHasta.Size = new System.Drawing.Size(80, 20);
            this.despegueHasta.TabIndex = 10;
            this.despegueHasta.Text = "4";
            this.despegueHasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // despegueDesde
            // 
            this.despegueDesde.Location = new System.Drawing.Point(25, 37);
            this.despegueDesde.Name = "despegueDesde";
            this.despegueDesde.Size = new System.Drawing.Size(80, 20);
            this.despegueDesde.TabIndex = 9;
            this.despegueDesde.Text = "2";
            this.despegueDesde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "(Uniforme)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "(Normal)";
            // 
            // mediaEspera
            // 
            this.mediaEspera.Location = new System.Drawing.Point(87, 39);
            this.mediaEspera.Name = "mediaEspera";
            this.mediaEspera.Size = new System.Drawing.Size(80, 20);
            this.mediaEspera.TabIndex = 7;
            this.mediaEspera.Text = "80";
            this.mediaEspera.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // desviacionEspera
            // 
            this.desviacionEspera.Location = new System.Drawing.Point(87, 68);
            this.desviacionEspera.Name = "desviacionEspera";
            this.desviacionEspera.Size = new System.Drawing.Size(80, 20);
            this.desviacionEspera.TabIndex = 8;
            this.desviacionEspera.Text = "30";
            this.desviacionEspera.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Desviacion:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(173, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "minutos";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "(Exp. Negativa)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(149, 42);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "minutos";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 42);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 13);
            this.label17.TabIndex = 29;
            this.label17.Text = "Media:";
            // 
            // mediaExponencial
            // 
            this.mediaExponencial.Location = new System.Drawing.Point(63, 39);
            this.mediaExponencial.Name = "mediaExponencial";
            this.mediaExponencial.Size = new System.Drawing.Size(80, 20);
            this.mediaExponencial.TabIndex = 27;
            this.mediaExponencial.Text = "10";
            this.mediaExponencial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // iniciarSimulacion
            // 
            this.iniciarSimulacion.Location = new System.Drawing.Point(68, 63);
            this.iniciarSimulacion.Name = "iniciarSimulacion";
            this.iniciarSimulacion.Size = new System.Drawing.Size(137, 56);
            this.iniciarSimulacion.TabIndex = 3;
            this.iniciarSimulacion.Text = "Iniciar Simulacion";
            this.iniciarSimulacion.UseVisualStyleBackColor = true;
            this.iniciarSimulacion.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTiempoASimular
            // 
            this.txtTiempoASimular.Location = new System.Drawing.Point(43, 25);
            this.txtTiempoASimular.Name = "txtTiempoASimular";
            this.txtTiempoASimular.Size = new System.Drawing.Size(80, 20);
            this.txtTiempoASimular.TabIndex = 0;
            this.txtTiempoASimular.Text = "150";
            this.txtTiempoASimular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTiempoASimular.TextChanged += new System.EventHandler(this.txtTiempoASimular_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(126, 28);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(111, 13);
            this.label19.TabIndex = 34;
            this.label19.Text = "Minutos de simulación";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.mediaExponencial);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Location = new System.Drawing.Point(12, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 67);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Llegada de aeronaves";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.aterrizajeDesde);
            this.groupBox2.Controls.Add(this.aterrizajeHasta);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(220, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 75);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aterrizaje de aeronaves";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.despegueHasta);
            this.groupBox3.Controls.Add(this.despegueDesde);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(733, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(269, 75);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Despegue de aeronaves";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "(Uniforme)";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.mediaEspera);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.desviacionEspera);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Location = new System.Drawing.Point(495, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(232, 95);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tiempo de espera en tierra";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Media:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(173, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "minutos";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.simularHasta);
            this.groupBox5.Controls.Add(this.simularDesde);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.txtTiempoASimular);
            this.groupBox5.Controls.Add(this.iniciarSimulacion);
            this.groupBox5.Location = new System.Drawing.Point(1162, 17);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(461, 133);
            this.groupBox5.TabIndex = 36;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Simulacion";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(271, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 38;
            this.label13.Text = "Simular hasta";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(271, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 37;
            this.label12.Text = "Simular desde";
            // 
            // simularHasta
            // 
            this.simularHasta.Location = new System.Drawing.Point(350, 82);
            this.simularHasta.Name = "simularHasta";
            this.simularHasta.Size = new System.Drawing.Size(80, 20);
            this.simularHasta.TabIndex = 2;
            this.simularHasta.Text = "150";
            this.simularHasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // simularDesde
            // 
            this.simularDesde.Location = new System.Drawing.Point(350, 28);
            this.simularDesde.Name = "simularDesde";
            this.simularDesde.Size = new System.Drawing.Size(80, 20);
            this.simularDesde.TabIndex = 1;
            this.simularDesde.Text = "0";
            this.simularDesde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cantidadAvionesEnTierra
            // 
            this.cantidadAvionesEnTierra.Location = new System.Drawing.Point(1039, 38);
            this.cantidadAvionesEnTierra.Name = "cantidadAvionesEnTierra";
            this.cantidadAvionesEnTierra.Size = new System.Drawing.Size(80, 20);
            this.cantidadAvionesEnTierra.TabIndex = 11;
            this.cantidadAvionesEnTierra.Text = "30";
            this.cantidadAvionesEnTierra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1008, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Cantidad de aviones en tierra:";
            // 
            // mediaEsperaEnAire
            // 
            this.mediaEsperaEnAire.Enabled = false;
            this.mediaEsperaEnAire.Location = new System.Drawing.Point(186, 755);
            this.mediaEsperaEnAire.Name = "mediaEsperaEnAire";
            this.mediaEsperaEnAire.Size = new System.Drawing.Size(80, 20);
            this.mediaEsperaEnAire.TabIndex = 39;
            this.mediaEsperaEnAire.TabStop = false;
            this.mediaEsperaEnAire.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mati
            // 
            this.mati.AutoSize = true;
            this.mati.Location = new System.Drawing.Point(52, 758);
            this.mati.Name = "mati";
            this.mati.Size = new System.Drawing.Size(121, 13);
            this.mati.TabIndex = 17;
            this.mati.Text = "Media de espera en aire";
            // 
            // totalAterrizaron
            // 
            this.totalAterrizaron.Enabled = false;
            this.totalAterrizaron.Location = new System.Drawing.Point(656, 755);
            this.totalAterrizaron.Name = "totalAterrizaron";
            this.totalAterrizaron.Size = new System.Drawing.Size(80, 20);
            this.totalAterrizaron.TabIndex = 40;
            this.totalAterrizaron.TabStop = false;
            this.totalAterrizaron.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(491, 758);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(159, 13);
            this.label18.TabIndex = 41;
            this.label18.Text = "Total de aviones que aterrizaron";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(742, 758);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(166, 13);
            this.label20.TabIndex = 42;
            this.label20.Text = "Total de aviones que despegaron";
            // 
            // totalDespegaron
            // 
            this.totalDespegaron.Enabled = false;
            this.totalDespegaron.Location = new System.Drawing.Point(914, 755);
            this.totalDespegaron.Name = "totalDespegaron";
            this.totalDespegaron.Size = new System.Drawing.Size(80, 20);
            this.totalDespegaron.TabIndex = 43;
            this.totalDespegaron.TabStop = false;
            this.totalDespegaron.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mediaEsperaEnTierra
            // 
            this.mediaEsperaEnTierra.Enabled = false;
            this.mediaEsperaEnTierra.Location = new System.Drawing.Point(405, 755);
            this.mediaEsperaEnTierra.Name = "mediaEsperaEnTierra";
            this.mediaEsperaEnTierra.Size = new System.Drawing.Size(80, 20);
            this.mediaEsperaEnTierra.TabIndex = 44;
            this.mediaEsperaEnTierra.TabStop = false;
            this.mediaEsperaEnTierra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(272, 758);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(127, 13);
            this.label21.TabIndex = 45;
            this.label21.Text = "Media de espera en tierra";
            // 
            // porcentajeNavesDespegue
            // 
            this.porcentajeNavesDespegue.Enabled = false;
            this.porcentajeNavesDespegue.Location = new System.Drawing.Point(1749, 755);
            this.porcentajeNavesDespegue.Name = "porcentajeNavesDespegue";
            this.porcentajeNavesDespegue.Size = new System.Drawing.Size(80, 20);
            this.porcentajeNavesDespegue.TabIndex = 46;
            this.porcentajeNavesDespegue.TabStop = false;
            this.porcentajeNavesDespegue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // porcentajeNavesAterrizaje
            // 
            this.porcentajeNavesAterrizaje.Enabled = false;
            this.porcentajeNavesAterrizaje.Location = new System.Drawing.Point(1329, 755);
            this.porcentajeNavesAterrizaje.Name = "porcentajeNavesAterrizaje";
            this.porcentajeNavesAterrizaje.Size = new System.Drawing.Size(80, 20);
            this.porcentajeNavesAterrizaje.TabIndex = 47;
            this.porcentajeNavesAterrizaje.TabStop = false;
            this.porcentajeNavesAterrizaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(1000, 758);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(323, 13);
            this.label22.TabIndex = 48;
            this.label22.Text = "Porcentaje de naves que comienzan instantaneamente el aterrizaje";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(1415, 758);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(328, 13);
            this.label23.TabIndex = 49;
            this.label23.Text = "Porcentaje de naves que comienzan instantaneamente el despegue";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Simulacion);
            this.tabControl1.Controls.Add(this.Runge);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 156);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1857, 593);
            this.tabControl1.TabIndex = 50;
            // 
            // Simulacion
            // 
            this.Simulacion.Controls.Add(this.dgvSimulacion);
            this.Simulacion.Location = new System.Drawing.Point(4, 22);
            this.Simulacion.Name = "Simulacion";
            this.Simulacion.Padding = new System.Windows.Forms.Padding(3);
            this.Simulacion.Size = new System.Drawing.Size(1849, 567);
            this.Simulacion.TabIndex = 0;
            this.Simulacion.Text = "Simulacion";
            this.Simulacion.UseVisualStyleBackColor = true;
            // 
            // Runge
            // 
            this.Runge.Controls.Add(this.dgvRungeKutta);
            this.Runge.Location = new System.Drawing.Point(4, 22);
            this.Runge.Name = "Runge";
            this.Runge.Padding = new System.Windows.Forms.Padding(3);
            this.Runge.Size = new System.Drawing.Size(1849, 567);
            this.Runge.TabIndex = 1;
            this.Runge.Text = "Runge-Kutta";
            this.Runge.UseVisualStyleBackColor = true;
            // 
            // dgvRungeKutta
            // 
            this.dgvRungeKutta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRungeKutta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.t,
            this.Yn,
            this.k1,
            this.k2,
            this.k3,
            this.k4});
            this.dgvRungeKutta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRungeKutta.Location = new System.Drawing.Point(3, 3);
            this.dgvRungeKutta.Name = "dgvRungeKutta";
            this.dgvRungeKutta.Size = new System.Drawing.Size(1843, 561);
            this.dgvRungeKutta.TabIndex = 0;
            // 
            // t
            // 
            this.t.HeaderText = "t";
            this.t.Name = "t";
            // 
            // Yn
            // 
            this.Yn.HeaderText = "E";
            this.Yn.Name = "Yn";
            // 
            // k1
            // 
            this.k1.HeaderText = "k1";
            this.k1.Name = "k1";
            // 
            // k2
            // 
            this.k2.HeaderText = "k2";
            this.k2.Name = "k2";
            // 
            // k3
            // 
            this.k3.HeaderText = "k3";
            this.k3.Name = "k3";
            // 
            // k4
            // 
            this.k4.HeaderText = "k4";
            this.k4.Name = "k4";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvRungeKuttaLimpieza);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1849, 567);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Runge-Kutta Limpieza";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvRungeKuttaLimpieza
            // 
            this.dgvRungeKuttaLimpieza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRungeKuttaLimpieza.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.LLt});
            this.dgvRungeKuttaLimpieza.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRungeKuttaLimpieza.Location = new System.Drawing.Point(3, 3);
            this.dgvRungeKuttaLimpieza.Name = "dgvRungeKuttaLimpieza";
            this.dgvRungeKuttaLimpieza.Size = new System.Drawing.Size(1843, 561);
            this.dgvRungeKuttaLimpieza.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "t";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "L";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "k1";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.HeaderText = "k2";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.HeaderText = "k3";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.HeaderText = "k4";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // LLt
            // 
            this.LLt.HeaderText = "L - Lt+1";
            this.LLt.Name = "LLt";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBox3);
            this.groupBox6.Controls.Add(this.label25);
            this.groupBox6.Controls.Add(this.label24);
            this.groupBox6.Controls.Add(this.textBox1);
            this.groupBox6.Controls.Add(this.label27);
            this.groupBox6.Controls.Add(this.textBox2);
            this.groupBox6.Location = new System.Drawing.Point(1629, 17);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(240, 133);
            this.groupBox6.TabIndex = 37;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Ecuacion Diferencial";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(105, 94);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(129, 20);
            this.textBox3.TabIndex = 14;
            this.textBox3.Text = "0.025";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(0, 97);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(105, 13);
            this.label25.TabIndex = 30;
            this.label25.Text = "Alpha recomendado:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(61, 44);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(37, 13);
            this.label24.TabIndex = 29;
            this.label24.Text = "Alpha:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "0.0035328119";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(66, 71);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(32, 13);
            this.label27.TabIndex = 24;
            this.label27.Text = "Beta:";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(104, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(129, 20);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = "-0.0035328119";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rk1
            // 
            this.rk1.Enabled = false;
            this.rk1.Location = new System.Drawing.Point(756, 130);
            this.rk1.Name = "rk1";
            this.rk1.Size = new System.Drawing.Size(80, 20);
            this.rk1.TabIndex = 51;
            this.rk1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rk2
            // 
            this.rk2.Enabled = false;
            this.rk2.Location = new System.Drawing.Point(842, 130);
            this.rk2.Name = "rk2";
            this.rk2.Size = new System.Drawing.Size(80, 20);
            this.rk2.TabIndex = 52;
            this.rk2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rk3
            // 
            this.rk3.Enabled = false;
            this.rk3.Location = new System.Drawing.Point(928, 130);
            this.rk3.Name = "rk3";
            this.rk3.Size = new System.Drawing.Size(80, 20);
            this.rk3.TabIndex = 53;
            this.rk3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(768, 114);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(234, 13);
            this.label26.TabIndex = 17;
            this.label26.Text = "Tiempos asociados al mantenimiento de la pista.";
            // 
            // SimulacionTP5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1881, 787);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.rk3);
            this.Controls.Add(this.rk2);
            this.Controls.Add(this.rk1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.porcentajeNavesAterrizaje);
            this.Controls.Add(this.porcentajeNavesDespegue);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.mediaEsperaEnTierra);
            this.Controls.Add(this.totalDespegaron);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.totalAterrizaron);
            this.Controls.Add(this.mati);
            this.Controls.Add(this.mediaEsperaEnAire);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cantidadAvionesEnTierra);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SimulacionTP5";
            this.Text = "Simulacion TP°5";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimulacion)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.Simulacion.ResumeLayout(false);
            this.Runge.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRungeKutta)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRungeKuttaLimpieza)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSimulacion;
        private System.Windows.Forms.TextBox aterrizajeDesde;
        private System.Windows.Forms.TextBox aterrizajeHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox despegueHasta;
        private System.Windows.Forms.TextBox despegueDesde;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox mediaEspera;
        private System.Windows.Forms.TextBox desviacionEspera;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox mediaExponencial;
        private System.Windows.Forms.Button iniciarSimulacion;
        private System.Windows.Forms.TextBox txtTiempoASimular;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox cantidadAvionesEnTierra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox simularHasta;
        private System.Windows.Forms.TextBox simularDesde;
        private System.Windows.Forms.TextBox mediaEsperaEnAire;
        private System.Windows.Forms.Label mati;
        private System.Windows.Forms.TextBox totalAterrizaron;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox totalDespegaron;
        private System.Windows.Forms.TextBox mediaEsperaEnTierra;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox porcentajeNavesDespegue;
        private System.Windows.Forms.TextBox porcentajeNavesAterrizaje;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Simulacion;
        private System.Windows.Forms.TabPage Runge;
        private System.Windows.Forms.DataGridView dgvRungeKutta;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn t;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yn;
        private System.Windows.Forms.DataGridViewTextBoxColumn k1;
        private System.Windows.Forms.DataGridViewTextBoxColumn k2;
        private System.Windows.Forms.DataGridViewTextBoxColumn k3;
        private System.Windows.Forms.DataGridViewTextBoxColumn k4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvRungeKuttaLimpieza;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn LLt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn RNDDemora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Demora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Orden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn navesTierra;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RNDMantenimientoPista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn RNDEstadia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoEstadia;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFinEstadia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn esperaEnAire;
        private System.Windows.Forms.DataGridViewTextBoxColumn esperaTierra;
        private System.Windows.Forms.TextBox rk1;
        private System.Windows.Forms.TextBox rk2;
        private System.Windows.Forms.TextBox rk3;
        private System.Windows.Forms.Label label26;
    }
}

