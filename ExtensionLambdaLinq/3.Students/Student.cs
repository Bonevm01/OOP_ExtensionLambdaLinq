using System;

public class Student
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public uint age;

    public Student(string fName, string lName, uint year)
    {
        this.firstName = fName;
        this.lastName = lName;
        this.age = year;
    }
}
