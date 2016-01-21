using System;

using Xamarin.Forms;

namespace NavigationSample
{
	public class DropdownMenu : ContentPage
	{
		public DropdownMenu ()
		{
			ToolbarItems.Clear ();
			ToolbarItems.Add (new ToolbarItem {
				Text = "Home",
				Order = ToolbarItemOrder.Secondary,
				Command = new Command (() =>
					Navigation.PushAsync (new Homepage ()))
			});

			ToolbarItems.Add (new ToolbarItem {
				Text = "Second",
				Order = ToolbarItemOrder.Secondary,
				Command = new Command (() =>
					Navigation.PushAsync (new secondPage ()))
			});

//			StackLayout stacklayout = new StackLayout 
//			{
//				Children = { Too}
//			};

			//Content = ToolbarItem;
	}
}

}
