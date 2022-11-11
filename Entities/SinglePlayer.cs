namespace Entities
{
    public class SinglePlayer : Player
    {
        private int _ranking;

        public int Ranking { get => _ranking; set => _ranking = value; }
    }
}
