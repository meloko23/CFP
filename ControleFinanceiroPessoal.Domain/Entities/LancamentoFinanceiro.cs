using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiroPessoal.Domain.Entities {
    public abstract class LancamentoFinanceiro : BaseEntity {
        public int Id { get; set; }
    }
}
