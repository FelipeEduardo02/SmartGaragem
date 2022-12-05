using MySql.Data.MySqlClient;

namespace Crud_1
{
    public partial class Form_CadastrarUsuario : Form
    {
        MySqlConnection Conexao;
        public Form_CadastrarUsuario()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Cancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

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
                string sql = "INSERT INTO tb_usuario(nome,senha) VALUES ('"+ txtb_Nome.Text + "', '"+ txtb_Senha.Text + "')";

                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                Conexao.Open();
                comando.ExecuteReader();
                MessageBox.Show("Usuário cadastrado!");
                this.Close();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtb_Nome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}