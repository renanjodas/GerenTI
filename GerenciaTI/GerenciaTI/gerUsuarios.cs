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
    public partial class gerUsuarios : Form
    {
        string perfilUsuario = "";

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "W9RQV24GotoQeIXVA977wAuyC91w3OR6aYjcpS9G",
            BasePath = "https://gerenti-64e75.firebaseio.com/"
        };

        IFirebaseClient client;

        public gerUsuarios()
        {
            InitializeComponent();
        }

        private void gerUsuarios_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            if (client != null)
            {
                MessageBox.Show("conexão feita usuario");
            }
        }

        //private async void btnIncluir_Click(object sender, EventArgs e)
        //{
        //    if(validarCampos())
        //    {
        //        if (rbAdministrador.Checked || rbTecnico.Checked || rbColaborador.Checked)
        //        {
        //            if (rbAdministrador.Checked) { perfilUsuario = "Adiministrador"; }
        //            else if (rbTecnico.Checked) { perfilUsuario = "Tecnico"; }
        //            else if (rbColaborador.Checked) { perfilUsuario = "Colaborador"; }

        //            var usuario = new Usuario
        //            {
        //                matricula = txtMatricula.Text,
        //                nome = txtNome.Text,
        //                dataNascimento = txtNascimento.Text,
        //                endereco = txtEndereco.Text,
        //                bairro = txtBairro.Text,
        //                cidade = txtCidade.Text,
        //                estado = txtEstado.Text,
        //                departamento = txtDepartamento.Text,
        //                funcao = txtFuncao.Text,
        //                email = txtEmail.Text,
        //                dataAdmissao = txtAdmissao.Text,
        //                usuario = txtUsuario.Text,
        //                senha = txtSenha.Text,
        //                perfil = perfilUsuario,
        //            };
        //            SetResponse response = await client.SetTaskAsync("usuario/" + txtMatricula.Text, usuario);
        //            Usuario result = response.ResultAs<Usuario>();
        //            MessageBox.Show("Usuário inserido com sucesso");
        //        }
        //        else
        //        { MessageBox.Show("Por favor selecione um perfil do usuário"); }
        //    }
        // }
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                if (rbAdministrador.Checked || rbTecnico.Checked || rbColaborador.Checked)
                {
                    if (rbAdministrador.Checked) { perfilUsuario = "Adiministrador"; }
                    else if (rbTecnico.Checked) { perfilUsuario = "Tecnico"; }
                    else if (rbColaborador.Checked) { perfilUsuario = "Colaborador"; }

                    var usuario = new Usuario
                    {
                        matricula = txtMatricula.Text,
                        nome = txtNome.Text,
                        dataNascimento = txtNascimento.Text,
                        endereco = txtEndereco.Text,
                        bairro = txtBairro.Text,
                        cidade = txtCidade.Text,
                        estado = txtEstado.Text,
                        departamento = txtDepartamento.Text,
                        funcao = txtFuncao.Text,
                        email = txtEmail.Text,
                        dataAdmissao = txtAdmissao.Text,
                        usuario = txtUsuario.Text,
                        senha = txtSenha.Text,
                        perfil = perfilUsuario,
                    };
                    SetResponse response = client.Set(@"usuario/" + txtMatricula.Text, usuario);
                    Usuario result = response.ResultAs<Usuario>();
                    MessageBox.Show("Usuário inserido com sucesso");
                }
                else
                { MessageBox.Show("Por favor selecione um perfil do usuário"); }
            }
        }
    
        public Boolean validarCampos()
        {
            Boolean validacao = true;
            string mensagem = "";
            if(string.IsNullOrWhiteSpace(txtMatricula.Text))
            {
                mensagem += "\n - Matrícula";
                validacao = false;
            }
            if(string.IsNullOrWhiteSpace(txtNome.Text))
            {
                mensagem += "\n - Nome";
                validacao = false;
            }
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                mensagem += "\n - Usuário";
                validacao = false;
            }
            if (string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                mensagem += "\n - Senha";
                validacao = false;
            }
            if(mensagem != "")
            {
                mensagem = "Os seguintes campos precisam ser preenchidos:" + mensagem;
                MessageBox.Show(mensagem);
            }
            return validacao;
        }
    }

    
}
