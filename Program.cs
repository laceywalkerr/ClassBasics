using System;

namespace ClassBasics
{
    // class Program
    // {
    //     static void Main(string[] args)
    //     {
    //         Console.WriteLine("Hello World!");
    //     }
    // }

    public class Writer
    {
        public Writer(string prefix)
        {
            Prefix = prefix;
        }

        public string Prefix { get; set; }

        public void Write(string message)
        {
            Console.WriteLine(Prefix + message);

            // The output variable's type is `string` -- a built in type
            string output = "Nashville Software School";

            // The author variable's type is Writer -- a custom type you defined
            Writer author = new Writer("I do declare: ");
            author.Write(output);

            author.Prefix = "That's right, I said: ";
            author.Write(output);
        }

    }
}