using System;
using System.Linq;
using LoginNavigation.Droid;
using Xamarin.Forms;

namespace LoginNavigation
{
	public partial class SignUpPage : ContentPage
	{
		public SignUpPage ()
		{
			InitializeComponent ();
		}

		async void OnSignUpButtonClicked (object sender, EventArgs e)
		{
			var person = new Person() {
				Username = usernameEntry.Text,
				Password = passwordEntry.Text,
				Email = emailEntry.Text
			};

			// Sign up logic goes here

			var signUpSucceeded = AreDetailsValid (person);
			if (signUpSucceeded) {
				var rootPage = Navigation.NavigationStack.FirstOrDefault ();
				if (rootPage != null) {
					App.IsUserLoggedIn = true;
                    Navigation.InsertPageBefore(new MainViewXaml(), Navigation.NavigationStack.First());
                    await Navigation.PopToRootAsync();
                }
			} else {
				messageLabel.Text = "Sign up failed";
			}
		}

		bool AreDetailsValid (Person user)
		{
			return (!string.IsNullOrWhiteSpace (user.Username) && !string.IsNullOrWhiteSpace (user.Password) && !string.IsNullOrWhiteSpace (user.Email) && user.Email.Contains ("@"));
		}
	}
}
