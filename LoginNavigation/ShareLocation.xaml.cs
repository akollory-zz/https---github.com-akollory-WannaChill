using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace LoginNavigation
{
    public partial class ShareLocation : ContentPage
    {
        public ShareLocation()
        {
            InitializeComponent();


            StackLayout stacklayout = new StackLayout()
            {
                Spacing = 0,
                VerticalOptions = LayoutOptions.FillAndExpand, 
                Children =
                {
                     new Label
                     {
                         Text = "Share your events with your friends!", 
                         HorizontalOptions = LayoutOptions.Start

                     },

                     new Entry
                     {
                         Placeholder = "Post your location!"

                     }
             
                }

            };

            Button postButton = new Button();
            postButton.Text = "Share Now!";
            postButton.Clicked += OnButtonClicked;


            stacklayout.Children.Add(postButton);
        }

        void OnButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavigationPage(new MainViewXaml()));

        }

    }
}
