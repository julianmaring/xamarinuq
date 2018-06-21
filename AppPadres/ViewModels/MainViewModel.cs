namespace AppPadres.ViewModels
{

    public class MainViewModel
    {
        #region Propiedades
        public LoginViewModel Login
        {
            get;
            set;
        }
        #endregion

        #region Constructores
        public MainViewModel()
        {
            this.Login = new LoginViewModel();
        }
        #endregion

    }
}
