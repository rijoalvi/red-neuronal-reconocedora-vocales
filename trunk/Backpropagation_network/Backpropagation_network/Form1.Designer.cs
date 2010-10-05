namespace Backpropagation_network
{
    partial class PantallaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelIndicacionesDibujo = new System.Windows.Forms.LinkLabel();
            this.labelIndicacionesDibujo2 = new System.Windows.Forms.LinkLabel();
            this.labelIndicacionesDibujo3 = new System.Windows.Forms.LinkLabel();
            this.botonBorrarTodo = new System.Windows.Forms.Button();
            this.modos = new System.Windows.Forms.TabControl();
            this.modoEntrenamiento = new System.Windows.Forms.TabPage();
            this.groupBoxEntrenamiento = new System.Windows.Forms.GroupBox();
            this.botonEntrenar = new System.Windows.Forms.Button();
            this.labelNeuronasOcultas = new System.Windows.Forms.Label();
            this.numericUpDownCantNeuronas = new System.Windows.Forms.NumericUpDown();
            this.labelError = new System.Windows.Forms.Label();
            this.numericUpDownError = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxNuevoConjunto = new System.Windows.Forms.GroupBox();
            this.botonGuardarConjunto = new System.Windows.Forms.Button();
            this.labelElementosConjunto = new System.Windows.Forms.Label();
            this.listBoxVocales = new System.Windows.Forms.ListBox();
            this.comboVocales = new System.Windows.Forms.ComboBox();
            this.labelComboVocales = new System.Windows.Forms.Label();
            this.botonCrearConjuntoEntrenamiento = new System.Windows.Forms.Button();
            this.modoEjecucion = new System.Windows.Forms.TabPage();
            this.botonSalir = new System.Windows.Forms.Button();
            this.panelError = new System.Windows.Forms.Panel();
            this.modos.SuspendLayout();
            this.modoEntrenamiento.SuspendLayout();
            this.groupBoxEntrenamiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantNeuronas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownError)).BeginInit();
            this.groupBoxNuevoConjunto.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(431, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 0;
            // 
            // labelIndicacionesDibujo
            // 
            this.labelIndicacionesDibujo.AutoSize = true;
            this.labelIndicacionesDibujo.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.labelIndicacionesDibujo.Location = new System.Drawing.Point(12, 421);
            this.labelIndicacionesDibujo.Name = "labelIndicacionesDibujo";
            this.labelIndicacionesDibujo.Size = new System.Drawing.Size(376, 13);
            this.labelIndicacionesDibujo.TabIndex = 0;
            this.labelIndicacionesDibujo.TabStop = true;
            this.labelIndicacionesDibujo.Text = "Para realizar un dibujo, haga click sobre el cuadro de dibujo y empice a dibujar";
            // 
            // labelIndicacionesDibujo2
            // 
            this.labelIndicacionesDibujo2.AutoSize = true;
            this.labelIndicacionesDibujo2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.labelIndicacionesDibujo2.Location = new System.Drawing.Point(12, 443);
            this.labelIndicacionesDibujo2.Name = "labelIndicacionesDibujo2";
            this.labelIndicacionesDibujo2.Size = new System.Drawing.Size(335, 13);
            this.labelIndicacionesDibujo2.TabIndex = 1;
            this.labelIndicacionesDibujo2.TabStop = true;
            this.labelIndicacionesDibujo2.Text = "Para terminar el dibujo, vuelva a hacer click sobre el cuadro de dibujo";
            // 
            // labelIndicacionesDibujo3
            // 
            this.labelIndicacionesDibujo3.AutoSize = true;
            this.labelIndicacionesDibujo3.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.labelIndicacionesDibujo3.Location = new System.Drawing.Point(12, 466);
            this.labelIndicacionesDibujo3.Name = "labelIndicacionesDibujo3";
            this.labelIndicacionesDibujo3.Size = new System.Drawing.Size(414, 13);
            this.labelIndicacionesDibujo3.TabIndex = 2;
            this.labelIndicacionesDibujo3.TabStop = true;
            this.labelIndicacionesDibujo3.Text = "Si termino el dibujo, puede volver a hacer click y continuar nuevamente donde lo " +
                "dejo.";
            // 
            // botonBorrarTodo
            // 
            this.botonBorrarTodo.Location = new System.Drawing.Point(12, 494);
            this.botonBorrarTodo.Name = "botonBorrarTodo";
            this.botonBorrarTodo.Size = new System.Drawing.Size(75, 23);
            this.botonBorrarTodo.TabIndex = 0;
            this.botonBorrarTodo.Text = "Borrar Todo";
            this.botonBorrarTodo.UseVisualStyleBackColor = true;
            this.botonBorrarTodo.Click += new System.EventHandler(this.button1_Click);
            // 
            // modos
            // 
            this.modos.Controls.Add(this.modoEntrenamiento);
            this.modos.Controls.Add(this.modoEjecucion);
            this.modos.Location = new System.Drawing.Point(431, 12);
            this.modos.Name = "modos";
            this.modos.SelectedIndex = 0;
            this.modos.Size = new System.Drawing.Size(400, 505);
            this.modos.TabIndex = 0;
            // 
            // modoEntrenamiento
            // 
            this.modoEntrenamiento.BackColor = System.Drawing.SystemColors.Control;
            this.modoEntrenamiento.Controls.Add(this.groupBoxEntrenamiento);
            this.modoEntrenamiento.Controls.Add(this.groupBoxNuevoConjunto);
            this.modoEntrenamiento.Controls.Add(this.botonCrearConjuntoEntrenamiento);
            this.modoEntrenamiento.Location = new System.Drawing.Point(4, 22);
            this.modoEntrenamiento.Name = "modoEntrenamiento";
            this.modoEntrenamiento.Padding = new System.Windows.Forms.Padding(3);
            this.modoEntrenamiento.Size = new System.Drawing.Size(392, 479);
            this.modoEntrenamiento.TabIndex = 0;
            this.modoEntrenamiento.Text = "Modo Entrenamiento";
            // 
            // groupBoxEntrenamiento
            // 
            this.groupBoxEntrenamiento.Controls.Add(this.panelError);
            this.groupBoxEntrenamiento.Controls.Add(this.botonEntrenar);
            this.groupBoxEntrenamiento.Controls.Add(this.labelNeuronasOcultas);
            this.groupBoxEntrenamiento.Controls.Add(this.numericUpDownCantNeuronas);
            this.groupBoxEntrenamiento.Controls.Add(this.labelError);
            this.groupBoxEntrenamiento.Controls.Add(this.numericUpDownError);
            this.groupBoxEntrenamiento.Controls.Add(this.label1);
            this.groupBoxEntrenamiento.Controls.Add(this.button2);
            this.groupBoxEntrenamiento.Controls.Add(this.textBox1);
            this.groupBoxEntrenamiento.Location = new System.Drawing.Point(6, 263);
            this.groupBoxEntrenamiento.Name = "groupBoxEntrenamiento";
            this.groupBoxEntrenamiento.Size = new System.Drawing.Size(380, 210);
            this.groupBoxEntrenamiento.TabIndex = 5;
            this.groupBoxEntrenamiento.TabStop = false;
            this.groupBoxEntrenamiento.Text = "Entrenamiento";
            // 
            // botonEntrenar
            // 
            this.botonEntrenar.Location = new System.Drawing.Point(286, 51);
            this.botonEntrenar.Name = "botonEntrenar";
            this.botonEntrenar.Size = new System.Drawing.Size(75, 23);
            this.botonEntrenar.TabIndex = 9;
            this.botonEntrenar.Text = "Entrenar!";
            this.botonEntrenar.UseVisualStyleBackColor = true;
            // 
            // labelNeuronasOcultas
            // 
            this.labelNeuronasOcultas.AutoSize = true;
            this.labelNeuronasOcultas.Location = new System.Drawing.Point(158, 59);
            this.labelNeuronasOcultas.Name = "labelNeuronasOcultas";
            this.labelNeuronasOcultas.Size = new System.Drawing.Size(92, 13);
            this.labelNeuronasOcultas.TabIndex = 8;
            this.labelNeuronasOcultas.Text = "Neuronas Ocultas";
            // 
            // numericUpDownCantNeuronas
            // 
            this.numericUpDownCantNeuronas.Location = new System.Drawing.Point(161, 75);
            this.numericUpDownCantNeuronas.Maximum = new decimal(new int[] {
            225,
            0,
            0,
            0});
            this.numericUpDownCantNeuronas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCantNeuronas.Name = "numericUpDownCantNeuronas";
            this.numericUpDownCantNeuronas.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownCantNeuronas.TabIndex = 7;
            this.numericUpDownCantNeuronas.Value = new decimal(new int[] {
            168,
            0,
            0,
            0});
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(158, 19);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(75, 13);
            this.labelError.TabIndex = 6;
            this.labelError.Text = "Error Permitido";
            // 
            // numericUpDownError
            // 
            this.numericUpDownError.DecimalPlaces = 2;
            this.numericUpDownError.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownError.Location = new System.Drawing.Point(161, 36);
            this.numericUpDownError.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownError.Name = "numericUpDownError";
            this.numericUpDownError.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownError.TabIndex = 5;
            this.numericUpDownError.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownError.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Conjunto para entrenar:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(108, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(93, 20);
            this.textBox1.TabIndex = 0;
            // 
            // groupBoxNuevoConjunto
            // 
            this.groupBoxNuevoConjunto.Controls.Add(this.botonGuardarConjunto);
            this.groupBoxNuevoConjunto.Controls.Add(this.labelElementosConjunto);
            this.groupBoxNuevoConjunto.Controls.Add(this.listBoxVocales);
            this.groupBoxNuevoConjunto.Controls.Add(this.comboVocales);
            this.groupBoxNuevoConjunto.Controls.Add(this.labelComboVocales);
            this.groupBoxNuevoConjunto.Location = new System.Drawing.Point(6, 35);
            this.groupBoxNuevoConjunto.Name = "groupBoxNuevoConjunto";
            this.groupBoxNuevoConjunto.Size = new System.Drawing.Size(380, 222);
            this.groupBoxNuevoConjunto.TabIndex = 4;
            this.groupBoxNuevoConjunto.TabStop = false;
            this.groupBoxNuevoConjunto.Text = "Datos del nuevo conjunto";
            // 
            // botonGuardarConjunto
            // 
            this.botonGuardarConjunto.Location = new System.Drawing.Point(248, 147);
            this.botonGuardarConjunto.Name = "botonGuardarConjunto";
            this.botonGuardarConjunto.Size = new System.Drawing.Size(75, 23);
            this.botonGuardarConjunto.TabIndex = 7;
            this.botonGuardarConjunto.Text = "Guardar";
            this.botonGuardarConjunto.UseVisualStyleBackColor = true;
            // 
            // labelElementosConjunto
            // 
            this.labelElementosConjunto.AutoSize = true;
            this.labelElementosConjunto.Location = new System.Drawing.Point(6, 80);
            this.labelElementosConjunto.Name = "labelElementosConjunto";
            this.labelElementosConjunto.Size = new System.Drawing.Size(117, 13);
            this.labelElementosConjunto.TabIndex = 6;
            this.labelElementosConjunto.Text = "Elementos del conjunto";
            // 
            // listBoxVocales
            // 
            this.listBoxVocales.FormattingEnabled = true;
            this.listBoxVocales.Location = new System.Drawing.Point(6, 96);
            this.listBoxVocales.Name = "listBoxVocales";
            this.listBoxVocales.Size = new System.Drawing.Size(177, 121);
            this.listBoxVocales.TabIndex = 5;
            // 
            // comboVocales
            // 
            this.comboVocales.BackColor = System.Drawing.SystemColors.Control;
            this.comboVocales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboVocales.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboVocales.FormattingEnabled = true;
            this.comboVocales.Items.AddRange(new object[] {
            "A",
            "E",
            "I",
            "O",
            "U"});
            this.comboVocales.Location = new System.Drawing.Point(6, 43);
            this.comboVocales.Name = "comboVocales";
            this.comboVocales.Size = new System.Drawing.Size(34, 21);
            this.comboVocales.TabIndex = 0;
            // 
            // labelComboVocales
            // 
            this.labelComboVocales.AutoSize = true;
            this.labelComboVocales.Location = new System.Drawing.Point(6, 27);
            this.labelComboVocales.Name = "labelComboVocales";
            this.labelComboVocales.Size = new System.Drawing.Size(34, 13);
            this.labelComboVocales.TabIndex = 1;
            this.labelComboVocales.Text = "Vocal";
            // 
            // botonCrearConjuntoEntrenamiento
            // 
            this.botonCrearConjuntoEntrenamiento.Location = new System.Drawing.Point(6, 6);
            this.botonCrearConjuntoEntrenamiento.Name = "botonCrearConjuntoEntrenamiento";
            this.botonCrearConjuntoEntrenamiento.Size = new System.Drawing.Size(183, 23);
            this.botonCrearConjuntoEntrenamiento.TabIndex = 2;
            this.botonCrearConjuntoEntrenamiento.Text = "Crear Conjunto de Entrenamiento";
            this.botonCrearConjuntoEntrenamiento.UseVisualStyleBackColor = true;
            // 
            // modoEjecucion
            // 
            this.modoEjecucion.BackColor = System.Drawing.SystemColors.Control;
            this.modoEjecucion.Location = new System.Drawing.Point(4, 22);
            this.modoEjecucion.Name = "modoEjecucion";
            this.modoEjecucion.Padding = new System.Windows.Forms.Padding(3);
            this.modoEjecucion.Size = new System.Drawing.Size(392, 375);
            this.modoEjecucion.TabIndex = 1;
            this.modoEjecucion.Text = "Modo Ejecucion";
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(746, 523);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(75, 23);
            this.botonSalir.TabIndex = 3;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // panelError
            // 
            this.panelError.Location = new System.Drawing.Point(0, 113);
            this.panelError.Name = "panelError";
            this.panelError.Size = new System.Drawing.Size(383, 100);
            this.panelError.TabIndex = 10;
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 567);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.modos);
            this.Controls.Add(this.botonBorrarTodo);
            this.Controls.Add(this.labelIndicacionesDibujo3);
            this.Controls.Add(this.labelIndicacionesDibujo2);
            this.Controls.Add(this.labelIndicacionesDibujo);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "PantallaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reconocedor de Vocales";
            this.modos.ResumeLayout(false);
            this.modoEntrenamiento.ResumeLayout(false);
            this.groupBoxEntrenamiento.ResumeLayout(false);
            this.groupBoxEntrenamiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantNeuronas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownError)).EndInit();
            this.groupBoxNuevoConjunto.ResumeLayout(false);
            this.groupBoxNuevoConjunto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel labelIndicacionesDibujo;
        private System.Windows.Forms.LinkLabel labelIndicacionesDibujo2;
        private System.Windows.Forms.LinkLabel labelIndicacionesDibujo3;
        private System.Windows.Forms.Button botonBorrarTodo;
        private System.Windows.Forms.TabControl modos;
        private System.Windows.Forms.TabPage modoEntrenamiento;
        private System.Windows.Forms.TabPage modoEjecucion;
        private System.Windows.Forms.ComboBox comboVocales;
        private System.Windows.Forms.Label labelComboVocales;
        private System.Windows.Forms.Button botonCrearConjuntoEntrenamiento;
        private System.Windows.Forms.GroupBox groupBoxNuevoConjunto;
        private System.Windows.Forms.Button botonGuardarConjunto;
        private System.Windows.Forms.Label labelElementosConjunto;
        private System.Windows.Forms.ListBox listBoxVocales;
        private System.Windows.Forms.GroupBox groupBoxEntrenamiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.NumericUpDown numericUpDownError;
        private System.Windows.Forms.Label labelNeuronasOcultas;
        private System.Windows.Forms.NumericUpDown numericUpDownCantNeuronas;
        private System.Windows.Forms.Button botonEntrenar;
        private System.Windows.Forms.Panel panelError;








    }
}

