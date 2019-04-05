using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using AndroidX.Work;

namespace WorkManagerSample.Droid
{
    [Activity(Label = "WorkManagerSample", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());

            PeriodicWorkRequest taxWorkRequest = PeriodicWorkRequest.Builder.From<CalculatorWorker>(TimeSpan.FromMinutes(20)).Build();

            WorkManager.Instance.Enqueue(taxWorkRequest);
        }
    }
}