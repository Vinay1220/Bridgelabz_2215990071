using System; 
 
// Base class representing a Person 
public class Person 
{ 
    public string Name { get; set; } 
    public int Age { get; set; } 
 
    public Person(string name, int age) 
    { 
        Name = name; 
        Age = age; 
    } 
 
    public virtual void DisplayRole() 
    { 
        Console.WriteLine("General Person"); 
    } 
} 
 
// Subclass Teacher 
public class Teacher : Person 
{ 
    public string Subject { get; set; } 
 
    public Teacher(string name, int age, string subject) : base(name, age) 
    { 
        Subject = subject; 
    } 
 
    public override void DisplayRole() 
    { 
        Console.WriteLine("Teacher of Subject: {0}", Subject); 
    } 
} 
 
// Subclass Student 
public class Student : Person 
{ 
    public int Grade { get; set; } 
 
    public Student(string name, int age, int grade) : base(name, age) 
    { 
        Grade = grade; 
    } 
 
    public override void DisplayRole() 
    { 
        Console.WriteLine("Student in Grade: {0}", Grade); 
    } 
} 
 
// Subclass Staff 
public class Staff : Person 
{ 
    public string Department { get; set; } 
 
    public Staff(string name, int age, string department) : base(name, age) 
    { 
        Department = department; 
    } 
 
    public override void DisplayRole() 
    { 
        Console.WriteLine("Staff working in: {0} Department", Department); 
    } 
} 
 
// Main Program 
public class Program 
{ 
    public static void Main() 
    { 
        // Testing Person hierarchy 
        Person teacher = new Teacher("Alice", 35, "Mathematics"); 
        Person student = new Student("Bob", 16, 10); 
        Person staff = new Staff("Charlie", 40, "Administration"); 
         
        teacher.DisplayRole(); 
        student.DisplayRole(); 
        staff.DisplayRole(); 
    } 
} 