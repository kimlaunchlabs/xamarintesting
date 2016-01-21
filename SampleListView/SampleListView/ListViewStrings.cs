using System;

using Xamarin.Forms;
using System.Collections.Generic;

namespace SampleListView
{
	public class ListViewStrings : ContentPage
	{
		public ListViewStrings ()
		{
			ListView listView = new ListView ();
			List<String> items = new List <String> () { "First", "Second", "Third" };
			listView.ItemsSource = items;
			this.Content = listView;


			listView.ItemTapped += async (sender, e) => 
			{
				await DisplayAlert("Tapped",e.Item.ToString() + " was selected.", "OK");
				((ListView)sender).SelectedItem = null;
			};
			listView.ItemSelected += async (sender, e) => 
			{
				if (e.SelectedItem == null) return;
				await DisplayAlert("Selected", e.SelectedItem.ToString() + " was selected.", "OK");
				((ListView)sender).SelectedItem = null;
			};




			//StackLayout ListStack = new StackLayout 
			//{
				//Children = {
				//	listView
				//}
			//};

			this.Content = listView;

		}

		//this.Content = ListStack;
	}
}


