namespace Backpropagation_network
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.modos = new System.Windows.Forms.TabControl();
            this.modoEntrenamiento = new System.Windows.Forms.TabPage();
            this.modoEjecucion = new System.Windows.Forms.TabPage();
            this.modos.SuspendLayout();
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
            this.labelIndicacionesDibujo.Location = new System.Drawing.Point(231, 421);
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
            this.labelIndicacionesDibujo2.Location = new System.Drawing.Point(252, 443);
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
            this.labelIndicacionesDibujo3.Location = new System.Drawing.Point(212, 466);
            this.labelIndicacionesDibujo3.Name = "labelIndicacionesDibujo3";
            this.labelIndicacionesDibujo3.Size = new System.Drawing.Size(414, 13);
            this.labelIndicacionesDibujo3.TabIndex = 2;
            this.labelIndicacionesDibujo3.TabStop = true;
            this.labelIndicacionesDibujo3.Text = "Si termino el dibujo, puede volver a hacer click y continuar nuevamente donde lo " +
                "dejo.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Borrar Todo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // modos
            // 
            this.modos.Controls.Add(this.modoEntrenamiento);
            this.modos.Controls.Add(this.modoEjecucion);
            this.modos.Location = new System.Drawing.Point(431, 12);
            this.modos.Name = "modos";
            this.modos.SelectedIndex = 0;
            this.modos.Size = new System.Drawing.Size(400, 401);
            this.modos.TabIndex = 0;
            // 
            // modoEntrenamiento
            // 
            this.modoEntrenamiento.BackColor = System.Drawing.SystemColors.Control;
            this.modoEntrenamiento.Location = new System.Drawing.Point(4, 22);
            this.modoEntrenamiento.Name = "modoEntrenamiento";
            this.modoEntrenamiento.Padding = new System.Windows.Forms.Padding(3);
            this.modoEntrenamiento.Size = new System.Drawing.Size(392, 375);
            this.modoEntrenamiento.TabIndex = 0;
            this.modoEntrenamiento.Text = "Modo Entrenamiento";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 488);
            this.Controls.Add(this.modos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelIndicacionesDibujo3);
            this.Controls.Add(this.labelIndicacionesDibujo2);
            this.Controls.Add(this.labelIndicacionesDibujo);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.modos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel labelIndicacionesDibujo;
        private System.Windows.Forms.LinkLabel labelIndicacionesDibujo2;
        private System.Windows.Forms.LinkLabel labelIndicacionesDibujo3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl modos;
        private System.Windows.Forms.TabPage modoEntrenamiento;
        private System.Windows.Forms.TabPage modoEjecucion;








    }
}

