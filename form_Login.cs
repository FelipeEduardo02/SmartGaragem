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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Crud_1
{
    public partial class form_Login : Form
    {
        public int id_logado;
        private MySqlConnection Conexao;
        //Endereço da conexão
        private string data_source = "datasource=localhost;username=root;password=;database=db_garagem";
        public form_Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                //Conexão do C# com o banco de dados
                Conexao = new MySqlConnection(data_source);

                //Inserindo dados na tabela do banco
                string sql = "SELECT * FROM tb_usuario WHERE id_usuario LIKE '"+ txtb_Id.Text +"'"; //String contendo um comando SQL para buscar por ID

                Conexao.Open(); //Abre a conexão

                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                MySqlDataReader reader = comando.ExecuteReader();

                bool usuarioEncontrado=false;
                while (reader.Read()) //Será executado enquanto o reader retornar resultados do db
                {
                    //MessageBox.Show("Usuário: "+reader.GetString(1)); //Mostra o usuário encontrado
                    if(reader.GetString(2)==txtb_Senha.Text)
                    {
                        //id_logado = Convert.ToInt16(reader.GetString(0));
                        //nome_logado = reader.GetString(1);
                        Form_Consulta obj_main = new Form_Consulta();
                        this.Hide();
                        obj_main.lb_UsuarioLogado.Text = "Usuário logado: "+reader.GetString(1);
                        obj_main.Show();
                    }
                    else if (reader.GetString(2) != txtb_Senha.Text)
                    {
                        MessageBox.Show("Senha incorreta!");
                    }
                    else 
                    {
                        MessageBox.Show("Sei la o que aconteceu..."); //Não ta aparecendo, graças a Deus!
                    }
                    usuarioEncontrado =true;
                }
                if (usuarioEncontrado == false)
                {
                    MessageBox.Show("Usuário não encontrado!");
                }
                Conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                
            }
        }

        private void checkUsers(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();
                MySqlCommand comando = new MySqlCommand("SELECT COUNT(nome) FROM tb_usuario", Conexao);
                MySqlDataReader reader = comando.ExecuteReader();
                reader.Read();
                if (reader.GetString(0) == "0")
                {
                    MessageBox.Show("Não há nenhum usuário cadastrado!\nÉ necessário cadastrar pelo menos um.");
                    try
                    {
                        Form_CadastrarUsuario obj_cadastrarUsuario = new Form_CadastrarUsuario();
                        obj_cadastrarUsuario.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    /*finally
                    {

                    }*/
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
    }
}
