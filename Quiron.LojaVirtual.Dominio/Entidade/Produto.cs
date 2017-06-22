using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Quiron.LojaVirtual.Dominio.Entidade
{
    public class Produto
    {
        [HiddenInput(DisplayValue= false)]
        public int ProdutoId { get; set; }

        [Required(ErrorMessage ="Digite o nome do Produto")]
        public string Nome { get; set; }

        [DataType(DataType.MultilineText)]

        [Required(ErrorMessage ="Digite a Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage ="Digite o Valor")]
        [Range(0.01,double.MaxValue,ErrorMessage ="Valor Inválido")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage ="Digite a Categoria")]
        public string Categoria { get; set; }
 
    }
}
