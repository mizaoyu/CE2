using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace CE2
{
	[Activity (Label = "CardEmulation", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			SetContentView (Resource.Layout.Main);
			//Console.WriteLine ("bbb");
			if (savedInstanceState == null) {
				var fm = FragmentManager;
				FragmentTransaction transaction = fm.BeginTransaction();
				CardEmulationFragment fragment = new CardEmulationFragment();
				transaction.Replace(Resource.Id.sample_content_fragment, fragment);
				transaction.Commit();
			}
			// Get our button from the layout resource,
			// and attach an event to it
			//Button button = FindViewById<Button> (Resource.Id.myButton);
			
			//button.Click += delegate {
			//	button.Text = string.Format ("{0} clicks!", count++);
			//};
		}
	}
}


