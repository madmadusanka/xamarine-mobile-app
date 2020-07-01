using LoginApp.Services;
using LoginApp.views;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;



namespace LoginApp.ViewModel
{
    class LoginViewModel : INotifyPropertyChanged
    {
        private string password;
        private string username;
        private Dictionary<string, string> userData = new Dictionary<string, string>(){
            {"dilan","123"} };

        public event PropertyChangedEventHandler PropertyChanged;
        private readonly INavigationService _navigationService;
        public LoginViewModel()
        {
            LoginCommand = new Command(AuthenticateAsync);

        }
        public string Username
        {

            set
            {
                username = value;

            }
        }
        public string Password
        {
            set { password = value; }
        }
        public Command LoginCommand
        {
            get;

        }
        

        public void AuthenticateAsync()
        {
            if (username == null || password == null)
            {

                Application.Current.MainPage.DisplayAlert("Login State", "Wrong credentials", "OK");
            }
            else if (userData.ContainsKey(username))
            {
                if (userData[username] == password)
                {
                    // Application.Current.MainPage.DisplayAlert("Login State","Succesfull Login", "OK");

                }
                else Application.Current.MainPage.DisplayAlert("Save", "Wrong credentials", "OK");
            }
            else Application.Current.MainPage.DisplayAlert("Login State", "Wrong credentials", "OK");
        }

        public ICommand BackToPage { get; private set; }
        public void Home()

            BackToPage = new Command(async () => {
                await Application.Current.MainPage.Navigation.PushAsync(UserDetail);
            });
        }

    }

}                     

