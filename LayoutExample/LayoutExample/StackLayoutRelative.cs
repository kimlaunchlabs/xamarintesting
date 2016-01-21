using System;

using Xamarin.Forms;

namespace LayoutExample
{
	public class StackLayoutRelative : ContentPage
	{
		public StackLayoutRelative ()
		{
			RelativeLayout relativeLayout = new RelativeLayout ();

			Label upperLeft = new Label 
			{
				Text = "Upper Left",
				FontSize = 20
				
			};

			Label constantLabel = new Label 
			{
				Text = "Constants are Absolute",
				FontSize = 20
			};

			Label halfwayDown = new Label 
			{
				Text = "Halfway down and across",
				FontSize = 15
			};

			BoxView boxView = new BoxView 
			{
				Color = Color.Accent,
				WidthRequest = 150,
				HeightRequest = 150,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};


			Label below = new Label 
			{
				Text = "Below Upper Left",
				FontSize = 15
			};




			relativeLayout.Children.Add(below,
				Constraint.Constant(0),
				Constraint.RelativeToView(upperLeft,(parent, sibling) =>
				{
					return sibling.Y + sibling.Height;
				})
			
			
			);



			relativeLayout.Children.Add(boxView,
				Constraint.Constant(0),
				Constraint.RelativeToParent((parent) =>
					{
						return parent.Height / 2;		
					}),
				Constraint.RelativeToParent((parent) =>
					{
						return parent.Width / 2;
					}),
				Constraint.RelativeToParent((parent) =>
					{
						return parent.Height / 2;
					})
			);


			relativeLayout.Children.Add (halfwayDown,
				Constraint.RelativeToParent((parent) =>
					{
						return parent.Width / 2;
					}),
				Constraint.RelativeToParent((parent) =>
					{
						return parent.Height / 2;
					})
			);


			relativeLayout.Children.Add (upperLeft,
				Constraint.Constant (0),
				Constraint.Constant (10)
			);


			relativeLayout.Children.Add (constantLabel,
				Constraint.Constant (100),
				Constraint.Constant (100),
				Constraint.Constant (50),
				Constraint.Constant (200)
			);



			Content = relativeLayout;

		}
	}
}


