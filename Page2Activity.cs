
using Android.App;
using Android.Content;
using Android.OS;
using Android.Provider;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XA2_433_D2
{
    [Activity(Label = "Page2Activity")]
    public class Page2Activity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.activity_page2);
            var mobile = FindViewById<EditText>(Resource.Id.mobile);
            var website = FindViewById<EditText>(Resource.Id.website);
            var call = FindViewById<EditText>(Resource.Id.call);    
            var web     = FindViewById<EditText>(Resource.Id.web);
            var signout = FindViewById<EditText>(Resource.Id.signout);  
            var clear = FindViewById<EditText>(Resource.Id.clear);

            // Call Me
            call.Click += delegate
            {                
                try
                {
                    var url = Android.Net.Uri.Parse("tel:" + mobile.Text);
                    var i = new Intent(Intent.ActionDial, url);
                    StartActivity(i);
                }
                catch (ArgumentNullException anEx)
                {
                    // Number was null or white space
                }                
                catch (Exception ex)
                {
                    // Other error has occurred.
                }
            };
            web.Click += delegate
            {
                var url = Android.Net.Uri.Parse(website.Text);
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