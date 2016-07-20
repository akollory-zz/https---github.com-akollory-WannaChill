using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LoginNavigation
{
    class CenterboxView : ContentPage
    {

        public CenterboxView()
        {
            var label = new Label
            {
                Text = "Hi this is the center box page"

            };

            var layout = new Xamarin.Forms.AbsoluteLayout();

            var centerLabel = new Label
            {
                Text = "I'm centered on iPhone 4 but no other device.",
                LineBreakMode = LineBreakMode.WordWrap
            };

            Xamarin.Forms.AbsoluteLayout.SetLayoutBounds(centerLabel, new Rectangle(115, 159, 100, 100));
            // No need to set layout flags, absolute positioning is the default

            var bottomLabel = new BoxView { BackgroundColor = Color.Gray };
            Xamarin.Forms.AbsoluteLayout.SetLayoutBounds(bottomLabel, new Rectangle(.5, 1, 1, .1));
            Xamarin.Forms.AbsoluteLayout.SetLayoutFlags(bottomLabel, AbsoluteLayoutFlags.All);

            var centerBox = new Image { Source = "icon.png" };
            Xamarin.Forms.AbsoluteLayout.SetLayoutBounds(centerBox, new Rectangle(.5, 1, 1, .1));
            Xamarin.Forms.AbsoluteLayout.SetLayoutFlags(centerBox, AbsoluteLayoutFlags.All);


            var leftBox = new Image { Source = "male_on.png" };
            Xamarin.Forms.AbsoluteLayout.SetLayoutBounds(leftBox, new Rectangle(10, 515, 50, 50));
            //Xamarin.Forms.AbsoluteLayout.SetLayoutBounds(centerBox, new Rectangle(.1, .1, 1, .1));
            //Xamarin.Forms.AbsoluteLayout.SetLayoutFlags(centerBox, AbsoluteLayoutFlags.All);

            var rightBox = new Image { Source = "female_on.png" };
            Xamarin.Forms.AbsoluteLayout.SetLayoutBounds(rightBox, new Rectangle(275, 515, 50, 50));


            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += (s, e) =>
            {

                Navigation.PushModalAsync(new CenterboxView());
            };
            centerBox.GestureRecognizers.Add(tapGestureRecognizer);

            layout.Children.Add(bottomLabel);
            layout.Children.Add(label);
            layout.Children.Add(rightBox);
            layout.Children.Add(leftBox);
            layout.Children.Add(centerBox);

            this.Content = layout;

        }



    
    }
}
