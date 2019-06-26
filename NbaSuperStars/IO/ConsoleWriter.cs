using System;

using NbaSuperStars.IO.Contracts;

namespace NbaSuperStars.IO
{
    public class ConsoleWriter : IWriter
    {
        public void Write(string content)
        {
            Console.WriteLine(content);
        }
    }
}
