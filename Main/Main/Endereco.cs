using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Models
{
    public class Endereco
    {
        protected int id;
        protected string logradouro;
        protected string bairro;
        protected int numero;
        protected string complemento;
        protected string cep;
        protected string cidade;
        protected string estado;
        protected string pais;

        public Endereco()
        {

        }

        //-------Metodos GET e SET 
        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public string Logradouro
        {
            get
            {
                return this.logradouro;
            }
            set
            {
                this.logradouro = value;
            }
        }

        public string Bairro
        {
            get
            {
                return this.bairro;
            }
            set
            {
                this.bairro = value;
            }
        }

        public int Numero
        {
            get
            {
                return this.numero;
            }
            set
            {
                this.numero = value;
            }
        }

        public string Complemento
        {
            get
            {
                return this.complemento;
            }
            set
            {
                this.complemento = value;
            }
        }

        public string CEP
        {
            get
            {
                return this.cep;
            }
            set
            {
                this.cep = value;
            }
        }

        public string Cidade
        {
            get
            {
                return this.cidade;
            }
            set
            {
                this.cidade = value;
            }
        }

        public string Estado
        {
            get
            {
                return this.estado;
            }
            set
            {
                this.estado = value;
            }
        }

        public string Pais
        {
            get
            {
                return this.pais;
            }
            set
            {
                this.pais = value;
            }
        }
        //Metodos GET e SET-------

        public string EnderecoCompleto()
        {
            string enderecoCompleto = this.logradouro + ", " + this.numero + " - " + this.bairro + ", " + this.estado + " - " + this.cep;
            return enderecoCompleto;
        }
    }
}
