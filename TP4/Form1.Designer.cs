namespace TP4
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
            this.tn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.k1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.k2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.k3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.k4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.aterrizajeDesde.Text = "3";
            this.aterrizajeDesde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // aterrizajeHasta
            // 
            this.aterrizajeHasta.Location = new System.Drawing.Point(125, 36);
            this.aterrizajeHasta.Name = "aterrizajeHasta";
            this.aterrizajeHasta.Size = new System.Drawing.Size(80, 20);
            this.aterrizajeHasta.TabIndex = 1;
            this.aterrizajeHasta.Text = "5";
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
            this.despegueHasta.TabIndex = 3;
            this.despegueHasta.Text = "4";
            this.despegueHasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // despegueDesde
            // 
            this.despegueDesde.Location = new System.Drawing.Point(25, 37);
            this.despegueDesde.Name = "despegueDesde";
            this.despegueDesde.Size = new System.Drawing.Size(80, 20);
            this.despegueDesde.TabIndex = 2;
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
            this.mediaEspera.TabIndex = 18;
            this.mediaEspera.Text = "80";
            this.mediaEspera.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // desviacionEspera
            // 
            this.desviacionEspera.Location = new System.Drawing.Point(87, 68);
            this.desviacionEspera.Name = "desviacionEspera";
            this.desviacionEspera.Size = new System.Drawing.Size(80, 20);
            this.desviacionEspera.TabIndex = 17;
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
            this.iniciarSimulacion.TabIndex = 32;
            this.iniciarSimulacion.Text = "Iniciar Simulacion";
            this.iniciarSimulacion.UseVisualStyleBackColor = true;
            this.iniciarSimulacion.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTiempoASimular
            // 
            this.txtTiempoASimular.Location = new System.Drawing.Point(43, 25);
            this.txtTiempoASimular.Name = "txtTiempoASimular";
            this.txtTiempoASimular.Size = new System.Drawing.Size(80, 20);
            this.txtTiempoASimular.TabIndex = 33;
            this.txtTiempoASimular.Text = "150";
            this.txtTiempoASimular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.simularHasta.TabIndex = 36;
            this.simularHasta.Text = "150";
            this.simularHasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // simularDesde
            // 
            this.simularDesde.Location = new System.Drawing.Point(350, 28);
            this.simularDesde.Name = "simularDesde";
            this.simularDesde.Size = new System.Drawing.Size(80, 20);
            this.simularDesde.TabIndex = 35;
            this.simularDesde.Text = "0";
            this.simularDesde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cantidadAvionesEnTierra
            // 
            this.cantidadAvionesEnTierra.Location = new System.Drawing.Point(1039, 38);
            this.cantidadAvionesEnTierra.Name = "cantidadAvionesEnTierra";
            this.cantidadAvionesEnTierra.Size = new System.Drawing.Size(80, 20);
            this.cantidadAvionesEnTierra.TabIndex = 17;
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
            this.tn,
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
            // tn
            // 
            this.tn.HeaderText = "tn";
            this.tn.Name = "tn";
            // 
            // Yn
            // 
            this.Yn.HeaderText = "Yn";
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
            // SimulacionTP5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1881, 787);
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
        private System.Windows.Forms.TextBox porcentajeNavesDespegue;
        private System.Windows.Forms.TextBox porcentajeNavesAterrizaje;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Simulacion;
        private System.Windows.Forms.TabPage Runge;
        private System.Windows.Forms.DataGridView dgvRungeKutta;
        private System.Windows.Forms.DataGridViewTextBoxColumn tn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yn;
        private System.Windows.Forms.DataGridViewTextBoxColumn k1;
        private System.Windows.Forms.DataGridViewTextBoxColumn k2;
        private System.Windows.Forms.DataGridViewTextBoxColumn k3;
        private System.Windows.Forms.DataGridViewTextBoxColumn k4;
    }
}

