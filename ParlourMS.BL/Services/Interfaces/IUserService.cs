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

    }
}
