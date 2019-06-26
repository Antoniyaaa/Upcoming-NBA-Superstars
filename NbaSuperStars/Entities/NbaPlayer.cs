using NbaSuperStars.Entities.Contracts;

namespace NbaSuperStars.Entities
{
    public class NbaPlayer : IPlayer
    {
        public string Name { get; set; }

        public int PlayingSince { get; set; }

        public string Position { get; set; }

        public int Rating { get; set; }
    }
}
