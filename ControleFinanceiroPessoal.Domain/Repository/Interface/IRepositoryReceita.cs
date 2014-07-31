using ControleFinanceiroPessoal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiroPessoal.Domain.Repository.Interface {
    public interface IRepositoryReceita : IBaseRepository {
        IQueryable<Receita> Receitas { get; }
    }
}
