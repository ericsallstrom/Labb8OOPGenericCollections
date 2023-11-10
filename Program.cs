// Eric Sällström .NET23

namespace Labb8OOPGenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.ForegroundColor = ConsoleColor.Green;

            /* DEL 1 - Stack */

            // Skapar en Stack som kan lagra objekt från Employee-klassen.
            Stack<Employee> stackOfEmployees = new();

            // Instansierar fem olika Employee-objekt, med olika värden för id, name, firstMaleInList och salary.
            Employee emp1 = new(id: 101, name: "Aretha Franklin", gender: Genders.Female, salary: 35000);
            Employee emp2 = new(id: 102, name: "David Bowie", gender: Genders.Male, salary: 35000);
            Employee emp3 = new(id: 103, name: "Demi Lovato", gender: Genders.Nonbinary, salary: 25000);
            Employee emp4 = new(id: 104, name: "Prince", gender: Genders.Male, salary: 30000);
            Employee emp5 = new(id: 105, name: "Dorit Chrysler", gender: Genders.Female, salary: 20000);

            // Lägger till objekten i Stacken med hjälp av Push()-metoden.
            stackOfEmployees.Push(emp1);
            stackOfEmployees.Push(emp2);
            stackOfEmployees.Push(emp3);
            stackOfEmployees.Push(emp4);
            stackOfEmployees.Push(emp5);

            /* Itererar över alla objekt i Stacken och skriver ut respektive 
             * information genom PrintEmployeeInfo()-metoden. Efter att
             * informationen har skrivits ut för ett objekt skrivs det sedan
             * ut hur många element (objekt) som finns kvar i Stacken. */
            foreach (var employee in stackOfEmployees)
            {
                employee.PrintEmployeeInfo();

                Console.WriteLine($"Employees left in the stack: {stackOfEmployees.Count}\n");
            }

            // Avgränsning som visar på ett nytt avsnitt i Del 1.
            Console.WriteLine("======\n" +
                            "\nRetrieve and Remove Using Pop Method\n");

            /* Så länge antal element i Stacken är större än 0, kommer
             * det sista elementet i listan, dvs. det som ligger överst
             * i stacken, att tas bort (LIFO). För varje element som
             * raderas skrivs informationen om det specifika objektet ut.
             * Sedan skriver programmet ut hur många element som finns
             * kvar i Stacken, tills det att alla element är borta. */
            while (stackOfEmployees.Count > 0)
            {
                /* Variabeln removedEmployee tilldelas värdet
                 * av det element som hämtas och raderas 
                 * från Stacken genom metoden Pop(). */
                Employee removedEmployee = stackOfEmployees.Pop();

                Console.WriteLine("*** Employee removed ***");

                removedEmployee.PrintEmployeeInfo();

                Console.WriteLine($"Employees left in the stack: {stackOfEmployees.Count}\n");
            }

            // Lägger till objekten i Stacken igen.
            stackOfEmployees.Push(emp1);
            stackOfEmployees.Push(emp2);
            stackOfEmployees.Push(emp3);
            stackOfEmployees.Push(emp4);
            stackOfEmployees.Push(emp5);

            // Avgränsning som visar på ett nytt avsnitt i Del 1.
            Console.WriteLine("======\n" +
                            "\nRetrieve Using Peek Method\n");

            /* Variabeln employeePeek tar emot elementet som ligger överst i Stacken
             * genom Peek()-metoden. Därefter skrivs informationen om det elementet ut
             * genom PrintEmployeeInfo()-metoden. Sist visas hur många element som finns
             * kvar i Stacken. */
            Employee employeePeek = stackOfEmployees.Peek();
            employeePeek.PrintEmployeeInfo();
            Console.WriteLine($"Employees left in the stack: {stackOfEmployees.Count}\n");

            // Tar bort det översta elementet från Stacken.
            stackOfEmployees.Pop();

            /* Upprepar samma procedur som ovan men efter att ha raderat det
             * element som tidigare låg överst i Stacken. Detta för att kunna
             * visa på att det nu är ett nytt element som nu ligger överst. */
            employeePeek = stackOfEmployees.Peek();
            employeePeek.PrintEmployeeInfo();
            Console.WriteLine($"Employees left in the stack: {stackOfEmployees.Count}\n");

            // Avgränsning som visar på ett nytt avsnitt i Del 1.
            Console.WriteLine("======\n" +
                            "\nUsing Contain Method\n");

            /* Med Contain()-metoden kan man se om en Stack innehåller ett 
             * visst objekt eller inte. Om objektet finns i Stacken returneras 
             * true, och false om objektet således inte finns. Med en if-sats
             * kan man enkelt se efter om, som i det här fallet, objektet
             * emp3 finns i Stacken. Meddelande för respektive utfall skrivs
             * sedan ut i konsolen som berättar om objektet finns eller ej. */
            if (stackOfEmployees.Contains(emp3))
            {
                Console.WriteLine($"Employee {emp3.Id} - {emp3.Name} is in the stack.\n");
            }
            else
            {
                Console.WriteLine($"Employee {emp3.Id} - {emp3.Name} is not in the stack.\n");
            }

            Console.WriteLine("======\n");

            /* DEL 2 - List */

            // Skapar en lista som lagrar fem objekt av Employee-klassen.
            List<Employee> listOfEmployees = new() { emp1, emp2, emp3, emp4, emp5 };

            /* Med Contain()-metoden kan man se om en List innehåller ett visst
             * objekt eller inte. Om objektet finns returneras true, om det inte
             * finns returneras false. Jag använder en if-sats nedan för att 
             * kolla om ett objekt av Employee-klassen finns lagrad i listan. 
             * Meddelande för respektive utfall skrivs ut i konsolen. */
            if (listOfEmployees.Contains(emp2))
            {
                Console.WriteLine($"Employee {emp2.Id} - {emp2.Name} exists in the list.\n");
            }
            else
            {
                Console.WriteLine($"Employee {emp2.Id} - {emp2.Name} does not exist in the list.\n");
            }

            // Använder Find()-metoden för att hitta och tilldela variabeln 
            // firstMaleEmp det första objektet i listan som är av typen Male.
            var firstMaleEmp = listOfEmployees.Find(emp => emp.Gender == Genders.Male);

            // Informationen för det första objektet i listan
            // som är av typen Male skrivs ut till konsolen.
            Console.WriteLine("*** First male employee in the list ***");
            firstMaleEmp!.PrintEmployeeInfo();

            // Använder FindAll()-metoden för att hitta och lagra 
            // alla objekt som är av typen Male i listan allMaleEmp.
            var allMaleEmp = listOfEmployees.FindAll(emp => emp.Gender == Genders.Male);

            // Använder en foreach-loop för att hitta och skriva ut information
            // för alla objekt som är av typen Male till konsolen.
            Console.WriteLine("*** All male employees in the list ***");
            foreach (var maleEmp in allMaleEmp)
            {
                maleEmp.PrintEmployeeInfo();
            }
        }
    }
}