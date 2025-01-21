using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{


    public interface IPersonRepository
    {
        void AddPerson(Person person);
        List<Person> GetAllPersons();
        Person GetPersonById(int id);
    }

}

