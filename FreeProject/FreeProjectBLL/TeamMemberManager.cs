using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreeProjectDAL;

namespace FreeProjectBLL
{
    public class TeamMemberManager
    {
        private readonly ApplicationDbContext _context;

        public TeamMemberManager()
        {
            _context = new ApplicationDbContext();
            
        }
    }


}
