using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WoodShop.models
{
    public class Funcionario : Usuario
    {
        public Funcionario(string nome, string cpf, string telefone, string endereco) : base(nome, cpf, telefone, endereco)
        {
            Disponivel = true; 
        }
        public bool Disponivel { get; set; } = true;
    }
}