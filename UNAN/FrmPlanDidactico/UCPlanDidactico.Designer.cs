﻿namespace UNAN.FrmPlanDidactico
{
    partial class UCPlanDidactico
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.GBDetalles = new System.Windows.Forms.GroupBox();
            this.cbSemestre = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbGrupo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDocente = new System.Windows.Forms.TextBox();
            this.txtAAcademico = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbAsignaturas = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnSubirPlan = new System.Windows.Forms.Button();
            this.btnSubir = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPorcentaje = new System.Windows.Forms.TextBox();
            this.dtFechaInico = new System.Windows.Forms.DateTimePicker();
            this.dtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEstEva = new System.Windows.Forms.TextBox();
            this.txtForEva = new System.Windows.Forms.TextBox();
            this.txtCont = new System.Windows.Forms.TextBox();
            this.txtEstEnsApr = new System.Windows.Forms.TextBox();
            this.txtObj = new System.Windows.Forms.TextBox();
            this.txtSemInicio = new System.Windows.Forms.TextBox();
            this.txtSemFin = new System.Windows.Forms.TextBox();
            this.dtPlan = new System.Windows.Forms.DataGridView();
            this.fInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SIncio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Objetivos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contenidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstEnsApr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormEva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstrEva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbCarrera = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.GBDetalles.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtPlan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1137, 45);
            this.panel1.TabIndex = 0;
            // 
            // GBDetalles
            // 
            this.GBDetalles.BackColor = System.Drawing.Color.White;
            this.GBDetalles.Controls.Add(this.cbCarrera);
            this.GBDetalles.Controls.Add(this.label17);
            this.GBDetalles.Controls.Add(this.cbSemestre);
            this.GBDetalles.Controls.Add(this.label6);
            this.GBDetalles.Controls.Add(this.cbGrupo);
            this.GBDetalles.Controls.Add(this.label4);
            this.GBDetalles.Controls.Add(this.txtDocente);
            this.GBDetalles.Controls.Add(this.txtAAcademico);
            this.GBDetalles.Controls.Add(this.label3);
            this.GBDetalles.Controls.Add(this.cbAsignaturas);
            this.GBDetalles.Controls.Add(this.label5);
            this.GBDetalles.Controls.Add(this.label2);
            this.GBDetalles.Dock = System.Windows.Forms.DockStyle.Top;
            this.GBDetalles.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBDetalles.Location = new System.Drawing.Point(0, 45);
            this.GBDetalles.Name = "GBDetalles";
            this.GBDetalles.Size = new System.Drawing.Size(1137, 110);
            this.GBDetalles.TabIndex = 1;
            this.GBDetalles.TabStop = false;
            // 
            // cbSemestre
            // 
            this.cbSemestre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbSemestre.FormattingEnabled = true;
            this.cbSemestre.Items.AddRange(new object[] {
            "l",
            "ll"});
            this.cbSemestre.Location = new System.Drawing.Point(519, 65);
            this.cbSemestre.Name = "cbSemestre";
            this.cbSemestre.Size = new System.Drawing.Size(161, 30);
            this.cbSemestre.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(417, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 26);
            this.label6.TabIndex = 4;
            this.label6.Text = "Semestre:";
            // 
            // cbGrupo
            // 
            this.cbGrupo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbGrupo.FormattingEnabled = true;
            this.cbGrupo.Items.AddRange(new object[] {
            "Primer Año",
            "Segundo Año",
            "Tercer Año",
            "Cuarto Año",
            "Quinto Año"});
            this.cbGrupo.Location = new System.Drawing.Point(799, 62);
            this.cbGrupo.Name = "cbGrupo";
            this.cbGrupo.Size = new System.Drawing.Size(240, 30);
            this.cbGrupo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(716, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Grupo:";
            // 
            // txtDocente
            // 
            this.txtDocente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDocente.Location = new System.Drawing.Point(130, 66);
            this.txtDocente.Name = "txtDocente";
            this.txtDocente.Size = new System.Drawing.Size(260, 29);
            this.txtDocente.TabIndex = 3;
            // 
            // txtAAcademico
            // 
            this.txtAAcademico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtAAcademico.Location = new System.Drawing.Point(580, 25);
            this.txtAAcademico.Name = "txtAAcademico";
            this.txtAAcademico.Size = new System.Drawing.Size(100, 29);
            this.txtAAcademico.TabIndex = 3;
            this.txtAAcademico.Text = "20";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(409, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Año Académico:";
            // 
            // cbAsignaturas
            // 
            this.cbAsignaturas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbAsignaturas.FormattingEnabled = true;
            this.cbAsignaturas.Items.AddRange(new object[] {
            "Estructura l",
            "Estructura ll",
            "Prog Alg",
            "Inf Bas",
            "Fund Prog"});
            this.cbAsignaturas.Location = new System.Drawing.Point(130, 22);
            this.cbAsignaturas.Name = "cbAsignaturas";
            this.cbAsignaturas.Size = new System.Drawing.Size(260, 30);
            this.cbAsignaturas.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "Docente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Asignatura:";
            // 
            // gbDatos
            // 
            this.gbDatos.BackColor = System.Drawing.Color.White;
            this.gbDatos.Controls.Add(this.flowLayoutPanel1);
            this.gbDatos.Controls.Add(this.label14);
            this.gbDatos.Controls.Add(this.txtPorcentaje);
            this.gbDatos.Controls.Add(this.dtFechaInico);
            this.gbDatos.Controls.Add(this.dtFechaFin);
            this.gbDatos.Controls.Add(this.label13);
            this.gbDatos.Controls.Add(this.label12);
            this.gbDatos.Controls.Add(this.label11);
            this.gbDatos.Controls.Add(this.label10);
            this.gbDatos.Controls.Add(this.label9);
            this.gbDatos.Controls.Add(this.label16);
            this.gbDatos.Controls.Add(this.label8);
            this.gbDatos.Controls.Add(this.label15);
            this.gbDatos.Controls.Add(this.label7);
            this.gbDatos.Controls.Add(this.txtEstEva);
            this.gbDatos.Controls.Add(this.txtForEva);
            this.gbDatos.Controls.Add(this.txtCont);
            this.gbDatos.Controls.Add(this.txtEstEnsApr);
            this.gbDatos.Controls.Add(this.txtObj);
            this.gbDatos.Controls.Add(this.txtSemInicio);
            this.gbDatos.Controls.Add(this.txtSemFin);
            this.gbDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDatos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatos.Location = new System.Drawing.Point(0, 155);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(1137, 296);
            this.gbDatos.TabIndex = 2;
            this.gbDatos.TabStop = false;
            this.gbDatos.Enter += new System.EventHandler(this.gbDatos_Enter);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnInsertar);
            this.flowLayoutPanel1.Controls.Add(this.btnSubirPlan);
            this.flowLayoutPanel1.Controls.Add(this.btnSubir);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(279, 238);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(567, 50);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.Blue;
            this.btnInsertar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInsertar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsertar.FlatAppearance.BorderSize = 0;
            this.btnInsertar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.ForeColor = System.Drawing.Color.White;
            this.btnInsertar.Image = global::UNAN.Properties.Resources.Add_32x;
            this.btnInsertar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertar.Location = new System.Drawing.Point(3, 3);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(121, 39);
            this.btnInsertar.TabIndex = 5;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInsertar.UseVisualStyleBackColor = false;
            // 
            // btnSubirPlan
            // 
            this.btnSubirPlan.BackColor = System.Drawing.Color.Blue;
            this.btnSubirPlan.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubirPlan.ForeColor = System.Drawing.Color.White;
            this.btnSubirPlan.Image = global::UNAN.Properties.Resources.save32px;
            this.btnSubirPlan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubirPlan.Location = new System.Drawing.Point(130, 3);
            this.btnSubirPlan.Name = "btnSubirPlan";
            this.btnSubirPlan.Size = new System.Drawing.Size(178, 39);
            this.btnSubirPlan.TabIndex = 6;
            this.btnSubirPlan.Text = "Guardar Plan Didáctico";
            this.btnSubirPlan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSubirPlan.UseVisualStyleBackColor = false;
            // 
            // btnSubir
            // 
            this.btnSubir.BackColor = System.Drawing.Color.Blue;
            this.btnSubir.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubir.ForeColor = System.Drawing.Color.White;
            this.btnSubir.Image = global::UNAN.Properties.Resources.up_32px;
            this.btnSubir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubir.Location = new System.Drawing.Point(314, 3);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(226, 39);
            this.btnSubir.TabIndex = 5;
            this.btnSubir.Text = "Subir Plan Didáctico";
            this.btnSubir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSubir.UseVisualStyleBackColor = false;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(66, 241);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 24);
            this.label14.TabIndex = 4;
            this.label14.Text = "%:";
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.Location = new System.Drawing.Point(110, 238);
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.Size = new System.Drawing.Size(100, 26);
            this.txtPorcentaje.TabIndex = 3;
            this.txtPorcentaje.Text = "%";
            // 
            // dtFechaInico
            // 
            this.dtFechaInico.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaInico.Location = new System.Drawing.Point(110, 18);
            this.dtFechaInico.Name = "dtFechaInico";
            this.dtFechaInico.Size = new System.Drawing.Size(109, 26);
            this.dtFechaInico.TabIndex = 2;
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFin.Location = new System.Drawing.Point(110, 68);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(109, 26);
            this.dtFechaFin.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(845, 117);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(225, 24);
            this.label13.TabIndex = 1;
            this.label13.Text = "Estrategia de Evaluacion:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(472, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(195, 24);
            this.label12.TabIndex = 1;
            this.label12.Text = "Forma de Evaluacion:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(762, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 24);
            this.label11.TabIndex = 1;
            this.label11.Text = "Contenido:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(342, 24);
            this.label10.TabIndex = 1;
            this.label10.Text = "Estrategia de Enseñanza - Aprendizaje:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(394, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 24);
            this.label9.TabIndex = 1;
            this.label9.Text = "Objetivos:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(225, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(113, 20);
            this.label16.TabIndex = 1;
            this.label16.Text = "Semana Inicio:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(225, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Semana Fin:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(3, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 20);
            this.label15.TabIndex = 1;
            this.label15.Text = "Fecha Inicio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Fecha Fin:";
            // 
            // txtEstEva
            // 
            this.txtEstEva.Location = new System.Drawing.Point(779, 142);
            this.txtEstEva.Multiline = true;
            this.txtEstEva.Name = "txtEstEva";
            this.txtEstEva.Size = new System.Drawing.Size(352, 78);
            this.txtEstEva.TabIndex = 0;
            // 
            // txtForEva
            // 
            this.txtForEva.Location = new System.Drawing.Point(394, 142);
            this.txtForEva.Multiline = true;
            this.txtForEva.Name = "txtForEva";
            this.txtForEva.Size = new System.Drawing.Size(352, 78);
            this.txtForEva.TabIndex = 0;
            // 
            // txtCont
            // 
            this.txtCont.Location = new System.Drawing.Point(872, 21);
            this.txtCont.Multiline = true;
            this.txtCont.Name = "txtCont";
            this.txtCont.Size = new System.Drawing.Size(259, 78);
            this.txtCont.TabIndex = 0;
            // 
            // txtEstEnsApr
            // 
            this.txtEstEnsApr.Location = new System.Drawing.Point(9, 142);
            this.txtEstEnsApr.Multiline = true;
            this.txtEstEnsApr.Name = "txtEstEnsApr";
            this.txtEstEnsApr.Size = new System.Drawing.Size(352, 78);
            this.txtEstEnsApr.TabIndex = 0;
            // 
            // txtObj
            // 
            this.txtObj.Location = new System.Drawing.Point(497, 28);
            this.txtObj.Multiline = true;
            this.txtObj.Name = "txtObj";
            this.txtObj.Size = new System.Drawing.Size(261, 78);
            this.txtObj.TabIndex = 0;
            // 
            // txtSemInicio
            // 
            this.txtSemInicio.BackColor = System.Drawing.Color.White;
            this.txtSemInicio.Enabled = false;
            this.txtSemInicio.Location = new System.Drawing.Point(344, 18);
            this.txtSemInicio.Name = "txtSemInicio";
            this.txtSemInicio.Size = new System.Drawing.Size(59, 26);
            this.txtSemInicio.TabIndex = 0;
            // 
            // txtSemFin
            // 
            this.txtSemFin.BackColor = System.Drawing.Color.White;
            this.txtSemFin.Enabled = false;
            this.txtSemFin.Location = new System.Drawing.Point(329, 68);
            this.txtSemFin.Name = "txtSemFin";
            this.txtSemFin.Size = new System.Drawing.Size(58, 26);
            this.txtSemFin.TabIndex = 0;
            this.txtSemFin.TextChanged += new System.EventHandler(this.txtSemFin_TextChanged);
            // 
            // dtPlan
            // 
            this.dtPlan.AllowUserToAddRows = false;
            this.dtPlan.AllowUserToDeleteRows = false;
            this.dtPlan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtPlan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtPlan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPlan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fInicio,
            this.SIncio,
            this.FFin,
            this.Objetivos,
            this.Contenidos,
            this.EstEnsApr,
            this.FormEva,
            this.EstrEva,
            this.Porcentaje});
            this.dtPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtPlan.Location = new System.Drawing.Point(0, 451);
            this.dtPlan.Name = "dtPlan";
            this.dtPlan.ReadOnly = true;
            this.dtPlan.RowHeadersVisible = false;
            this.dtPlan.RowHeadersWidth = 82;
            this.dtPlan.Size = new System.Drawing.Size(1137, 472);
            this.dtPlan.TabIndex = 3;
            // 
            // fInicio
            // 
            this.fInicio.HeaderText = "FInicio";
            this.fInicio.MinimumWidth = 10;
            this.fInicio.Name = "fInicio";
            this.fInicio.ReadOnly = true;
            // 
            // SIncio
            // 
            this.SIncio.HeaderText = "SemanaI";
            this.SIncio.MinimumWidth = 10;
            this.SIncio.Name = "SIncio";
            this.SIncio.ReadOnly = true;
            // 
            // FFin
            // 
            this.FFin.HeaderText = "FFin";
            this.FFin.MinimumWidth = 10;
            this.FFin.Name = "FFin";
            this.FFin.ReadOnly = true;
            // 
            // Objetivos
            // 
            this.Objetivos.HeaderText = "Objetivos";
            this.Objetivos.MinimumWidth = 10;
            this.Objetivos.Name = "Objetivos";
            this.Objetivos.ReadOnly = true;
            // 
            // Contenidos
            // 
            this.Contenidos.HeaderText = "Contenidos";
            this.Contenidos.MinimumWidth = 10;
            this.Contenidos.Name = "Contenidos";
            this.Contenidos.ReadOnly = true;
            // 
            // EstEnsApr
            // 
            this.EstEnsApr.HeaderText = "EstEnsApr";
            this.EstEnsApr.MinimumWidth = 10;
            this.EstEnsApr.Name = "EstEnsApr";
            this.EstEnsApr.ReadOnly = true;
            // 
            // FormEva
            // 
            this.FormEva.HeaderText = "FormEva";
            this.FormEva.MinimumWidth = 10;
            this.FormEva.Name = "FormEva";
            this.FormEva.ReadOnly = true;
            // 
            // EstrEva
            // 
            this.EstrEva.HeaderText = "EstrEva";
            this.EstrEva.MinimumWidth = 10;
            this.EstrEva.Name = "EstrEva";
            this.EstrEva.ReadOnly = true;
            // 
            // Porcentaje
            // 
            this.Porcentaje.HeaderText = "%";
            this.Porcentaje.MinimumWidth = 10;
            this.Porcentaje.Name = "Porcentaje";
            this.Porcentaje.ReadOnly = true;
            // 
            // cbCarrera
            // 
            this.cbCarrera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbCarrera.FormattingEnabled = true;
            this.cbCarrera.Items.AddRange(new object[] {
            "Primer Año",
            "Segundo Año",
            "Tercer Año",
            "Cuarto Año",
            "Quinto Año"});
            this.cbCarrera.Location = new System.Drawing.Point(797, 18);
            this.cbCarrera.Name = "cbCarrera";
            this.cbCarrera.Size = new System.Drawing.Size(240, 30);
            this.cbCarrera.TabIndex = 7;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(701, 22);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(90, 26);
            this.label17.TabIndex = 6;
            this.label17.Text = "Carrera:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1137, 16);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Yellow;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1137, 17);
            this.panel3.TabIndex = 1;
            // 
            // UCPlanDidactico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtPlan);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.GBDetalles);
            this.Controls.Add(this.panel1);
            this.Name = "UCPlanDidactico";
            this.Size = new System.Drawing.Size(1137, 923);
            this.panel1.ResumeLayout(false);
            this.GBDetalles.ResumeLayout(false);
            this.GBDetalles.PerformLayout();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtPlan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox GBDetalles;
        private System.Windows.Forms.ComboBox cbAsignaturas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbGrupo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAAcademico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSemestre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDocente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.TextBox txtSemFin;
        private System.Windows.Forms.DateTimePicker dtFechaFin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEstEnsApr;
        private System.Windows.Forms.TextBox txtObj;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtForEva;
        private System.Windows.Forms.TextBox txtCont;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPorcentaje;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEstEva;
        private System.Windows.Forms.DateTimePicker dtFechaInico;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSemInicio;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.DataGridView dtPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn fInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn SIncio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Objetivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contenidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstEnsApr;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormEva;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstrEva;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porcentaje;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnSubir;
        private System.Windows.Forms.Button btnSubirPlan;
        private System.Windows.Forms.ComboBox cbCarrera;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}
