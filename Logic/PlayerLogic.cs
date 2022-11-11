using System;
using Entities;
using AccessData;
using System.Data;

namespace Logic
{
    public class PlayerLogic
    {
        protected DataBase objDataBase = null;

        public void Index(ref Player objPlayer, string modality)
        {
            objDataBase = new DataBase()
            {
                NameSP = "SP_Players_Index",
                TableName = "Players",
                Scalar = false
            };

            objDataBase.DtParameters.Rows.Add(@"_modalidad", "6", modality);

            Execute(ref objPlayer);
        }

        public void Create(ref Player objPlayer)
        {
            objDataBase = new DataBase()
            {
                NameSP = "SP_Players_Create",
                Scalar = true
            };

            objDataBase.DtParameters.Rows.Add(@"_nombre", "6", objPlayer.Name);
            objDataBase.DtParameters.Rows.Add(@"_apellido", "6", objPlayer.LastName);
            objDataBase.DtParameters.Rows.Add(@"_nacionalidad", "6", objPlayer.Nationality);

            Execute(ref objPlayer);
        }

        public void Read(ref Player objPlayer, string modality)
        {
            objDataBase = new DataBase()
            {
                NameSP = "SP_Players_Read",
                TableName = "Players",
                Scalar = false
            };

            objDataBase.DtParameters.Rows.Add(@"_idJugador", "3", objPlayer.PlayerID);
            objDataBase.DtParameters.Rows.Add(@"_modalidad", "6", modality);
        }

        public void Update(ref Player objPlayer)
        {
            objDataBase = new DataBase()
            {
                NameSP = "SP_Players_Update",
                Scalar = true
            };

            objDataBase.DtParameters.Rows.Add(@"_idJugador", "3", objPlayer.PlayerID);
            objDataBase.DtParameters.Rows.Add(@"_nombre", "6", objPlayer.Name);
            objDataBase.DtParameters.Rows.Add(@"_apellido", "6", objPlayer.LastName);
            objDataBase.DtParameters.Rows.Add(@"_nacionalidad", "6", objPlayer.Nationality);

            Execute(ref objPlayer);
        }

        public void Delete(ref Player objPlayer, string modality)
        {
            objDataBase = new DataBase()
            {
                NameSP = "SP_Players_Delete",
                Scalar = true
            };

            objDataBase.DtParameters.Rows.Add(@"_idJugador", "3", objPlayer.PlayerID);
            objDataBase.DtParameters.Rows.Add(@"_modalidad", "6", modality);

            Execute(ref objPlayer);
        }

        protected void Execute(ref Player objPlayer)
        {
            objDataBase.CRUD(ref objDataBase);

            if (objDataBase.ErrorMessageDB == null)
            {
                if (objDataBase.Scalar)
                {
                    objPlayer.ScalarValue = objDataBase.ScalarValue;
                }
                else
                {
                    objPlayer.DtResults = objDataBase.DsResults.Tables[0];

                    if (objDataBase.NameSP == "SP_Players_Read")
                    {
                        DataRow dr = objPlayer.DtResults.Rows[0];

                        objPlayer.Name = dr["nombre"].ToString();
                        objPlayer.LastName = dr["apellido"].ToString();
                        objPlayer.Nationality = dr["nacionalidad"].ToString();
                    }
                }
            }
            else
            {
                objPlayer.ErrorMessage = objDataBase.ErrorMessageDB;
            }
        }
    }
}
