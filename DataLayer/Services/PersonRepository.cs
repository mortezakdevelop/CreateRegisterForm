using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    // impeliment repository interface
    public class PersonRepository : IPersonRepository
    {
        MyPersonContext db = new MyPersonContext();

        public bool DeletePerson(Person person)
        {
            try
            {
                db.Entry(person).State = System.Data.Entity.EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }

            }
           

        public bool InsertPerson(Person person)
        {
            try
            {
                db.people.Add(person);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        public bool UpdatePerson(Person person)
        {
            try
            {
                db.Entry(person).State = System.Data.Entity.EntityState.Modified;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public void save()
        {
            db.SaveChanges();
        }
    }
}
