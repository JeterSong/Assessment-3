using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
using Android.Support.Design.Widget;

namespace App6
{
    [Activity(Label = "WelcomActivity")]
    public class WelcomActivity : Activity,BottomNavigationView.IOnNavigationItemSelectedListener
    {
        TextView username;

        public bool OnNavigationItemSelected(IMenuItem item)
        {
           switch(item.ItemId)
            {
                case Resource.Id.navigation_home:

                    return true;
                case Resource.Id.navigation_list:

                    return true;
                case Resource.Id.navigation_map:

                    return true;
                case Resource.Id.navigation_user:

                    return true;
            }

            return false;
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Welcom);

            // Create your application here
            //username = FindViewById<TextView>(Resource.Id.lblWelcome);
            //username.Text = Intent.GetStringExtra("AccName");
        }

    }
}
