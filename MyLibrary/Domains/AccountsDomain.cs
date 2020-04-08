using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyLibrary.DTO;
using MyLibrary.Models;

namespace MyLibrary.Domains
{
    public class AccountsDomain : IAccountsDomain
    {
        public static IList<Account> accounts = new List<Account>()
        {
            new Account
            {
                Email="mohammed@gmail.com",
                Password = "123",
                Work="Programmer"
            },
              new Account
            {
                Email="ahmad1980@hotmail.com",
                Password = "123",
                Work="Doctor"
            },
            new Account
            {
                Email="fadi89@gmail.com",
                Password = "123",
                Work="Dentist"
            }
        };


        public void AddAccount(string email, string password, string work)
        {
            accounts.Add(new Account
            {
                Email = email,
                Work = work,
                Password = password
            });
        }

        public void DeleteAccount(Guid id)
        {
            accounts = accounts.Where(a => a.Id != id).ToList();
        }

        public AccountDTO GetAccount(Guid id)
        {
            var account = accounts.ToList().Find(a => a.Id == id);
            return new AccountDTO { Id = account.Id, Email = account.Email, Work = account.Work };
        }

        public IEnumerable<AccountDTO> GetAll()
        {
           
            return accounts.ToList().Select(account => new AccountDTO { Id = account.Id, Email = account.Email, Work = account.Work });
        }
    }
}