// Eric Sällström .NET23

namespace Labb8OOPGenericCollections
{
    internal class Employee
    {
        // Publika egenskaper som där värdet går att hämta men ej ändra.
        public uint Id { get; private set; }
        public string Name { get; private set; }
        public Genders Gender { get; private set; }
        public decimal Salary { get; private set; }

        // Konstruktor som tilldelar värdet av varje variabel från respektive 
        // objekt som instansieras av Employee-klassen till motsvarande egenskap.
        public Employee(uint id, string name, Genders gender, decimal salary)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Salary = salary;
        }

        // Publik metod som skriver ut egenskaperna för respektive objekt.
        public void PrintEmployeeInfo()
        {
            Console.WriteLine($"{Id} - {Name} - {Gender} - {Salary:C}\n");
        }
    }
}