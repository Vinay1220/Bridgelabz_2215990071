using System;

class TextStateNode
{
    public string TextContent;
    public TextStateNode Prev;
    public TextStateNode Next;

    public TextStateNode(string text)
    {
        TextContent = text;
        Prev = null;
        Next = null;
    }
}

class TextEditor
{
    private TextStateNode head;
    private TextStateNode current;
    private int maxSize = 10;
    private int size = 0;

    public void AddState(string text)
    {
        TextStateNode newState = new TextStateNode(text);

        if (head == null)
        {
            head = newState;
            current = newState;
        }
        else
        {
            current.Next = newState;
            newState.Prev = current;
            current = newState;
        }

        size++;
        if (size > maxSize)
        {
            head = head.Next;
            head.Prev = null;
            size--;
        }
    }

    public void Undo()
    {
        if (current == null || current.Prev == null)
        {
            Console.WriteLine("Undo not possible.");
            return;
        }

        current = current.Prev;
        Console.WriteLine("Undo performed. Current Text: " + current.TextContent);
    }

    public void Redo()
    {
        if (current == null || current.Next == null)
        {
            Console.WriteLine("Redo not possible.");
            return;
        }

        current = current.Next;
        Console.WriteLine("Redo performed. Current Text: " + current.TextContent);
    }

    public void DisplayCurrentState()
    {
        if (current == null)
        {
            Console.WriteLine("No text available.");
            return;
        }

        Console.WriteLine("Current Text: " + current.TextContent);
    }
}

class Program
{
    static void Main(string[] args)
    {
        TextEditor editor = new TextEditor();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nText Editor Menu:");
            Console.WriteLine("1 - Type Text (Add New State)");
            Console.WriteLine("2 - Undo");
            Console.WriteLine("3 - Redo");
            Console.WriteLine("4 - Display Current Text");
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
                    Console.Write("Enter new text: ");
                    string text = Console.ReadLine();
                    editor.AddState(text);
                    break;

                case 2:
                    editor.Undo();
                    break;

                case 3:
                    editor.Redo();
                    break;

                case 4:
                    editor.DisplayCurrentState();
                    break;

                default:
                    Console.WriteLine("Invalid choice! Please select a valid option.");
                    break;
            }
        }
    }
}
