
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Org.Apache.Http.Impl.Client;
using Xamarin.Forms;
using RBVRenderer;
using Android.Graphics.Drawables.Shapes;


namespace LoginNavigation
{
    public partial class MainViewXaml : ContentPage
    {

        AddLocation location = new AddLocation();
   
        readonly TapGestureRecognizer _tapGestureRecognizer = new TapGestureRecognizer();

        readonly TapGestureRecognizer _tapGestureRecognizer2 = new TapGestureRecognizer();
        readonly TapGestureRecognizer _tapGestureRecognizer1 = new TapGestureRecognizer();
        public ObservableCollection<LocationViewModel> locations { get; set; }
        public MainViewXaml()
        {
            InitializeComponent();
            locations = new ObservableCollection<LocationViewModel>();
            lstView.ItemsSource = locations;
            lstView.BackgroundColor = Color.FromHex("#F65B64");
            locations.Add(new LocationViewModel { Name = "Anita", Location = "NJ", Image = string.Empty });
            locations.Add(new LocationViewModel { Name = "John", Location = "NJ", Image = string.Empty });
            

            var contentPage = new ContentPage
            {



            };


            var postButton = new Xamarin.Forms.Button
            {
                Text = "Post your location!",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand

            };

            postButton.Clicked += OnPostButtonClicked;

            var entryLocation = new MyEntry()
            {

                HeightRequest = 40,
                WidthRequest = 5,
                Text = location.entryText
            
            };

            var nextPageButton = new Xamarin.Forms.Button()
            {
                Text = "Add",
                

            };
            nextPageButton.Clicked += OnnextPageButtonClicked;


            var labelLocatoin = new Label()
            {
                Text = "Post your location:"

            };


            var stack = new StackLayout()
            {
                IsVisible = true,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Orientation = StackOrientation.Vertical,

            };

            stack.Children.Add(lstView);
            stack.Children.Add(nextPageButton);
            stack.Children.Add(postButton);
            stack.Children.Add(entryLocation);
            stack.Children.Add(labelLocatoin);


            var gridView = new Grid()
            {
                IsVisible = true,
                BackgroundColor = Color.Transparent,
                RowDefinitions = { (new RowDefinition() { Height = 400 }),
                    (new RowDefinition() { Height = 70 })
                
                },
                ColumnDefinitions = {(new ColumnDefinition (){ Width = new GridLength (.3, GridUnitType.Star) }),
                    (new ColumnDefinition (){ Width = new GridLength (.3, GridUnitType.Star) }),
                    (new ColumnDefinition (){ Width = new GridLength (.3, GridUnitType.Star) })
                },
                VerticalOptions = LayoutOptions.EndAndExpand
            };

            gridView.Children.Add(
                new StackLayout
                {
                    
                    GestureRecognizers = { _tapGestureRecognizer1 },
                    Orientation = StackOrientation.Vertical,
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                    Children = {
                            new Image {Source = "female_on.png", HeightRequest = 40, WidthRequest = 40},
                            new Label(){Text = "Maps", TextColor= Color.Black}
                    }
                }, 0, 2);

            gridView.Children.Add(
                new StackLayout
                {
                    GestureRecognizers = { _tapGestureRecognizer },
                    Orientation = StackOrientation.Vertical,
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                    Children = {
                            new Image {Source = "icon.png"},
                            new Label(){Text = "Profile", TextColor= Color.Black}
                    }
                }, 1, 2);

            gridView.Children.Add(
                new StackLayout
                {
                    GestureRecognizers = { _tapGestureRecognizer2 },
                    Orientation = StackOrientation.Vertical,
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                    Children = {
                            new Image {Source = "icon.png"},
                            new Label(){Text = "Friends", TextColor= Color.Black}
                    }
                }, 2, 2);

            var bottomRect = new BoxView();
            bottomRect.BackgroundColor = Color.Yellow;
            bottomRect.HeightRequest = 40;
            bottomRect.WidthRequest = 300;

            var stack1 = new StackLayout
            {
                IsVisible = false,
                GestureRecognizers = { _tapGestureRecognizer2 },
                Orientation = StackOrientation.Vertical,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Children = {
                            new BoxView {BackgroundColor = Color.Aqua },
                            new Label(){Text = "Saved", TextColor= Color.Black}
                    }
            };


            var stack2 = new StackLayout
            {
                IsVisible = false,
                GestureRecognizers = { _tapGestureRecognizer2 },
                Orientation = StackOrientation.Vertical,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Children = {
                            new BoxView {BackgroundColor = Color.Red },
                            new Label(){Text = "Saved", TextColor= Color.Black}
                    }
            };

        
            gridView.Children.Add(
                stack, 0, 0);
            Grid.SetColumnSpan(stack, 3);

            gridView.Children.Add(
               bottomRect, 0, 2);
            Grid.SetColumnSpan(bottomRect, 3);
            gridView.LowerChild(bottomRect);

            gridView.Children.Add(
                stack1, 0, 0);

            gridView.Children.Add(
             stack2, 0, 0);

           


            _tapGestureRecognizer.Tapped += (object sender, EventArgs e) => {

                stack.IsVisible = false;
                stack1.IsVisible = true;
                stack2.IsVisible = false;

            };

            _tapGestureRecognizer2.Tapped += (object sender, EventArgs e) => {

                stack.IsVisible = false;
                stack1.IsVisible = false;
                stack2.IsVisible = true;
 
            };

            _tapGestureRecognizer1.Tapped += (object sender, EventArgs e) => {

                stack.IsVisible = true;
                stack1.IsVisible = false;
                stack2.IsVisible = false;

            };

            this.Content = gridView;
        }




        public void OnPostButtonClicked(object sender, EventArgs e)
        {
        
            //locations.Add(new LocationViewModel { Name = "John", Location = "NJ", Image = string.Empty });
            locations.Add(new LocationViewModel { Name = location.entryText});

        }

        private void OnnextPageButtonClicked(object sener, EventArgs e)
        {

            Navigation.PushModalAsync(new AddLocation());
        }
    }
}
