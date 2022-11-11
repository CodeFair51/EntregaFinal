using System;
using System.Data;
using AccessData;
using Entities;

namespace Logic
{
    public class MatchLogic
    {
        protected DataBase objDataBase = null;

        public void Index(ref Match objMatch, string modality)
        {
            objDataBase = new DataBase()
            {
                NameSP = "SP_Matchs_Index",
                TableName = "Match",
                Scalar = false
            };

            objDataBase.DtParameters.Rows.Add(@"_modalidad", "6", modality);

            Execute(ref objMatch);
        }

        public void Create(ref Match objMatch)
        {
            objDataBase = new DataBase()
            {
                NameSP = "SP_Matchs_Create",
                Scalar = true
            };

            objDataBase.DtParameters.Rows.Add(@"_estadio", "6", objMatch.Stadium);
            objDataBase.DtParameters.Rows.Add(@"_fecha", "10", objMatch.Date);
            objDataBase.DtParameters.Rows.Add(@"_hora", "6", objMatch.Time);
            objDataBase.DtParameters.Rows.Add(@"_nomDeporte", "6", objMatch.DeportName);

            Execute(ref objMatch);
        }

        public void Read(ref Match objMatch)
        {
            objDataBase = new DataBase()
            {
                NameSP = "SP_Matchs_Read",
                TableName = "Match",
                Scalar = false
            };

            objDataBase.DtParameters.Rows.Add(@"_idPartido", "3", objMatch.IdMatch);
        }

        public void Update(ref Match objMatch)
        {
            objDataBase = new DataBase()
            {
                NameSP = "SP_Matchs_Update",
                Scalar = true
            };

            objDataBase.DtParameters.Rows.Add(@"_idPartido", "3", objMatch.IdMatch);
            objDataBase.DtParameters.Rows.Add(@"_estadio", "6", objMatch.Stadium);
            objDataBase.DtParameters.Rows.Add(@"_fecha", "10", objMatch.Date);
            objDataBase.DtParameters.Rows.Add(@"_hora", "6", objMatch.Time);

            Execute(ref objMatch);
        }

        public void Delete(ref Match objMatch)
        {
            objDataBase = new DataBase()
            {
                NameSP = "SP_Matchs_Delete",
                Scalar = true
            };

            objDataBase.DtParameters.Rows.Add(@"_idPartido", "3", objMatch.IdMatch);

            Execute(ref objMatch);
        }

        public void UpdateHomeScore(ref Match objMatch)
        {
            objDataBase = new DataBase()
            {
                NameSP = "SP_Matchs_UpdateHomeScore",
                Scalar = true
            };

            objDataBase.DtParameters.Rows.Add(@"_idPartido", "3", objMatch.IdMatch);
            objDataBase.DtParameters.Rows.Add(@"_anotacion", "3", objMatch.HomeScore);

            Execute(ref objMatch);
        }

        public void UpdateVisitingScore(ref Match objMatch)
        {
            objDataBase = new DataBase()
            {
                NameSP = "SP_Matchs_UpdateVisitingScore",
                Scalar = true
            };

            objDataBase.DtParameters.Rows.Add(@"_idPartido", "3", objMatch.IdMatch);
            objDataBase.DtParameters.Rows.Add(@"_anotacion", "3", objMatch.VisitingScore);

            Execute(ref objMatch);
        }

        protected void Execute(ref Match objMatch)
        {
            objDataBase.CRUD(ref objDataBase);

            if (objDataBase.ErrorMessageDB == null)
            {
                if (objDataBase.Scalar)
                {
                    objMatch.ScalarValue = objDataBase.ScalarValue;
                }
                else
                {
                    objMatch.DtResults = objDataBase.DsResults.Tables[0];

                    if (objDataBase.NameSP == "SP_Matchs_Read")
                    {
                        DataRow dr = objMatch.DtResults.Rows[0];

                        objMatch.Stadium = dr["estadio"].ToString();
                        objMatch.Date = dr["fecha"].ToString();
                        objMatch.Time = dr["hora"].ToString();
                        objMatch.DeportName = dr["nomDeporte"].ToString();
                    }
                }
            }
            else
            {
                objMatch.ErrorMessage = objDataBase.ErrorMessageDB;
            }
        }
    }
}
