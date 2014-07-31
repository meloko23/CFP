using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiroPessoal.Architecture.Security {
    public interface IUser {
        int GetID();
        ICredencial GetCredential();
    }
}
