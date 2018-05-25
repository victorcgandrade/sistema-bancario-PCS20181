using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Models
{
    public class PessoaFisica : Cliente
    {
        protected string profissao;
        protected float rendaMensal;

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
    }
}
