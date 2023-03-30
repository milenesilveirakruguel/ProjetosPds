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
                var nome = tbNome.Text;
                var email = tbEmail.Text;
                var telefone = tbTelefone.Text;
                var sexo = cbSexo.Text;


                var sql = "INSERT INTO contato (nome_con, email_con, telefone_con,sexo_con) VALUES (@_nome, @_email,  @_telefone,  @_sexo )";
                var comando = new MySqlCommand(sql, _conexao);

                comando.Parameters.AddWithValue("@_nome", nome);
                comando.Parameters.AddWithValue("@_email", email);
                comando.Parameters.AddWithValue("@_telefone", telefone);
                comando.Parameters.AddWithValue("@_sexo", sexo);
                comando.ExecuteNonQuery();

                _conexao.Close();
            }catch (Exception ex)
            {
                //Menssage.Box
            }
          
            


            cadastro.Nome = tbNome.Text;
            cadastro.Email = tbEmail.Text;
            cadastro.Sexo = cbSexo.Text;
            cadastro.Telefone = tbTelefone.Text;
            cadastro.DataDeNascimento = dtpNascimento.Value;


            cadastroList.Add(cadastro); 
            dgvLista.DataSource = cadastroList;

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
