using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApp7
{

    public class FilePersonRepository : IPersonRepository
    {
        private readonly string filePath;

        public FilePersonRepository(string filePath)
        {
            this.filePath = filePath;
        }

        public void AddPerson(Person person)
        {
            var persons = GetAllPersons();
            persons.Add(person);
            SaveToFile(persons);
        }

        public List<Person> GetAllPersons()
        {
            if (!File.Exists(filePath)) return new List<Person>();
            var content = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<Person>>(content) ?? new List<Person>();
        }

        public Person GetPersonById(int id)
        {
            return GetAllPersons().Find(p => p.Id == id);
        }

        private void SaveToFile(List<Person> persons)
        {
            var json = JsonConvert.SerializeObject(persons, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
    }

}