using ControleFinanceiroPessoal.Domain.Entities;
using ControleFinanceiroPessoal.Domain.Repository.Singleton;
using ControleFinanceiroPessoal.Domain.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleFinanceiroPessoal.Domain.Context;

namespace ControleFinanceiroPessoal.Domain.Repository.Implementation {
    public class RepositoryDespesa : IRepositoryDespesa {
        public IQueryable<Despesa> Despesas {
            get { return SingletonRepository.getContext().Despesas.OrderBy(d => d.Id); }
        }
    }
}
