using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp.Services
{
    class NavigationService :INavigationService
    {


        public async Task NavigateUserDetail()
        {
            await App.Page.Navigation.PushAsync(new UserDetail());
        }
    }
}
