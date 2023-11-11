using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESKTOP2019
{
    public class CamadaDadosformCaixa
    {
        public class Produto
        {
            public int codProduto { get; set; }
            public string nomeProduto { get; set; }
            public double valorVenda { get; set; }
            public int quantidade { get; set; }
            public Produto(int codProduto, string nome, double valorVenda, int quantidade)
            {
                this.codProduto = codProduto;
                this.nomeProduto = nome;
                this.valorVenda = valorVenda;
                this.quantidade = quantidade;
            }
        }

        public class Venda
        {
            public int codVenda { get; set; }
            public int codProd { get; set; }
            public int quantidade { get; set; }
            public DateTime data { get; set; }

            public Venda(int codVenda, int quantidade, int codProd, DateTime data)
            {
                this.codVenda = codVenda;
                this.codProd = codProd;
                this.quantidade = quantidade;
                this.data = data;
            }
        }
    }
}
