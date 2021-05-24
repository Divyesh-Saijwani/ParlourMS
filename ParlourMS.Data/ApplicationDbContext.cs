using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ParlourMS.Data.Models;

namespace ParlourMS.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext ( DbContextOptions<ApplicationDbContext> options )
            : base ( options )
        {
        }
    }
}
