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
            this.cantidadAvionesEnTierra = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.simularDesde = new System.Windows.Forms.TextBox();
            this.simularHasta = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimulacion)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
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
            this.esperaEnAire});
            this.dgvSimulacion.Location = new System.Drawing.Point(9, 192);
            this.dgvSimulacion.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSimulacion.Name = "dgvSimulacion";
            this.dgvSimulacion.ReadOnly = true;
            this.dgvSimulacion.RowTemplate.Height = 28;
            this.dgvSimulacion.Size = new System.Drawing.Size(2041, 497);
            this.dgvSimulacion.TabIndex = 6;
            this.dgvSimulacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSimulacion_CellContentClick);
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
            this.label8.Click += new System.EventHandler(this.label8_Click);
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
            this.mediaEspera.TextChanged += new System.EventHandler(this.mediaEspera_TextChanged);
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
            this.groupBox1.Location = new System.Drawing.Point(22, 58);
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
            this.groupBox2.Location = new System.Drawing.Point(315, 55);
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
            this.groupBox3.Location = new System.Drawing.Point(1062, 55);
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
            this.groupBox4.Location = new System.Drawing.Point(722, 35);
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
            this.groupBox5.Location = new System.Drawing.Point(1576, 27);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(461, 133);
            this.groupBox5.TabIndex = 36;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Simulacion";
            // 
            // cantidadAvionesEnTierra
            // 
            this.cantidadAvionesEnTierra.Location = new System.Drawing.Point(1431, 91);
            this.cantidadAvionesEnTierra.Name = "cantidadAvionesEnTierra";
            this.cantidadAvionesEnTierra.Size = new System.Drawing.Size(80, 20);
            this.cantidadAvionesEnTierra.TabIndex = 17;
            this.cantidadAvionesEnTierra.Text = "30";
            this.cantidadAvionesEnTierra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1399, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Cantidad de aviones en tierra:";
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
            // simularHasta
            // 
            this.simularHasta.Location = new System.Drawing.Point(350, 82);
            this.simularHasta.Name = "simularHasta";
            this.simularHasta.Size = new System.Drawing.Size(80, 20);
            this.simularHasta.TabIndex = 36;
            this.simularHasta.Text = "150";
            this.simularHasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(271, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 38;
            this.label13.Text = "Simular hasta";
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
            // SimulacionTP5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2061, 700);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cantidadAvionesEnTierra);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvSimulacion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SimulacionTP5";
            this.Text = "Simulacion TP°5";
            this.Load += new System.EventHandler(this.SimulacionTP5_Load);
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
    }
}

