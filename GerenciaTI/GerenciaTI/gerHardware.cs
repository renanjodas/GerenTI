using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace GerenciaTI
{
    public partial class gerHardware : Form
    {
        public gerHardware()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection(Banco.enderecoBanco());
            MySqlCommand query = new MySqlCommand();
            query.Connection = conexao;
            conexao.Open();

            query.CommandText = "INSERT INTO hardware " +
                "(codigo, equipamento, descricao, numeroSerie, modelo, marca, dataAquisicao, observacao) " +
                "values " +
                "(@Codigo, @Equipamento, @Descricao, @NumeroSerie, @Modelo, @Marca, @DataAquisicao, @Observacao)";

            query.Parameters.AddWithValue("@Codigo", txtCodigo.Text);
            query.Parameters.AddWithValue("@Equipamento", txtEquipamento.Text);
            query.Parameters.AddWithValue("@Descricao", txtDescEquip.Text);
            query.Parameters.AddWithValue("@NumeroSerie", txtNumSerie.Text);
            query.Parameters.AddWithValue("@Modelo", txtModelo.Text);
            query.Parameters.AddWithValue("@Marca", txtMarca.Text);
            query.Parameters.AddWithValue("@DataAquisicao", Convert.ToDateTime(dtpAquisicao.Text).ToString("yyyy-MM-dd"));
            query.Parameters.AddWithValue("@Observacao", txtObservacao.Text);
            query.ExecuteNonQuery();

            conexao.Close();
        }

        private void gerHardware_Load(object sender, EventArgs e)
        {
            MySqlConnection mysqlCon = new MySqlConnection(Banco.enderecoBanco());
            mysqlCon.Open();

            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            string sqlSelectAll = "SELECT pkHardware, codigo, equipamento from hardware";
            MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, mysqlCon);

            DataTable table = new DataTable();
            MyDA.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;

            dgvHardware.DataSource = bSource;

            dgvHardware.Columns[0].Visible = false;
        }

        private void dgvHardware_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgvHardware.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtEquipamento.Text = dgvHardware.Rows[e.RowIndex].Cells[2].Value.ToString();
           
        }
    }
}