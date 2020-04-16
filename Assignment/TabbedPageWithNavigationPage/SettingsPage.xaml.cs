using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TabbedPageWithNavigationPage
{
	public partial class SettingsPage : ContentPage
	{
		public SettingsPage ()
		{
			InitializeComponent ();
		}

		public void verifyButton(Object sender, EventArgs args)
		{
			
			if (string.IsNullOrEmpty(Age.Text))
			{
				showQuiz.Text = $"Invalid age entered  { Age.Text}";
			}
			else if (Convert.ToInt16(Age.Text) <= 14)
			{
				showQuiz.Text = $"@ age of { Age.Text}, sorry you can't drive in Wisconsin";
			}
			else if (Convert.ToInt16(Age.Text) > 14)
			{
				showQuiz.Text = $"@ age of { Age.Text}, you can drive in Wisconsin, but careful not to booze and wheel - Insurance spike!!!";
			}
			else if (Convert.ToInt16(Age.Text) > 30)
			{
				showQuiz.Text = $"@ age of { Age.Text}, you can perfectly drive in Wisconsin, enjoy the low insurance rate buddy!!!";
			}
			showQuiz.IsVisible = true;
		}

	}
}

