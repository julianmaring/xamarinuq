using System;
using System.Collections.Generic;
using System.Text;

namespace AppPadres.ViewModels
{
    public class LoginViewModel
    {
        #region Propiedades
        public string Email { get; set; }
        #endregion

        #region Constructores
        public LoginViewModel()
        {
            this.Email="cualquiercosa@gmail.com";

        }
        #endregion
    }
}
