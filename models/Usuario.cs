using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WoodShop.models
{
    public class Usuario
    {
        public Usuario(string nome, string cpf, string telefone, string endereco)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Endereco = endereco;
        }

        public String Nome { get; set; }
        public String Cpf { get; set; }
        public String Telefone { get; set; }
        public String Endereco { get; set; }
        
    }
}