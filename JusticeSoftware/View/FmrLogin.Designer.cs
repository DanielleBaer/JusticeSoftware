
namespace JusticeSoftware
{
    partial class FmrLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmrLogin));
            this.bnt_RevelaSenha = new System.Windows.Forms.Button();
            this.lbl_RecuperarSenha = new System.Windows.Forms.LinkLabel();
            this.lbl_TituloLogin = new System.Windows.Forms.Label();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.btn_Entrar = new System.Windows.Forms.Button();
            this.txt_SenhaUsuario = new System.Windows.Forms.TextBox();
            this.txt_EmailUsuario = new System.Windows.Forms.TextBox();
            this.lbl_Senha = new System.Windows.Forms.Label();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bnt_RevelaSenha
            // 
            this.bnt_RevelaSenha.Location = new System.Drawing.Point(537, 274);
            this.bnt_RevelaSenha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bnt_RevelaSenha.Name = "bnt_RevelaSenha";
            this.bnt_RevelaSenha.Size = new System.Drawing.Size(27, 28);
            this.bnt_RevelaSenha.TabIndex = 132;
            this.bnt_RevelaSenha.Text = "៙";
            this.bnt_RevelaSenha.UseVisualStyleBackColor = true;
            this.bnt_RevelaSenha.Click += new System.EventHandler(this.bnt_RevelaSenha_Click);
            // 
            // lbl_RecuperarSenha
            // 
            this.lbl_RecuperarSenha.AutoSize = true;
            this.lbl_RecuperarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RecuperarSenha.Location = new System.Drawing.Point(351, 375);
            this.lbl_RecuperarSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_RecuperarSenha.Name = "lbl_RecuperarSenha";
            this.lbl_RecuperarSenha.Size = new System.Drawing.Size(143, 17);
            this.lbl_RecuperarSenha.TabIndex = 131;
            this.lbl_RecuperarSenha.TabStop = true;
            this.lbl_RecuperarSenha.Text = "Esqueci minha senha";
            this.lbl_RecuperarSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_RecuperarSenha_LinkClicked);
            // 
            // lbl_TituloLogin
            // 
            this.lbl_TituloLogin.AutoSize = true;
            this.lbl_TituloLogin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_TituloLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TituloLogin.Location = new System.Drawing.Point(346, 154);
            this.lbl_TituloLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TituloLogin.Name = "lbl_TituloLogin";
            this.lbl_TituloLogin.Size = new System.Drawing.Size(138, 44);
            this.lbl_TituloLogin.TabIndex = 130;
            this.lbl_TituloLogin.Text = "LOGIN";
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Registrar.Location = new System.Drawing.Point(416, 326);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(117, 37);
            this.btn_Registrar.TabIndex = 129;
            this.btn_Registrar.Text = "Registrar";
            this.btn_Registrar.UseVisualStyleBackColor = true;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // btn_Entrar
            // 
            this.btn_Entrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Entrar.Location = new System.Drawing.Point(289, 326);
            this.btn_Entrar.Name = "btn_Entrar";
            this.btn_Entrar.Size = new System.Drawing.Size(121, 37);
            this.btn_Entrar.TabIndex = 128;
            this.btn_Entrar.Text = "Entrar";
            this.btn_Entrar.UseVisualStyleBackColor = true;
            this.btn_Entrar.Click += new System.EventHandler(this.btn_Entrar_Click);
            // 
            // txt_SenhaUsuario
            // 
            this.txt_SenhaUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_SenhaUsuario.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SenhaUsuario.Location = new System.Drawing.Point(289, 274);
            this.txt_SenhaUsuario.Name = "txt_SenhaUsuario";
            this.txt_SenhaUsuario.PasswordChar = '*';
            this.txt_SenhaUsuario.Size = new System.Drawing.Size(244, 28);
            this.txt_SenhaUsuario.TabIndex = 127;
            // 
            // txt_EmailUsuario
            // 
            this.txt_EmailUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_EmailUsuario.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EmailUsuario.Location = new System.Drawing.Point(289, 229);
            this.txt_EmailUsuario.Name = "txt_EmailUsuario";
            this.txt_EmailUsuario.Size = new System.Drawing.Size(244, 28);
            this.txt_EmailUsuario.TabIndex = 126;
            // 
            // lbl_Senha
            // 
            this.lbl_Senha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Senha.AutoSize = true;
            this.lbl_Senha.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Senha.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Senha.Location = new System.Drawing.Point(222, 276);
            this.lbl_Senha.Name = "lbl_Senha";
            this.lbl_Senha.Size = new System.Drawing.Size(61, 21);
            this.lbl_Senha.TabIndex = 125;
            this.lbl_Senha.Text = "Senha:";
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Usuario.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Usuario.Location = new System.Drawing.Point(220, 232);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(62, 21);
            this.lbl_Usuario.TabIndex = 124;
            this.lbl_Usuario.Text = "E-mail:";
            // 
            // FmrLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 597);
            this.Controls.Add(this.bnt_RevelaSenha);
            this.Controls.Add(this.lbl_RecuperarSenha);
            this.Controls.Add(this.lbl_TituloLogin);
            this.Controls.Add(this.btn_Registrar);
            this.Controls.Add(this.btn_Entrar);
            this.Controls.Add(this.txt_SenhaUsuario);
            this.Controls.Add(this.txt_EmailUsuario);
            this.Controls.Add(this.lbl_Senha);
            this.Controls.Add(this.lbl_Usuario);
            this.Name = "FmrLogin";
            this.Text = "FmrLogin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FmrLogin_FormClosing);
            this.Load += new System.EventHandler(this.FmrLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnt_RevelaSenha;
        private System.Windows.Forms.LinkLabel lbl_RecuperarSenha;
        private System.Windows.Forms.Label lbl_TituloLogin;
        private System.Windows.Forms.Button btn_Registrar;
        private System.Windows.Forms.Button btn_Entrar;
        private System.Windows.Forms.TextBox txt_SenhaUsuario;
        private System.Windows.Forms.Label lbl_Senha;
        private System.Windows.Forms.Label lbl_Usuario;
        public System.Windows.Forms.TextBox txt_EmailUsuario;
    }
}