using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Models
{
    public abstract class Usuario
    {
        protected int id;
        protected string primeiroNome;
        protected string sobrenome;

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

        public string PrimeiroNome 
        {
            get
            {
                return this.primeiroNome;
            }
            set
            {
                this.primeiroNome = value;
            }
        }

        public string Sobrenome
        {
            get
            {
                return this.sobrenome;
            }
            set
            {
                this.sobrenome = value;
            }
        }
        //Metodos GET e SET-------

        //Obtem nome completo a partir do primeiro nome e do sobrenome
        public string NomeCompleto()
        {
            string nomeCompleto = this.primeiroNome + " " + this.sobrenome;
            return nomeCompleto;
        }

    }
}
