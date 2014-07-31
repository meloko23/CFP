using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiroPessoal.Domain.Entities {
    public abstract class Grupo : BaseEntity {
        public int Id { get; set; }
        public string Descricao { get; set; }
    }
}
