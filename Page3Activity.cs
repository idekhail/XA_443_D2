using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XA2_433_D2
{
    [Activity(Label = "Page3Activity")]
    public class Page3Activity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.activity_page3);

            var latitude = FindViewById<EditText>(Resource.Id.latitude);
            var longitude = FindViewById<EditText>(Resource.Id.longitude); 
            var location = FindViewById<Button>(Resource.Id.location);    
            var signout = FindViewById<Button>(Resource.Id.signout);


            location.Click += delegate
            {                
                var url = Android.Net.Uri.Parse("geo:" + latitude.Text + "," + longitude.Text);
                var i = new Intent(Intent.ActionView, url);
                StartActivity(i);
            };

            signout.Click += delegate
            {
                var i = new Intent(this, typeof(Page1Activity));
                StartActivity(i);
            };

        }
    }
}