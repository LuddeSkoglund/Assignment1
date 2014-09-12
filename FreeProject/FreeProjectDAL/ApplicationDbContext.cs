
using System.Data.Entity;




using FreeProjectModels;

namespace FreeProjectDAL
{
    public class ApplicationDbContext 
    {
        public DbSet<TeamMember> TeamMembers { get; set; }
    }
}
