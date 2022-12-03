namespace Crud_1
{
    partial class form_Login
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lb_Senha = new System.Windows.Forms.Label();
            this.lb_Id = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 23);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(215, 23);
            this.textBox2.TabIndex = 1;
            // 
            // lb_Senha
            // 
            this.lb_Senha.AutoSize = true;
            this.lb_Senha.Location = new System.Drawing.Point(12, 66);
            this.lb_Senha.Name = "lb_Senha";
            this.lb_Senha.Size = new System.Drawing.Size(42, 15);
            this.lb_Senha.TabIndex = 2;
            this.lb_Senha.Text = "Senha:";
            // 
            // lb_Id
            // 
            this.lb_Id.AutoSize = true;
            this.lb_Id.Location = new System.Drawing.Point(12, 11);
            this.lb_Id.Name = "lb_Id";
            this.lb_Id.Size = new System.Drawing.Size(21, 15);
            this.lb_Id.TabIndex = 3;
            this.lb_Id.Text = "ID:";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(152, 122);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Logar";
            this.btn_login.UseVisualStyleBackColor = true;
            // 
            // form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 157);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lb_Id);
            this.Controls.Add(this.lb_Senha);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "form_Login";
            this.Text = "form_Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label lb_Senha;
        private Label lb_Id;
        private Button btn_login;
    }
}