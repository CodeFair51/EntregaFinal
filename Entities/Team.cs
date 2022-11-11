using System.Data;

namespace Entities
{
    public class Team
    {
        private string _teamName, _newTeamName, _country;

        //Atributos de manejo a la base de datos
        private string _errorMessage, _scalarValue;
        private DataTable _dtResults;

        public string TeamName { get => _teamName; set => _teamName = value; }
        public string NewTeamName { get => _newTeamName; set => _newTeamName = value; }
        public string Country { get => _country; set => _country = value; }
        public string ErrorMessage { get => _errorMessage; set => _errorMessage = value; }
        public string ScalarValue { get => _scalarValue; set => _scalarValue = value; }
        public DataTable DtResults { get => _dtResults; set => _dtResults = value; }
    }
}
