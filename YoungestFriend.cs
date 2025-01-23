using System;

class YoungestFriend
{
    static void Main()
    {
        // Taking input for the 3 friends
        Console.WriteLine("Enter age of Amar:");
        int amarAge = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter height of Amar (in cm):");
        int amarHeight = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter age of Akbar:");
        int akbarAge = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter height of Akbar (in cm):");
        int akbarHeight = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter age of Anthony:");
        int anthonyAge = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter height of Anthony (in cm):");
        int anthonyHeight = int.Parse(Console.ReadLine());

        // Finding the youngest friend
        int youngestAge = amarAge;
        string youngestFriend = "Amar";
        if (akbarAge < youngestAge)
        {
            youngestAge = akbarAge;
            youngestFriend = "Akbar";
        }
        if (anthonyAge < youngestAge)
        {
            youngestAge = anthonyAge;
            youngestFriend = "Anthony";
        }

        // Finding the tallest friend
        int tallestHeight = amarHeight;
        string tallestFriend = "Amar";
        if (akbarHeight > tallestHeight)
        {
            tallestHeight = akbarHeight;
            tallestFriend = "Akbar";
        }
        if (anthonyHeight > tallestHeight)
        {
            tallestHeight = anthonyHeight;
            tallestFriend = "Anthony";
        }

        // Output
        Console.WriteLine("The youngest friend is " + youngestFriend + " with age " + youngestAge + ".");
        Console.WriteLine("The tallest friend is " + tallestFriend + " with height " + tallestHeight + " cm.");
    }
}
