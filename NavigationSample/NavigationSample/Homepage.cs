using System;

using Xamarin.Forms;

namespace NavigationSample
{
	public class Homepage : ContentPage
	{
		Button homeButton;
		public Homepage ()
		{
			Title = "Home";
			var image = "icon.png";
			NavigationPage.SetTitleIcon (this, image);


			Label homeLabel = new Label 
			{
				Text = "Home Page",
				FontSize = 40
			};

			homeButton = new Button 
			{
				Text = "Go to Second Page"
			};

			homeButton.Clicked += async (sender, args) => await Navigation.PushAsync (new secondPage ());

			StackLayout stacklayout = new StackLayout 
			{
				Children = { homeLabel, homeButton }
			};

			this.Content = stacklayout;
		}
	}
}


