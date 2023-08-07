using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Persistence
{
    public class DbInitializer
    {
        public static void Initialize(NotesDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
