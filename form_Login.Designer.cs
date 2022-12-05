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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Login));
            this.txtb_Id = new System.Windows.Forms.TextBox();
            this.txtb_Senha = new System.Windows.Forms.TextBox();
            this.lb_Senha = new System.Windows.Forms.Label();
            this.lb_Id = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtb_Id
            // 
            resources.ApplyResources(this.txtb_Id, "txtb_Id");
            this.txtb_Id.Name = "txtb_Id";
            // 
            // txtb_Senha
            // 
            resources.ApplyResources(this.txtb_Senha, "txtb_Senha");
            this.txtb_Senha.Name = "txtb_Senha";
            // 
            // lb_Senha
            // 
            resources.ApplyResources(this.lb_Senha, "lb_Senha");
            this.lb_Senha.Name = "lb_Senha";
            // 
            // lb_Id
            // 
            resources.ApplyResources(this.lb_Id, "lb_Id");
            this.lb_Id.Name = "lb_Id";
            // 
            // btn_login
            // 
            resources.ApplyResources(this.btn_login, "btn_login");
            this.btn_login.Name = "btn_login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // form_Login
            // 
            this.AcceptButton = this.btn_login;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lb_Id);
            this.Controls.Add(this.lb_Senha);
            this.Controls.Add(this.txtb_Senha);
            this.Controls.Add(this.txtb_Id);
            this.Name = "form_Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtb_Id;
        private TextBox txtb_Senha;
        private Label lb_Senha;
        private Label lb_Id;
        private Button btn_login;
    }
}