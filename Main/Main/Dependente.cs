using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Models
{
    class Dependente : Cliente
    {
        protected string cpf;
        protected string rg;
        protected DateTime dataNascimento;
        protected PessoaFisica titularAssociado;

        public Dependente()
        {
        }

        public Dependente(string primeiroNome, string sobrenome, string cpf, string rg, DateTime dataNascimento, PessoaFisica titularAssociado)
        {
            this.primeiroNome = primeiroNome;
            this.sobrenome = sobrenome;
            this.cpf = cpf;
            this.rg = rg;
            this.dataNascimento = dataNascimento;
            this.titularAssociado = titularAssociado;
            this.estado = EstadosCliente.Ativo; //Automaticamente, o estado de cliente torna ativo ao ser criado
        }

        //-------Metodos GET e SET 
        public string CPF
        {
            get
            {
                return this.cpf;
            }
            set
            {
                this.cpf = value;
            }
        }

        public string RG
        {
            get
            {
                return this.rg;
            }
            set
            {
                this.rg = value;
            }
        }

        public PessoaFisica TitularAssociado
        {
            get
            {
                return this.titularAssociado;
            }
        }
        //Metodos GET e SET-------

        //Obtem a idade do cliente pela data de nascimento e o ano atual
        public int Idade()
        {
            var dataAtual = DateTime.Today;
            int idade = dataAtual.Year - this.dataNascimento.Year;
            return idade;
        }

        public string CPFTitular()
        {
            return this.titularAssociado.CPF;
        }
    }
}
