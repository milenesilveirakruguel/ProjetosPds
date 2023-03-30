using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using PojetoVisual._02.Formularios;
using PojetoVisual._02.RegrasDeNegocio;
using MySql.Data.MySqlClient;





namespace PojetoVisual._02.Formularios
{
    /// <summary>
    /// Lógica interna para CadastroDeContato.xaml
    /// </summary>
    public partial class CadastroDeContato : Window
    {
        private MySqlConnection _conexao;
      

        List<Cadastro> cadastrolist = new List<Cadastro>();
        public CadastroDeContato()
        {
            InitializeComponent();
            Conexao();
            
        }
       
        private void Conexao()
        {
            string conexaoString = "server=localhost;database=app_contato_bd;user=root;password=root;port=3360;";
            _conexao = new MySqlConnection(conexaoString);

            _conexao.Open();
        }

        public void limparEspacos()
        {
            tbNome.Clear();
            tbEmail.Clear();
            tbTelefone.Clear();
            tbSexo.Clear();
           
        }

       


        private void btSalvar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var nome = tbNome.Text;
                var sexo = tbSexo.Text;
                var email = tbEmail.Text;
                var telefone = tbTelefone.Text;
                DateTime? dataNascimento = null;

                if (dtpNascimento.SelectedDate != null)
                {
                    dataNascimento = (DateTime)dtpNascimento.SelectedDate;
                }

                if (nome != "" && sexo != "" && email != "" && telefone != "" && dataNascimento != null)
                {
                    var sql = "INSERT INTO contato (nome_con,  data_nas_con, sexo_con, email_con, telefone_con) VALUES (@_nome,  @_dataNas, @_sexo, @_email, @_telefone);";
                    var cmd = new MySqlCommand(sql, _conexao);

                    cmd.Parameters.AddWithValue("@_nome", nome);
                    cmd.Parameters.AddWithValue("@_dataNas", dataNascimento?.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@_sexo", sexo);
                    cmd.Parameters.AddWithValue("@_email", email);
                    cmd.Parameters.AddWithValue("@_telefone", telefone);
                   

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Informação salva com sucesso!");

                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btExcluir_Click(object sender, RoutedEventArgs e)
        {
            limparEspacos();
        }
    }
}
