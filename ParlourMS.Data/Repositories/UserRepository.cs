using ParlourMS.Data.Models;
using ParlourMS.Data.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace ParlourMS.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;
        
        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<User> GetUserList ()
        {
            return _context.Users.ToList ();
        }
    }
}
