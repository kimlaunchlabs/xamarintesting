using System;

using Xamarin.Forms;

namespace NavigationSample
{
	public class secondPage : ContentPage
	{
		public secondPage ()
		{
			
			Title = "Heirarchical Navigation";
			var image = "icon.png";
			NavigationPage.SetTitleIcon (this, image);

			Label homeLabel = new Label 
			{
				Text = "Second Page",
				FontSize = 40
			};

			var stackLayout = new StackLayout 
				
			{
				Children = { homeLabel }
			};

			this.Content = stackLayout;
		}
	}
}


