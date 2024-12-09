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
    public class SupplierRepository : GenericRepository<Supplier>
    {
        public SupplierRepository() { }

        public async Task<List<Supplier>> GetByNameAsync(string name)
        {
            var suppliers = await _context.Suppliers.Where(s => s.Name.Equals(name, StringComparison.OrdinalIgnoreCase)).ToListAsync();
            return suppliers;
        }

        public async Task<List<Supplier>> GetByEmailAsync(string email)
        {
            var suppliers = await _context.Suppliers.Where(s => s.Email.Equals(email, StringComparison.OrdinalIgnoreCase)).ToListAsync();
            return suppliers;
        }

    }
}
