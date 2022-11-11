using System;
using System.Data;
using Entities;
using AccessData;

namespace Logic
{
    public class TeamPlayerLogic : PlayerLogic
    {
        public void Create(ref TeamPlayer objTeamPlayer)
        {
            Player objPlayer = objTeamPlayer;

            base.Create(ref objPlayer);

            if (objPlayer.ErrorMessage == null)
            {
                objDataBase = new DataBase()
                {
                    NameSP = "SP_TeamPlayers_Create",
                    Scalar = true
                };

                objDataBase.DtParameters.Rows.Add(@"_idJugador", "3", objPlayer.ScalarValue);
                objDataBase.DtParameters.Rows.Add(@"_anotaciones", "3", objTeamPlayer.Score);

                Execute(ref objTeamPlayer);
            }
            else
            {
                objTeamPlayer.ErrorMessage = objPlayer.ErrorMessage;
            }
        }

        public void Read(ref TeamPlayer objTeamPlayer, string modality)
        {
            Player objPlayer = objTeamPlayer;

            base.Read(ref objPlayer, modality);

            Execute(ref objTeamPlayer);
        }

        public void Update(ref TeamPlayer objTeamPlayer)
        {
            Player objPlayer = objTeamPlayer;

            base.Update(ref objPlayer);

            if (objPlayer.ErrorMessage == null)
            {
                objDataBase = new DataBase()
                {
                    NameSP = "SP_TeamPlayers_Update",
                    Scalar = true
                };

                objDataBase.DtParameters.Rows.Add(@"_idJugador", "3", objTeamPlayer.PlayerID);
                objDataBase.DtParameters.Rows.Add(@"_anotaciones", "3", objTeamPlayer.Score);

                Execute(ref objTeamPlayer);
            }
            else
            {
                objTeamPlayer.ErrorMessage = objPlayer.ErrorMessage;
            }
        }

        private void Execute(ref TeamPlayer objTeamPlayer)
        {
            Player objPlayer = new Player();

            base.Execute(ref objPlayer);

            if (objPlayer.ErrorMessage == null)
            {
                if (objDataBase.Scalar)
                {
                    objTeamPlayer.ScalarValue = objPlayer.ScalarValue;
                }
                else
                {
                    objTeamPlayer.DtResults = objPlayer.DtResults;

                    if (objDataBase.NameSP == "SP_Players_Read")
                    {
                        DataRow dr = objPlayer.DtResults.Rows[0];

                        objTeamPlayer.Name = objPlayer.Name;
                        objTeamPlayer.LastName = objPlayer.LastName;
                        objTeamPlayer.Nationality = objPlayer.Nationality;

                        objTeamPlayer.Score = Convert.ToInt32(dr["anotaciones"].ToString());
                    }
                }
            }
            else
            {
                objTeamPlayer.ErrorMessage = objPlayer.ErrorMessage;
            }
        }
    }
}
