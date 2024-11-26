using KoiDeliveryManagement.Repository.Model;
using KoiDeliveryManagement.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoiDeliveryManagement.Services
{
    public class TransactionService
    {
        private TransactionRepository _repository;
        public TransactionService()
        {
            _repository = new TransactionRepository();
        }

        public async Task<List<Transaction>> GetAll()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<int> Create(Transaction Transaction)
        {
            return await _repository.CreateAsync(Transaction);
        }

        public async Task<Transaction> GetById(string id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<int> Update(Transaction Transaction)
        {
            return await _repository.UpdateAsync(Transaction);
        }

        public async Task<bool> Delete(Transaction Transaction)
        {
            return await _repository.RemoveAsync(Transaction);
        }

        //public List<Transaction> Search(string bankNo, string holderName, string holderTaxCode)
        //{
        //    return _repository.Search(bankNo, holderName, holderTaxCode);
        //}
    }
}
