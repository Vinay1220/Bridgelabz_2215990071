using System;

class Movie
{
    public string Title;
    public string Director;
    public int Year;
    public float Rating;
    public Movie Prev;
    public Movie Next;

    public Movie(string title, string director, int year, float rating)
    {
        Title = title;
        Director = director;
        Year = year;
        Rating = rating;
        Prev = null;
        Next = null;
    }
}

class MovieList
{
    private Movie head;
    private Movie tail;

    public void AddFirst(string title, string director, int year, float rating)
    {
        Movie newMovie = new Movie(title, director, year, rating);
        if (head == null)
        {
            head = tail = newMovie;
            return;
        }
        newMovie.Next = head;
        head.Prev = newMovie;
        head = newMovie;
    }

    public void AddLast(string title, string director, int year, float rating)
    {
        Movie newMovie = new Movie(title, director, year, rating);
        if (tail == null)
        {
            head = tail = newMovie;
            return;
        }
        tail.Next = newMovie;
        newMovie.Prev = tail;
        tail = newMovie;
    }

    public void AddAtPosition(string title, string director, int year, float rating, int position)
    {
        if (position <= 1)
        {
            AddFirst(title, director, year, rating);
            return;
        }
        Movie newMovie = new Movie(title, director, year, rating);
        Movie temp = head;
        int count = 1;
        while (temp != null && count < position - 1)
        {
            temp = temp.Next;
            count++;
        }
        if (temp == null || temp.Next == null)
        {
            AddLast(title, director, year, rating);
            return;
        }
        newMovie.Next = temp.Next;
        newMovie.Prev = temp;
        temp.Next.Prev = newMovie;
        temp.Next = newMovie;
    }

    public void DeleteByTitle(string title)
    {
        Movie temp = head;
        while (temp != null && temp.Title != title)
        {
            temp = temp.Next;
        }
        if (temp == null)
        {
            Console.WriteLine("Movie not found!");
            return;
        }
        if (temp == head)
        {
            head = head.Next;
            if (head != null) head.Prev = null;
        }
        else if (temp == tail)
        {
            tail = tail.Prev;
            if (tail != null) tail.Next = null;
        }
        else
        {
            temp.Prev.Next = temp.Next;
            temp.Next.Prev = temp.Prev;
        }
    }

    public void SearchByDirector(string director)
    {
        Movie temp = head;
        while (temp != null)
        {
            if (temp.Director == director)
            {
                Console.WriteLine("Title: " + temp.Title + ", Year: " + temp.Year + ", Rating: " + temp.Rating);
            }
            temp = temp.Next;
        }
    }

    public void SearchByRating(float rating)
    {
        Movie temp = head;
        while (temp != null)
        {
            if (temp.Rating == rating)
            {
                Console.WriteLine("Title: " + temp.Title + ", Director: " + temp.Director + ", Year: " + temp.Year);
            }
            temp = temp.Next;
        }
    }

    public void DisplayForward()
    {
        Movie temp = head;
        while (temp != null)
        {
            Console.WriteLine("Title: " + temp.Title + ", Director: " + temp.Director + ", Year: " + temp.Year + ", Rating: " + temp.Rating);
            temp = temp.Next;
        }
    }

    public void DisplayBackward()
    {
        Movie temp = tail;
        while (temp != null)
        {
            Console.WriteLine("Title: " + temp.Title + ", Director: " + temp.Director + ", Year: " + temp.Year + ", Rating: " + temp.Rating);
            temp = temp.Prev;
        }
    }

    public void UpdateRating(string title, float newRating)
    {
        Movie temp = head;
        while (temp != null)
        {
            if (temp.Title == title)
            {
                temp.Rating = newRating;
                Console.WriteLine("Updated rating for " + title + " to " + newRating);
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Movie not found!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        MovieList movieList = new MovieList();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1 - Add Movie at Beginning");
            Console.WriteLine("2 - Add Movie at End");
            Console.WriteLine("3 - Add Movie at Position");
            Console.WriteLine("4 - Remove Movie by Title");
            Console.WriteLine("5 - Search Movie by Director");
            Console.WriteLine("6 - Search Movie by Rating");
            Console.WriteLine("7 - Display Movies (Forward)");
            Console.WriteLine("8 - Display Movies (Reverse)");
            Console.WriteLine("9 - Update Movie Rating");
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
                case 2:
                case 3:
                    Console.Write("Enter Movie Title: ");
                    string title = Console.ReadLine();
                    Console.Write("Enter Director: ");
                    string director = Console.ReadLine();
                    Console.Write("Enter Year of Release: ");
                    int year = int.Parse(Console.ReadLine());
                    Console.Write("Enter Rating: ");
                    float rating = float.Parse(Console.ReadLine());

                    if (choice == 1)
                        movieList.AddFirst(title, director, year, rating);
                    else if (choice == 2)
                        movieList.AddLast(title, director, year, rating);
                    else
                    {
                        Console.Write("Enter Position: ");
                        int position = int.Parse(Console.ReadLine());
                        movieList.AddAtPosition(title, director, year, rating, position);
                    }
                    break;

                case 4:
                    Console.Write("Enter Movie Title to Remove: ");
                    string removeTitle = Console.ReadLine();
                    movieList.DeleteByTitle(removeTitle);
                    break;

                case 5:
                    Console.Write("Enter Director to Search: ");
                    string searchDirector = Console.ReadLine();
                    movieList.SearchByDirector(searchDirector);
                    break;

                case 6:
                    Console.Write("Enter Rating to Search: ");
                    float searchRating = float.Parse(Console.ReadLine());
                    movieList.SearchByRating(searchRating);
                    break;

                case 7:
                    movieList.DisplayForward();
                    break;

                case 8:
                    movieList.DisplayBackward();
                    break;

                case 9:
                    Console.Write("Enter Movie Title to Update Rating: ");
                    string updateTitle = Console.ReadLine();
                    Console.Write("Enter New Rating: ");
                    float newRating = float.Parse(Console.ReadLine());
                    movieList.UpdateRating(updateTitle, newRating);
                    break;

                default:
                    Console.WriteLine("Invalid choice! Please select a valid option.");
                    break;
            }
        }
    }
}
