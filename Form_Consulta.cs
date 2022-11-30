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
    public partial class Form_Consulta : Form
    {
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
            obj_cadastrarVeiculo.Show();
        }

        private void toolStrip_Usuario_Click(object sender, EventArgs e)
        {
            Form_CadastrarUsuario obj_cadastrarUsuario = new Form_CadastrarUsuario();
            obj_cadastrarUsuario.Show();
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
