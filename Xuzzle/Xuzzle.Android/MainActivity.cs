using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Content.PM;

using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;


using Xamarin.Forms.Platform.Android;

namespace Xuzzle.Android
{

	[Activity (Label = "Xuzzle", Icon = "@drawable/icon", MainLauncher = true, 
		ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : 
	global::Xamarin.Forms.Platform.Android.FormsApplicationActivity // superclass new in 1.3
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);



			global::Xamarin.Forms.Forms.Init (this, bundle);

            MobileCenter.Start("6396b4f4-9a06-4398-a8c3-efea13114b4e", typeof(Analytics), typeof(Crashes));

            LoadApplication (new App ()); // method is new in 1.3
		}
	}

}

