using System.Collections.Generic;
using System.ComponentModel;
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
                    OpenUserDetail();

                }
                else Application.Current.MainPage.DisplayAlert("Save", "Wrong credentials", "OK");
            }
            else Application.Current.MainPage.DisplayAlert("Login State", "Wrong credentials", "OK");
        }


        public void OpenUserDetail()
        {

            //Application.Current.MainPage.Navigation.PushAsync(new UserDetail());


        }

    }

}

