using ParlourMS.Data.Models;
using System.Collections.Generic;

namespace ParlourMS.Data.Repositories.Interfaces
{
    /// <summary>
    /// User Repository Interface
    /// </summary>
    public interface IUserRepository
    {
        /// <summary>
        /// This method is responsible for getting user list from database
        /// </summary>
        /// <returns>List of user</returns>
        List<User> GetUserList ();

        /// <summary>
        /// This method is responsible for getting user details
        /// </summary>
        /// <returns>User details</returns>
        User GetUser ( string id );

        /// <summary>
        /// This method is responsible for adding new user into database
        /// </summary>
        /// <param name="user">User object</param>
        /// <returns>User object</returns>
        User AddUser ( User user );
    }
}
