using System;
using Logic;
using Entities;

namespace ApiAuthentication
{
    public class Register
    {
        private User objUser = null;
        private readonly UserLogic objUserLogic = new UserLogic();
        private string _errorMessage, _errorMessageDB;

        public string ErrorMessage { get => _errorMessage; set => _errorMessage = value; }
        public string ErrorMessageDB { get => _errorMessageDB; set => _errorMessageDB = value; }

        public void doRegister(string userName, string email, string pass, string name, string lastName, string country)
        {
            try
            {
                objUser = new User()
                {
                    UserName = userName,
                    Email = email,
                    Pass = pass,
                    Name = name,
                    LastName = lastName,
                    Country = country,
                    Payment = 0,
                    Type = "cliente"
                };

                objUserLogic.Create(ref objUser);

                if (objUser.ErrorMessage != null)
                {
                    ErrorMessageDB = objUser.ErrorMessage;
                }

            }catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }
    }
}
