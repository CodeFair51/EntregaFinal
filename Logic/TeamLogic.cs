using System;
using System.Data;
using AccessData;
using Entities;

namespace Logic
{
    public class TeamLogic
    {
        private DataBase objDataBase = null;

        public void Index(ref Team objTeam)
        {
            objDataBase = new DataBase()
            {
                NameSP = "SP_Teams_Index",
                TableName = "Team",
                Scalar = false
            };

            Execute(ref objTeam);
        }

        public void Create(ref Team objTeam)
        {
            objDataBase = new DataBase()
            {
                NameSP = "SP_Teams_Create",
                Scalar = true
            };

            objDataBase.DtParameters.Rows.Add(@"_nomEquipo", "6", objTeam.TeamName);
            objDataBase.DtParameters.Rows.Add(@"_pais", "6", objTeam.Country);

            Execute(ref objTeam);
        }

        public void Read(ref Team objTeam)
        {
            objDataBase = new DataBase()
            {
                NameSP = "SP_Teams_Read",
                TableName = "Team",
                Scalar = false
            };

            objDataBase.DtParameters.Rows.Add(@"_nomEquipo", "6", objTeam.TeamName);

            Execute(ref objTeam);
        }

        public void Update(ref Team objTeam)
        {
            objDataBase = new DataBase()
            {
                NameSP = "SP_Teams_Update",
                Scalar = true
            };

            objDataBase.DtParameters.Rows.Add(@"_nomEquipo", "6", objTeam.TeamName);
            objDataBase.DtParameters.Rows.Add(@"_nuevoNomEquipo", "6", objTeam.NewTeamName);
            objDataBase.DtParameters.Rows.Add(@"_pais", "6", objTeam.Country);

            Execute(ref objTeam);
        }
        public void Delete(ref Team objTeam)
        {
            objDataBase = new DataBase()
            {
                NameSP = "SP_Teams_Delete",
                Scalar = true
            };

            objDataBase.DtParameters.Rows.Add(@"_nomEquipo", "6", objTeam.TeamName);

            Execute(ref objTeam);
        }

        private void Execute(ref Team objTeam)
        {
            objDataBase.CRUD(ref objDataBase);

            if (objDataBase.ErrorMessageDB == null)
            {
                if (objDataBase.Scalar)
                {
                    objTeam.ScalarValue = objDataBase.ScalarValue;
                }
                else
                {
                    objTeam.DtResults = objDataBase.DsResults.Tables[0];

                    if (objDataBase.NameSP == "SP_Teams_Read")
                    {
                        DataRow dr = objTeam.DtResults.Rows[0];

                        objTeam.Country = dr["pais"].ToString();
                    }
                }
            }
            else
            {
                objTeam.ErrorMessage = objDataBase.ErrorMessageDB;
            }
        }
    }
}
