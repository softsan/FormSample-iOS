﻿using System;
using Xamarin.Forms;
using FormSample.Views;
using FormSample.ViewModel;
using FormSample.Helpers;

namespace FormSample
{
	public interface ILoginManager
	{
		void ShowMainPage();
		void ShowLoginPage();
	}

    /// <summary>
    /// The login modal page.
    /// </summary>
    public class LoginModalPage : CarouselPage
	{
		ContentPage login, create,contactUs;
		public LoginModalPage (ILoginManager ilm)
		{
			login = new LoginPage (ilm);
			create = new RegisterPage (ilm);
			// contactUs = new ContactUsPage (ilm);

			this.Children.Add (login);
			this.Children.Add (create);
			// this.Children.Add (contactUs);

			MessagingCenter.Subscribe<AgentViewModel> (this, "Login", (sender) => {
				this.SelectedItem = login;
			});
			MessagingCenter.Subscribe<LoginViewModel> (this, "Create", (sender) => {
				this.SelectedItem = create;
			});
//			MessagingCenter.Subscribe<LoginViewModel> (this, "ContactUs", (sender) => {
//				Settings.PageName = "ContactUs";
//				this.SelectedItem = contactUs;
//
//			});
		}
	}
}

