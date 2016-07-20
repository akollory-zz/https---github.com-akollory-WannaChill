using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;

namespace LoginNavigation.Droid
{
    public class ListView : ContentPage
    {
        public ObservableCollection<LocationViewModel> locations { get; set; }

        public ListView()
        {
            locations = new ObservableCollection<LocationViewModel>();
            Xamarin.Forms.ListView lstView = new Xamarin.Forms.ListView();
            lstView.RowHeight = 60;
            this.Title = "ListView Code Sample";
            lstView.ItemsSource = locations;
            lstView.ItemTemplate = new DataTemplate(/*typeof(CustomLocationCell)*/);
            Content = lstView;
            locations.Add(new LocationViewModel {Name = "Anita", Location = "New Jersey", Image = string.Empty});
            locations.Add(new LocationViewModel { Name = "John", Location = "Matawan", Image = string.Empty });
        }


        public class CustomLocationViewCell : ViewCell
        {

            public CustomLocationViewCell()
            {
                Xamarin.Forms.AbsoluteLayout cellView = new Xamarin.Forms.AbsoluteLayout() {BackgroundColor = Color.Aqua};
                var nameLabel = new Label();
                nameLabel.SetBinding(Label.TextProperty, new Binding("Name"));
                Xamarin.Forms.AbsoluteLayout.SetLayoutBounds(nameLabel, new Rectangle(.25, .25, 400, 40));
                nameLabel.FontSize = 24; 
                cellView.Children.Add(nameLabel);

                var locationLabel = new Label();
                locationLabel.SetBinding(Label.TextProperty, new Binding("Location"));
                Xamarin.Forms.AbsoluteLayout.SetLayoutBounds(locationLabel, new Rectangle(50, 35, 200, 25));
                cellView.Children.Add(locationLabel);

                var image = new Image();
                image.SetBinding(Image.SourceProperty, new Binding("Image"));
                Xamarin.Forms.AbsoluteLayout.SetLayoutBounds(image, new Rectangle(250, .25, 200, 25));
                cellView.Children.Add(image);

                this.View = cellView;
            }
        }
    }
}