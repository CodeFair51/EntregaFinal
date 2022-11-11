using Entities;
using System.Data;

namespace Logic
{
    public class TeamMatchLogic : MatchLogic
    {
        public void Create(ref TeamMatch objTeamMatch)
        {
            Match objMatch = objTeamMatch;

            base.Create(ref objMatch);

            if (objMatch.ErrorMessage == null)
            {
                objDataBase.NameSP = "SP_TeamMatchs_Create";

                objDataBase.DtParameters.Rows.Add(@"_idPartido", "3", objMatch.ScalarValue);
                objDataBase.DtParameters.Rows.Add(@"_nomEquipoLocal", "6", objTeamMatch.HomeName);
                objDataBase.DtParameters.Rows.Add(@"_nomEquipoVisitante", "6", objTeamMatch.VisitingName);

                Execute(ref objTeamMatch);
            }
            else
            {
                objTeamMatch.ErrorMessage = objMatch.ErrorMessage;
            }
        }

        public void Read(ref TeamMatch objTeamMatch)
        {
            Match objMatch = objTeamMatch;

            base.Read(ref objMatch);

            Execute(ref objTeamMatch);
        }

        public void Update(ref TeamMatch objTeamMatch)
        {
            Match objMatch = objTeamMatch;

            base.Update(ref objMatch);

            if (objMatch.ErrorMessage == null)
            {
                objDataBase.NameSP = "SP_TeamMatchs_Update";

                objDataBase.DtParameters.Rows.Add(@"_nomEquipoLocal", "6", objTeamMatch.HomeName);
                objDataBase.DtParameters.Rows.Add(@"_nomEquipoVisitante", "6", objTeamMatch.VisitingName);

                Execute(ref objTeamMatch);
            }
            else
            {
                objTeamMatch.ErrorMessage = objMatch.ErrorMessage;
            }
        }

        private void Execute(ref TeamMatch objTeamMatch)
        {
            Match objMatch = new Match();

            base.Execute(ref objMatch);

            if (objMatch.ErrorMessage == null)
            {
                if (objDataBase.Scalar)
                {
                    objTeamMatch.ScalarValue = objMatch.ScalarValue;
                }
                else
                {
                    objTeamMatch.DtResults = objMatch.DtResults;

                    if (objDataBase.NameSP == "SP_Matchs_Read")
                    {
                        objTeamMatch.Stadium = objMatch.Stadium;
                        objTeamMatch.Date = objMatch.Date;
                        objTeamMatch.Time = objMatch.Time;
                        objTeamMatch.DeportName = objMatch.DeportName;

                        DataRow dr = objTeamMatch.DtResults.Rows[0];

                        objTeamMatch.HomeName = dr["nomEquipoLocal"].ToString();
                        objTeamMatch.VisitingName = dr["nomEquipoVisitante"].ToString();
                    }
                }
            }
            else
            {
                objTeamMatch.ErrorMessage = objMatch.ErrorMessage;
            }
        }
    }
}
