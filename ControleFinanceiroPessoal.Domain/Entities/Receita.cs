using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiroPessoal.Domain.Entities {
    public class Receita : LancamentoFinanceiro {        
        
        [Display(Name="Descrição")]
        public string Descricao { get; set; }
        
        [DataType(DataType.Currency)]
        public decimal Valor { get; set; }
        
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString="{0:dd/MM/yyyy}")]
        [Display(Name = "Data Referência")]
        public DateTime DataReferencia { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Data Competência")]
        public DateTime DataCompetencia { get; set; }
        
        public int IdTipoReceita { get; set; }
        //public virtual TipoReceita TipoReceita { get; set; }
    }
}
