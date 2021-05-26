using ParlourMS.BL.Services.Interfaces;
using ParlourMS.Data.Models;
using ParlourMS.Data.Repositories.Interfaces;
using System.Collections.Generic;

namespace ParlourMS.BL.Services
{
    /// <summary>
    /// User Service
    /// </summary>
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService ( IUserRepository userRepository )
        {
            _userRepository = userRepository;
        }

        public List<User> GetUserList ()
        {
            return _userRepository.GetUserList ();
        }
    }
}
