using System;
namespace HelloWorld
{
    public class Message
    {
        string text1;
        

        public Message(string text)
        {
            text1 = text;
        }

        public void Print()
        {
            Console.WriteLine(text1);
        }

        public static implicit operator Message(string v)
        {
            throw new NotImplementedException();
        }
    }
}

