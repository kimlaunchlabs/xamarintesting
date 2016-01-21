using System;

using Xamarin.Forms;
using System.Collections.Generic;

namespace UIControlExample
{
	public class Controls : ContentPage
	{
		Label eventValue;
		Label pageValue;

		public Controls ()
		{
			eventValue = new Label ();
			eventValue.Text = "Value in Handler";
			pageValue = new Label ();
			pageValue.Text = "Value in Page";




			// Picker
			Picker picker = new Picker 
			{
				Title = "Options",
				VerticalOptions = LayoutOptions.CenterAndExpand
			};

			var options = new List<string> { "First", "Second", "Third", "Fourth" };

			foreach (string optionName in options) 
			{
				picker.Items.Add (optionName);
			}

			picker.SelectedIndexChanged += (sender, args) => 
			{
				pageValue.Text = picker.Items[picker.SelectedIndex];
			};



			// Date Picker
			DatePicker datePicker = new DatePicker 
			{
				Format = "D",
				VerticalOptions = LayoutOptions.CenterAndExpand
			};

			datePicker.DateSelected += (object sender, DateChangedEventArgs e) =>
			{
				eventValue.Text = e.NewDate.ToString();
				pageValue.Text = datePicker.Date.ToString();
			};
			datePicker.MaximumDate = Convert.ToDateTime ("1/1/2019");
			datePicker.MinimumDate = Convert.ToDateTime ("1/1/2014");



			// Time Picker
			TimePicker timePicker = new TimePicker 
			{
				Format = "T",
				VerticalOptions = LayoutOptions.CenterAndExpand
			};

			timePicker.PropertyChanged += (sender, e) => 
			{
				if (e.PropertyName == TimePicker.TimeProperty.PropertyName)
				{
					pageValue.Text = timePicker.Time.ToString();
				}
			};



			// Stepper
			Stepper stepper = new Stepper 
			{
				Minimum = 0,
				Maximum = 10,
				Increment = 1,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};

			stepper.ValueChanged += (sender, e) => 
			{
				eventValue.Text = String.Format("Stepper value is {0:F1}",e.NewValue);
				pageValue.Text = Stepper.ValueProperty.ToString();
			};



			// Slider
			Slider slider = new Slider 
			{
				Minimum = 0,
				Maximum = 100,
				Value = 50,
				VerticalOptions = LayoutOptions.CenterAndExpand,
				WidthRequest = 300
			};

			slider.ValueChanged += (sender, e) => 
			{
				eventValue.Text = String.Format("Slider value is {0:F1}",e.NewValue);
				pageValue.Text = slider.Value.ToString();
			};



			// Switch
			Switch switcher = new Switch 
			{
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};

			switcher.Toggled += (sender, e) => 
			{
				eventValue.Text = String.Format("Switch is now {0}", e.Value);
				pageValue.Text = switcher.IsToggled.ToString();

			};
		





		

			StackLayout stackLay = new StackLayout {
				//Spacing = 0,
				//Orientation = StackOrientation.Horizontal,
				HorizontalOptions = LayoutOptions.Center,
				Children = {
					//HorizontalOptions = LayoutOptions.Center,
					eventValue,
					pageValue,
					picker,
					datePicker,
					timePicker,
					stepper,
					slider,
					switcher
				}

			};

			this.Content = stackLay;

		}


	}
}


