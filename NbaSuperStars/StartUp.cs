using NbaSuperStars.Core;
using NbaSuperStars.Core.Contracts;
using NbaSuperStars.IO;
using NbaSuperStars.IO.Contracts;

namespace NbaSuperStars
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            IReader consoleReader = new ConsoleReader();
            IWriter consoleWriter = new ConsoleWriter();

            IEngine engine = new Engine(consoleReader, consoleWriter);

            engine.Run();
        }
    }
}
