using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
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

        public LoginViewModel() {
            LoginCommand = new Command(Authenticate); ;
        }
        public string Username
        {
           
            set {
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
        void Authenticate() {
            if(username==null || password == null)
            {
                Application.Current.MainPage.DisplayAlert("Login State", "Wrong credentials", "OK");
            }
            else if (userData.ContainsKey(username))
            {
                if (userData[username]==password) {
                    Application.Current.MainPage.DisplayAlert("Login State","Succesfull Login", "OK");
                }
               else Application.Current.MainPage.DisplayAlert("Save", "Wrong credentials", "OK");
            }
             else  Application.Current.MainPage.DisplayAlert("Login State", "Wrong credentials", "OK"); 
   


        }            
    }
   
}
