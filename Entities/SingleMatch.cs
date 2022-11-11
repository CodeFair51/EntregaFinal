namespace Entities
{
    public class SingleMatch : Match
    {
        private int _idHomePlayer, _idVisitingPlayer;

        public int IdHomePlayer { get => _idHomePlayer; set => _idHomePlayer = value; }
        public int IdVisitingPlayer { get => _idVisitingPlayer; set => _idVisitingPlayer = value; }
    }
}
