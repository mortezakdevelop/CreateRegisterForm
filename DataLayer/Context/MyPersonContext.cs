using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
   public class MyPersonContext:DbContext
    {
        public object People;

        public DbSet<Person> people { get; set; }
    }
}
