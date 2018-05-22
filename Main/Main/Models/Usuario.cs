using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Models
{
    //Esta classe refere-se a todos os usuarios do sistema
    public abstract class Usuario
    {
        private string nome;
        private string senha;

        //-------Metodos GET e SET 
        public string Nome 
        {
            get
            {
                return this.nome;
            }
            set
            {
                this.nome = value;
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
    }
}
