using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WoodShop.models
{
    public class Pagamento
    {
        public Pagamento(Movel movel, float preco, int duracaoDias)
        {
            Movel = movel;
            Preco = preco;
            DuracaoDias = duracaoDias;
        }

        public Movel Movel { get; set; }
        public float Preco { get; set; }
        public int DuracaoDias { get; set; }

        public void FecharPedido(Movel movel, Funcionario funcionario)
        {
            funcionario.Disponivel = true;
            movel.Status = "Entregue";
        }
    }
}