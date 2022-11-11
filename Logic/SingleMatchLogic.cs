using Entities;
using System;
using System.Data;
using AccessData;

namespace Logic
{
    public class SingleMatchLogic : MatchLogic
    {
        public void Create(ref SingleMatch objSingleMatch)
        {
            Match objMatch = objSingleMatch;

            base.Create(ref objMatch);

            if (objMatch.ErrorMessage == null)
            {
                objDataBase = new DataBase()
                {
                    NameSP = "SP_SingleMatchs_Create",
                    Scalar = true
                };

                objDataBase.DtParameters.Rows.Add(@"_idPartido", "3", objMatch.ScalarValue);
                objDataBase.DtParameters.Rows.Add(@"_idJugadorLocal", "3", objSingleMatch.IdHomePlayer);
                objDataBase.DtParameters.Rows.Add(@"_idJugadorVisitante", "3", objSingleMatch.IdVisitingPlayer);

                Execute(ref objSingleMatch);
            }
            else
            {
                objSingleMatch.ErrorMessage = objMatch.ErrorMessage;
            }
        }

        public void Read(ref SingleMatch objSingleMatch)
        {
            Match objMatch = objSingleMatch;

            base.Read(ref objMatch);

            Execute(ref objSingleMatch);
        }

        public void Update(ref SingleMatch objSingleMatch)
        {
            Match objMatch = objSingleMatch;

            base.Update(ref objMatch);

            if (objMatch.ErrorMessage == null)
            {
                objDataBase = new DataBase()
                {
                    NameSP = "SP_SingleMatchs_Update",
                    Scalar = true
                };

                objDataBase.DtParameters.Rows.Add(@"_idJugadorLocal", "3", objSingleMatch.IdHomePlayer);
                objDataBase.DtParameters.Rows.Add(@"_idJugadorVisitante", "3", objSingleMatch.IdVisitingPlayer);

                Execute(ref objSingleMatch);
            }
            else
            {
                objSingleMatch.ErrorMessage = objMatch.ErrorMessage;
            }
        }

        private void Execute(ref SingleMatch objSingleMatch)
        {
            Match objMatch = new Match();

            base.Execute(ref objMatch);

            if (objMatch.ErrorMessage == null)
            {
                if (objDataBase.Scalar)
                {
                    objSingleMatch.ScalarValue = objMatch.ScalarValue;
                }
                else
                {
                    objSingleMatch.DtResults = objMatch.DtResults;

                    if (objDataBase.NameSP == "SP_Matchs_Read")
                    {
                        objSingleMatch.Stadium = objMatch.Stadium;
                        objSingleMatch.Date = objMatch.Date;
                        objSingleMatch.Time = objMatch.Time;
                        objSingleMatch.DeportName = objMatch.DeportName;

                        DataRow dr = objSingleMatch.DtResults.Rows[0];

                        objSingleMatch.IdHomePlayer = Convert.ToInt32(dr["idJugadorLocal"].ToString());
                        objSingleMatch.IdVisitingPlayer = Convert.ToInt32(dr["idJugadorVisitante"].ToString());
                    }
                }
            }
            else
            {
                objSingleMatch.ErrorMessage = objMatch.ErrorMessage;
            }
        }
    }
}
