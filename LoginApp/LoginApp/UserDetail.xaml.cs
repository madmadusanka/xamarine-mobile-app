using LoginApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserDetail : ContentView
    {
        public UserDetail()
        {
            InitializeComponent();
            BindingContext = new UserDetailViewModel();
        }

        public static implicit operator Page(UserDetail v)
        {
            throw new NotImplementedException();
        }
    }
}