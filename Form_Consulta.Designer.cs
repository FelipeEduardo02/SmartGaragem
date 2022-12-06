namespace Crud_1
{
    partial class Form_Consulta
    {

        

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        ///
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_novo = new System.Windows.Forms.Button();
            this.BtnMenu_Novo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStrip_Veículo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_Usuario = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Apagar = new System.Windows.Forms.Button();
            this.btn_Pesquisar = new System.Windows.Forms.Button();
            this.txtbox_Pesquisar = new System.Windows.Forms.TextBox();
            this.list_Consulta = new System.Windows.Forms.ListView();
            this.list_Usuarios = new System.Windows.Forms.ListView();
            this.lb_Veiculos = new System.Windows.Forms.Label();
            this.lb_Usuarios = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.lb_UsuarioLogado = new System.Windows.Forms.Label();
            this.BtnMenu_Novo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(12, 415);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(75, 23);
            this.btn_novo.TabIndex = 3;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // BtnMenu_Novo
            // 
            this.BtnMenu_Novo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_Veículo,
            this.toolStrip_Usuario});
            this.BtnMenu_Novo.Name = "BtnMenu_Novo";
            this.BtnMenu_Novo.Size = new System.Drawing.Size(115, 48);
            // 
            // toolStrip_Veículo
            // 
            this.toolStrip_Veículo.Name = "toolStrip_Veículo";
            this.toolStrip_Veículo.Size = new System.Drawing.Size(114, 22);
            this.toolStrip_Veículo.Text = "Veículo";
            this.toolStrip_Veículo.Click += new System.EventHandler(this.toolStrip_Veículo_Click);
            // 
            // toolStrip_Usuario
            // 
            this.toolStrip_Usuario.AccessibleDescription = "";
            this.toolStrip_Usuario.Name = "toolStrip_Usuario";
            this.toolStrip_Usuario.Size = new System.Drawing.Size(114, 22);
            this.toolStrip_Usuario.Text = "Usuário";
            this.toolStrip_Usuario.Click += new System.EventHandler(this.toolStrip_Usuario_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(93, 415);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(75, 23);
            this.btn_Editar.TabIndex = 4;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Apagar
            // 
            this.btn_Apagar.Location = new System.Drawing.Point(174, 415);
            this.btn_Apagar.Name = "btn_Apagar";
            this.btn_Apagar.Size = new System.Drawing.Size(75, 23);
            this.btn_Apagar.TabIndex = 5;
            this.btn_Apagar.Text = "Apagar";
            this.btn_Apagar.UseVisualStyleBackColor = true;
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Pesquisar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_Pesquisar.FlatAppearance.BorderSize = 0;
            this.btn_Pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pesquisar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Pesquisar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Pesquisar.Location = new System.Drawing.Point(312, 11);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(75, 23);
            this.btn_Pesquisar.TabIndex = 8;
            this.btn_Pesquisar.Text = "Pesquisar";
            this.btn_Pesquisar.UseVisualStyleBackColor = false;
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // txtbox_Pesquisar
            // 
            this.txtbox_Pesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtbox_Pesquisar.Location = new System.Drawing.Point(12, 12);
            this.txtbox_Pesquisar.Name = "txtbox_Pesquisar";
            this.txtbox_Pesquisar.PlaceholderText = "Procure por marca, modelo ou placa";
            this.txtbox_Pesquisar.Size = new System.Drawing.Size(294, 23);
            this.txtbox_Pesquisar.TabIndex = 9;
            // 
            // list_Consulta
            // 
            this.list_Consulta.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.list_Consulta.Location = new System.Drawing.Point(12, 41);
            this.list_Consulta.Name = "list_Consulta";
            this.list_Consulta.Size = new System.Drawing.Size(480, 368);
            this.list_Consulta.TabIndex = 10;
            this.list_Consulta.UseCompatibleStateImageBehavior = false;
            this.list_Consulta.SelectedIndexChanged += new System.EventHandler(this.list_Consulta_SelectedIndexChanged);
            // 
            // list_Usuarios
            // 
            this.list_Usuarios.Location = new System.Drawing.Point(498, 41);
            this.list_Usuarios.Name = "list_Usuarios";
            this.list_Usuarios.Size = new System.Drawing.Size(290, 368);
            this.list_Usuarios.TabIndex = 11;
            this.list_Usuarios.UseCompatibleStateImageBehavior = false;
            // 
            // lb_Veiculos
            // 
            this.lb_Veiculos.AutoSize = true;
            this.lb_Veiculos.BackColor = System.Drawing.Color.White;
            this.lb_Veiculos.ForeColor = System.Drawing.Color.DimGray;
            this.lb_Veiculos.Location = new System.Drawing.Point(24, 384);
            this.lb_Veiculos.Name = "lb_Veiculos";
            this.lb_Veiculos.Size = new System.Drawing.Size(50, 15);
            this.lb_Veiculos.TabIndex = 12;
            this.lb_Veiculos.Text = "Veículos";
            // 
            // lb_Usuarios
            // 
            this.lb_Usuarios.AutoSize = true;
            this.lb_Usuarios.BackColor = System.Drawing.Color.White;
            this.lb_Usuarios.ForeColor = System.Drawing.Color.DimGray;
            this.lb_Usuarios.Location = new System.Drawing.Point(512, 384);
            this.lb_Usuarios.Name = "lb_Usuarios";
            this.lb_Usuarios.Size = new System.Drawing.Size(52, 15);
            this.lb_Usuarios.TabIndex = 13;
            this.lb_Usuarios.Text = "Usuários";
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(713, 415);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 14;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // lb_UsuarioLogado
            // 
            this.lb_UsuarioLogado.AutoSize = true;
            this.lb_UsuarioLogado.Location = new System.Drawing.Point(498, 419);
            this.lb_UsuarioLogado.Name = "lb_UsuarioLogado";
            this.lb_UsuarioLogado.Size = new System.Drawing.Size(69, 15);
            this.lb_UsuarioLogado.TabIndex = 15;
            this.lb_UsuarioLogado.Text = "Não logado";
            // 
            // Form_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_UsuarioLogado);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.lb_Usuarios);
            this.Controls.Add(this.lb_Veiculos);
            this.Controls.Add(this.list_Usuarios);
            this.Controls.Add(this.list_Consulta);
            this.Controls.Add(this.txtbox_Pesquisar);
            this.Controls.Add(this.btn_Pesquisar);
            this.Controls.Add(this.btn_Apagar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_novo);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form_Consulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Garagem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Consulta_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BtnMenu_Novo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_novo;
        private ContextMenuStrip BtnMenu_Novo;
        private ToolStripMenuItem toolStrip_Veículo;
        private ToolStripMenuItem toolStrip_Usuario;
        private Button btn_Editar;
        private Button btn_Apagar;
        private Button btn_Pesquisar;
        private TextBox txtbox_Pesquisar;
        private ListView list_Consulta;
        private ListView list_Usuarios;
        private Label lb_Veiculos;
        private Label lb_Usuarios;
        private Button btn_sair;
        public Label lb_UsuarioLogado;
    }
}