using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ControleFinanceiroPessoal.WebUI.Startup))]
namespace ControleFinanceiroPessoal.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }

    }
}
