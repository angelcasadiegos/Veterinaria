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
    public partial class MenuMascotasFrm : Form
    {
        public MenuMascotasFrm()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void AgregarMascotaBtn_Click(object sender, EventArgs e)
        {
            RegistroMascotaFrm registroMascotaFrm = new RegistroMascotaFrm();
            registroMascotaFrm.Show();
        }
    }
}
