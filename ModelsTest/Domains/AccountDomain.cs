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
            new Account { Id=Guid.NewGuid(), Email = "mtg@gmail.com" , Password = "123" , Work="Programmer" },
            new Account {Id=Guid.NewGuid(), Email = "ahmad@gmail.com" , Password = "123" , Work="Doctor" }
        };
        private readonly IMapper mapper;

        public AccountDomain(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public void CreateAccount(CreateAccountDTO input)
        {
            var account = mapper.Map<CreateAccountDTO, Account>(input);
            account.Id = Guid.NewGuid();
            //var account = new Account { Email = input.Email, Password = input.Password, Work = input.Work };
            accounts.Add(account);
        }

        public AccountDTO GetAccount(Guid id)
        {
            var account = accounts.Find(a => a.Id == id);
            return mapper.Map<Account, AccountDTO>(account);
        }

        public IEnumerable<AccountDTO> GetAll()
        {
            //  var accountsDTOList = accounts.Select(a => new AccountDTO { Email = a.Email, Work = a.Work });
            var accountsDTOList = mapper.Map<IEnumerable<Account>, IEnumerable<AccountDTO>>(accounts);
            return accountsDTOList;
        }
    }
}