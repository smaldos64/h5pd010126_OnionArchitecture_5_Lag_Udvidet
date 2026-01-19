using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using MyBank.Domain.Model.Entities;

namespace MyBank.Domain.Services.Interfaces
{
    public interface IAccountRepository
    {
        Account GetById(int id);
        IEnumerable<Account> GetAll();
        void Add(Account account);
        void Update(Account account);
        void Delete(int id);
    }
}
