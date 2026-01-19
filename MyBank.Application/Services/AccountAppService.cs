using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Mapster;
using MyBank.Application.DTO;
using MyBank.Application.Interfaces;
using MyBank.Domain.Model.Entities;
using MyBank.Domain.Services.Interfaces;

namespace MyBank.Application.Services
{
    public class AccountAppService : IAccountAppService
    {
        private readonly IAccountRepository _repo;
        public AccountAppService(IAccountRepository repo) => _repo = repo;

        public AccountResponseDTO GetAccount(int id) => _repo.GetById(id).Adapt<AccountResponseDTO>();

        public IEnumerable<AccountResponseDTO> GetAllAccounts() => _repo.GetAll().Adapt<IEnumerable<AccountResponseDTO>>();

        public void CreateAccount(CreateAccountRequest req)
        {
            var acc = new Account { Owner = req.Owner };
            acc.Deposit(req.InitialBalance);
            _repo.Add(acc);
        }

        public void Deposit(TransactionRequest req)
        {
            var acc = _repo.GetById(req.AccountId);
            acc.Deposit(req.Amount);
            _repo.Update(acc);
        }

        public void Withdraw(TransactionRequest req)
        {
            var acc = _repo.GetById(req.AccountId);
            acc.Withdraw(req.Amount);
            _repo.Update(acc);
        }

        public void DeleteAccount(int id) => _repo.Delete(id);
    }
}
