using ProjetoVisual.RegrasDeNegocio;
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
   
    public partial class ListarCadastro : Form
    {
        private MySqlConnection _conexao;

        private MySqlCommand _command;

        
        public ListarCadastro()
        {
            InitializeComponent();

            Conexao();

            Lista();
        }
        
        public void Conexao()
        {
            string conexaoString = "server=localhost;database=app_contato_bd;user=root;password=root;port=3360";

            _conexao = new MySqlConnection(conexaoString);

            _conexao.Open();
        }

      
        private void Lista()
        {
            var sql = "SELECT * FROM contato";
            var comando = new MySqlCommand(sql, _conexao);
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
           

            DataTable dataTable = new DataTable();
            da.Fill(dataTable);

            dgvLista.DataSource = dataTable;


        }

      
    }
}
