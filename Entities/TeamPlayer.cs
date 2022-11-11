namespace Entities
{
    public class TeamPlayer : Player
    {
        private int _score;

        public int Score { get => _score; set => _score = value; }
    }
}
