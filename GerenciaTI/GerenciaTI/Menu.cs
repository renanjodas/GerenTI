using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciaTI
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void lblHardware_Click(object sender, EventArgs e)
        {
            gerHardware formHardware = new gerHardware();
            formHardware.ShowDialog();
        }

        private void lblSoftware_Click(object sender, EventArgs e)
        {
            gerSoftware formSoftware = new gerSoftware();
            formSoftware.ShowDialog();
        }

        private void lblUsuarios_Click(object sender, EventArgs e)
        {
            gerUsuarios formUsuarios = new gerUsuarios();
            formUsuarios.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            gerHardware formHardware = new gerHardware();
            formHardware.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            gerSoftware formSoftware = new gerSoftware();
            formSoftware.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            gerUsuarios formUsuarios = new gerUsuarios();
            formUsuarios.ShowDialog();
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            Form1 formLogin = new Form1();
            formLogin.ShowDialog();
        }
    }
}
