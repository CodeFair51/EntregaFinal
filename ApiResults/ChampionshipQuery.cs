using System;
using Logic;
using Entities;
using System.Data;

namespace ApiResults
{
    public class ChampionshipQuery
    {
        private Championship objChamp = null;
        private readonly ChampionshipLogic objChampLogic = new ChampionshipLogic();

        private string _modality;
        private byte _datesQuantity, _firstAndSecondGroupLeg;

        private string _errorMessage, _errorMessageDB;
        private DataTable _dtResults;

        public string Modality { get => _modality; set => _modality = value; }
        public byte DatesQuantity { get => _datesQuantity; set => _datesQuantity = value; }
        public string ErrorMessage { get => _errorMessage; set => _errorMessage = value; }
        public string ErrorMessageDB { get => _errorMessageDB; set => _errorMessageDB = value; }
        public DataTable DtResults { get => _dtResults; set => _dtResults = value; }
        public byte FirstAndSecondGroupLeg { get => _firstAndSecondGroupLeg; set => _firstAndSecondGroupLeg = value; }

        public void IndexName(string deport)
        {
            try
            {
                objChamp = new Championship()
                {
                    DeportName = deport
                };

                objChampLogic.IndexName(ref objChamp);

                if (objChamp.ErrorMessage == null)
                {
                    DtResults = objChamp.DtResults;
                }
                else
                {
                    ErrorMessageDB = objChamp.ErrorMessage;
                }

            }catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }

        public void IndexNameNow(string deport)
        {
            try
            {
                objChamp = new Championship()
                {
                    DeportName = deport
                };

                objChampLogic.IndexNameNow(ref objChamp);

                if (objChamp.ErrorMessage == null)
                {
                    DtResults = objChamp.DtResults;
                }
                else
                {
                    ErrorMessageDB = objChamp.ErrorMessage;
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }

        public void Read(string championshipName)
        {
            try
            {
                objChamp = new Championship()
                {
                    ChampionshipName = championshipName
                };

                objChampLogic.Read(ref objChamp);

                if (objChamp.ErrorMessage == null)
                {
                    Modality = objChamp.Modality;
                    DatesQuantity = objChamp.QuantityDates;
                    FirstAndSecondGroupLeg = objChamp.FirstAndSecondGroupLeg;
                }
                else
                {
                    ErrorMessageDB = objChamp.ErrorMessage;
                }
                
            }catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }
    }
}
