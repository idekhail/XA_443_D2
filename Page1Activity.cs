using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;

using AndroidX.AppCompat.App;

namespace XA2_433_D2
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class Page1Activity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_page1);

            var name = FindViewById<EditText>(Resource.Id.name);
            var code = FindViewById<EditText>(Resource.Id.code);
            var signin = FindViewById<Button>(Resource.Id.signin);
            var clear = FindViewById<Button>(Resource.Id.clear);
            var page3 = FindViewById<Button>(Resource.Id.page3);
            var close = FindViewById<Button>(Resource.Id.close);

            signin.Click += delegate
            {
                if(name.Text == "a" && code.Text == "123") {
                    var i = new Intent(this, typeof(Page2Activity));
                    StartActivity(i);
                }else
                    Toast.MakeText(this,"Error", ToastLength.Long).Show();                  
            };

            page3.Click += delegate
            {
                var i = new Intent(this, typeof(Page3Activity));
                StartActivity(i);
            };


        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}