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
using Newtonsoft.Json;
using Xamarin.Essentials;

namespace App6
{
    [Activity(Label = "UserInfActivity")]
    public class UserInfActivity : Activity
    {
        public Bundle Arguments { get; private set; }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
        }

        //public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        //{
        //    // Use this to return your custom view for this Fragment
        //    // return inflater.Inflate(Resource.Layout.YourFragment, container, false);
        //    LinearLayout linearLayout = (LinearLayout)inflater.Inflate(Resource.Id.frameLayout1, container, false);

        //    textview = linearLayout.FindViewById<TextView>(Resource.Id.UserInfo);
        //    textview.Text = RegisterActivity.newUser.ToString();
        //    return linearLayout;
        //    // return base.OnCreateView(inflater, container, savedInstanceState);
        //}

        private async void btnShare_Clicked(object sender, System.EventArgs e)
        {
            var json = JsonConvert.SerializeObject(RegisterActivity.newUser);
            await Share.RequestAsync(new ShareTextRequest
            {
                Text = json,
                Title = "Share Info"
            });
        }
        public static UserInfActivity NewInstance()
        {
            var frag1 = new UserInfActivity { Arguments = new Bundle() };
            return frag1;
        }

    }
}