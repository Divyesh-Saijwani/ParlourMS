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
    }
}
