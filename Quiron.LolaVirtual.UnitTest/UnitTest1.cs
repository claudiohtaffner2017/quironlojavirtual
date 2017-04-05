using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using Quiron.LojaVirtual.Web.Models;
using Quiron.LojaVirtual.Web.HtmlHelpers;

namespace Quiron.LolaVirtual.UnitTest
{
    [TestClass]
    public class UnitTestQuiron
    {

        [TestMethod]
        public void pagina()
        {
            HtmlHelper html = null;
            Paginacao paginacao = new Paginacao
            {
                PaginaAtual = 2,
                ItensPorPagina = 10,
                ItensTotal = 28
            };
            Func<int, string> paginaUrl = i => "Pagina" + i;

            MvcHtmlString resultado = html.PageLinks(paginacao, paginaUrl);

            Assert.AreEqual(
                @"<a class=""btn btn-default"" href=""Pagina1"">1</a>"
               + @"<a class=""btn btn-default btn-primary selected"" href=""Pagina2"">2</a>"
                + @"<a class=""btn btn-default"" href=""Pagina3"">3</a>", resultado.ToString());
        }
    }
}
