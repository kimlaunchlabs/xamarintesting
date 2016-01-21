using System;

using Xamarin.Forms;

namespace SampleListView
{
	public class ListViewImageCell : ContentPage
	{
		public class ListItem
		{
			public string Source { get; set;}
			public string Title { get; set;}
			public string Description { get; set;}
			public string Price { get; set;}
		}


		public ListViewImageCell ()
		{
			var listView = new ListView ();
			listView.ItemsSource = new ListItem[]{
				new ListItem {Source = "icon.png", Title = "First", Description= "1st item"},
				new ListItem {Source = "icon.png", Title = "Second", Description="2nd item"},
				new ListItem {Source = "icon.png", Title = "Third", Description="3rd item"}
			};

			listView.ItemTemplate = new DataTemplate(typeof(ImageCell));
			listView.ItemTemplate.SetBinding(ImageCell.ImageSourceProperty,"Source");
			listView.ItemTemplate.SetBinding(ImageCell.TextProperty,"Title");
			listView.ItemTemplate.SetBinding(ImageCell.DetailProperty,"Description");

			this.Padding = new Thickness(0, Device.OnPlatform(20,0,0),0,0);

			Content = listView;

		}
	}
}


