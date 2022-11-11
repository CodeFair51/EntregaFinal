using System.Data;

namespace Entities
{
    public class Match
    {
        //Atributos de partido
        private int _idMatch;
        private string _deportName, _stadium, _duration, _date, _time;
        private byte _homeScore, _visitingScore;

        //Atributos de manejo a la base de datos
        private string _errorMessage, _scalarValue;
        private DataTable _dtResults;

        public int IdMatch { get => _idMatch; set => _idMatch = value; }
        public string Stadium { get => _stadium; set => _stadium = value; }
        public string Duration { get => _duration; set => _duration = value; }
        public string Date { get => _date; set => _date = value; }
        public byte HomeScore { get => _homeScore; set => _homeScore = value; }
        public byte VisitingScore { get => _visitingScore; set => _visitingScore = value; }
        public string ErrorMessage { get => _errorMessage; set => _errorMessage = value; }
        public string ScalarValue { get => _scalarValue; set => _scalarValue = value; }
        public DataTable DtResults { get => _dtResults; set => _dtResults = value; }
        public string Time { get => _time; set => _time = value; }
        public string DeportName { get => _deportName; set => _deportName = value; }
    }
}
