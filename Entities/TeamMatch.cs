namespace Entities
{
    public class TeamMatch : Match
    {
        private string _homeName, _visitingName, _homeAlignment, _visitingAlignment;

        public string HomeName { get => _homeName; set => _homeName = value; }
        public string VisitingName { get => _visitingName; set => _visitingName = value; }
        public string HomeAlignment { get => _homeAlignment; set => _homeAlignment = value; }
        public string VisitingAlignment { get => _visitingAlignment; set => _visitingAlignment = value; }
    }
}
