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

namespace Crud_1
{
    public partial class Form_Consulta : Form
    {
        private MySqlConnection Conexao;
        //Endereço da conexão
        private string data_source = "datasource=localhost;username=root;password=;database=db_garagem";
        public Form_Consulta()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            BtnMenu_Novo.Show(Cursor.Position);
        }

        private void toolStrip_Veículo_Click(object sender, EventArgs e)
        {
            Form_CadastrarVeiculo obj_cadastrarVeiculo = new Form_CadastrarVeiculo();
            obj_cadastrarVeiculo.ShowDialog();
        }

        private void toolStrip_Usuario_Click(object sender, EventArgs e)
        {
            Form_CadastrarUsuario obj_cadastrarUsuario = new Form_CadastrarUsuario();
            obj_cadastrarUsuario.ShowDialog();
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            //Conexão do C# com o banco de dados
            Conexao = new MySqlConnection(data_source);

            //Variável para comandos SQL
            string keyword = "'%" + txtbox_Pesquisar.Text + "%'";
            string sql = "select * from tb_usuario WHERE nome LIKE "+keyword;

            Conexao.Open();
            MySqlCommand comando = new MySqlCommand(sql, Conexao);
            MySqlDataReader reader = comando.ExecuteReader();
            list_Consulta.Items.Clear();

            while(reader.Read())
            {
                string[] linha= 
                {
                    reader.GetString(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetString(4),
                    reader.GetString(5),
                };
                var linha_listview = new ListViewItem(linha);
                list_Consulta.Items.Add(linha_listview);
            }

            

        }
    }
}
