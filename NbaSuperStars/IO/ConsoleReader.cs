using System;

using NbaSuperStars.IO.Contracts;

namespace NbaSuperStars.IO
{
    public class ConsoleReader : IReader
    {
        public string Read()
        {
            return Console.ReadLine();
        }
    }
}
