using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackEnd;

namespace FrondEnd
{
    public partial class Inicio : Form
    {
        //arreglo para el movimiento de la imagen (X,Y)
        public int[] movimientobalon  = new int[2];


        public Point movimiento1 = new Point();
        
        //variable para la dificultad del mini juego
        public  int contador = 0;
        

        public Inicio()
        {
            InitializeComponent();
            movimientobalon[0] = img_balon.Location.X;
            movimientobalon[1] = img_balon.Location.Y;
            
        }

        private void bt_inicio_Click(object sender, EventArgs e)
        {
            Menu llamar_menu = new Menu();
            llamar_menu.Show();
            timer_balon.Enabled = false;
        }

      


        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer_balon.Enabled = false;
        }

        private void img_balon_Click(object sender, EventArgs e)
        {
            // posicion de inicio del balon al hacer click
            movimientobalon[1] = 12;
            movimiento1.Y = movimientobalon[1];

            // puntaje
            contador += 1;
            txt_contador.Text = Convert.ToString(contador);


            // aumenta la velocidad del timer
            if (timer_balon.Interval == 40)
            {
                timer_balon.Interval = 60;
            }
            else { 
                timer_balon.Interval -= 20;
            }
            

        }


        private void timer_balon_Tick(object sender, EventArgs e)
        {
            // movimiento de caida del balon
            if (movimiento1.Y <= 430)
            {

                movimiento1.Y = movimientobalon[1] += 20;
                img_balon.Location = movimiento1;

            }
            else {
                img_balon.Visible = false;
                bt_otrointento.Visible = true;
            }
        }

        private void bt_otrointento_Click(object sender, EventArgs e)
        {
            timer_balon.Interval = 300;

            contador = 0;
            txt_contador.Text = Convert.ToString(contador);
            img_balon.Visible = true;

            movimientobalon[1] = 12;
            movimiento1.Y = movimientobalon[1];
        }

        private void Inicio_Click(object sender, EventArgs e)
        {
            timer_balon.Enabled = true;
        }
    }
}
