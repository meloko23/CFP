using ControleFinanceiroPessoal.Domain.Repository.Implementation;
using ControleFinanceiroPessoal.Domain.Repository.Interface;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ControleFinanceiroPessoal.WebUI.Infrastructure {
    public class NinjectControllerFactory : DefaultControllerFactory {
        
        private IKernel ninjectKernel;

        public NinjectControllerFactory() {
            ninjectKernel = new StandardKernel();
            AddBindings();
        }
        
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType) {
            return controllerType == null
            ? null
            : (IController)ninjectKernel.Get(controllerType);
        }
        
        private void AddBindings() {
            ninjectKernel.Bind<IRepositoryReceita>().To<RepositoryReceita>();
            ninjectKernel.Bind<IRepositoryDespesa>().To<RepositoryDespesa>();
            ninjectKernel.Bind<IRepositoryUser>().To<RepositoryUser>();
        }

    }
}