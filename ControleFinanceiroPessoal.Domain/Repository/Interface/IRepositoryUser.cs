using ControleFinanceiroPessoal.Domain.Entities;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiroPessoal.Domain.Repository.Interface {
    public interface IRepositoryUser : IBaseRepository {
        
        /// <summary>
        /// Register a new User
        /// </summary>
        /// <param name="usuario"></param>
        void Register(Usuario usuario);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="usuario"></param>
        void Edit(Usuario usuario);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        Usuario Find(int userId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        Usuario Find(Usuario usuario);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        List<Usuario> List();

    }
}
