using ControleFinanceiroPessoal.Domain.Entities;
using ControleFinanceiroPessoal.Domain.Repository.Interface;
using ControleFinanceiroPessoal.Domain.Repository.Singleton;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiroPessoal.Domain.Repository.Implementation {
    public class RepositoryUser : IRepositoryUser {
        public void Register(Usuario usuario) {
            throw new NotImplementedException();
        }

        public void Edit(Usuario usuario) {
            throw new NotImplementedException();
        }

        public Usuario Find(int userId) {
            throw new NotImplementedException();
        }

        public Usuario Find(Usuario usuario) {
            throw new NotImplementedException();
        }

        public List<Usuario> List() {
            throw new NotImplementedException();
        }
    }
}
