using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Models
{
    public class PessoaFisica : Titular
    {
        protected string cpf;
        protected string rg;
        protected string profissao;
        protected float rendaMensal;
        protected DateTime dataNascimento;

        public PessoaFisica()
        {
        }

        public PessoaFisica(string primeiroNome, string sobrenome, string cpf, string rg, string profissao, float rendaMensal, DateTime dataNascimento)
        {
            this.primeiroNome = primeiroNome;
            this.sobrenome = sobrenome;
            this.cpf = cpf;
            this.rg = rg;
            this.profissao = profissao;
            this.rendaMensal = rendaMensal;
            this.dataNascimento = dataNascimento;
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

        public string Profissao
        {
            get
            {
                return this.profissao;
            }
            set
            {
                this.profissao = value;
            }
        }

        public float RendaMensal
        {
            get
            {
                return this.rendaMensal;
            }
            set
            {
                this.rendaMensal = value;
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
    }
}
