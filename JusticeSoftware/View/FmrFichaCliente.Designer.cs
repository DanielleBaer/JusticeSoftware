﻿
namespace JusticeSoftware
{
    partial class FmrFichaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmrFichaCliente));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumProcesso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdPena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InicPena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProgSemi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProgAberto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FimPena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calcular = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Relatório = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.NumProcesso,
            this.QtdPena,
            this.InicPena,
            this.ProgSemi,
            this.ProgAberto,
            this.FimPena,
            this.Calcular,
            this.Relatório});
            this.dataGridView1.Location = new System.Drawing.Point(199, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(459, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // NumProcesso
            // 
            this.NumProcesso.HeaderText = "Número de Processo";
            this.NumProcesso.Name = "NumProcesso";
            this.NumProcesso.ReadOnly = true;
            // 
            // QtdPena
            // 
            this.QtdPena.HeaderText = "Total Pena";
            this.QtdPena.Name = "QtdPena";
            this.QtdPena.ReadOnly = true;
            this.QtdPena.Visible = false;
            // 
            // InicPena
            // 
            this.InicPena.HeaderText = "Início Pena";
            this.InicPena.Name = "InicPena";
            this.InicPena.ReadOnly = true;
            this.InicPena.Visible = false;
            // 
            // ProgSemi
            // 
            this.ProgSemi.HeaderText = "Progressão Semi";
            this.ProgSemi.Name = "ProgSemi";
            this.ProgSemi.ReadOnly = true;
            this.ProgSemi.Visible = false;
            // 
            // ProgAberto
            // 
            this.ProgAberto.HeaderText = "Progressão Aberto";
            this.ProgAberto.Name = "ProgAberto";
            this.ProgAberto.ReadOnly = true;
            this.ProgAberto.Visible = false;
            // 
            // FimPena
            // 
            this.FimPena.HeaderText = "Fim Pena";
            this.FimPena.Name = "FimPena";
            this.FimPena.ReadOnly = true;
            this.FimPena.Visible = false;
            // 
            // Calcular
            // 
            this.Calcular.HeaderText = "Calcular";
            this.Calcular.Name = "Calcular";
            this.Calcular.ReadOnly = true;
            // 
            // Relatório
            // 
            this.Relatório.HeaderText = "Relatório";
            this.Relatório.Name = "Relatório";
            this.Relatório.ReadOnly = true;
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Voltar.Location = new System.Drawing.Point(674, 407);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(108, 31);
            this.btn_Voltar.TabIndex = 2;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "LISTA DE  CLIENTES";
            // 
            // FmrFichaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FmrFichaCliente";
            this.Text = "FmrFichaCliente";
            this.Load += new System.EventHandler(this.FmrFichaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumProcesso;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdPena;
        private System.Windows.Forms.DataGridViewTextBoxColumn InicPena;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProgSemi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProgAberto;
        private System.Windows.Forms.DataGridViewTextBoxColumn FimPena;
        private System.Windows.Forms.DataGridViewButtonColumn Calcular;
        private System.Windows.Forms.DataGridViewButtonColumn Relatório;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.Label label1;
    }
}