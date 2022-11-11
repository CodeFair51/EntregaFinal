using Entities;
using AccessData;
using System.Data;
using System;

namespace Logic
{
    public class Match_ChampionshipLogic
    {
        private DataBase objDataBase = null;

        public void Index(ref Match_Championship objMatch_Champ)
        {
            objDataBase = new DataBase()
            {
                NameSP = "SP_Matchs_Championship_Index",
                TableName = "Match_Championship",
                Scalar = false
            };

            Execute(ref objMatch_Champ);
        }

        public void Create(ref Match_Championship objMatch_Champ)
        {
            objDataBase = new DataBase()
            {
                NameSP = "SP_Matchs_Championship_Create",
                Scalar = true
            };

            objDataBase.DtParameters.Rows.Add(@"_idPartido", "3", objMatch_Champ.IdMatch);
            objDataBase.DtParameters.Rows.Add(@"_nomCampeonato", "6", objMatch_Champ.ChampionshipName);
            objDataBase.DtParameters.Rows.Add(@"_nroFecha", "2", objMatch_Champ.DateNumber);

            Execute(ref objMatch_Champ);
        }

        public void Read(ref Match_Championship objMatch_Champ)
        {
            objDataBase = new DataBase()
            {
                NameSP = "SP_Matchs_Championship_Read",
                TableName = "Match_Championship",
                Scalar = false
            };

            objDataBase.DtParameters.Rows.Add(@"_idPartido", "3", objMatch_Champ.IdMatch);

            Execute(ref objMatch_Champ);
        }

        public void Update(ref Match_Championship objMatch_Champ)
        {
            objDataBase = new DataBase()
            {
                NameSP = "SP_Matchs_Championship_Update",
                Scalar = true
            };

            objDataBase.DtParameters.Rows.Add(@"_idPartido", "3", objMatch_Champ.IdMatch);
            objDataBase.DtParameters.Rows.Add(@"_nomCampeonato", "6", objMatch_Champ.ChampionshipName);
            objDataBase.DtParameters.Rows.Add(@"_nroFecha", "2", objMatch_Champ.DateNumber);

            Execute(ref objMatch_Champ);
        }

        public void Delete(ref Match_Championship objMatch_Champ)
        {
            objDataBase = new DataBase()
            {
                NameSP = "SP_Matchs_Championship_Delete",
                Scalar = true
            };

            objDataBase.DtParameters.Rows.Add(@"_idPartido", "3", objMatch_Champ.IdMatch);

            Execute(ref objMatch_Champ);
        }

        public void IndexNow(ref Match_Championship objMatch_Champ)
        {
            objDataBase = new DataBase()
            {
                NameSP = "SP_Matchs_Championship_Index_Now",
                TableName = "Match_Championship",
                Scalar = false
            };

            objDataBase.DtParameters.Rows.Add(@"_nomCampeonato", "6", objMatch_Champ.ChampionshipName);

            Execute(ref objMatch_Champ);
        }

        public void IndexNroFecha(ref Match_Championship objMatch_Champ)
        {
            objDataBase = new DataBase()
            {
                NameSP = "SP_Matchs_Championship_Index_NroFecha",
                TableName = "Match_Championship",
                Scalar = false
            };

            objDataBase.DtParameters.Rows.Add(@"_nroFecha", "2", objMatch_Champ.DateNumber);
            objDataBase.DtParameters.Rows.Add(@"_nomCampeonato", "6", objMatch_Champ.ChampionshipName);

            Execute(ref objMatch_Champ);
        }

        private void Execute(ref Match_Championship objMatch_Champ)
        {
            objDataBase.CRUD(ref objDataBase);

            if (objDataBase.ErrorMessageDB == null)
            {
                if (objDataBase.Scalar)
                {
                    objMatch_Champ.ScalarValue = objDataBase.ScalarValue;
                }
                else
                {
                    objMatch_Champ.DtResults = objDataBase.DsResults.Tables[0];

                    if (objDataBase.NameSP == "SP_Matchs_Championship_Read")
                    {
                        DataRow dr = objMatch_Champ.DtResults.Rows[0];

                        objMatch_Champ.ChampionshipName = dr["nomCampeonato"].ToString();
                        objMatch_Champ.DateNumber = Convert.ToByte(dr["nroFecha"].ToString());
                    }
                }
            }
            else
            {
                objMatch_Champ.ErrorMessage = objDataBase.ErrorMessageDB;
            }
        }
    }
}
