using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using ModelsTest.DTO;
using ModelsTest.Models;

namespace ModelsTest.Domains
{
    public class AccountDomain : IAccountDomain
    {
        private static List<Account> accounts = new List<Account> {
            new Account { Email = "mtg@gmail.com" , Password = "123" , Work="Programmer" },
            new Account { Email = "ahmad@gmail.com" , Password = "123" , Work="Doctor" }
        };
        private readonly IMapper mapper;

        public AccountDomain(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public void CreateAccount(CreateAccountInput input)
        {
            var account = mapper.Map<CreateAccountInput, Account>(input);
            //var account = new Account { Email = input.Email, Password = input.Password, Work = input.Work };
            accounts.Add(account);
        }

        public IEnumerable<AccountDTO> GetAll()
        {
            //  var accountsDTOList = accounts.Select(a => new AccountDTO { Email = a.Email, Work = a.Work });
            var accountsDTOList = mapper.Map<IEnumerable<Account>, IEnumerable<AccountDTO>>(accounts);
            return accountsDTOList;
        }
    }
}