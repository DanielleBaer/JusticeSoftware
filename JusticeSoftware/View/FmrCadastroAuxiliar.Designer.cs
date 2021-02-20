
namespace JusticeSoftware
{
    partial class FmrCadastroAuxiliar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmrCadastroAuxiliar));
            this.lbl_Localidade = new System.Windows.Forms.Label();
            this.lbl_DadosEmpresaTitulo = new System.Windows.Forms.Label();
            this.txt_Estado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Cidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Bairro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_DataNascimento = new System.Windows.Forms.DateTimePicker();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.btn_VoltarCadastro = new System.Windows.Forms.Button();
            this.txt_Foto = new System.Windows.Forms.TextBox();
            this.lbl_NomeCompleto = new System.Windows.Forms.Label();
            this.txt_Logradouro = new System.Windows.Forms.TextBox();
            this.txt_CEP = new System.Windows.Forms.TextBox();
            this.txt_RG = new System.Windows.Forms.TextBox();
            this.txt_CPF = new System.Windows.Forms.TextBox();
            this.txt_NomeCompleto = new System.Windows.Forms.TextBox();
            this.btn_foto = new System.Windows.Forms.Button();
            this.lbl_TituloCadastro = new System.Windows.Forms.Label();
            this.lbl_Endereco = new System.Windows.Forms.Label();
            this.lbl_DataNascimento = new System.Windows.Forms.Label();
            this.lbl_CPF = new System.Windows.Forms.Label();
            this.lbl_RG = new System.Windows.Forms.Label();
            this.lbl_CEP = new System.Windows.Forms.Label();
            this.cmb_TipodeAcesso = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_foto = new System.Windows.Forms.Label();
            this.bnt_RevelaSenha = new System.Windows.Forms.Button();
            this.lbl_ForcaSenha = new System.Windows.Forms.Label();
            this.txt_ConfirmaSenhaVerifica = new System.Windows.Forms.TextBox();
            this.lbl_ConfirmarSenhaVerifica = new System.Windows.Forms.Label();
            this.lbl_EmailVerifica = new System.Windows.Forms.Label();
            this.txt_SenhaVerifica = new System.Windows.Forms.TextBox();
            this.txt_EmailVerifica = new System.Windows.Forms.TextBox();
            this.lbl_SenhaVerifica = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lbl_Localidade
            // 
            this.lbl_Localidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Localidade.AutoSize = true;
            this.lbl_Localidade.BackColor = System.Drawing.Color.LightGray;
            this.lbl_Localidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Localidade.Location = new System.Drawing.Point(735, 184);
            this.lbl_Localidade.Name = "lbl_Localidade";
            this.lbl_Localidade.Size = new System.Drawing.Size(79, 18);
            this.lbl_Localidade.TabIndex = 235;
            this.lbl_Localidade.Text = "Localidade";
            // 
            // lbl_DadosEmpresaTitulo
            // 
            this.lbl_DadosEmpresaTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_DadosEmpresaTitulo.AutoSize = true;
            this.lbl_DadosEmpresaTitulo.BackColor = System.Drawing.Color.LightGray;
            this.lbl_DadosEmpresaTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DadosEmpresaTitulo.Location = new System.Drawing.Point(261, 184);
            this.lbl_DadosEmpresaTitulo.Name = "lbl_DadosEmpresaTitulo";
            this.lbl_DadosEmpresaTitulo.Size = new System.Drawing.Size(118, 18);
            this.lbl_DadosEmpresaTitulo.TabIndex = 234;
            this.lbl_DadosEmpresaTitulo.Text = "Dados Pessoais";
            // 
            // txt_Estado
            // 
            this.txt_Estado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Estado.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Estado.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Estado.Location = new System.Drawing.Point(825, 243);
            this.txt_Estado.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Estado.Name = "txt_Estado";
            this.txt_Estado.Size = new System.Drawing.Size(116, 29);
            this.txt_Estado.TabIndex = 205;
            this.txt_Estado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NomeCompleto_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(755, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 232;
            this.label3.Text = "Estado:";
            // 
            // txt_Cidade
            // 
            this.txt_Cidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Cidade.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Cidade.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cidade.Location = new System.Drawing.Point(616, 244);
            this.txt_Cidade.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Cidade.Name = "txt_Cidade";
            this.txt_Cidade.Size = new System.Drawing.Size(116, 29);
            this.txt_Cidade.TabIndex = 204;
            this.txt_Cidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NomeCompleto_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(552, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 231;
            this.label2.Text = "Cidade:";
            // 
            // txt_Bairro
            // 
            this.txt_Bairro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Bairro.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Bairro.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Bairro.Location = new System.Drawing.Point(616, 282);
            this.txt_Bairro.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Bairro.Name = "txt_Bairro";
            this.txt_Bairro.Size = new System.Drawing.Size(324, 29);
            this.txt_Bairro.TabIndex = 206;
            this.txt_Bairro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NomeCompleto_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(552, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 230;
            this.label1.Text = "Bairro:";
            // 
            // dtp_DataNascimento
            // 
            this.dtp_DataNascimento.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DataNascimento.Location = new System.Drawing.Point(164, 317);
            this.dtp_DataNascimento.MaxDate = new System.DateTime(2006, 12, 30, 0, 0, 0, 0);
            this.dtp_DataNascimento.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtp_DataNascimento.Name = "dtp_DataNascimento";
            this.dtp_DataNascimento.Size = new System.Drawing.Size(120, 22);
            this.dtp_DataNascimento.TabIndex = 201;
            this.dtp_DataNascimento.Value = new System.DateTime(2006, 12, 30, 0, 0, 0, 0);
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cadastrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Cadastrar.Location = new System.Drawing.Point(402, 592);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(267, 52);
            this.btn_Cadastrar.TabIndex = 227;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // btn_VoltarCadastro
            // 
            this.btn_VoltarCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_VoltarCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VoltarCadastro.Location = new System.Drawing.Point(878, 620);
            this.btn_VoltarCadastro.Name = "btn_VoltarCadastro";
            this.btn_VoltarCadastro.Size = new System.Drawing.Size(135, 52);
            this.btn_VoltarCadastro.TabIndex = 228;
            this.btn_VoltarCadastro.Text = "Voltar";
            this.btn_VoltarCadastro.UseVisualStyleBackColor = true;
            this.btn_VoltarCadastro.Click += new System.EventHandler(this.btn_VoltarCadastro_Click);
            // 
            // txt_Foto
            // 
            this.txt_Foto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Foto.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Foto.Location = new System.Drawing.Point(164, 347);
            this.txt_Foto.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Foto.Name = "txt_Foto";
            this.txt_Foto.Size = new System.Drawing.Size(231, 29);
            this.txt_Foto.TabIndex = 210;
            this.txt_Foto.TabStop = false;
            // 
            // lbl_NomeCompleto
            // 
            this.lbl_NomeCompleto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_NomeCompleto.AutoSize = true;
            this.lbl_NomeCompleto.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_NomeCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NomeCompleto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_NomeCompleto.Location = new System.Drawing.Point(38, 206);
            this.lbl_NomeCompleto.Name = "lbl_NomeCompleto";
            this.lbl_NomeCompleto.Size = new System.Drawing.Size(121, 22);
            this.lbl_NomeCompleto.TabIndex = 208;
            this.lbl_NomeCompleto.Text = "Nome Completo:";
            this.lbl_NomeCompleto.UseCompatibleTextRendering = true;
            // 
            // txt_Logradouro
            // 
            this.txt_Logradouro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Logradouro.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Logradouro.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Logradouro.Location = new System.Drawing.Point(616, 319);
            this.txt_Logradouro.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Logradouro.Name = "txt_Logradouro";
            this.txt_Logradouro.Size = new System.Drawing.Size(324, 29);
            this.txt_Logradouro.TabIndex = 207;
            this.txt_Logradouro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NomeCompleto_KeyPress);
            // 
            // txt_CEP
            // 
            this.txt_CEP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_CEP.BackColor = System.Drawing.SystemColors.Window;
            this.txt_CEP.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CEP.Location = new System.Drawing.Point(616, 206);
            this.txt_CEP.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CEP.Name = "txt_CEP";
            this.txt_CEP.Size = new System.Drawing.Size(324, 29);
            this.txt_CEP.TabIndex = 203;
            this.txt_CEP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CPF_KeyPress);
            this.txt_CEP.Leave += new System.EventHandler(this.txt_CEP_Leave);
            // 
            // txt_RG
            // 
            this.txt_RG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_RG.BackColor = System.Drawing.SystemColors.Window;
            this.txt_RG.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_RG.Location = new System.Drawing.Point(164, 279);
            this.txt_RG.Margin = new System.Windows.Forms.Padding(4);
            this.txt_RG.Name = "txt_RG";
            this.txt_RG.Size = new System.Drawing.Size(324, 29);
            this.txt_RG.TabIndex = 200;
            this.txt_RG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CPF_KeyPress);
            // 
            // txt_CPF
            // 
            this.txt_CPF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_CPF.BackColor = System.Drawing.SystemColors.Window;
            this.txt_CPF.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CPF.Location = new System.Drawing.Point(164, 242);
            this.txt_CPF.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CPF.MaxLength = 11;
            this.txt_CPF.Name = "txt_CPF";
            this.txt_CPF.Size = new System.Drawing.Size(324, 29);
            this.txt_CPF.TabIndex = 199;
            this.txt_CPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CPF_KeyPress);
            // 
            // txt_NomeCompleto
            // 
            this.txt_NomeCompleto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_NomeCompleto.BackColor = System.Drawing.SystemColors.Window;
            this.txt_NomeCompleto.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NomeCompleto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_NomeCompleto.Location = new System.Drawing.Point(164, 206);
            this.txt_NomeCompleto.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NomeCompleto.MaxLength = 60;
            this.txt_NomeCompleto.Name = "txt_NomeCompleto";
            this.txt_NomeCompleto.Size = new System.Drawing.Size(324, 29);
            this.txt_NomeCompleto.TabIndex = 198;
            this.txt_NomeCompleto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NomeCompleto_KeyPress);
            // 
            // btn_foto
            // 
            this.btn_foto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_foto.Location = new System.Drawing.Point(402, 347);
            this.btn_foto.Name = "btn_foto";
            this.btn_foto.Size = new System.Drawing.Size(84, 29);
            this.btn_foto.TabIndex = 209;
            this.btn_foto.Text = "Upload";
            this.btn_foto.UseVisualStyleBackColor = true;
            this.btn_foto.Click += new System.EventHandler(this.btn_foto_Click);
            // 
            // lbl_TituloCadastro
            // 
            this.lbl_TituloCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TituloCadastro.AutoSize = true;
            this.lbl_TituloCadastro.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_TituloCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TituloCadastro.Location = new System.Drawing.Point(442, 57);
            this.lbl_TituloCadastro.Name = "lbl_TituloCadastro";
            this.lbl_TituloCadastro.Size = new System.Drawing.Size(201, 38);
            this.lbl_TituloCadastro.TabIndex = 191;
            this.lbl_TituloCadastro.Text = "CADASTRO";
            // 
            // lbl_Endereco
            // 
            this.lbl_Endereco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Endereco.AutoSize = true;
            this.lbl_Endereco.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Endereco.Location = new System.Drawing.Point(516, 321);
            this.lbl_Endereco.Name = "lbl_Endereco";
            this.lbl_Endereco.Size = new System.Drawing.Size(89, 18);
            this.lbl_Endereco.TabIndex = 187;
            this.lbl_Endereco.Text = "Logradouro:";
            // 
            // lbl_DataNascimento
            // 
            this.lbl_DataNascimento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_DataNascimento.AutoSize = true;
            this.lbl_DataNascimento.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_DataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DataNascimento.Location = new System.Drawing.Point(11, 317);
            this.lbl_DataNascimento.Name = "lbl_DataNascimento";
            this.lbl_DataNascimento.Size = new System.Drawing.Size(147, 18);
            this.lbl_DataNascimento.TabIndex = 186;
            this.lbl_DataNascimento.Text = "Data de Nascimento:";
            // 
            // lbl_CPF
            // 
            this.lbl_CPF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_CPF.AutoSize = true;
            this.lbl_CPF.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_CPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CPF.Location = new System.Drawing.Point(118, 242);
            this.lbl_CPF.Name = "lbl_CPF";
            this.lbl_CPF.Size = new System.Drawing.Size(41, 22);
            this.lbl_CPF.TabIndex = 185;
            this.lbl_CPF.Text = "CPF:";
            this.lbl_CPF.UseCompatibleTextRendering = true;
            // 
            // lbl_RG
            // 
            this.lbl_RG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_RG.AutoSize = true;
            this.lbl_RG.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_RG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RG.Location = new System.Drawing.Point(123, 279);
            this.lbl_RG.Name = "lbl_RG";
            this.lbl_RG.Size = new System.Drawing.Size(35, 18);
            this.lbl_RG.TabIndex = 184;
            this.lbl_RG.Text = "RG:";
            // 
            // lbl_CEP
            // 
            this.lbl_CEP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_CEP.AutoSize = true;
            this.lbl_CEP.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_CEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CEP.Location = new System.Drawing.Point(562, 208);
            this.lbl_CEP.Name = "lbl_CEP";
            this.lbl_CEP.Size = new System.Drawing.Size(43, 18);
            this.lbl_CEP.TabIndex = 183;
            this.lbl_CEP.Text = "CEP:";
            // 
            // cmb_TipodeAcesso
            // 
            this.cmb_TipodeAcesso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_TipodeAcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_TipodeAcesso.FormattingEnabled = true;
            this.cmb_TipodeAcesso.Items.AddRange(new object[] {
            "Assistente",
            "Estagiário"});
            this.cmb_TipodeAcesso.Location = new System.Drawing.Point(422, 142);
            this.cmb_TipodeAcesso.Name = "cmb_TipodeAcesso";
            this.cmb_TipodeAcesso.Size = new System.Drawing.Size(246, 28);
            this.cmb_TipodeAcesso.TabIndex = 236;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(512, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 237;
            this.label4.Text = "Acesso:";
            // 
            // lbl_foto
            // 
            this.lbl_foto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_foto.AutoSize = true;
            this.lbl_foto.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_foto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_foto.Location = new System.Drawing.Point(115, 347);
            this.lbl_foto.Name = "lbl_foto";
            this.lbl_foto.Size = new System.Drawing.Size(43, 18);
            this.lbl_foto.TabIndex = 238;
            this.lbl_foto.Text = "Foto:";
            // 
            // bnt_RevelaSenha
            // 
            this.bnt_RevelaSenha.Location = new System.Drawing.Point(947, 435);
            this.bnt_RevelaSenha.Name = "bnt_RevelaSenha";
            this.bnt_RevelaSenha.Size = new System.Drawing.Size(36, 29);
            this.bnt_RevelaSenha.TabIndex = 246;
            this.bnt_RevelaSenha.Text = "៙";
            this.bnt_RevelaSenha.UseVisualStyleBackColor = true;
            // 
            // lbl_ForcaSenha
            // 
            this.lbl_ForcaSenha.AutoSize = true;
            this.lbl_ForcaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ForcaSenha.Location = new System.Drawing.Point(519, 482);
            this.lbl_ForcaSenha.Name = "lbl_ForcaSenha";
            this.lbl_ForcaSenha.Size = new System.Drawing.Size(0, 20);
            this.lbl_ForcaSenha.TabIndex = 245;
            // 
            // txt_ConfirmaSenhaVerifica
            // 
            this.txt_ConfirmaSenhaVerifica.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_ConfirmaSenhaVerifica.BackColor = System.Drawing.SystemColors.Window;
            this.txt_ConfirmaSenhaVerifica.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ConfirmaSenhaVerifica.Location = new System.Drawing.Point(616, 482);
            this.txt_ConfirmaSenhaVerifica.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ConfirmaSenhaVerifica.Name = "txt_ConfirmaSenhaVerifica";
            this.txt_ConfirmaSenhaVerifica.PasswordChar = '*';
            this.txt_ConfirmaSenhaVerifica.Size = new System.Drawing.Size(324, 29);
            this.txt_ConfirmaSenhaVerifica.TabIndex = 244;
            // 
            // lbl_ConfirmarSenhaVerifica
            // 
            this.lbl_ConfirmarSenhaVerifica.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ConfirmarSenhaVerifica.AutoSize = true;
            this.lbl_ConfirmarSenhaVerifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ConfirmarSenhaVerifica.Location = new System.Drawing.Point(475, 482);
            this.lbl_ConfirmarSenhaVerifica.Name = "lbl_ConfirmarSenhaVerifica";
            this.lbl_ConfirmarSenhaVerifica.Size = new System.Drawing.Size(126, 22);
            this.lbl_ConfirmarSenhaVerifica.TabIndex = 243;
            this.lbl_ConfirmarSenhaVerifica.Text = "Confirmar Senha:";
            this.lbl_ConfirmarSenhaVerifica.UseCompatibleTextRendering = true;
            // 
            // lbl_EmailVerifica
            // 
            this.lbl_EmailVerifica.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_EmailVerifica.AutoSize = true;
            this.lbl_EmailVerifica.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_EmailVerifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EmailVerifica.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_EmailVerifica.Location = new System.Drawing.Point(547, 400);
            this.lbl_EmailVerifica.Name = "lbl_EmailVerifica";
            this.lbl_EmailVerifica.Size = new System.Drawing.Size(54, 22);
            this.lbl_EmailVerifica.TabIndex = 242;
            this.lbl_EmailVerifica.Text = "E-mail:";
            this.lbl_EmailVerifica.UseCompatibleTextRendering = true;
            // 
            // txt_SenhaVerifica
            // 
            this.txt_SenhaVerifica.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_SenhaVerifica.BackColor = System.Drawing.SystemColors.Window;
            this.txt_SenhaVerifica.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SenhaVerifica.Location = new System.Drawing.Point(616, 435);
            this.txt_SenhaVerifica.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SenhaVerifica.Name = "txt_SenhaVerifica";
            this.txt_SenhaVerifica.PasswordChar = '*';
            this.txt_SenhaVerifica.Size = new System.Drawing.Size(324, 29);
            this.txt_SenhaVerifica.TabIndex = 241;
            // 
            // txt_EmailVerifica
            // 
            this.txt_EmailVerifica.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_EmailVerifica.BackColor = System.Drawing.SystemColors.Window;
            this.txt_EmailVerifica.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EmailVerifica.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_EmailVerifica.Location = new System.Drawing.Point(616, 394);
            this.txt_EmailVerifica.Margin = new System.Windows.Forms.Padding(4);
            this.txt_EmailVerifica.Name = "txt_EmailVerifica";
            this.txt_EmailVerifica.Size = new System.Drawing.Size(324, 29);
            this.txt_EmailVerifica.TabIndex = 240;
            // 
            // lbl_SenhaVerifica
            // 
            this.lbl_SenhaVerifica.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_SenhaVerifica.AutoSize = true;
            this.lbl_SenhaVerifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SenhaVerifica.Location = new System.Drawing.Point(547, 441);
            this.lbl_SenhaVerifica.Name = "lbl_SenhaVerifica";
            this.lbl_SenhaVerifica.Size = new System.Drawing.Size(54, 22);
            this.lbl_SenhaVerifica.TabIndex = 239;
            this.lbl_SenhaVerifica.Text = "Senha:";
            this.lbl_SenhaVerifica.UseCompatibleTextRendering = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGray;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(755, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 18);
            this.label5.TabIndex = 247;
            this.label5.Text = "Conta:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FmrCadastroAuxiliar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1067, 735);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bnt_RevelaSenha);
            this.Controls.Add(this.lbl_ForcaSenha);
            this.Controls.Add(this.txt_ConfirmaSenhaVerifica);
            this.Controls.Add(this.lbl_ConfirmarSenhaVerifica);
            this.Controls.Add(this.lbl_EmailVerifica);
            this.Controls.Add(this.txt_SenhaVerifica);
            this.Controls.Add(this.txt_EmailVerifica);
            this.Controls.Add(this.lbl_SenhaVerifica);
            this.Controls.Add(this.lbl_foto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_TipodeAcesso);
            this.Controls.Add(this.lbl_Localidade);
            this.Controls.Add(this.lbl_DadosEmpresaTitulo);
            this.Controls.Add(this.txt_Estado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Cidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Bairro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_DataNascimento);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.btn_VoltarCadastro);
            this.Controls.Add(this.txt_Foto);
            this.Controls.Add(this.lbl_NomeCompleto);
            this.Controls.Add(this.txt_Logradouro);
            this.Controls.Add(this.txt_CEP);
            this.Controls.Add(this.txt_RG);
            this.Controls.Add(this.txt_CPF);
            this.Controls.Add(this.txt_NomeCompleto);
            this.Controls.Add(this.btn_foto);
            this.Controls.Add(this.lbl_TituloCadastro);
            this.Controls.Add(this.lbl_Endereco);
            this.Controls.Add(this.lbl_DataNascimento);
            this.Controls.Add(this.lbl_CPF);
            this.Controls.Add(this.lbl_RG);
            this.Controls.Add(this.lbl_CEP);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FmrCadastroAuxiliar";
            this.Text = "Cadastro de auxiliares";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FmrCadastroAuxiliar_FormClosing);
            this.Load += new System.EventHandler(this.FmrCadastroAuxiliar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Localidade;
        private System.Windows.Forms.Label lbl_DadosEmpresaTitulo;
        private System.Windows.Forms.TextBox txt_Estado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Cidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Bairro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_DataNascimento;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.Button btn_VoltarCadastro;
        private System.Windows.Forms.TextBox txt_Foto;
        private System.Windows.Forms.Label lbl_NomeCompleto;
        private System.Windows.Forms.TextBox txt_Logradouro;
        private System.Windows.Forms.TextBox txt_CEP;
        private System.Windows.Forms.TextBox txt_RG;
        private System.Windows.Forms.TextBox txt_CPF;
        private System.Windows.Forms.TextBox txt_NomeCompleto;
        private System.Windows.Forms.Button btn_foto;
        private System.Windows.Forms.Label lbl_TituloCadastro;
        private System.Windows.Forms.Label lbl_Endereco;
        private System.Windows.Forms.Label lbl_DataNascimento;
        private System.Windows.Forms.Label lbl_CPF;
        private System.Windows.Forms.Label lbl_RG;
        private System.Windows.Forms.Label lbl_CEP;
        private System.Windows.Forms.ComboBox cmb_TipodeAcesso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_foto;
        private System.Windows.Forms.Button bnt_RevelaSenha;
        private System.Windows.Forms.Label lbl_ForcaSenha;
        private System.Windows.Forms.TextBox txt_ConfirmaSenhaVerifica;
        private System.Windows.Forms.Label lbl_ConfirmarSenhaVerifica;
        private System.Windows.Forms.Label lbl_EmailVerifica;
        private System.Windows.Forms.TextBox txt_SenhaVerifica;
        private System.Windows.Forms.TextBox txt_EmailVerifica;
        private System.Windows.Forms.Label lbl_SenhaVerifica;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}