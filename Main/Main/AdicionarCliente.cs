using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class AdicionarCliente : Form
    {
        public AdicionarCliente()
        {
            InitializeComponent();
        }

        //-------Inserir conexao com Banco de Dados

        //Cria uma instancia de Endereco segundo os parametros informados
        private Models.Endereco adicionarEndereco(string logradouro, int numero, string bairro, string complemento, string cep, string cidade, string estado, string pais)
        {
            Models.Endereco endereco = new Models.Endereco();
            endereco.Logradouro = logradouro;
            endereco.Bairro = bairro;
            endereco.Complemento = complemento;
            endereco.CEP = cep;
            endereco.Cidade = cidade;
            endereco.Estado = estado;
            endereco.Pais = pais;

            return endereco;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

    }
}
