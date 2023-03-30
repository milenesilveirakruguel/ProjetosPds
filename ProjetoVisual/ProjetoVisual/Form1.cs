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


namespace ProjetoVisual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCadastro_Click(object sender, EventArgs e)
        {
            CadastroDeContato cadastroDeContato = new CadastroDeContato();  
            cadastroDeContato.ShowDialog();
            
        }

        private void btListar_Click(object sender, EventArgs e)
        {
            ListarCadastro listarCadastro = new ListarCadastro();
            listarCadastro.ShowDialog();
        }
    }
}
