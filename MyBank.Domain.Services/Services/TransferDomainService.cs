using MyBank.Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBank.Domain.Services.Services
{
    public class TransferDomainService
    {
        //public void ValidateTransfer(Account from, decimal amount)
        //{
        //    if (from.Balance < amount) throw new InvalidOperationException("Ingen dækning");
        //}

        public void Transfer(Account from, Account to, float amount)
        {
            from.Withdraw(amount);
            to.Deposit(amount);
        }
    }
}
