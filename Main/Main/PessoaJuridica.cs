using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Models
{
    //Esta classe herda de Cliente, uma vez que possui um representante legal, que sera o Titular da conta
    class PessoaJuridica : Cliente
    {
        //Enumeracao para classificar Pessoas jurídicas de direito privado 
        public enum TiposPessoaJuridica { Sociedade_Ltda, Associacao, Fundacao };

        //Atributos referentes a organizacao
        protected string cnpj;
        protected TiposPessoaJuridica tipoPessoaJuridica;
        protected string razaoSocial;


        public PessoaJuridica()
        {
        }

        public PessoaJuridica(string primeiroNome, string sobrenome, string cpf, string rg, string cnpj, TiposPessoaJuridica tipo, string razaoSocial)
        {
            this.primeiroNome = primeiroNome;
            this.sobrenome = sobrenome;
            this.cpf = cpf;
            this.rg = rg;
            this.tipoPessoaJuridica = tipo;
            this.razaoSocial = razaoSocial;
        }

        //-------Metodos GET e SET 
        public string CNPJ
        {
            get
            {
                return this.cnpj;
            }
            set
            {
                this.cnpj = value;
            }
        }

        public TiposPessoaJuridica TipoPessoaJuridica
        {
            get
            {
                return this.tipoPessoaJuridica;
            }
            set
            {
                this.tipoPessoaJuridica = value;
            }
        }

        public string RazaoSocial
        {
            get
            {
                return this.razaoSocial;
            }
            set
            {
                this.razaoSocial = value;
            }
        }
        //Metodos GET e SET-------
    }
}
