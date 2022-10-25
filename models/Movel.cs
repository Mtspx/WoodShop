using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WoodShop.models
{
    public class Movel
    {
        public Movel(string nome, string cor, string dimensoes, string material, string link)
        {
            Nome = nome;
            Cor = cor;
            Dimensoes = dimensoes;
            Material = material;
            Link = link;
            Status = "Solicitado";
        }

        public string Nome { get; set; }
        public string Cor { get; set; }
        public string Dimensoes { get; set; }
        public string Material { get; set; }   
        public string Link { get; set; }     
        public string Status { get; set; } = "Solicitado";
        public Funcionario Funcionario { get; set; }

        public void AssociarFuncionario(Funcionario funcionario)
        {
            Funcionario = funcionario;
            funcionario.Disponivel = false;
            Status = "Em andamento";
        }

    }
}