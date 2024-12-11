using KoiDeliveryManagement.Repository.Model;
using KoiDeliveryManagement.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoiDeliveryManagement.Services
{
    public class DeliveryService
    {
        private DeliveryRepository _repository;
        public DeliveryService()
        {
            _repository = new DeliveryRepository();
        }

        public async Task<List<Delivery>> GetAll()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<int> Create(Delivery delivery)
        {
            return await _repository.CreateAsync(delivery);
        }

        public async Task<Delivery> GetById(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<int> Update(Delivery delivery)
        {
            return await _repository.UpdateAsync(delivery);
        }

        public async Task<bool> Delete(Delivery delivery)
        {
            return await _repository.RemoveAsync(delivery);
        }
    }
}
