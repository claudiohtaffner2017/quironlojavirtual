using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiron.LojaVirtual.Dominio.Entidade
{
    public class Carrinho
    {
        private readonly List<ItensCarrinho> _itensCarrinho = new List<ItensCarrinho>();
        //adicionar 
        public void AdiconarItem(Produto produto,int quantidade)
        {
            ItensCarrinho item = _itensCarrinho.FirstOrDefault(p => p.Produto.ProdutoId == produto.ProdutoId);
            if(item == null)
            {
                _itensCarrinho.Add(new ItensCarrinho
                {
                    Produto = item.Produto,
                    Quantidade = quantidade
                });
            }
            else
            {
                item.Quantidade += quantidade;
            }
        }

        //remover
        public void RemoverItem(Produto produto)
        {
            _itensCarrinho.RemoveAll(l => l.Produto.ProdutoId == produto.ProdutoId);
        }

        //obter valor total
        public decimal ObterValorTotal()
        {
            return _itensCarrinho.Sum(e => e.Produto.Preco * e.Quantidade);
        }

        //Limpar Carrinho
        public void LimparCarrinho()
        {
            _itensCarrinho.Clear();
        }

        //Itens Carrinho
        public IEnumerable<ItensCarrinho> ItensCarrinho
        {
            get { return _itensCarrinho; }
        }
    }


    public class ItensCarrinho
    {
        public Produto Produto { get; set; }

        public int Quantidade { get; set; }
    }
}
