using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Backpropagation_network
{
    public partial class PantallaPrincipal : Form
    {
        /// <summary>
        /// Variables globales del sistema
        /// </summary>
        System.Windows.Forms.Panel [,] paneles = new Panel[20,20];
        bool dibujar = false;

        public PantallaPrincipal()
        {
            InitializeComponent();
            this.crearCuadricula(this);
            this.comboVocales.SelectedIndex = 0;
        }


        private void crearCuadricula(Form formDestino)
        {
            int ubicacionPanelX = 12;
            int ubicacionPanelY = 12;

            for (int fila = 0; fila < 15; fila++)
            {
                for (int col = 0; col < 15; col++)
                {
                    this.paneles[fila, col] = new System.Windows.Forms.Panel();
                    this.paneles[fila, col].Size = new System.Drawing.Size(25, 25);
                    this.paneles[fila, col].Location = new System.Drawing.Point(ubicacionPanelX, ubicacionPanelY);
                    this.paneles[fila, col].TabIndex = 0;
                    this.paneles[fila, col].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    this.paneles[fila, col].BackColor = System.Drawing.Color.White;
                    this.paneles[fila, col].Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left);
                    this.paneles[fila, col].MaximumSize = new System.Drawing.Size(25, 25);
                    this.paneles[fila, col].MinimumSize = new System.Drawing.Size(25, 25);
                    this.paneles[fila, col].MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
                    formDestino.Controls.Add(this.paneles[fila, col]);
                    paneles[fila, col].Show();
                    if (ubicacionPanelX < 362)
                    {
                        ubicacionPanelX = ubicacionPanelX + 25;
                    }
                    else
                    {
                        ubicacionPanelX = 12;
                        ubicacionPanelY = ubicacionPanelY + 25;
                    }
                }
            }
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            Panel p = sender as Panel;
            p.BackColor = System.Drawing.Color.Black;
        }
        private void panel1_MouseClick(object sender, EventArgs e)
        {
            for (int fila = 0; fila < 15; fila++)
            {
                for (int col = 0; col < 15; col++)
                {
                    if (dibujar)
                    {
                        this.paneles[fila, col].MouseEnter -= new System.EventHandler(this.panel1_MouseEnter);
                    }
                    else
                    {
                        this.paneles[fila, col].MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
                    }
                }
            }
            if (dibujar)
            {
                dibujar = false;
            }
            else
            {
                dibujar = true;
            }
        }
        private void borrarTodo()
        {
            for (int fila = 0; fila < 15; fila++)
            {
                for (int col = 0; col < 15; col++)
                {
                    this.paneles[fila, col].BackColor = System.Drawing.Color.White;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.borrarTodo();
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
