using LoginNavigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace LoginNavigation
{
    public class MainPageCS : MasterDetailPage
    {
        MasterPageCS masterPage;
        public MainPageCS()
        {

            masterPage = new MasterPageCS();
            Master = masterPage;
            Detail = new NavigationPage(new MainViewXaml());

        }
    }
}
