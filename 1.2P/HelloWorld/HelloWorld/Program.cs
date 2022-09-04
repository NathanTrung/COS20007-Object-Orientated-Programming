using System;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        { 
            Message myMessage = new Message("Hello World - Hello from Message Object");
            myMessage.Print();
            string name;
            Console.WriteLine("Enter name: ");
            name = Console.ReadLine();
            Message[] messages = new Message[5];
            messages[0] = new Message("Welcome Back!");
            messages[1] = new Message("What a lovely name");
            messages[2] = new Message("Great name");
            messages[3] = new Message("Oh hi");
            messages[4] = new Message("This is a silly name");
            if (name == "Mark")
            {
                messages[0].Print();
            }
            else if (name == "Fred")
            {
                messages[1].Print();
            }
            else if (name == "Wilma")
            {
                messages[2].Print();
            }
            else if (name == "Alice")
            {
                messages[3].Print();
            }
            else
                messages[4].Print();


        }
    }
}