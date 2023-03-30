using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoVisual.Formularios;
using ProjetoVisual.RegrasDeNegocio;
using MySql.Data.MySqlClient;

namespace ProjetoVisual.Formularios
{
    public partial class CadastroDeContato : Form
    {
        private MySqlConnection _conexao;

        List<Cadastro> cadastroList = new List<Cadastro>();
        public CadastroDeContato()
        {
            InitializeComponent();

            Conexao();
        }

        public void Conexao()
        {
            string conexaoString = "server=localhost;database=app_contato_bd;user=root;password=root;port=3360";


            _conexao = new MySqlConnection(conexaoString);

            _conexao.Open();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();

            try
            {
                dtpNascimento.Format = DateTimePickerFormat.Custom;
                dtpNascimento.CustomFormat = "yyyy-MM-dd";

                var nome = tbNome.Text;
                var dataNascimento = dtpNascimento.Text;
                var sexo = cbSexo.Text;
                var email = tbEmail.Text;
                var telefone = tbTelefone.Text;
               
               


                var sql = "INSERT INTO contato (nome_con, data_nas_con, sexo_con, email_con, telefone_con) VALUES (@_nome, @_data_nas, @_sexo, @_email, @_telefone);";
                var comando = new MySqlCommand(sql, _conexao);

                comando.Parameters.AddWithValue("@_nome", nome);
                comando.Parameters.AddWithValue("@_data_nas", dataNascimento);
                comando.Parameters.AddWithValue("@_sexo", sexo);
                comando.Parameters.AddWithValue("@_email", email);
                comando.Parameters.AddWithValue("@_telefone", telefone);
              
               
                comando.ExecuteNonQuery();

                MessageBox.Show("Os dados foram salvos com sucesso!");


            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //Menssage.Box;
            }

           
          
            


            cadastro.Nome = tbNome.Text;
            cadastro.Email = tbEmail.Text;
            cadastro.Sexo = cbSexo.Text;
            cadastro.Telefone = tbTelefone.Text;
            cadastro.DataDeNascimento = dtpNascimento.Value;


            cadastroList.Add(cadastro); 
            //dgvLista.DataSource = cadastroList;

            limpar();

           

        }


        public void limpar()
        {
            tbNome.Clear();
            tbEmail.Clear();
            tbTelefone.Clear();
            

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        
    }
}
