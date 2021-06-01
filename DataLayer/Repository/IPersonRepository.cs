using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
   public interface IPersonRepository
    {
        // CRUD Operation

        bool InsertPerson(Person person);
        bool UpdatePerson(Person person);
        bool DeletePerson(Person person);

        void save();
    }
}
