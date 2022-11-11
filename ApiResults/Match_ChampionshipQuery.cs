using System;
using Logic;
using Entities;
using System.Data;

namespace ApiResults
{
    public class Match_ChampionshipQuery
    {
        private Match_Championship objMatch_Champ = null;
        private readonly Match_ChampionshipLogic objMatch_ChampLogic = new Match_ChampionshipLogic();

        private string _errorMessage, _errorMessageDB;
        private DataTable _dtResults;

        public string ErrorMessage { get => _errorMessage; set => _errorMessage = value; }
        public string ErrorMessageDB { get => _errorMessageDB; set => _errorMessageDB = value; }
        public DataTable DtResults { get => _dtResults; set => _dtResults = value; }

        public void IndexNroFecha(byte dateNumber, string championshipName)
        {
            try
            {
                objMatch_Champ = new Match_Championship()
                {
                    DateNumber = dateNumber,
                    ChampionshipName = championshipName
                };

                objMatch_ChampLogic.IndexNroFecha(ref objMatch_Champ);

                if (objMatch_Champ.ErrorMessage == null)
                {
                    DtResults = objMatch_Champ.DtResults;
                }
                else
                {
                    ErrorMessageDB = objMatch_Champ.ErrorMessage;
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }

        public void IndexNow(string championshipName)
        {
            try
            {
                objMatch_Champ = new Match_Championship()
                {
                    ChampionshipName = championshipName
                };

                objMatch_ChampLogic.IndexNow(ref objMatch_Champ);

                if (objMatch_Champ.ErrorMessage == null)
                {
                    DtResults = objMatch_Champ.DtResults;
                }
                else
                {
                    ErrorMessageDB = objMatch_Champ.ErrorMessage;
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }
    }
}
