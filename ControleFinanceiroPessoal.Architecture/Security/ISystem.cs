using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiroPessoal.Architecture.Security {
    public interface ISystem {
        int GetID();
        string GetDescription();
        string GetAcronym();
        float GerVersion();
        List<IProfile> GetProfiles();
        bool IsActive();
    }
}
