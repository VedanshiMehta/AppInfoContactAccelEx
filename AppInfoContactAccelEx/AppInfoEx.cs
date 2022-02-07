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
using Xamarin.Essentials;

namespace AppInfoContactAccelEx
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    class AppInfoEx : Activity
    {
        private Button myButton;
        private TextView text1;
        private TextView text2;
        private TextView text3;
        private TextView text4;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.appInfoDemo);
            UIReference();
            UIClickEvent();
        }

        private void UIClickEvent()
        {
            myButton.Click += MyButton_Click;
        }

        private void MyButton_Click(object sender, EventArgs e)
        {
            text1.Text = "APP NAME:" + AppInfo.Name;
            text2.Text = "PACKAGE NAME:" + AppInfo.PackageName;
            text3.Text = "VERSION STRING:" + AppInfo.VersionString;
            text3.Text = "BUILD STRING" + AppInfo.BuildString;

        }

        private void UIReference()
        {
            myButton = FindViewById<Button>(Resource.Id.buttonAI);
            text1 = FindViewById<TextView>(Resource.Id.textViewAI1);
            text2 = FindViewById<TextView>(Resource.Id.textViewAI2);
            text3 = FindViewById<TextView>(Resource.Id.textViewAI3);
            text4 = FindViewById<TextView>(Resource.Id.textViewAI4);
        }
    }
}