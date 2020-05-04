using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterinariaGUI
{
    public partial class MenuVeterinarioFrm : Form
    {
        public MenuVeterinarioFrm()
        {
            InitializeComponent();
        }

        private void AgregarVeterinarioBtn_Click(object sender, EventArgs e)
        {
            RegistrarVeterinarioFrm registrarVeterinarioFrm = new RegistrarVeterinarioFrm();
            registrarVeterinarioFrm.Show();
        }

        private void VeterinarioDtg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
