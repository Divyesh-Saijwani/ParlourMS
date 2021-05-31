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

        public User AddUser ( User user )
        {
            var result = _context.Users.Add ( user );
            _context.SaveChanges ();
            return result.Entity;
        }

        public User GetUser ( string id )
        {
            return _context.Users.Find(id);
        }

        public List<User> GetUserList ()
        {
            return _context.Users.ToList ();
        }
    }
}
