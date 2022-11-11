using System.Data;

namespace Entities
{
    public class Player
    {
        private int _playerID;
        private string _name, _lastName, _nationality;

        //Atributos de manejo a la base de datos
        private string _errorMessage, _scalarValue;
        private DataTable _dtResults;

        public int PlayerID { get => _playerID; set => _playerID = value; }
        public string Name { get => _name; set => _name = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string Nationality { get => _nationality; set => _nationality = value; }
        public string ErrorMessage { get => _errorMessage; set => _errorMessage = value; }
        public string ScalarValue { get => _scalarValue; set => _scalarValue = value; }
        public DataTable DtResults { get => _dtResults; set => _dtResults = value; }
    }
}
