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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.btn_novo = new System.Windows.Forms.Button();
            this.BtnMenu_Novo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStrip_Veículo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_Usuario = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Apagar = new System.Windows.Forms.Button();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.listV_Consulta = new System.Windows.Forms.ListView();
            this.Column_ID = new System.Windows.Forms.ColumnHeader();
            this.Column_Marca = new System.Windows.Forms.ColumnHeader();
            this.Column_Modelo = new System.Windows.Forms.ColumnHeader();
            this.Column_Placa = new System.Windows.Forms.ColumnHeader();
            this.Column_Cor = new System.Windows.Forms.ColumnHeader();
            this.Column_Ano = new System.Windows.Forms.ColumnHeader();
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
            // btn_Fechar
            // 
            this.btn_Fechar.Location = new System.Drawing.Point(713, 415);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(75, 23);
            this.btn_Fechar.TabIndex = 6;
            this.btn_Fechar.Text = "Fechar";
            this.btn_Fechar.UseVisualStyleBackColor = true;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // listV_Consulta
            // 
            this.listV_Consulta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Column_ID,
            this.Column_Marca,
            this.Column_Modelo,
            this.Column_Placa,
            this.Column_Cor,
            this.Column_Ano});
            this.listV_Consulta.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listV_Consulta.Location = new System.Drawing.Point(12, 12);
            this.listV_Consulta.Name = "listV_Consulta";
            this.listV_Consulta.Size = new System.Drawing.Size(776, 397);
            this.listV_Consulta.TabIndex = 7;
            this.listV_Consulta.UseCompatibleStateImageBehavior = false;
            this.listV_Consulta.View = System.Windows.Forms.View.Details;
            this.listV_Consulta.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Column_ID
            // 
            this.Column_ID.Text = "ID";
            this.Column_ID.Width = 40;
            // 
            // Column_Marca
            // 
            this.Column_Marca.Text = "Marca";
            this.Column_Marca.Width = 100;
            // 
            // Column_Modelo
            // 
            this.Column_Modelo.Text = "Modelo";
            this.Column_Modelo.Width = 100;
            // 
            // Column_Placa
            // 
            this.Column_Placa.Text = "Placa";
            this.Column_Placa.Width = 80;
            // 
            // Column_Cor
            // 
            this.Column_Cor.Text = "Cor";
            this.Column_Cor.Width = 80;
            // 
            // Column_Ano
            // 
            this.Column_Ano.Text = "Ano";
            this.Column_Ano.Width = 50;
            // 
            // Form_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listV_Consulta);
            this.Controls.Add(this.btn_Fechar);
            this.Controls.Add(this.btn_Apagar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_novo);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form_Consulta";
            this.Text = "Smart Garagem";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BtnMenu_Novo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Button btn_novo;
        private ContextMenuStrip BtnMenu_Novo;
        private ToolStripMenuItem toolStrip_Veículo;
        private ToolStripMenuItem toolStrip_Usuario;
        private Button btn_Editar;
        private Button btn_Apagar;
        private Button btn_Fechar;
        private ListView listV_Consulta;
        private ColumnHeader Column_ID;
        private ColumnHeader Column_Marca;
        private ColumnHeader Column_Modelo;
        private ColumnHeader Column_Placa;
        private ColumnHeader Column_Cor;
        private ColumnHeader Column_Ano;
    }
}