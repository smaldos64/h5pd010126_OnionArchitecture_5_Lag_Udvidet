using MyBank.Domain.Model.Entities;
using MyBank.Domain.Services.Interfaces;
using MyBank.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBank.Infrastructure.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly BankDbContext _db;
        public AccountRepository(BankDbContext db) => _db = db;

        public Account GetById(int id) => _db.Accounts.Find(id) ?? throw new Exception("Konto ikke fundet");
        public IEnumerable<Account> GetAll() => _db.Accounts.ToList();
        public void Add(Account acc) { _db.Accounts.Add(acc); _db.SaveChanges(); }
        public void Update(Account acc) { _db.Update(acc); _db.SaveChanges(); }
        public void Delete(int id)
        {
            var acc = GetById(id);
            _db.Accounts.Remove(acc);
            _db.SaveChanges();
        }
    }
}
