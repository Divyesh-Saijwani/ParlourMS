using ParlourMS.Data.Models;
using System.Collections.Generic;

namespace ParlourMS.BL.Services.Interfaces
{
    /// <summary>
    /// User service interface
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// This method is responsible for getting user list
        /// </summary>
        /// <returns>List of user</returns>
        List<User> GetUserList();

        /// <summary>
        /// This method is responsible for getting user details
        /// </summary>
        /// <returns>User details</returns>
        User GetUser (string id);

        /// <summary>
        /// This method is responsible for adding new user
        /// </summary>
        /// <param name="user">User object</param>
        /// <returns>User object</returns>
        User AddUser (User user);

    }
}
