using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoiDeliveryManagement.Repository.Base;
using KoiDeliveryManagement.Repository.Model;
using Microsoft.EntityFrameworkCore;

namespace KoiDeliveryManagement.Repository.Repositories
{
    public class UserRepository : GenericRepository<User>
    {
        public UserRepository() { }

        public async Task<List<User>> GetByNameAsync(string name)
        {
            var users = await _context.Users.Where(x => x.FullName.Contains(name)).ToListAsync();

            return users;
        }

        public async Task<List<User>> GetByEmailAsync(string email)
        {
            var users = await _context.Users.Where(x => x.Email.Contains(email)).ToListAsync();

            return users;
        }

        public async Task<List<User>> GetByPhoneAsync(string role)
        {
            var users = await _context.Users.Where(x => x.Role.Contains(role)).ToListAsync();

            return users;
        }

        public async Task<User> GetByUserNameAsync(string userName)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Username == userName);

            return user;
        }
    }
}
