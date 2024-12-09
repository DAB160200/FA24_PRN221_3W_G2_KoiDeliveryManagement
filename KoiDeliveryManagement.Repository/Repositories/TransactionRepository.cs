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

        public async Task<List<Transaction>> GetTransactions()
        {
            var transactions = await _context.Transactions.Include(t => t.Order).ThenInclude(o => o.Customer).ToListAsync();

            return transactions;
        }

        public async Task<Transaction> GetTransactionById(int id)
        {
            var transaction = await _context.Transactions.Include(t => t.Order).ThenInclude(o => o.Customer).FirstAsync(t => t.Id == id);

            return transaction;
        }

        public async Task<List<Transaction>> SearchTransactionAsync(string currency, string paymentMethod, string customerName)
        {
            var query = await _context.Transactions.Include(t => t.Order).ThenInclude(o => o.Customer).ToListAsync();

            if (!string.IsNullOrEmpty(currency))
            {
                query = query.Where(t => t.Currency == currency).ToList();
            }

            if (!string.IsNullOrEmpty(paymentMethod))
            {
                query = query.Where(t => t.PaymentMethod == paymentMethod).ToList();
            }

            if (!string.IsNullOrEmpty(customerName))
            {
                query = query.Where(t => t.Order.Customer.FullName.Contains(customerName)).ToList();
            }

            return query;
        }
    }
}
