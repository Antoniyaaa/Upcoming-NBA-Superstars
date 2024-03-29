﻿using System.IO;

using NbaSuperStars.IO.Contracts;

namespace NbaSuperStars.IO
{
    public class FileWriter : IWriter
    {
        private readonly StreamWriter streamWriter;

        public FileWriter(string filePath)
        {
            this.streamWriter = new StreamWriter(filePath);
        }

        public void Write(string content)
        {
            using (this.streamWriter)
            {
                this.streamWriter.Write(content);
            }
        }
    }
}
