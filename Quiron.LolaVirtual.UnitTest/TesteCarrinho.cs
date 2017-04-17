using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quiron.LojaVirtual.Dominio.Entidade;
using System.Linq;

namespace Quiron.LolaVirtual.UnitTest
{
    [TestClass]
    public class TesteCarrinho
    {
        [TestMethod]
        public void AdicionarItensCarrinho()
        {
            Produto produto1 = new Produto
            {
                ProdutoId = 1,
                Nome = "produto1"
            };

            Produto produto2 = new Produto
            {
                ProdutoId = 2,
                Nome = "produto2"
            };

            Produto produto3 = new Produto
            {
                ProdutoId = 3,
                Nome = "produto3"
            };

            Carrinho carrinho = new Carrinho();
            carrinho.AdiconarItem(produto1, 2);
            carrinho.AdiconarItem(produto2, 3);
            int y = carrinho.ItensCarrinho.Count();

            ItemCarrinho[] itens = carrinho.ItensCarrinho.ToArray();

            Assert.AreEqual(itens.Length, 2);
            Assert.AreEqual(y, 2);
        }
    }
}
