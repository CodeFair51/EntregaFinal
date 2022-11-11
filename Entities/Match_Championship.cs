using System.Data;

namespace Entities
{
    public class Match_Championship
    {
        private int _idMatch;
        private string _championshipName;
        private byte _dateNumber;

        //Atributos de manejo a la base de datos
        private string _errorMessage, _scalarValue;
        private DataTable _dtResults;

        public int IdMatch { get => _idMatch; set => _idMatch = value; }
        public string ChampionshipName { get => _championshipName; set => _championshipName = value; }
        public byte DateNumber { get => _dateNumber; set => _dateNumber = value; }
        public string ErrorMessage { get => _errorMessage; set => _errorMessage = value; }
        public string ScalarValue { get => _scalarValue; set => _scalarValue = value; }
        public DataTable DtResults { get => _dtResults; set => _dtResults = value; }
    }
}
