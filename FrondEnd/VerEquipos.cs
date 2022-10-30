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
    public partial class VerEquipos : Form
    {
        
        public ListadeJugadoresA ver_listaA  = new ListadeJugadoresA();
        public ListadeJugadoresB ver_listaB = new ListadeJugadoresB();
        public VerEquipos()
        {
            InitializeComponent();
            // conecta los data table con los data gredview
            dtgvVeraA.DataSource = ver_listaA.DT;
            dtgvVerB.DataSource = ver_listaB.DTb;
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            Menu llamar_menu = new Menu();
            llamar_menu.Show();
            this.Close();
        }
    }
}
