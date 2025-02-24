using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
public class RoleAllowedAttribute : Attribute
{
    public string Role { get; }

    public RoleAllowedAttribute(string role)
    {
        Role = role;
    }
}

class AccessControl
{
    [RoleAllowed("ADMIN")]
    public void AdminMethod()
    {
        Console.WriteLine("Admin method executed.");
    }

    public void UserMethod()
    {
        Console.WriteLine("User method executed.");
    }
}

class Program
{
    static void Main()
    {
        AccessControl accessControl = new AccessControl();

        string userRole = "USER"; // Simulate user role (can change to "ADMIN" for testing)

        MethodInfo[] methods = typeof(AccessControl).GetMethods();
        foreach (MethodInfo method in methods)
        {
            RoleAllowedAttribute roleAllowed = (RoleAllowedAttribute)Attribute.GetCustomAttribute(method, typeof(RoleAllowedAttribute));

            if (roleAllowed != null)
            {
                if (roleAllowed.Role == userRole)
                {
                    method.Invoke(accessControl, null);
                }
                else
                {
                    Console.WriteLine("Access Denied!");
                }
            }
            else
            {
                method.Invoke(accessControl, null);
            }
        }
    }
}