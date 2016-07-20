﻿using System;
using LoginNavigation.Droid;
using Xamarin.Forms;

namespace LoginNavigation
{
	public class LoginPageCS : ContentPage
	{
		Entry usernameEntry, passwordEntry;
		Label messageLabel;

		public LoginPageCS ()
		{
			var toolbarItem = new ToolbarItem {
				Text = "Sign Up"
			};
			toolbarItem.Clicked += OnSignUpButtonClicked;
			ToolbarItems.Add (toolbarItem);

			messageLabel = new Label ();
			usernameEntry = new Entry {
				Placeholder = "username"	
			};
			passwordEntry = new Entry {
				IsPassword = true, 
                Placeholder = "password"
			};
			var loginButton = new Button {
				Text = "Login"
			};
			loginButton.Clicked += OnLoginButtonClicked;

			Title = "Login";
			Content = new StackLayout { 
				VerticalOptions = LayoutOptions.StartAndExpand,
				Children = {
					new Label { Text = "Username" },
					usernameEntry,
					new Label { Text = "Password" },
					passwordEntry,
					loginButton,
					messageLabel
				}
			};
		}

		async void OnSignUpButtonClicked (object sender, EventArgs e)
		{
			await Navigation.PushAsync (new SignUpPageCS ());
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

		bool AreCredentialsCorrect (Person person)
		{
			return person.Username == Constants.Username && person.Password == Constants.Password;
		}
	}
}


