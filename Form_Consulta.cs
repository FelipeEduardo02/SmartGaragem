using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.ListViewItem;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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



            //Configuração do ListView de Veículos
            list_Consulta.View = View.Details;
            list_Consulta.LabelEdit = true;
            //list_Consulta.AllowColumnReorder = true;
            list_Consulta.FullRowSelect = true;
            list_Consulta.GridLines = true;
            //Colunas do ListView de Usuários
            list_Consulta.Columns.Add("ID", 30, HorizontalAlignment.Right);
            list_Consulta.Columns.Add("Marca", 80, HorizontalAlignment.Center);
            list_Consulta.Columns.Add("Modelo", 70, HorizontalAlignment.Center);
            list_Consulta.Columns.Add("Placa", 65, HorizontalAlignment.Center);
            list_Consulta.Columns.Add("Cor", 70, HorizontalAlignment.Center);
            list_Consulta.Columns.Add("Ano", 50, HorizontalAlignment.Center);
            list_Consulta.Columns.Add("Responsável", 80, HorizontalAlignment.Center);

            list_Usuarios.View = View.Details;
            list_Usuarios.LabelEdit = true;
            //list_Usuarios.AllowColumnReorder = true;
            list_Usuarios.FullRowSelect = true;
            list_Usuarios.GridLines = true;

            //Configuração do ListView de Usuários
            list_Usuarios.Columns.Add("ID", 30, HorizontalAlignment.Right);
            list_Usuarios.Columns.Add("Nome", 80, HorizontalAlignment.Center);

            Consultar_Veiculo("");
            Atualizar_Usuarios();
        }

        public void Consultar_Veiculo(string complemento)
        {
            try
            {
                //Conexão do C# com o banco de dados
                Conexao = new MySqlConnection(data_source);

                //Inserindo dados na tabela do banco
                string sql = "SELECT tb_veiculo.id_veiculo, " +
                                    "tb_veiculo.marca, " +
                                    "tb_veiculo.modelo, " +
                                    "tb_veiculo.placa, " +
                                    "tb_veiculo.cor, " +
                                    "tb_veiculo.ano, " +
                                    "tb_usuario.nome" +
                             " FROM tb_veiculo JOIN tb_usuario" +
                             " ON tb_usuario.id_usuario = tb_veiculo.responsavel" + complemento; //String contendo um comando SQL para buscar por modelo

                Conexao.Open(); //Abre a conexão

                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                MySqlDataReader reader = comando.ExecuteReader();

                list_Consulta.Items.Clear(); //Limpa o ListView de consulta

                while (reader.Read()) //Será executado enquanto o reader retornar resultados do db
                {
                    string[] linha =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetString(4),
                        reader.GetString(5),
                        reader.GetString(6),
                     };
                    var linha_listview = new ListViewItem(linha);
                    list_Consulta.Items.Add(linha_listview);
                }

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
        
        public void Atualizar_Usuarios()
        {
            try
            {
                //Endereço da conexão
                string data_source = "datasource=localhost;username=root;password=;database=db_garagem";

                Conexao = new MySqlConnection(data_source); //Conexão do C# com o banco de dados
                Conexao.Open(); //Abre a conexão

                MySqlCommand comando = new MySqlCommand("SELECT * FROM tb_usuario", Conexao); //Comando SQL para listar todos os usuarios
                MySqlDataReader reader = comando.ExecuteReader();

                list_Usuarios.Items.Clear(); //Limpa o ListView de usuários

                while (reader.Read()) //Será executado enquanto o reader retornar resultados do db
                {
                    string[] linha =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                     };
                    var linha_listview = new ListViewItem(linha);
                    list_Usuarios.Items.Add(linha_listview);
                }

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

        private void btn_novo_Click(object sender, EventArgs e)
        {
            BtnMenu_Novo.Show(Cursor.Position);
        }
        private void toolStrip_Veículo_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> nomes_responsavel = new List<string>(); //lista criada
                foreach (ListViewItem item in list_Usuarios.Items)
                {
                    nomes_responsavel.Add(item.SubItems[1].Text); 
                }
                Form_CadastrarVeiculo obj_cadastrarVeiculo = new Form_CadastrarVeiculo(nomes_responsavel); 
                obj_cadastrarVeiculo.ShowDialog();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }finally
            {
                Consultar_Veiculo("");
            }

        }

        private void toolStrip_Usuario_Click(object sender, EventArgs e)
        {
            try
            {
                Form_CadastrarUsuario obj_cadastrarUsuario = new Form_CadastrarUsuario();
                obj_cadastrarUsuario.ShowDialog();
            } finally
            {
                Atualizar_Usuarios();
            }
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            Consultar_Veiculo(" WHERE modelo LIKE '%" + txtbox_Pesquisar.Text + "%'" +
                              " OR marca LIKE '%" + txtbox_Pesquisar.Text + "%'" +
                              " OR placa LIKE '%" + txtbox_Pesquisar.Text + "%'"); //Metodo Consultar recebe o que pesquisar
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            try
            {

                List<string> nomes_responsavel = new List<string>(); //lista criada
                foreach (ListViewItem item in list_Usuarios.Items)
                {
                    nomes_responsavel.Add(item.SubItems[1].Text);
                }

                Conexao = new MySqlConnection(data_source);
                Conexao.Open(); //Abre a conexão
                MySqlCommand comando = new MySqlCommand(
                    "SELECT tb_veiculo.id_veiculo, tb_veiculo.marca, tb_veiculo.modelo, tb_veiculo.placa, tb_veiculo.cor, tb_veiculo.ano, tb_usuario.nome "+
                    "FROM tb_veiculo JOIN tb_usuario "+
                    "ON tb_usuario.id_usuario = tb_veiculo.responsavel "+
                    "WHERE tb_veiculo.id_veiculo = '"+ list_Consulta.SelectedItems[0].Text+"'", Conexao);
                MySqlDataReader reader = comando.ExecuteReader();
                reader.Read();
                
                Form_UpdateVeiculo obj_UpdateVeiculo = new Form_UpdateVeiculo(reader.GetString(0), 
                                                                              reader.GetString(1),
                                                                              reader.GetString(2),
                                                                              reader.GetString(3),
                                                                              reader.GetString(4),
                                                                              reader.GetString(5),
                                                                              reader.GetString(6),
                                                                              nomes_responsavel);
                Conexao.Close();
                obj_UpdateVeiculo.ShowDialog();

                //MessageBox.Show(list_Consulta.SelectedItems[0].Text);
                
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Consultar_Veiculo("");
            }
        }

        private void Form_Consulta_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Apagar_Click(object sender, EventArgs e)
        {
            btnMenu_Apagar.Show(Cursor.Position);
        }

        private void toolStripMenuItem_Veiculo_Click(object sender, EventArgs e)
        {
            try
            {
                //Conexão do C# com o banco de dados
                Conexao = new MySqlConnection(data_source);

                //Deletando dados da tabela do banco
                MySqlCommand comando = new MySqlCommand("DELETE FROM tb_veiculo WHERE id_veiculo = '"+ list_Consulta.SelectedItems[0].Text + "'", Conexao);
                Conexao.Open();
                comando.ExecuteReader();
                MessageBox.Show("Veículo deletado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                Consultar_Veiculo("");
            }

        }

        private void toolStripMenuItem_Usuario_Click(object sender, EventArgs e)
        {
            try
            {
                //Conexão do C# com o banco de dados
                Conexao = new MySqlConnection(data_source);

                //Deletando dados da tabela do banco
                MySqlCommand comando = new MySqlCommand("DELETE FROM tb_usuario WHERE id_usuario = '" + list_Usuarios.SelectedItems[0].Text + "'", Conexao);
                Conexao.Open();
                comando.ExecuteReader();
                MessageBox.Show("Usuário deletado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Atualizar_Usuarios();
            }
        }
    }
}
