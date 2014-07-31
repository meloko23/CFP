using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiroPessoal.Architecture.Security {
    [Serializable]
    public class Identity {
        private IUser User;

        public Identity(IUser user) {
            this.User = user;
        }
    }
}
