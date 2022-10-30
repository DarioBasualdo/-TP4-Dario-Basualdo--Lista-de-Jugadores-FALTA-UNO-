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
    public partial class EquipoB : Form
    {
        // es la clase de los datos del jugador
        public jugador datosjugadorB { get; set; } = new jugador();

        // es la clase de la lista de jugadores
        public ListadeJugadoresB equipoB { get; set; } = new ListadeJugadoresB();

        

        public EquipoB()
        {
            InitializeComponent();
            //conecta el data table con el data gredview
            dtgv_equipoB.DataSource = equipoB.DTb;

            // es para que los combo box nose puedan editar
            cmb_posicionB.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_actualizarposicionB.DropDownStyle = ComboBoxStyle.DropDownList;


            // es para hacer aparecer o desaparecer botones segun corresponda
            if (equipoB.DTb.Rows.Count == 0)
            {
                bt_borrartodo.Visible = false;
                btActualizar.Visible = false;
                btBorrar.Visible = false;
                btCargar.Visible = true;
                lbadvertenciaB.Text = "";
            }
            else if (equipoB.DTb.Rows.Count > 0 && equipoB.DTb.Rows.Count < 11)
            {
                bt_borrartodo.Visible = true;
                btActualizar.Visible = true;
                btBorrar.Visible = true;
                btCargar.Visible = true;
                lbadvertenciaB.Text = "";
            }
            else if (equipoB.DTb.Rows.Count == 11)
            {
                bt_borrartodo.Visible = true;
                btActualizar.Visible = true;
                btBorrar.Visible = true;
                btCargar.Visible = false;
                lbadvertenciaB.Text = "El limite de jugadores es 11";
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
            datosjugadorB.Nombre = txtcargarjugadorB.Text;
            datosjugadorB.Posicion = cmb_posicionB.Text;

            // llamo al metodo cargar jugador de la clase lista de jugador
            equipoB.cargar_datosDT(datosjugadorB);

            // borro el txt.
            txtcargarjugadorB.Text = "";
            txtcargarjugadorB.Focus();

            // es para hacer aparecer o desaparecer botones segun corresponda
            if (equipoB.DTb.Rows.Count == 0)
            {
                bt_borrartodo.Visible = false;
                btActualizar.Visible = false;
                btBorrar.Visible = false;
                btCargar.Visible = true;
                lbadvertenciaB.Text = "";
            }
            else if (equipoB.DTb.Rows.Count > 0 && equipoB.DTb.Rows.Count < 11)
            {
                bt_borrartodo.Visible = true;
                btActualizar.Visible = true;
                btBorrar.Visible = true;
                btCargar.Visible = true;
                lbadvertenciaB.Text = "";
            }
            else if (equipoB.DTb.Rows.Count == 11)
            {
                bt_borrartodo.Visible = true;
                btActualizar.Visible = true;
                btBorrar.Visible = true;
                btCargar.Visible = false;
                lbadvertenciaB.Text = "El limite de jugadores es 11";
            }


        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            // envio el txt ala clase jugador
            datosjugadorB.Codigo = Convert.ToInt32(txtborrarB.Text);

            // llamo el metodo de la clase lista de jugadores
            equipoB.borrar_datosDT(datosjugadorB);

            //borro el txt.
            txtborrarB.Text = "";
            txtborrarB.Focus();

            // es para hacer aparecer o desaparecer botones segun corresponda
            if (equipoB.DTb.Rows.Count == 0)
            {
                bt_borrartodo.Visible = false;
                btActualizar.Visible = false;
                btBorrar.Visible = false;
                btCargar.Visible = true;
                lbadvertenciaB.Text = "";
            }
            else if (equipoB.DTb.Rows.Count > 0 && equipoB.DTb.Rows.Count < 11)
            {
                bt_borrartodo.Visible = true;
                btActualizar.Visible = true;
                btBorrar.Visible = true;
                btCargar.Visible = true;
                lbadvertenciaB.Text = "";
            }
            else if (equipoB.DTb.Rows.Count == 11)
            {
                bt_borrartodo.Visible = true;
                btActualizar.Visible = true;
                btBorrar.Visible = true;
                btCargar.Visible = false;
                lbadvertenciaB.Text = "El limite de jugadores es 11";
            }

        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            // envio los datos del txt ala clase jugador
            datosjugadorB.Nombre = txtactualizarjugadorB.Text;
            datosjugadorB.Posicion = cmb_actualizarposicionB.Text;
            datosjugadorB.Codigo = Convert.ToInt32(txtactualizarcodigoB.Text);

            // llamo al metodo de la clase lista de jugadores
            equipoB.actualizar_datosDT(datosjugadorB);

            // limpio los txt
            txtactualizarjugadorB.Text = "";
            txtactualizarcodigoB.Text = "";
            txtactualizarjugadorB.Focus();
        }

        private void bt_borrartodo_Click(object sender, EventArgs e)
        {
            // llamo al metodo de la clase lista de jugadores
            equipoB.borrar_todo(datosjugadorB);


            // espara hacer aparecer o desaparecer botones segun corresponda
            if (equipoB.DTb.Rows.Count == 0)
            {
                bt_borrartodo.Visible = false;
                btActualizar.Visible = false;
                btBorrar.Visible = false;
                btCargar.Visible = true;
                lbadvertenciaB.Text = "";
            }
            else if (equipoB.DTb.Rows.Count > 0 && equipoB.DTb.Rows.Count < 11)
            {
                bt_borrartodo.Visible = true;
                btActualizar.Visible = true;
                btBorrar.Visible = true;
                btCargar.Visible = true;
                lbadvertenciaB.Text = "";
            }
            else if (equipoB.DTb.Rows.Count == 11)
            {
                bt_borrartodo.Visible = true;
                btActualizar.Visible = true;
                btBorrar.Visible = true;
                btCargar.Visible = false;
                lbadvertenciaB.Text = "El limite de jugadores es 11";
            }


        }
    }
}
