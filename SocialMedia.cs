using System;
using System.Collections.Generic;

class UserNode
{
    public int UserID;
    public string Name;
    public int Age;
    public List<int> FriendIDs;
    public UserNode Next;

    public UserNode(int userID, string name, int age)
    {
        UserID = userID;
        Name = name;
        Age = age;
        FriendIDs = new List<int>();
        Next = null;
    }
}

class SocialMediaNetwork
{
    private UserNode head;

    public void AddUser(int userID, string name, int age)
    {
        UserNode newUser = new UserNode(userID, name, age);
        if (head == null)
        {
            head = newUser;
        }
        else
        {
            UserNode temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newUser;
        }
    }

    public void AddFriendConnection(int userID1, int userID2)
    {
        UserNode user1 = FindUserByID(userID1);
        UserNode user2 = FindUserByID(userID2);

        if (user1 == null || user2 == null)
        {
            Console.WriteLine("One or both users not found.");
            return;
        }

        if (!user1.FriendIDs.Contains(userID2))
        {
            user1.FriendIDs.Add(userID2);
        }
        if (!user2.FriendIDs.Contains(userID1))
        {
            user2.FriendIDs.Add(userID1);
        }

        Console.WriteLine("Friend connection added between " + user1.Name + " and " + user2.Name);
    }

    public void RemoveFriendConnection(int userID1, int userID2)
    {
        UserNode user1 = FindUserByID(userID1);
        UserNode user2 = FindUserByID(userID2);

        if (user1 == null || user2 == null)
        {
            Console.WriteLine("One or both users not found.");
            return;
        }

        user1.FriendIDs.Remove(userID2);
        user2.FriendIDs.Remove(userID1);

        Console.WriteLine("Friend connection removed between " + user1.Name + " and " + user2.Name);
    }

    public void DisplayFriends(int userID)
    {
        UserNode user = FindUserByID(userID);
        if (user == null)
        {
            Console.WriteLine("User not found.");
            return;
        }

        Console.WriteLine("Friends of " + user.Name + ":");
        foreach (int friendID in user.FriendIDs)
        {
            UserNode friend = FindUserByID(friendID);
            if (friend != null)
            {
                Console.WriteLine("User ID: " + friend.UserID + ", Name: " + friend.Name);
            }
        }
    }

    public void FindMutualFriends(int userID1, int userID2)
    {
        UserNode user1 = FindUserByID(userID1);
        UserNode user2 = FindUserByID(userID2);

        if (user1 == null || user2 == null)
        {
            Console.WriteLine("One or both users not found.");
            return;
        }

        List<int> mutualFriends = new List<int>();
        foreach (int friendID in user1.FriendIDs)
        {
            if (user2.FriendIDs.Contains(friendID))
            {
                mutualFriends.Add(friendID);
            }
        }

        Console.WriteLine("Mutual Friends:");
        if (mutualFriends.Count == 0)
        {
            Console.WriteLine("No mutual friends found.");
        }
        else
        {
            foreach (int friendID in mutualFriends)
            {
                UserNode mutualFriend = FindUserByID(friendID);
                if (mutualFriend != null)
                {
                    Console.WriteLine("User ID: " + mutualFriend.UserID + ", Name: " + mutualFriend.Name);
                }
            }
        }
    }

    public void SearchUser(int userID)
    {
        UserNode user = FindUserByID(userID);
        if (user != null)
        {
            Console.WriteLine("User Found: ID - " + user.UserID + ", Name - " + user.Name + ", Age - " + user.Age);
        }
        else
        {
            Console.WriteLine("User not found.");
        }
    }

    public void SearchUser(string name)
    {
        UserNode temp = head;
        while (temp != null)
        {
            if (temp.Name.ToLower() == name.ToLower())
            {
                Console.WriteLine("User Found: ID - " + temp.UserID + ", Name - " + temp.Name + ", Age - " + temp.Age);
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("User not found.");
    }

    public void CountFriends(int userID)
    {
        UserNode user = FindUserByID(userID);
        if (user == null)
        {
            Console.WriteLine("User not found.");
            return;
        }

        Console.WriteLine("User " + user.Name + " has " + user.FriendIDs.Count + " friends.");
    }

    private UserNode FindUserByID(int userID)
    {
        UserNode temp = head;
        while (temp != null)
        {
            if (temp.UserID == userID)
            {
                return temp;
            }
            temp = temp.Next;
        }
        return null;
    }
}

class Program
{
    static void Main(string[] args)
    {
        SocialMediaNetwork network = new SocialMediaNetwork();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nSocial Media Friend Connection Menu:");
            Console.WriteLine("1 - Add User");
            Console.WriteLine("2 - Add Friend Connection");
            Console.WriteLine("3 - Remove Friend Connection");
            Console.WriteLine("4 - Display Friends of a User");
            Console.WriteLine("5 - Find Mutual Friends");
            Console.WriteLine("6 - Search User by ID");
            Console.WriteLine("7 - Search User by Name");
            Console.WriteLine("8 - Count Friends");
            Console.WriteLine("0 - Exit");
            Console.Write("Enter your choice: ");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input! Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 0:
                    running = false;
                    break;

                case 1:
                    Console.Write("Enter User ID: ");
                    int userID = int.Parse(Console.ReadLine());
                    Console.Write("Enter Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Age: ");
                    int age = int.Parse(Console.ReadLine());
                    network.AddUser(userID, name, age);
                    break;

                case 2:
                    Console.Write("Enter First User ID: ");
                    int userID1 = int.Parse(Console.ReadLine());
                    Console.Write("Enter Second User ID: ");
                    int userID2 = int.Parse(Console.ReadLine());
                    network.AddFriendConnection(userID1, userID2);
                    break;

                case 3:
                    Console.Write("Enter First User ID: ");
                    int removeUserID1 = int.Parse(Console.ReadLine());
                    Console.Write("Enter Second User ID: ");
                    int removeUserID2 = int.Parse(Console.ReadLine());
                    network.RemoveFriendConnection(removeUserID1, removeUserID2);
                    break;

                case 4:
                    Console.Write("Enter User ID: ");
                    int displayUserID = int.Parse(Console.ReadLine());
                    network.DisplayFriends(displayUserID);
                    break;

                case 5:
                    Console.Write("Enter First User ID: ");
                    int mutualUserID1 = int.Parse(Console.ReadLine());
                    Console.Write("Enter Second User ID: ");
                    int mutualUserID2 = int.Parse(Console.ReadLine());
                    network.FindMutualFriends(mutualUserID1, mutualUserID2);
                    break;

                case 6:
                    Console.Write("Enter User ID to Search: ");
                    int searchUserID = int.Parse(Console.ReadLine());
                    network.SearchUser(searchUserID);
                    break;

                case 7:
                    Console.Write("Enter Name to Search: ");
                    string searchName = Console.ReadLine();
                    network.SearchUser(searchName);
                    break;

                case 8:
                    Console.Write("Enter User ID: ");
                    int countUserID = int.Parse(Console.ReadLine());
                    network.CountFriends(countUserID);
                    break;

                default:
                    Console.WriteLine("Invalid choice! Please select a valid option.");
                    break;
            }
        }
    }
}
