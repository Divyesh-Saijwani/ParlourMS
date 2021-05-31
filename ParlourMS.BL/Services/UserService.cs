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

        public User AddUser ( User user )
        {
            if ( !string.IsNullOrEmpty ( user.Email ) )
            {
                user.EmailConfirmed = true;
                user.NormalizedEmail = user.Email.ToUpper ();
            }

            if ( !string.IsNullOrEmpty ( user.PhoneNumber ) )
            {
                user.PhoneNumberConfirmed = true;
            }

            if ( !string.IsNullOrEmpty ( user.UserName ) )
            {
                user.NormalizedUserName = user.UserName.ToUpper ();
            }

            return _userRepository.AddUser ( user );

        }

        public User GetUser ( string id )
        {
            return _userRepository.GetUser ( id );
        }

        public List<User> GetUserList ()
        {
            return _userRepository.GetUserList ();
        }
    }
}
