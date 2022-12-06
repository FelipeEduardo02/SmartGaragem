namespace Crud_1
{
    partial class Form_CadastrarVeiculo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.txtbox_Marca = new System.Windows.Forms.TextBox();
            this.txtbox_Modelo = new System.Windows.Forms.TextBox();
            this.txtbox_Cor = new System.Windows.Forms.TextBox();
            this.txtbox_Ano = new System.Windows.Forms.TextBox();
            this.lb_Marca = new System.Windows.Forms.Label();
            this.lb_Modelo = new System.Windows.Forms.Label();
            this.lb_Cor = new System.Windows.Forms.Label();
            this.lb_Placa = new System.Windows.Forms.Label();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.txtbox_Placa = new System.Windows.Forms.TextBox();
            this.lb_Ano = new System.Windows.Forms.Label();
            this.lb_Responsavel = new System.Windows.Forms.Label();
            this.box_Responsavel = new System.Windows.Forms.ComboBox();
            this.formConsultaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.formConsultaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbox_Marca
            // 
            this.txtbox_Marca.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtbox_Marca.Location = new System.Drawing.Point(12, 32);
            this.txtbox_Marca.Name = "txtbox_Marca";
            this.txtbox_Marca.Size = new System.Drawing.Size(87, 23);
            this.txtbox_Marca.TabIndex = 0;
            this.txtbox_Marca.TextChanged += new System.EventHandler(this.txtbox_Marca_TextChanged);
            // 
            // txtbox_Modelo
            // 
            this.txtbox_Modelo.Location = new System.Drawing.Point(106, 32);
            this.txtbox_Modelo.Name = "txtbox_Modelo";
            this.txtbox_Modelo.Size = new System.Drawing.Size(87, 23);
            this.txtbox_Modelo.TabIndex = 1;
            this.txtbox_Modelo.TextChanged += new System.EventHandler(this.txtbox_Modelo_TextChanged);
            // 
            // txtbox_Cor
            // 
            this.txtbox_Cor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox_Cor.Location = new System.Drawing.Point(12, 88);
            this.txtbox_Cor.Name = "txtbox_Cor";
            this.txtbox_Cor.Size = new System.Drawing.Size(87, 23);
            this.txtbox_Cor.TabIndex = 2;
            // 
            // txtbox_Ano
            // 
            this.txtbox_Ano.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox_Ano.Location = new System.Drawing.Point(199, 88);
            this.txtbox_Ano.Name = "txtbox_Ano";
            this.txtbox_Ano.Size = new System.Drawing.Size(87, 23);
            this.txtbox_Ano.TabIndex = 3;
            // 
            // lb_Marca
            // 
            this.lb_Marca.AutoSize = true;
            this.lb_Marca.Location = new System.Drawing.Point(12, 14);
            this.lb_Marca.Name = "lb_Marca";
            this.lb_Marca.Size = new System.Drawing.Size(43, 15);
            this.lb_Marca.TabIndex = 5;
            this.lb_Marca.Text = "Marca:";
            // 
            // lb_Modelo
            // 
            this.lb_Modelo.AutoSize = true;
            this.lb_Modelo.Location = new System.Drawing.Point(106, 14);
            this.lb_Modelo.Name = "lb_Modelo";
            this.lb_Modelo.Size = new System.Drawing.Size(51, 15);
            this.lb_Modelo.TabIndex = 6;
            this.lb_Modelo.Text = "Modelo:";
            // 
            // lb_Cor
            // 
            this.lb_Cor.AutoSize = true;
            this.lb_Cor.Location = new System.Drawing.Point(12, 70);
            this.lb_Cor.Name = "lb_Cor";
            this.lb_Cor.Size = new System.Drawing.Size(29, 15);
            this.lb_Cor.TabIndex = 7;
            this.lb_Cor.Text = "Cor:";
            // 
            // lb_Placa
            // 
            this.lb_Placa.AutoSize = true;
            this.lb_Placa.Location = new System.Drawing.Point(106, 70);
            this.lb_Placa.Name = "lb_Placa";
            this.lb_Placa.Size = new System.Drawing.Size(38, 15);
            this.lb_Placa.TabIndex = 8;
            this.lb_Placa.Text = "Placa:";
            // 
            // btn_Ok
            // 
            this.btn_Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Ok.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ok.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Ok.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Ok.Location = new System.Drawing.Point(130, 128);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.btn_Ok.TabIndex = 9;
            this.btn_Ok.Text = "Ok";
            this.btn_Ok.UseVisualStyleBackColor = false;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.AccessibleDescription = "Fecha esta janela sem salvar as alterações";
            this.btn_Cancelar.AccessibleName = "Cancelar";
            this.btn_Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancelar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_Cancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Cancelar.Location = new System.Drawing.Point(211, 128);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 10;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtbox_Placa
            // 
            this.txtbox_Placa.Location = new System.Drawing.Point(106, 88);
            this.txtbox_Placa.Name = "txtbox_Placa";
            this.txtbox_Placa.Size = new System.Drawing.Size(87, 23);
            this.txtbox_Placa.TabIndex = 11;
            // 
            // lb_Ano
            // 
            this.lb_Ano.AutoSize = true;
            this.lb_Ano.Location = new System.Drawing.Point(199, 70);
            this.lb_Ano.Name = "lb_Ano";
            this.lb_Ano.Size = new System.Drawing.Size(29, 15);
            this.lb_Ano.TabIndex = 12;
            this.lb_Ano.Text = "Ano";
            // 
            // lb_Responsavel
            // 
            this.lb_Responsavel.AutoSize = true;
            this.lb_Responsavel.Location = new System.Drawing.Point(199, 14);
            this.lb_Responsavel.Name = "lb_Responsavel";
            this.lb_Responsavel.Size = new System.Drawing.Size(72, 15);
            this.lb_Responsavel.TabIndex = 13;
            this.lb_Responsavel.Text = "Responsável";
            // 
            // box_Responsavel
            // 
            this.box_Responsavel.FormattingEnabled = true;
            this.box_Responsavel.Items.AddRange(new object[] {
            "h",
            "i"});
            this.box_Responsavel.Location = new System.Drawing.Point(199, 32);
            this.box_Responsavel.Name = "box_Responsavel";
            this.box_Responsavel.Size = new System.Drawing.Size(87, 23);
            this.box_Responsavel.TabIndex = 14;
            // 
            // formConsultaBindingSource
            // 
            this.formConsultaBindingSource.DataSource = typeof(Crud_1.Form_Consulta);
            // 
            // Form_CadastrarVeiculo
            // 
            this.AcceptButton = this.btn_Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.CancelButton = this.btn_Cancelar;
            this.ClientSize = new System.Drawing.Size(298, 166);
            this.Controls.Add(this.box_Responsavel);
            this.Controls.Add(this.lb_Responsavel);
            this.Controls.Add(this.lb_Ano);
            this.Controls.Add(this.txtbox_Placa);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.lb_Placa);
            this.Controls.Add(this.lb_Cor);
            this.Controls.Add(this.lb_Modelo);
            this.Controls.Add(this.lb_Marca);
            this.Controls.Add(this.txtbox_Ano);
            this.Controls.Add(this.txtbox_Cor);
            this.Controls.Add(this.txtbox_Modelo);
            this.Controls.Add(this.txtbox_Marca);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(314, 205);
            this.MinimumSize = new System.Drawing.Size(314, 205);
            this.Name = "Form_CadastrarVeiculo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar veículo";
            this.Load += new System.EventHandler(this.Form_CadastrarVeiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.formConsultaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtbox_Marca;
        private TextBox txtbox_Modelo;
        private TextBox txtbox_Cor;
        private TextBox txtbox_Ano;
        private Label lb_Marca;
        private Label lb_Modelo;
        private Label lb_Cor;
        private Label lb_Placa;
        private Button btn_Ok;
        private Button btn_Cancelar;
        private TextBox txtbox_Placa;
        private Label lb_Ano;
        private Label lb_Responsavel;
        private ComboBox box_Responsavel;
        private BindingSource formConsultaBindingSource;
    }
}