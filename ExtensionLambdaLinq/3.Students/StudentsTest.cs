//

using System;
using System.Linq;

class StudentsTest
{
    static void Main()
    {
        Student stud1 = new Student("Angel", "Dimitrov", 19);
        Student stud2 = new Student("Dimitar", "Ivanov", 25);
        Student stud3 = new Student("Ivan", "Petrov", 20);
        Student stud4 = new Student("Dimitar", "Angelov", 17);
        Student stud5 = new Student("Vasil", "Delchev", 22);
        Student stud6 = new Student("Delcho", "Stefanov", 21);
        Student stud7 = new Student("Dimitar", "Petrov", 27);

        Student[] class1B = { stud1, stud2, stud3, stud4, stud5, stud6, stud7};

        //Write a method that from a given array of students finds all students whose first name
        //is before its last name alphabetically. Use LINQ query operators.

        var selected = from person in class1B
                       where person.firstName.CompareTo(person.lastName)==-1
                       select person;
        Console.WriteLine("Student with first name before last name alphabetically are:");
        PrintListOfstudents(selected);


        //Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
        var withinAge = from person in class1B
                        where person.age >= 18 && person.age <= 24
                        select person;
        Console.WriteLine();
        Console.WriteLine("students with age betheen 18 and 24 are:");
        PrintListOfstudents(withinAge);

        //Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students 
        //by first name and last name in descending order. Rewrite the same with LINQ.

        Console.WriteLine();
        var sortedList = class1B.OrderByDescending(x => x.firstName).ThenByDescending(x => x.lastName);
        Console.WriteLine("Sorted list by Lambda:");
        PrintListOfstudents(sortedList);

        Console.WriteLine();
        var sortList2 = from person in class1B
                        orderby person.firstName descending, person.lastName descending
                        select person;
        Console.WriteLine("Sorted list by LINQ:");
        PrintListOfstudents(sortList2);
                        

    }

    private static void PrintListOfstudents(System.Collections.Generic.IEnumerable<Student> selected)
    {
        foreach (Student item in selected)
        {
            Console.WriteLine("{0} {1}", item.firstName, item.lastName);
        }
    }
}
