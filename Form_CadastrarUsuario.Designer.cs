namespace Crud_1
{
    partial class Form_CadastrarUsuario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_Nome = new System.Windows.Forms.Label();
            this.txtb_Nome = new System.Windows.Forms.TextBox();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lb_Senha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_Nome
            // 
            this.lb_Nome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Nome.AutoSize = true;
            this.lb_Nome.Location = new System.Drawing.Point(12, 11);
            this.lb_Nome.Name = "lb_Nome";
            this.lb_Nome.Size = new System.Drawing.Size(43, 15);
            this.lb_Nome.TabIndex = 0;
            this.lb_Nome.Text = "Nome:";
            // 
            // txtb_Nome
            // 
            this.txtb_Nome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtb_Nome.Location = new System.Drawing.Point(12, 29);
            this.txtb_Nome.Name = "txtb_Nome";
            this.txtb_Nome.Size = new System.Drawing.Size(215, 23);
            this.txtb_Nome.TabIndex = 1;
            // 
            // btn_Ok
            // 
            this.btn_Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Ok.Location = new System.Drawing.Point(71, 121);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.btn_Ok.TabIndex = 2;
            this.btn_Ok.Text = "Ok";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancelar.Location = new System.Drawing.Point(152, 122);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 3;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(215, 23);
            this.textBox2.TabIndex = 4;
            // 
            // lb_Senha
            // 
            this.lb_Senha.AutoSize = true;
            this.lb_Senha.Location = new System.Drawing.Point(12, 66);
            this.lb_Senha.Name = "lb_Senha";
            this.lb_Senha.Size = new System.Drawing.Size(42, 15);
            this.lb_Senha.TabIndex = 5;
            this.lb_Senha.Text = "Senha:";
            this.lb_Senha.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form_CadastrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 157);
            this.Controls.Add(this.lb_Senha);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.txtb_Nome);
            this.Controls.Add(this.lb_Nome);
            this.MaximizeBox = false;
            this.Name = "Form_CadastrarUsuario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Cadastro de usuário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_Nome;
        private TextBox txtb_Nome;
        private Button btn_Ok;
        private Button btn_Cancelar;
        private TextBox textBox2;
        private Label lb_Senha;
    }
}