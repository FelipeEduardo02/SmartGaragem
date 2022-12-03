using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud_1
{
    public partial class Form_CadastrarVeiculo : Form
    {
        MySqlConnection Conexao;
        public Form_CadastrarVeiculo()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            try
            {
                //Endereço da conexão
                string data_source = "datasource=localhost;username=root;password=;database=db_garagem";

                //Conexão do C# com o banco de dados
                Conexao = new MySqlConnection(data_source);

                //Inserindo dados na tabela do banco
                string sql = "INSERT INTO tb_veiculo(marca, modelo, placa, cor, ano)" +
                    "VALUES ('"+ txtbox_Marca.Text+"','"+ txtbox_Modelo.Text + "','"+ txtbox_Placa.Text + "','"+txtbox_Cor.Text+"','"+ txtbox_Ano.Text + "')";

                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                Conexao.Open();
                comando.ExecuteReader();
                MessageBox.Show("Veículo cadastrado!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void Form_CadastrarVeiculo_Load(object sender, EventArgs e)
        {

        }

        private void txtbox_Marca_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_Modelo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
