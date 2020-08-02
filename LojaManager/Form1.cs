using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Loja.Classes;

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
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dados.DataSource = new BindingList<Cliente>(Cliente.Todos());

            dataGridView1.DataSource = dados;

            txtCodigo.DataBindings.Add("Text", dados, "Codigo", true, DataSourceUpdateMode.OnPropertyChanged);
            txtNome.DataBindings.Add("Text", dados, "Nome", true, DataSourceUpdateMode.OnPropertyChanged);
            txtTipo.DataBindings.Add("Text", dados, "Tipo", true, DataSourceUpdateMode.OnPropertyChanged);
            txtDataCadastro.DataBindings.Add("Text", dados, "DataCadastro", true, DataSourceUpdateMode.OnPropertyChanged);

            txtCodigoContato.DataBindings.Add("Text", ((Loja.Classes.Cliente)dados.Current).Contato, "Codigo", true, DataSourceUpdateMode.OnPropertyChanged);
            txtDadosContato.DataBindings.Add("Text", ((Loja.Classes.Cliente)dados.Current).Contato, "DadosContato", true, DataSourceUpdateMode.OnPropertyChanged);
            txtTipoContato.DataBindings.Add("Text", ((Loja.Classes.Cliente)dados.Current).Contato, "Tipo", true, DataSourceUpdateMode.OnPropertyChanged);
            txtClienteContato.DataBindings.Add("Text", ((Loja.Classes.Cliente)dados.Current).Contato, "Cliente", true, DataSourceUpdateMode.OnPropertyChanged);

            dados.CurrentChanged += dados_CurrentChanged;
            dgvContato.DataSource = ((Loja.Classes.Cliente)dados.Current).Contato;
        }

        private void dados_CurrentChanged(object sender, EventArgs e)
        {
            dgvContato.DataSource = ((Loja.Classes.Cliente)dados.Current).Contato;
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
