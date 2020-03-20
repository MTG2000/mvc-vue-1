using ModelsTest.DTO;
using ModelsTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsTest.Domains
{
    public interface IAccountDomain
    {
        IEnumerable<AccountDTO> GetAll();

        void CreateAccount(CreateAccountInput input);

    }
}
