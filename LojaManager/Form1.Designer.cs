namespace LojaManager
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtDataCadastro = new System.Windows.Forms.DateTimePicker();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblDataCadastro = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.dgvContato = new System.Windows.Forms.DataGridView();
            this.txtCodigoContato = new System.Windows.Forms.TextBox();
            this.txtClienteContato = new System.Windows.Forms.TextBox();
            this.txtTipoContato = new System.Windows.Forms.TextBox();
            this.txtDadosContato = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDadosContato = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContato)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(593, 283);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(742, 172);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(742, 207);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(244, 20);
            this.txtNome.TabIndex = 2;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(742, 244);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(100, 20);
            this.txtTipo.TabIndex = 3;
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataCadastro.Location = new System.Drawing.Point(742, 279);
            this.txtDataCadastro.Name = "txtDataCadastro";
            this.txtDataCadastro.Size = new System.Drawing.Size(100, 20);
            this.txtDataCadastro.TabIndex = 4;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(637, 175);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 5;
            this.lblCodigo.Text = "Código:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(637, 210);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "Nome:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(637, 247);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 7;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.AutoSize = true;
            this.lblDataCadastro.Location = new System.Drawing.Point(637, 283);
            this.lblDataCadastro.Name = "lblDataCadastro";
            this.lblDataCadastro.Size = new System.Drawing.Size(78, 13);
            this.lblDataCadastro.TabIndex = 8;
            this.lblDataCadastro.Text = "Data Cadastro:";
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(627, 54);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 9;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(627, 15);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 10;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(627, 99);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 23);
            this.btnApagar.TabIndex = 11;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // dgvContato
            // 
            this.dgvContato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContato.Location = new System.Drawing.Point(12, 335);
            this.dgvContato.Name = "dgvContato";
            this.dgvContato.Size = new System.Drawing.Size(593, 276);
            this.dgvContato.TabIndex = 12;
            // 
            // txtCodigoContato
            // 
            this.txtCodigoContato.Location = new System.Drawing.Point(742, 387);
            this.txtCodigoContato.Name = "txtCodigoContato";
            this.txtCodigoContato.ReadOnly = true;
            this.txtCodigoContato.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoContato.TabIndex = 13;
            // 
            // txtClienteContato
            // 
            this.txtClienteContato.Location = new System.Drawing.Point(742, 426);
            this.txtClienteContato.Name = "txtClienteContato";
            this.txtClienteContato.ReadOnly = true;
            this.txtClienteContato.Size = new System.Drawing.Size(100, 20);
            this.txtClienteContato.TabIndex = 14;
            // 
            // txtTipoContato
            // 
            this.txtTipoContato.Location = new System.Drawing.Point(742, 463);
            this.txtTipoContato.Name = "txtTipoContato";
            this.txtTipoContato.Size = new System.Drawing.Size(100, 20);
            this.txtTipoContato.TabIndex = 15;
            // 
            // txtDadosContato
            // 
            this.txtDadosContato.Location = new System.Drawing.Point(742, 499);
            this.txtDadosContato.Name = "txtDadosContato";
            this.txtDadosContato.Size = new System.Drawing.Size(244, 20);
            this.txtDadosContato.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(645, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(645, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(645, 470);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tipo:";
            // 
            // lblDadosContato
            // 
            this.lblDadosContato.AutoSize = true;
            this.lblDadosContato.Location = new System.Drawing.Point(645, 506);
            this.lblDadosContato.Name = "lblDadosContato";
            this.lblDadosContato.Size = new System.Drawing.Size(81, 13);
            this.lblDadosContato.TabIndex = 20;
            this.lblDadosContato.Text = "Dados Contato:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 639);
            this.Controls.Add(this.lblDadosContato);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDadosContato);
            this.Controls.Add(this.txtTipoContato);
            this.Controls.Add(this.txtClienteContato);
            this.Controls.Add(this.txtCodigoContato);
            this.Controls.Add(this.dgvContato);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.lblDataCadastro);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtDataCadastro);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Novo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.DateTimePicker txtDataCadastro;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblDataCadastro;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.DataGridView dgvContato;
        private System.Windows.Forms.TextBox txtCodigoContato;
        private System.Windows.Forms.TextBox txtClienteContato;
        private System.Windows.Forms.TextBox txtTipoContato;
        private System.Windows.Forms.TextBox txtDadosContato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDadosContato;
    }
}

