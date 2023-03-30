using MySql.Data.MySqlClient;
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

namespace PojetoVisual._02.Formularios
{
    /// <summary>
    /// Lógica interna para ListarCadastro.xaml
    /// </summary>
    public partial class ListarCadastro : Window
    {
        private MySqlConnection _conexao;

        public ListarCadastro()
        {
            InitializeComponent();
            Conexao();
            Listar();
        }

        private void Conexao()
        {
            string conexaoString = "server=localhost;database=app_contato_bd;user=root;password=root;port=3360;";
            _conexao = new MySqlConnection(conexaoString);

            _conexao.Open();
        }

        private void Listar()
        {
            string sql = "SELECT * FROM contato;";

            var comando = new MySqlCommand(sql, _conexao);
            var reader = comando.ExecuteReader();
            var lista = new List<Object>();

            while (reader.Read())
            {

                var contato = new
                {
                    Nome = reader.GetString(1),
                    DataNascimento = reader.GetDateTime(2),
                    Sexo = reader.GetString(3),
                    Email = reader.GetString(4),
                    Telefone = reader.GetString(5)
                };
                lista.Add(contato);
            }
            Lista.ItemsSource = lista;
        }
    }
}
