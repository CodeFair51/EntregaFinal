using System.Data;

namespace Entities
{
    public class User
    {
        private string _userName, _newUserName, _email, _pass, _name, _lastName, _country, _type;
        private byte _payment;

        //Atributos para manejar la base de datos
        private string _errorMessage, _scalarValue;
        private DataTable _dtResults;

        public string UserName { get => _userName; set => _userName = value; }
        public string Email { get => _email; set => _email = value; }
        public string Pass { get => _pass; set => _pass = value; }
        public string Name { get => _name; set => _name = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string Country { get => _country; set => _country = value; }
        public byte Payment { get => _payment; set => _payment = value; }
        public string ErrorMessage { get => _errorMessage; set => _errorMessage = value; }
        public string ScalarValue { get => _scalarValue; set => _scalarValue = value; }
        public DataTable DtResults { get => _dtResults; set => _dtResults = value; }
        public string Type { get => _type; set => _type = value; }
        public string NewUserName { get => _newUserName; set => _newUserName = value; }
    }
}
