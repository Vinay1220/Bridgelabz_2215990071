using System;

	class Student{
	
		public string Name;
		public int Roll;
		public int Age;
		public float Grade;
		public Student Next;
		
		public Student(string name, int roll, int age, float grade){
		
			Name = name;
			Roll = roll;
			Age = age;
			Grade = grade;
			Next = null;
		
		}	
		public Student(string name, int roll, int age, float grade, int position){
		
			Name = name;
			Roll = roll;
			Age = age;
			Grade = grade;
			Next = null;
		
		}
	}
	
	class StudentList
	{
		private Student head;

		public void Insert(string name, int roll, int age, float grade){
			Student newStudent = new Student(name, roll, age, grade);
			if (head == null){
				head = newStudent;
				return;
			}
			Student temp = head;
			while (temp.Next != null){
				temp = temp.Next;
			}
			temp.Next = newStudent;
		}

		public void Display(){
			Student temp = head;
			while (temp != null){
				Console.WriteLine("Name: " + temp.Name + ", Roll: " + temp.Roll + ", Age: " + temp.Age + ", Grade: " + temp.Grade);
				temp = temp.Next;
			}
		}
		
		public void addFirst(string name, int roll, int age, float grade){
			Student newStudent = new Student(name, roll, age, grade);
			if (head == null){
				head = newStudent;
				return;
			}
			newStudent.Next = head;
			head = newStudent;
		}
		
		public void addLast(string name, int roll, int age, float grade){
			Student newStudent = new Student(name, roll, age, grade);
			if(head == null){
				head = newStudent;
				return;
			}
			Student temp = head;
			while(temp.Next != null){
				temp = temp.Next;
			}
			temp.Next = newStudent;
			
		}
		
		public void addPos(string name, int roll, int age, float grade, int position){
			Student newStudent = new Student(name, roll, age, grade, position);
			if(head == null){
				head = newStudent;
				return;
			}
			Student temp = head;
			int count = 1;
			while(count < (position-1)){
				count++;
				temp = temp.Next;
			}
			newStudent.Next = temp.Next;
			temp.Next = newStudent;
			
		}
		
		public void Delete(int roll){
			
			Student temp = head, prev = null;

			if (temp != null && temp.Roll == roll)
			{
				head = temp.Next;
				return;
			}
			while (temp != null && temp.Roll != roll)
			{
				prev = temp;
				temp = temp.Next;
			}
			if (temp == null)
			{
				Console.WriteLine("Roll number not found!");
				return;
			}
			prev.Next = temp.Next;
		}
		
		public void Search(int roll){
			
			Student temp = head;
			while(temp.Roll != roll){
				temp = temp.Next;
			}
			Console.WriteLine("This is your data: "+temp.Name+", "+temp.Roll+", "+temp.Age+", "+temp.Grade);
		}
		
		public void Update(int roll){
			
			Student temp = head;
			while(temp.Roll != roll){
				temp = temp.Next;
			}
			Console.WriteLine("This is your old grade: "+temp.Grade);
			Console.WriteLine("Enter your new Grade:");
			temp.Grade = float.Parse(Console.ReadLine());
			Console.WriteLine("This is your new grade: "+temp.Grade);
			
		}
	}
	
	
	class Program
	{
		static void Main(string[] args)
		{
			StudentList list = new StudentList();
			 bool running = true;

			while (running)
			{
				Console.WriteLine("\nMenu:");
				Console.WriteLine("1 - Insert Student");
				Console.WriteLine("2 - Add First");
				Console.WriteLine("3 - Add Last");
				Console.WriteLine("4 - Add at Position");
				Console.WriteLine("5 - Delete Student");
				Console.WriteLine("6 - Search Student");
				Console.WriteLine("7 - Display All Students");
				Console.WriteLine("8 - Update Student Grade");
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
						Console.Write("Enter Name: ");
						string name = Console.ReadLine();
						Console.Write("Enter Roll: ");
						int roll = int.Parse(Console.ReadLine());
						Console.Write("Enter Age: ");
						int age = int.Parse(Console.ReadLine());
						Console.Write("Enter Grade(in float): ");
						float grade = float.Parse(Console.ReadLine());

						if (choice == 1)
							list.Insert(name, roll, age, grade);
						else if (choice == 2)
							list.addFirst(name, roll, age, grade);
						else
							list.addLast(name, roll, age, grade);
						break;

					case 4:
						Console.Write("Enter Name: ");
						name = Console.ReadLine();
						Console.Write("Enter Roll: ");
						roll = int.Parse(Console.ReadLine());
						Console.Write("Enter Age: ");
						age = int.Parse(Console.ReadLine());
						Console.Write("Enter Grade: ");
						grade = float.Parse(Console.ReadLine());
						Console.Write("Enter Position: ");
						int position = int.Parse(Console.ReadLine());

						list.addPos(name, roll, age, grade, position);
						break;

					case 5:
						Console.Write("Enter Roll number to delete: ");
						roll = int.Parse(Console.ReadLine());
						list.Delete(roll);
						break;

					case 6:
						Console.Write("Enter Roll number to search: ");
						roll = int.Parse(Console.ReadLine());
						list.Search(roll);
						break;
	
					case 7:
						list.Display();
						break;

					case 8:
						Console.Write("Enter Roll number to update grade: ");
						roll = int.Parse(Console.ReadLine());
						list.Update(roll);
						break;

					default:
						Console.WriteLine("Invalid choice! Please select a valid option.");
						break;
				}
			}
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
                    movieList.RemoveByTitle(removeTitle);
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
                    movieList.DisplayReverse();
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

	