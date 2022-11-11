using System;
using Logic;
using Entities;

namespace ApiAuthentication
{
    public class Login
    {
        private User objUser = null;
        private readonly UserLogic objUserLogic = new UserLogic();
        private string _errorMessageDB, _errorMessage;

        public string ErrorMessage { get => _errorMessage; set => _errorMessage = value; }
        public string ErrorMessageDB { get => _errorMessageDB; set => _errorMessageDB = value; }

        public bool doAuthentication(string userName, string pass)
        {
            bool enter = false;

            try
            {
                objUser = new User()
                {
                    UserName = userName
                };

                objUserLogic.Read(ref objUser);

                if (objUser.ErrorMessage == null)
                {
                    if (objUser.DtResults.Rows.Count == 1)
                    {
                        if (objUser.Pass == pass)
                        {
                            enter = true;
                        }
                        else
                        {
                            ErrorMessage = "Contraseña incorrecta!";
                        }
                    }
                    else
                    {
                        ErrorMessage = "Nombre de usuario incorrecto!";
                    }
                }
                else
                {
                    ErrorMessageDB = objUser.ErrorMessage;
                }
                return enter;
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                return false;
            }
        }
    }
}
