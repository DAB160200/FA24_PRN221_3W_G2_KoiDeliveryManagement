using KoiDeliveryManagement.Repository.Model;
using KoiDeliveryManagement.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoiDeliveryManagement.Services
{
    public class UserService
    {
        private UserRepository _repository;
        public UserService()
        {
            _repository = new UserRepository();
        }

        public async Task<List<User>> GetAll()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<int> Create(User User)
        {
            return await _repository.CreateAsync(User);
        }

        public async Task<User> GetById(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<int> Update(User User)
        {
            return await _repository.UpdateAsync(User);
        }

        public async Task<bool> Delete(User User)
        {
            return await _repository.RemoveAsync(User);
        }

        //public List<User> Search(string bankNo, string holderName, string holderTaxCode)
        //{
        //    return _repository.Search(bankNo, holderName, holderTaxCode);
        //}
    }
}
