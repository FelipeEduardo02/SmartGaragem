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
        private int tempIdRespons;
        MySqlConnection Conexao;
        public Form_CadastrarVeiculo(List<string> nomes)
        {
            InitializeComponent();
            box_Responsavel.Items.Clear();

            foreach(string nome in nomes)
            {
                box_Responsavel.Items.Add(nome);
            }
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

                Conexao.Open();
                MySqlCommand comando2 = new MySqlCommand("SELECT id_usuario FROM tb_usuario WHERE nome = '"+box_Responsavel.Text+"'", Conexao);
                MySqlDataReader reader2 = comando2.ExecuteReader();

                
                while (reader2.Read())
                {
                    tempIdRespons = Convert.ToInt16(reader2.GetString(0));
                }
                
                Conexao.Close();


                
                //Inserindo dados na tabela do banco
                string sql = "INSERT INTO tb_veiculo(marca, modelo, placa, cor, ano, responsavel)" +
                             "VALUES ('"+ txtbox_Marca.Text+"','"+ txtbox_Modelo.Text + "','"+ txtbox_Placa.Text + "','"+txtbox_Cor.Text+"','"+ txtbox_Ano.Text + "','" +tempIdRespons+"')";

                

                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                Conexao.Open();
                comando.ExecuteReader();
                Conexao.Close();
                
                
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
