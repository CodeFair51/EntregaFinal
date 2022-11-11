using AccessData;
using Entities;
using System;
using System.Data;

namespace Logic
{
    public class UserLogic
    {
        private DataBase objDataBase = null;

        public void Index(ref User objUser)
        {
            objDataBase = new DataBase()
            {
                TableName = "Users",
                NameSP = "SP_Users_Index",
                Scalar = false
            };
            objDataBase.DtParameters.Rows.Add(@"_tipo", "6", objUser.Type);

            Execute(ref objUser);
        }

        public void Create(ref User objUser)
        {
            objDataBase = new DataBase()
            {
                TableName = "Users",
                Scalar = true
            };
            objDataBase.DtParameters.Rows.Add(@"_nomUsuario", "6", objUser.UserName);
            objDataBase.DtParameters.Rows.Add(@"_email", "6", objUser.Email);
            objDataBase.DtParameters.Rows.Add(@"_contra", "6", objUser.Pass);
            objDataBase.DtParameters.Rows.Add(@"_nombre", "6", objUser.Name);
            objDataBase.DtParameters.Rows.Add(@"_apellido", "6", objUser.LastName);
            objDataBase.DtParameters.Rows.Add(@"_pais", "6", objUser.Country);
            objDataBase.DtParameters.Rows.Add(@"_pago", "1", objUser.Payment);
            objDataBase.DtParameters.Rows.Add(@"_tipo", "6", objUser.Type);

            Execute(ref objUser);
        }

        public void Read(ref User objUser)
        {
            objDataBase = new DataBase()
            {
                TableName = "Users",
                NameSP = "SP_Users_Read",
                Scalar = false
            };
            objDataBase.DtParameters.Rows.Add(@"_nomUsuario", "6", objUser.UserName);

            Execute(ref objUser);
        }

        public void Update(ref User objUser)
        {
            objDataBase = new DataBase()
            {
                TableName = "Users",
                Scalar = true
            };
            objDataBase.DtParameters.Rows.Add(@"_nomUsuario", "6", objUser.UserName);
            objDataBase.DtParameters.Rows.Add(@"_nuevoNomUsuario", "6", objUser.NewUserName);
            objDataBase.DtParameters.Rows.Add(@"_email", "6", objUser.Email);
            objDataBase.DtParameters.Rows.Add(@"_contra", "6", objUser.Pass);
            objDataBase.DtParameters.Rows.Add(@"_nombre", "6", objUser.Name);
            objDataBase.DtParameters.Rows.Add(@"_apellido", "6", objUser.LastName);
            objDataBase.DtParameters.Rows.Add(@"_pais", "6", objUser.Country);
            objDataBase.DtParameters.Rows.Add(@"_pago", "1", objUser.Payment);
            objDataBase.DtParameters.Rows.Add(@"_tipo", "9", objUser.Type);

            Execute(ref objUser);
        }

        public void Delete(ref User objUser)
        {
            objDataBase = new DataBase()
            {
                TableName = "Users",
                Scalar = true
            };
            objDataBase.DtParameters.Rows.Add(@"_nomUsuario", "6", objUser.UserName);

            Execute(ref objUser);
        }

        public void Execute(ref User objUser)
        {
            objDataBase.CRUD(ref objDataBase);

            if (objDataBase.ErrorMessageDB == null)
            {
                if (objDataBase.Scalar)
                {
                    objUser.ScalarValue = objDataBase.ScalarValue;
                }
                else
                {
                    objUser.DtResults = objDataBase.DsResults.Tables[0];

                    if (objUser.DtResults.Rows.Count == 1)
                    {
                        DataRow dr = objUser.DtResults.Rows[0];

                        objUser.Email = dr["email"].ToString();
                        objUser.Pass = dr["contra"].ToString();
                        objUser.Name = dr["nombre"].ToString();
                        objUser.LastName = dr["apellido"].ToString();
                        objUser.Country = dr["pais"].ToString();
                        objUser.Payment = Convert.ToByte(dr["pago"].ToString());
                        objUser.Type = dr["tipo"].ToString();
                    }
                }
            }
            else
            {
                objUser.ErrorMessage = objDataBase.ErrorMessageDB;
            }
        }
    }
}
