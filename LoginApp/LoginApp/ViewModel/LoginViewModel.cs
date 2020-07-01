using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;



namespace LoginApp.ViewModel 
{
    class LoginViewModel : INotifyPropertyChanged
    {
        private string password;
        private string username;
        INavigationService NavigationService;
      

        private Dictionary<string, string> userData = new Dictionary<string, string>(){ 
            {"dilan","123"} };

        public event PropertyChangedEventHandler PropertyChanged;

        public LoginViewModel() {
            NavigationService = ViewModelLocator.Resolve<INavigationService>();
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
        public ICommand BackToPage { get;  set; }

        void Authenticate() {
            if(username==null || password == null)
            {
                BackToPage = new Command(async () => {
                    Application.Current.MainPage = new UserDetail();
                });
                //Application.Current.MainPage.DisplayAlert("Login State", "Wrong credentials", "OK");
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
