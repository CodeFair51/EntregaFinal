using System;
using System.Data;
using Entities;
using AccessData;

namespace Logic
{
    public class SinglePlayerLogic : PlayerLogic
    {
        public void Create(ref SinglePlayer objSinglePlayer)
        {
            Player objPlayer = objSinglePlayer;

            base.Create(ref objPlayer);

            if (objPlayer.ErrorMessage == null)
            {
                objDataBase = new DataBase()
                {
                    NameSP = "SP_SinglePlayers_Create",
                    Scalar = true
                };

                objDataBase.DtParameters.Rows.Add(@"_idJugador", "3", objSinglePlayer.ScalarValue);
                objDataBase.DtParameters.Rows.Add(@"_ranking", "3", objSinglePlayer.Ranking);

                Execute(ref objSinglePlayer);
            }
            else
            {
                objSinglePlayer.ErrorMessage = objPlayer.ErrorMessage;
            }
        }

        public void Read(ref SinglePlayer objSinglePlayer, string modality)
        {
            Player objPlayer = objSinglePlayer;

            base.Read(ref objPlayer, modality);

            Execute(ref objSinglePlayer);
        }

        public void Update(ref SinglePlayer objSinglePlayer)
        {
            Player objPlayer = objSinglePlayer;

            base.Update(ref objPlayer);

            if (objPlayer.ErrorMessage == null)
            {
                objDataBase = new DataBase()
                {
                    NameSP = "SP_SinglePlayers_Update",
                    Scalar = true
                };

                objDataBase.DtParameters.Rows.Add(@"_idJugador", "3", objSinglePlayer.PlayerID);
                objDataBase.DtParameters.Rows.Add(@"_ranking", "3", objSinglePlayer.Ranking);

                Execute(ref objSinglePlayer);
            }
            else
            {
                objSinglePlayer.ErrorMessage = objPlayer.ErrorMessage;
            }
        }

        private void Execute(ref SinglePlayer objSinglePlayer)
        {
            Player objPlayer = new Player();

            base.Execute(ref objPlayer);

            if (objPlayer.ErrorMessage == null)
            {
                if (objDataBase.Scalar)
                {
                    objSinglePlayer.ScalarValue = objPlayer.ScalarValue;
                }
                else
                {
                    objSinglePlayer.DtResults = objPlayer.DtResults;

                    if (objDataBase.NameSP == "SP_Players_Read")
                    {
                        DataRow dr = objSinglePlayer.DtResults.Rows[0];

                        objSinglePlayer.Name = objPlayer.Name;
                        objSinglePlayer.LastName = objPlayer.LastName;
                        objSinglePlayer.Nationality = objPlayer.Nationality;

                        objSinglePlayer.Ranking = Convert.ToInt32(dr["ranking"].ToString());
                    }
                }
            }
            else
            {
                objSinglePlayer.ErrorMessage = objPlayer.ErrorMessage;
            }
        }
    }
}
