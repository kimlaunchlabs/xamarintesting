using System;

using Xamarin.Forms;

namespace LayoutExample
{
	public class StackLayoutAbsolute : ContentPage
	{
		public StackLayoutAbsolute ()
		{
			AbsoluteLayout absoluteLayout = new AbsoluteLayout 
			{
				VerticalOptions = LayoutOptions.FillAndExpand
			};

			Label firstlabel = new Label 
			{
				Text = "FirstLabel"
			};

			Label secondlabel = new Label 
			{
				Text = "SecondLabel"
			};


			absoluteLayout.Children.Add (secondlabel);
			AbsoluteLayout.SetLayoutFlags (secondlabel,
				AbsoluteLayoutFlags.PositionProportional);
			AbsoluteLayout.SetLayoutBounds (secondlabel,
				new Rectangle (0, 1, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));



			absoluteLayout.Children.Add (firstlabel);
			AbsoluteLayout.SetLayoutFlags (firstlabel,
				AbsoluteLayoutFlags.PositionProportional);
			AbsoluteLayout.SetLayoutBounds (firstlabel,
				new Rectangle (0,0, AbsoluteLayout.AutoSize,AbsoluteLayout.AutoSize));


			this.Content = absoluteLayout;
		}
	}
}


