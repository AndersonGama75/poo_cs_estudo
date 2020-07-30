using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LojaManager
{
    public partial class Form1 : Form
    {
        BindingSource dados = new BindingSource();
        public Form1()
        {
            InitializeComponent();

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;

            dados.DataSource = Loja.Classes.Cliente.Todos();

            dataGridView1.DataSource = dados;

            txtCodigo.DataBindings.Add("Text", dados, "Codigo", true, DataSourceUpdateMode.OnPropertyChanged);
            txtNome.DataBindings.Add("Text", dados, "Nome", true, DataSourceUpdateMode.OnPropertyChanged);
            txtTipo.DataBindings.Add("Text", dados, "Tipo", true, DataSourceUpdateMode.OnPropertyChanged);
            txtDataCadastro.DataBindings.Add("Text", dados, "DataCadastro", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            ((Loja.Classes.Cliente)dados.Current).Gravar();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            dados.Add(new Loja.Classes.Cliente());
            dados.MoveLast();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente apagar esse cliente?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                ((Loja.Classes.Cliente)dados.Current).Apagar();
                dados.RemoveCurrent();
            }
        }
    }
}
