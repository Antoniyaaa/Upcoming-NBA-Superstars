namespace NbaSuperStars.Entities.Contracts
{
    public interface IPlayer
    {
        string Name { get; }

        int PlayingSince { get; }

        string Position { get; }

        int Rating { get; }
    }
}
