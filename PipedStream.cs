using System;
using System.IO;
using System.IO.Pipes;
using System.Threading;

class PipedStream
{
    static void Main()
    {
        using (AnonymousPipeServerStream pipeServer = new AnonymousPipeServerStream(PipeDirection.Out, HandleInheritability.Inheritable))
        using (AnonymousPipeClientStream pipeClient = new AnonymousPipeClientStream(PipeDirection.In, pipeServer.ClientSafePipeHandle))
        {
            Thread writerThread = new Thread(() => WriteData(pipeServer));
            Thread readerThread = new Thread(() => ReadData(pipeClient));

            writerThread.Start();
            readerThread.Start();

            writerThread.Join();
            readerThread.Join();
        }
    }

    static void WriteData(PipeStream pipe)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(pipe))
            {
                writer.AutoFlush = true;
                for (int i = 1; i <= 5; i++)
                {
                    writer.WriteLine("Message " + i);
                    Thread.Sleep(500); // Simulating delay
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("Write Error: " + ex.Message);
        }
    }

    static void ReadData(PipeStream pipe)
    {
        try
        {
            using (StreamReader reader = new StreamReader(pipe))
            {
                string message;
                while ((message = reader.ReadLine()) != null)
                {
                    Console.WriteLine("Received: " + message);
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("Read Error: " + ex.Message);
        }
    }
}