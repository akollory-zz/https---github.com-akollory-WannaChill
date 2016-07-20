using System;
using LoginNavigation.Droid;
using Xamarin.Forms;


namespace LoginNavigation
{
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
            var layout = new StackLayout { Padding = 10 };

            var label = new Label
            {
                Text = "WannaChill?",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                TextColor = Color.White,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalTextAlignment = TextAlignment.Center, // Center the text in the blue box.
                VerticalTextAlignment = TextAlignment.Center, // Center the text in the blue box.
            };

            layout.Children.Add(label);

            var username = new Entry { Placeholder = "Username" };
		    username.PlaceholderColor = Color.White;
            //username.SetBinding(Entry.TextProperty, LoginViewModel.UsernamePropertyName);
            layout.Children.Add(username);

            var password = new Entry { Placeholder = "Password", IsPassword = true };
            password.PlaceholderColor = Color.White;
            //password.SetBinding(Entry.TextProperty, LoginViewModel.PasswordPropertyName);
            layout.Children.Add(password);



            var button = new Button { Text = "Sign In", TextColor = Color.White };
            button.Clicked += OnLoginButtonClicked;
            //button.SetBinding(Button.CommandProperty, LoginViewModel.LoginCommandPropertyName);
            var buttonSignUp = new Button { Text = "Sign Up!", TextColor = Color.White };
            buttonSignUp.Clicked += OnSignUpButtonClicked;
            layout.Children.Add(button);
            layout.Children.Add(buttonSignUp);

            Content = new ScrollView { Content = layout };
            Content.BackgroundColor = Color.FromHex("#F65B64");
		    


        }

		async void OnSignUpButtonClicked (object sender, EventArgs e)
		{
			await Navigation.PushAsync (new MainViewXaml());
		}

		async void OnLoginButtonClicked (object sender, EventArgs e)
		{
			var person = new Person() {
				Username = usernameEntry.Text,
				Password = passwordEntry.Text
			};

			var isValid = AreCredentialsCorrect (person);
			if (isValid) {
				App.IsUserLoggedIn = true;
                Navigation.InsertPageBefore(new MainViewXaml(), this);
                await Navigation.PopAsync ();
			} else {
				messageLabel.Text = "Login failed";
				passwordEntry.Text = string.Empty;
			}
		}

		bool AreCredentialsCorrect (Person user)
		{
			return user.Username == Constants.Username && user.Password == Constants.Password;
		}
	}
}
