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
    public partial class EquipoA : Form
    {
            

        // es la clase de los datos del jugador
        public jugador datosjugador { get; set; } = new jugador();

        // es la clase de la lista de jugadores
        public ListadeJugadoresA jugador_listaA { get; set; } = new ListadeJugadoresA();
        
        public EquipoA()
        {
            InitializeComponent();
            //conecta el data table con el data gredview
            dtgv_equipoA.DataSource = jugador_listaA.DT;

            // es para que los combo box nose puedan editar
           cmb_posicionA.DropDownStyle = ComboBoxStyle.DropDownList;
           cmb_actualizarposicionA.DropDownStyle = ComboBoxStyle.DropDownList;
           

            // es para hacer aparecer o desaparecer botones segun corresponda

            if (jugador_listaA.DT.Rows.Count == 0)
            {
                bt_borrartodo.Visible = false;
                btActualizar.Visible = false;
                btBorrar.Visible = false;
                btCargar.Visible = true;
                lbavisoA.Text = "";
            }
            else if (jugador_listaA.DT.Rows.Count > 0 && jugador_listaA.DT.Rows.Count < 11)
            {
                bt_borrartodo.Visible = true;
                btActualizar.Visible = true;
                btBorrar.Visible = true;
                btCargar.Visible = true;
                lbavisoA.Text = "";
            }
            else if (jugador_listaA.DT.Rows.Count == 11)
            {
                bt_borrartodo.Visible = true;
                btActualizar.Visible = true;
                btBorrar.Visible = true;
                btCargar.Visible = false;
                lbavisoA.Text = "El limite de jugadores es 11";
            }

        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            Menu llamar_menu = new Menu();
            llamar_menu.Show();
            this.Close();
        }

        private void btCargar_Click(object sender, EventArgs e)
        {
            // envio los datos del txt ala clase jugador
            datosjugador.Nombre = txtcargarjugadorA.Text;
            datosjugador.Posicion = cmb_posicionA.Text;

            // llamo al metodo cargar jugador de la clase lista de jugador
            jugador_listaA.cargar_datosDT(datosjugador);

            // borro el txt.
            txtcargarjugadorA.Text = "";
            txtcargarjugadorA.Focus();




            // es para hacer aparecer o desaparecer botones segun corresponda
            if (jugador_listaA.DT.Rows.Count == 0)
            {
                bt_borrartodo.Visible = false;
                btActualizar.Visible = false;
                btBorrar.Visible = false;
                btCargar.Visible = true;
                lbavisoA.Text = "";
            }
            else if (jugador_listaA.DT.Rows.Count > 0 && jugador_listaA.DT.Rows.Count < 11)
            {
                bt_borrartodo.Visible = true;
                btActualizar.Visible = true;
                btBorrar.Visible = true;
                btCargar.Visible = true;
                lbavisoA.Text = "";
            }
            else if (jugador_listaA.DT.Rows.Count == 11)
            {
                bt_borrartodo.Visible = true;
                btActualizar.Visible = true;
                btBorrar.Visible = true;
                btCargar.Visible = false;
                lbavisoA.Text = "El limite de jugadores es 11";
            }

        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
           // envio el txt ala clase jugador
            datosjugador.Codigo = Convert.ToInt32(txtborrarA.Text) ;

            // llamo el metodo de la clase lista de jugadores
            jugador_listaA.borrar_datosDT(datosjugador);

            //borro el txt.
            txtborrarA.Text = "";
            txtborrarA.Focus();

            // es para hacer aparecer o desaparecer botones segun corresponda
            if (jugador_listaA.DT.Rows.Count == 0)
            {
                bt_borrartodo.Visible = false;
                btActualizar.Visible = false;
                btBorrar.Visible = false;
                btCargar.Visible = true;
                lbavisoA.Text = "";
            }
            else if (jugador_listaA.DT.Rows.Count > 0 && jugador_listaA.DT.Rows.Count < 11)
            {
                bt_borrartodo.Visible = true;
                btActualizar.Visible = true;
                btBorrar.Visible = true;
                btCargar.Visible = true;
                lbavisoA.Text = "";
            }
            else if (jugador_listaA.DT.Rows.Count == 11)
            {
                bt_borrartodo.Visible = true;
                btActualizar.Visible = true;
                btBorrar.Visible = true;
                btCargar.Visible = false;
                lbavisoA.Text = "El limite de jugadores es 11";
            }
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            // envio los datos del txt ala clase jugador
            datosjugador.Nombre = txtactualizarjugadorA.Text;
            datosjugador.Posicion =cmb_actualizarposicionA.Text;
            datosjugador.Codigo = Convert.ToInt32(txtactualizarcodigoA.Text);


            // llamo al metodo de la clase lista de jugadores
            jugador_listaA.actualizar_datosDT(datosjugador);

            // limpio los txt
            txtactualizarjugadorA.Text = "";
            txtactualizarcodigoA.Text = "";
            txtactualizarjugadorA.Focus();
        }

        private void bt_borrartodo_Click(object sender, EventArgs e)
        {
            // llamo al metodo de la clase lista de jugadores
            jugador_listaA.borrar_todo(datosjugador);

            // espara hacer aparecer o desaparecer botones segun corresponda
            if (jugador_listaA.DT.Rows.Count == 0)
            {
                btActualizar.Visible = false;
                btBorrar.Visible = false;
                bt_borrartodo.Visible = false;
                btCargar.Visible = true;
                lbavisoA.Text = "";
            }
            else if (jugador_listaA.DT.Rows.Count > 0 && jugador_listaA.DT.Rows.Count < 11)
            {
                btActualizar.Visible = true;
                btBorrar.Visible = true;
                btCargar.Visible = true;
                bt_borrartodo.Visible = true;
                lbavisoA.Text = "";
            }
            else if (jugador_listaA.DT.Rows.Count == 11)
            {
                bt_borrartodo.Visible = true;
                btActualizar.Visible = true;
                btBorrar.Visible = true;
                btCargar.Visible = false;
                lbavisoA.Text = "El limite de jugadores es 11";
            }
        }
    }
}

