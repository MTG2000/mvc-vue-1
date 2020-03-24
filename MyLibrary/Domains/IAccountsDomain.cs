using MyLibrary.DTO;
using MyLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Domains
{

    public interface IAccountsDomain
    {
        IEnumerable<AccountDTO> GetAll();

        AccountDTO GetAccount(Guid id);

        void AddAccount(string email,string password,string work);
    }
}
