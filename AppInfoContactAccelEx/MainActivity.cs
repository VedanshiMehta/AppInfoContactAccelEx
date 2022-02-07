using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace AppInfoContactAccelEx
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Button myAppInfo;
        Button myContact;
        Button myAccelometer;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);


            myAppInfo = FindViewById<Button>(Resource.Id.button1);
            myContact = FindViewById<Button>(Resource.Id.button2);
            myAccelometer = FindViewById<Button>(Resource.Id.button3);


            myAppInfo.Click += MyAppInfo_Click;
            myContact.Click += MyContact_Click;
            myAccelometer.Click += MyAccelometer_Click;
        }

        private void MyAccelometer_Click(object sender, System.EventArgs e)
        {
            Intent k = new Intent(Application.Context, typeof(AccelrometerEx));
            StartActivity(k);
        }

        private void MyContact_Click(object sender, System.EventArgs e)
        {

            Intent j = new Intent(Application.Context, typeof(ContactEx));
            StartActivity(j);
        }

        private void MyAppInfo_Click(object sender, System.EventArgs e)
        {
            Intent i = new Intent(Application.Context, typeof(AppInfoEx));
            StartActivity(i);
        }

        private void MyPropertyDemo_Click(object sender, System.EventArgs e)
        {

        }





        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}