using KoiDeliveryManagement.Repository.Model;
using KoiDeliveryManagement.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoiDeliveryManagement.Services
{
    public class SupplierService
    {
        private SupplierRepository _repository;
        public SupplierService()
        {
            _repository = new SupplierRepository();
        }
        public async Task<List<Supplier>> GetAll()
        {
            return await _repository.GetAllAsync();
        }
        public async Task<int> Create(Supplier supplier)
        {
            return await _repository.CreateAsync(supplier);
        }

        public async Task<Supplier> GetById(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<bool> Delete(Supplier supplier)
        {
            return await _repository.RemoveAsync(supplier);
        }

        public async Task<int> Update(Supplier supplier)
        {
            return await _repository.UpdateAsync(supplier);
        }

        public async Task<List<Supplier>> SearchByName(string name)
        {
            return await _repository.GetByNameAsync(name);
        }

        public async Task<List<Supplier>> SearchByEmailAsync(string email)
        {
            return await _repository.GetByEmailAsync(email);
        }
    }
}
