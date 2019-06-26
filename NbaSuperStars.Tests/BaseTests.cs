using System.Collections.Generic;
using System.IO;

using NUnit.Framework;

using NbaSuperStars.Core;
using NbaSuperStars.Entities;


namespace Tests
{
    public class BaseTests
    {
        
        [Test]
        public void Deserialize()
        {
            string text;
            string filePath = "../../../TestFiles/Players.json";

            using (var stream = new StreamReader(filePath))
            {
                text = stream.ReadToEnd();
            }

            List<NbaPlayer> players = Deserializer.JsonDeserializer(text);

            var resultFromDeserializer = players.Count;
            var expectedResult = 2;
            Assert.AreEqual(expectedResult, resultFromDeserializer);
        }

        [Test]
        public void FilterByYearsAndRating()
        {
            List<NbaPlayer> players = new List<NbaPlayer>
            {
                new NbaPlayer{Name = "Trae Young", PlayingSince = 2018, Position = "PG", Rating = 84},
                new NbaPlayer{Name = "Stephen Curry", PlayingSince = 2009, Position = "PG", Rating = 95}
            };

            List<NbaPlayer> filteredPlayers = Filter.FilterByYearsAndRating(players, 10, 90);

            var resultFromFiltration = filteredPlayers.Count;
            var expectedResult = 1;
            Assert.AreEqual(expectedResult, resultFromFiltration);
        }

        [Test]
        public void ResultToStringMethod()
        {
            List<NbaPlayer> players = new List<NbaPlayer>
            {
                new NbaPlayer{Name = "Trae Young", PlayingSince = 2018, Position = "PG", Rating = 84},
                new NbaPlayer{Name = "Stephen Curry", PlayingSince = 2009, Position = "PG", Rating = 95}
            };

            var actualResult = Filter.FilteredListToString(players);
            var expectedResult = "Trae Young, 84\r\nStephen Curry, 95\r\n";

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}