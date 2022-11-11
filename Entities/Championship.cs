using System.Data;

namespace Entities
{
    public class Championship
    {
        private string _championshipName, _newChampionshipName, _region, _modality, _deportName;
        private byte _datesQuantity, _firstAndSecondGroupLeg;

        //Atributos para manejar la base de datos
        private string _scalarValue, _errorMessage;
        private DataTable _dtResults;

        public string ChampionshipName { get => _championshipName; set => _championshipName = value; }
        public string Region { get => _region; set => _region = value; }
        public string DeportName { get => _deportName; set => _deportName = value; }
        public byte QuantityDates { get => _datesQuantity; set => _datesQuantity = value; }
        public string ScalarValue { get => _scalarValue; set => _scalarValue = value; }
        public string ErrorMessage { get => _errorMessage; set => _errorMessage = value; }
        public DataTable DtResults { get => _dtResults; set => _dtResults = value; }
        public string NewChampionshipName { get => _newChampionshipName; set => _newChampionshipName = value; }
        public string Modality { get => _modality; set => _modality = value; }
        public byte FirstAndSecondGroupLeg { get => _firstAndSecondGroupLeg; set => _firstAndSecondGroupLeg = value; }
    }
}
