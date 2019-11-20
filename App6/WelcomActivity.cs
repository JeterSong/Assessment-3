using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace App6
{
    [Activity(Label = "WelcomActivity")]
    public class WelcomActivity : Activity
    {
        TextView UserName;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Welcom);

            // Create your application here

            UserName = FindViewById<TextView>(Resource.Id.txtWelcome);

            UserName.Text = Intent.GetStringExtra("Username");

        }
    }
}