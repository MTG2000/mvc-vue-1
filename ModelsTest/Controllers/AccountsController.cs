using ModelsTest.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyLibrary.Domains;


namespace ModelsTest.Controllers
{
    public class AccountsController : Controller
    {
        private readonly IAccountsDomain accountDomain;

        public AccountsController(IAccountsDomain accountDomain)
        {
            this.accountDomain = accountDomain;
        }


        // GET: Accounts
        public ActionResult Index()
        {
            var accounts = accountDomain.GetAll();
            return View(accounts);

        }

        // GET: Accounts/Details/5
        public ActionResult Details(Guid id)
        {

            var account = accountDomain.GetAccount(id);
            
            return View(account);
        }

        // GET: Accounts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Accounts/Create
        [HttpPost]
        public ActionResult Create(CreateAccountVM account)
        {
            
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(account);
                }
                accountDomain.AddAccount(account.Email, account.Password, account.Work);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Accounts/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Accounts/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Accounts/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Accounts/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
