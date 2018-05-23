using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Models
{
    public abstract class Cliente : Usuario
    {
        //Enumeracao para armazenar os possiveis estados de Cliente
        public enum EstadosCliente { Ativo, Inativo, Bloqueado };

        //Enumeracao para armazenar os possiveis estados civiis de Cliente
        public enum EstadosCivisCliente { Solteiro, Casado, Divorciado, Viuvo, Separado };

        protected string email;
        protected string telefone;
        protected string celular;
        protected EstadosCliente estado;
        protected EstadosCivisCliente estadoCivil;
        protected DateTime dataCadastro;
        protected Endereco endereco;

        //-------Metodos GET e SET 
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }

        public string Telefone
        {
            get
            {
                return this.telefone;
            }
            set
            {
                this.telefone = value;
            }
        }

        public string Celular
        {
            get
            {
                return this.celular;
            }
            set
            {
                this.celular = value;
            }
        }

        public DateTime DataCadastro
        {
            get
            {
                return this.dataCadastro;
            }
            set
            {
                this.dataCadastro = value;
            }
        }

        public EstadosCliente Estado
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

        public EstadosCivisCliente EstadoCivil
        {
            get
            {
                return this.estadoCivil;
            }
            set
            {
                this.estadoCivil = value;
            }
        }

        public Endereco Endereco
        {
            get
            {
                return this.endereco;
            }
            set
            {
                this.endereco = value;
            }
        }
        //Metodos GET e SET-------
    }
}