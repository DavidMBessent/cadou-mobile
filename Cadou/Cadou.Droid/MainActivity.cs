using System;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Cadou;
using Microsoft.WindowsAzure.MobileServices;

namespace Cadou.Droid
{
    [Activity(Label = "Cadou", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());

            CurrentPlatform.Init();
            TodoItem item = new TodoItem { Text = "Awesome item" };
            MobileService.GetTable<TodoItem>().InsertAsync(item);
        }

        public static MobileServiceClient MobileService = new MobileServiceClient("https://cadou-mobile.azurewebsites.net");

        public class TodoItem
        {
            public string Id { get; set; }
            public string Text { get; set; }
        }
    }
}

