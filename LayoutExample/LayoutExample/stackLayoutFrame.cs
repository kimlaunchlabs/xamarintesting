using System;

using Xamarin.Forms;

namespace LayoutExample
{
	public class stackLayoutFrame : ContentPage
	{
		public stackLayoutFrame ()
		{
			this.Padding = 20;
			this.Content = new Frame 
			{
				Content = new Label {Text = "Frame", FontSize = 40},
				OutlineColor = Color.Red
			};
		}
	}
}


