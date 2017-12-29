using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using HockeyApp.Android;
using HockeyApp.Android.Metrics;

namespace CoolBreeze.Droid
{
    [Activity(Label = "CoolBreeze", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        private string _appId = "6430a13d6e144aa689520ac6dd1a57f9";
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            CrashManager.Register(this, _appId);
            MetricsManager.Register(Application, _appId);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            Microsoft.Azure.Mobile.MobileCenter.Configure("baea31b7-d897-4011-ae49-6fd2b72db10b");
            LoadApplication(new App());
        }
    }
}

