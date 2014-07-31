using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiroPessoal.Domain.Entities {
    public class Pessoa : BaseEntity {
        int IdPessoa { get; set; }
        int IdEntidade { get; set; }
        string Nome { get; set; }
        string Sobrenome { get; set; }
        string Sexo { get; set; }
        DateTime DataNascimento { get; set; }
        int IdNaturalidade { get; set; }
        int IdNacionalidade { get; set; }

        Usuario Usuario { get; set; }
    }
}
