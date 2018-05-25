using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Models
{
    class Dependente : Cliente
    {
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

        public PessoaFisica TitularAssociado
        {
            get
            {
                return this.titularAssociado;
            }
        }
        //Metodos GET e SET-------

        public string CPFTitular()
        {
            return this.titularAssociado.CPF;
        }
    }
}
