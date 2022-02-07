using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace AppInfoContactAccelEx
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    class ContactEx : Activity
    {
        private Button mButton;
        private TextView mtext1;
        private TextView mtext2;
        private TextView mtext3;
        private TextView mtext4;
        private TextView mtext5;
        private TextView mtext6;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ContactInfoDemo);
            UIReference();
            UIClickEvent();
        }

        private void UIClickEvent()
        {
            GetContactInfoAsync();
        }

        private async Task GetContactInfoAsync()
        {
            try
            {
              
                var contact = await Contacts.PickContactAsync();
               ;


                if (contact == null)
               

                return;

                
                mtext1.Text = contact.Id;
                mtext2.Text = contact.NamePrefix;
                mtext3.Text = contact.GivenName;
                mtext4.Text = contact.MiddleName;
                mtext5.Text = contact.Phones.ToString();
                mtext6.Text = contact.Emails.ToString();
              


            }
            catch (Exception e)
            {
                Log.Debug("Execption", e.StackTrace);
            
            }
            
        }

        private void UIReference()
        {
            mButton = FindViewById<Button>(Resource.Id.buttonCI);
            mtext1 = FindViewById<TextView>(Resource.Id.textViewC1);
            mtext2 = FindViewById<TextView>(Resource.Id.textViewC2);
            mtext3 = FindViewById<TextView>(Resource.Id.textViewC3);
            mtext4 = FindViewById<TextView>(Resource.Id.textViewC4);
           mtext5 = FindViewById<TextView>(Resource.Id.textViewC5);
            mtext6 = FindViewById<TextView>(Resource.Id.textViewC6);
        }
    }
}