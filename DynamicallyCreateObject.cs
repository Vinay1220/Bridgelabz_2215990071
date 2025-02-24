using System;
using System.Reflection;

class Student
{
    private string name;
    private int age;

    public Student(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}

class ReflectionExample
{
    static void Main()
    {
        Type type = typeof(Student);

        ConstructorInfo constructor = type.GetConstructor(new Type[] { typeof(string), typeof(int) });

        if (constructor != null)
        {
            object studentInstance = constructor.Invoke(new object[] { "John Doe", 20 });

            MethodInfo method = type.GetMethod("DisplayInfo");

            if (method != null)
            {
                method.Invoke(studentInstance, null);
            }
        }
        else
        {
            Console.WriteLine("Constructor not found.");
        }
    }
}