using AccessData;
using Entities;
using System;
using System.Data;

namespace Logic
{
    public class ChampionshipLogic
    {
        private DataBase objDataBase = null;

        public void Index(ref Championship objChamp)
        {
            objDataBase = new DataBase()
            {
                NameSP = "SP_Championship_Index",
                TableName = "Championship",
                Scalar = false
            };

            objDataBase.DtParameters.Rows.Add(@"_modalidad", "6", objChamp.Modality);

            Execute(ref objChamp);
        }

        public void Create(ref Championship objChamp)
        {
            objDataBase = new DataBase()
            {
                NameSP = "SP_Championship_Create",
                Scalar = true
            };

            objDataBase.DtParameters.Rows.Add(@"_nomCampeonato", "6", objChamp.ChampionshipName);
            objDataBase.DtParameters.Rows.Add(@"_region", "6", objChamp.Region);
            objDataBase.DtParameters.Rows.Add(@"_cantFechas", "2", objChamp.QuantityDates);
            objDataBase.DtParameters.Rows.Add(@"_modalidad", "6", objChamp.Modality);
            objDataBase.DtParameters.Rows.Add(@"_nomDeporte", "6", objChamp.DeportName);
            objDataBase.DtParameters.Rows.Add(@"_idaYvueltaGrupos", "1", objChamp.FirstAndSecondGroupLeg);

            Execute(ref objChamp);
        }

        public void Read(ref Championship objChamp)
        {
            objDataBase = new DataBase()
            {
                NameSP = "SP_Championship_Read",
                TableName = "Championship",
                Scalar = false
            };

            objDataBase.DtParameters.Rows.Add(@"_nomCampeonato", "6", objChamp.ChampionshipName);

            Execute(ref objChamp);
        }

        public void Update(ref Championship objChamp)
        {
            objDataBase = new DataBase()
            {
                NameSP = "SP_Championship_Update",
                Scalar = true
            };

            objDataBase.DtParameters.Rows.Add(@"_nomCampeonato", "6", objChamp.ChampionshipName);
            objDataBase.DtParameters.Rows.Add(@"_nuevoNomCampeonato", "6", objChamp.NewChampionshipName);
            objDataBase.DtParameters.Rows.Add(@"_region", "6", objChamp.Region);
            objDataBase.DtParameters.Rows.Add(@"_cantFechas", "2", objChamp.QuantityDates);
            objDataBase.DtParameters.Rows.Add(@"_modalidad", "6", objChamp.Modality);
            objDataBase.DtParameters.Rows.Add(@"_nomDeporte", "6", objChamp.DeportName);
            objDataBase.DtParameters.Rows.Add(@"_idaYvueltaGrupos", "1", objChamp.FirstAndSecondGroupLeg);

            Execute(ref objChamp);
        }

        public void Delete(ref Championship objChamp)
        {
            objDataBase = new DataBase()
            {
                NameSP = "SP_Championship_Delete",
                Scalar = true
            };

            objDataBase.DtParameters.Rows.Add(@"_nomCampeonato", "6", objChamp.ChampionshipName);

            Execute(ref objChamp);
        }

        public void IndexName(ref Championship objChamp)
        {
            objDataBase = new DataBase()
            {
                NameSP = "SP_Championship_IndexName",
                TableName = "Championship",
                Scalar = false
            };

            objDataBase.DtParameters.Rows.Add(@"_nomDeporte", "6", objChamp.DeportName);

            Execute(ref objChamp);
        }

        public void IndexNameNow(ref Championship objChamp)
        {
            objDataBase = new DataBase()
            {
                NameSP = "SP_Championship_IndexName_Now",
                TableName = "Championship",
                Scalar = false
            };

            objDataBase.DtParameters.Rows.Add(@"_nomDeporte", "6", objChamp.DeportName);

            Execute(ref objChamp);
        }

        private void Execute(ref Championship objChamp)
        {
            objDataBase.CRUD(ref objDataBase);

            if (objDataBase.ErrorMessageDB == null)
            {
                if (objDataBase.Scalar)
                {
                    objChamp.ScalarValue = objDataBase.ScalarValue;
                }
                else
                {
                    objChamp.DtResults = objDataBase.DsResults.Tables[0];

                    if (objDataBase.NameSP == "SP_Championship_Read")
                    {
                        DataRow dr = objChamp.DtResults.Rows[0];

                        objChamp.Region = dr["region"].ToString();
                        objChamp.QuantityDates = Convert.ToByte(dr["cantFechas"].ToString());
                        objChamp.Modality = dr["modalidad"].ToString();
                        objChamp.DeportName = dr["nomDeporte"].ToString();

                        if (objChamp.Modality == "gruposEliminatorias")
                        {
                            objChamp.FirstAndSecondGroupLeg = Convert.ToByte(dr["idaYvueltaGrupos"].ToString());
                        }
                    }
                }
            }
            else
            {
                objChamp.ErrorMessage = objDataBase.ErrorMessageDB;
            }
        }
    }
}
