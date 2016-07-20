using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LoginNavigation
{
    public class AddLocation : ContentPage
    {
        public string entryText;
        readonly AddLocationVM addLocationVM;

        public AddLocation()
        {

            addLocationVM = new AddLocationVM();
            var entry = new Entry()
            {
                
                HeightRequest = 40, 
                WidthRequest = 200

            };

            var entryButton = new Button()
            {
                Text = "click here"

            };
            entryButton.Clicked += Signin_Clicked;



            var stack = new StackLayout()
            {
                Orientation = StackOrientation.Horizontal,
                Children = {entry},
                Padding = 20  
                          
              };

            var entryText = entry.Text;

            this.Content = stack;

        }

        private void Signin_Clicked(object sender, EventArgs e)
        {
            addLocationVM.EntryText = entryText;
        }
    }
     
}
