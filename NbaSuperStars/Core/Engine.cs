using System;
using System.Collections.Generic;
using System.IO;

using NbaSuperStars.Core.Contracts;
using NbaSuperStars.Entities;
using NbaSuperStars.IO;
using NbaSuperStars.IO.Contracts;
using NbaSuperStars.Utils;
using static NbaSuperStars.Core.Filter;

namespace NbaSuperStars.Core
{
    public class Engine : IEngine
    {
        private readonly IReader consoleReader;
        private readonly IWriter consoleWriter;

        public Engine(IReader reader, IWriter writer)
        {
            this.consoleReader = reader;
            this.consoleWriter = writer;
        }
        public void Run()
        {
            this.consoleWriter.Write(GlobalConstants.requiredInformation);

            string result;

            try
            {
                string jsonFilePath = consoleReader.Read();
                int maxYearsPlayed = int.Parse(consoleReader.Read());
                int minRating = int.Parse(consoleReader.Read());
                string csvFilePath = consoleReader.Read();

                IReader fileReader = new FileReader(jsonFilePath);
                string playersJsonString = fileReader.Read();

                List<NbaPlayer> players = Deserializer.JsonDeserializer(playersJsonString);
                string filteredPlayers = FilteredListToString(FilterByYearsAndRating(players, maxYearsPlayed, minRating));

                IWriter fileWriter = new FileWriter(csvFilePath);
                fileWriter.Write(filteredPlayers);

                result = $"Data sucessfully imported in {csvFilePath}";
            }
            catch (FileNotFoundException e)
            {
                result = $"Please enter valid source path. The file was not found:\r\n '{e}'";
            }
            catch (FormatException e)
            {
                result = $"Please enter valid data type:\r\n '{e}'";
            }

            this.consoleWriter.Write(result);

        }
    }
}

