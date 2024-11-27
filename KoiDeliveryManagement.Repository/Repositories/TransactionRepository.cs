using KoiDeliveryManagement.Repository.Base;
using KoiDeliveryManagement.Repository.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoiDeliveryManagement.Repository.Repositories
{
    public class TransactionRepository : GenericRepository<Transaction>
    {
        public TransactionRepository() { }

        public async Task<List<Transaction>> GetAllAsync()
        {
            var transactions = await _context.Transactions.Include(t => t.Order).ToListAsync();

            return transactions;
        }

        public async Task<Transaction> GetByIdAsync(int id)
        {
            var transaction = await _context.Transactions.Include(t => t.Order).FirstAsync(t => t.Id == id);

            return transaction;
        }
    }
}
