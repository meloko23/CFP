using ControleFinanceiroPessoal.Domain.Context;
using ControleFinanceiroPessoal.Domain.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiroPessoal.Domain.Repository.Singleton {
    public class SingletonRepository : IBaseRepository {
        
        private static SingletonRepository instance;
        private static AppDbContext context;
        
        private SingletonRepository() {
        }

        public static SingletonRepository Get() {
            if (instance == null) {
                instance = new SingletonRepository();
            }
            return instance;
        }

        public static AppDbContext getContext() {
            if (context == null) {
                context = new AppDbContext();
            }
            return context;
        }
    }
}
