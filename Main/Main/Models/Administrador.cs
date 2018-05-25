using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Models
{ 
    public class Administrador : Usuario
    {
        protected string login;
        protected string senha;

        public Administrador()
        {
        }

        public Administrador(string primeiroNome, string sobrenome, string cpf, string rg, string login, string senha)
        {
            this.primeiroNome = primeiroNome;
            this.sobrenome = sobrenome;
            this.cpf = cpf;
            this.rg = rg;
            this.login = login;
            this.senha = senha;
        }

        //-------Metodos GET e SET 

        public string Login
        {
            get
            {
                return this.login;
            }
            set
            {
                this.login = value;
            }
        }

        public string Senha
        {
            get
            {
                return this.senha;
            }
            set
            {
                this.senha = value;
            }
        }
        //Metodos GET e SET-------
    }
}