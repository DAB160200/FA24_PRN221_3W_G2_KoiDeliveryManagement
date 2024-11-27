using KoiDeliveryManagement.Repository.Model;
using KoiDeliveryManagement.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoiDeliveryManagement.Services
{
    public class OrderService
    {
        private OrderRepository _repository;
        public OrderService()
        {
            _repository = new OrderRepository();
        }

        public async Task<List<Order>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }
    }
}
