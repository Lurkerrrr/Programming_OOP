using System; 
using SharpLab

namespace SharpLab
{
    internal class Person
    {
        private string firstName, lastName; 
        private int age; 

        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName; 
            this.lastName = lastName;   
            this.age = age;
        } 

        public void View()
        {
            Console.WriteLine($"Imie: \t{firstName}\tNazwisko:\t{lastName}\tWiek:\t{age}"
        }
    }
} 

using SharpLab;

Person[] people = new Person[]
{
    new Person("Jan", "Nowak",34),
    new Person("Jana", "Nowak",36),
    new Person("Ala", "Jankowska",56),
    new Person("Maria", "Kowalska",18),
};