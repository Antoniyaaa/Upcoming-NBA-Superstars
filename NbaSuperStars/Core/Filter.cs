using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NbaSuperStars.Entities;

namespace NbaSuperStars.Core
{
    public static class Filter
    {
        public static List<NbaPlayer> FilterByYearsAndRating(List<NbaPlayer> players, int maxYearsPlayed, int minRating)
        {
            return players
                .Where(x => x.Rating >= minRating &&
                      ((DateTime.Now.Year - x.PlayingSince) <= maxYearsPlayed))
                .OrderByDescending(p => p.Rating)
                .ToList();
        }

        public static string FilteredListToString(List<NbaPlayer> players)
        {
            var sb = new StringBuilder();

            foreach (var player in players)
            {
                string name = player.Name;
                int rating = player.Rating;
                var newLine = string.Format("{0}, {1}", name, rating);
                sb.AppendLine(newLine);
            }

            return sb.ToString();
        }

    }
}
