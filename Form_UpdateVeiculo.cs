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
    public partial class Form_UpdateVeiculo : Form
    {
        private MySqlConnection Conexao;
        private int tempIdRespons;
        private string temp_id;
        public Form_UpdateVeiculo(string _id, string marca, string modelo, string placa, string cor, string ano, string responsavel, List<string> nomes)
        {

            InitializeComponent();
            try
            {
                temp_id = _id;
                foreach (string nome in nomes)
                {
                    box_Responsavel.Items.Add(nome);
                }

                txtbox_Marca.Text = marca;
                txtbox_Modelo.Text = modelo;
                txtbox_Placa.Text = placa;
                txtbox_Cor.Text = cor;
                txtbox_Ano.Text = ano;
                box_Responsavel.Text = responsavel;


                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }finally
            {

            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                //Endereço da conexão
                string data_source = "datasource=localhost;username=root;password=;database=db_garagem";

                //Conexão do C# com o banco de dados
                Conexao = new MySqlConnection(data_source);

                Conexao.Open();
                MySqlCommand comando2 = new MySqlCommand("SELECT id_usuario FROM tb_usuario WHERE nome = '" + box_Responsavel.Text + "'", Conexao);
                MySqlDataReader reader2 = comando2.ExecuteReader();


                while (reader2.Read())
                {
                    tempIdRespons = Convert.ToInt16(reader2.GetString(0));
                }

                Conexao.Close();


                MessageBox.Show(temp_id);

                //Atualizando dados na tabela do banco
                string sql = "UPDATE tb_veiculo" +
                        " SET marca = '" + txtbox_Marca.Text + "', " +
                             "modelo = '" + txtbox_Modelo.Text + "', " +
                             "placa = '" + txtbox_Placa.Text + "', " +
                             "cor = '" + txtbox_Cor.Text + "', " +
                             "ano = '" + txtbox_Ano.Text + "', " +
                             "responsavel = '" + tempIdRespons + "' " +
                             "WHERE id_veiculo = "+temp_id;
                            



                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                Conexao.Open();
                comando.ExecuteReader();
                Conexao.Close();


                MessageBox.Show("Cadastrado atualizado!");
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
    }
}
