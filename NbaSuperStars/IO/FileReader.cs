using System.IO;

using NbaSuperStars.IO.Contracts;

namespace NbaSuperStars.IO
{
    public class FileReader : IReader
    {
        private readonly StreamReader streamReader;

        public FileReader(string filePath)
        {
            this.streamReader = new StreamReader(filePath);
        }

        public string Read()
        {
            return this.streamReader.ReadToEnd();
        }
    }
}
