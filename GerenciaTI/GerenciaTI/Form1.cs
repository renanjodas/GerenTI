using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace GerenciaTI
{
    public partial class Form1 : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "W9RQV24GotoQeIXVA977wAuyC91w3OR6aYjcpS9G",
            BasePath = "https://gerenti-64e75.firebaseio.com/"
        };

        IFirebaseClient client;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            if (client != null)
            {
                MessageBox.Show("conexão feita");
            }
        }

        private async void btnLogar_Click(object sender, EventArgs e)
        {
            //var data = new Data
            //{
            //    usuario = txtUsuario.Text,
            //    senha = txtSenha.Text,
            //};
            //SetResponse response = await client.SetTaskAsync("usuario/"+txtUsuario.Text, data);
            //Data result = response.ResultAs<Data>();
            //MessageBox.Show("Data inserida" + result.usuario);
        }
    }
}
