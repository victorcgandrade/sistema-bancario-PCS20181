using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Models
{ 
    public class Administrador : Usuario
    {
        string cpf;
        string rg;
        string login;

        public Administrador()
        {
        }

        public Administrador(string cpf, string rg, string nome, string login, string senha)
        {
            this.cpf = cpf;
            this.rg = rg;
            this.nome = nome;
            this.login = login;
            this.senha = senha;
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
    }
}