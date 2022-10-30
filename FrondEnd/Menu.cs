using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrondEnd
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void bt_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_A_Click(object sender, EventArgs e)
        {
            EquipoA llamarequipoA = new EquipoA();
            llamarequipoA.Show();
            this.Close();
        }

        private void bt_B_Click(object sender, EventArgs e)
        {
            EquipoB llamarequipoB = new EquipoB();
            llamarequipoB.Show();
            this.Close();
        }

        private void bt_VerEquipo_Click(object sender, EventArgs e)
        {
            VerEquipos llamarver = new VerEquipos();
            llamarver.Show();
            this.Close();
        }
    }
}
