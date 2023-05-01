using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Utils
{
    public class DatabaseSeeder
    {
        public IReadOnlyCollection<User> Users { get; } = new List<User>();
        public DatabaseSeeder()
        { 
        }
    }
}
