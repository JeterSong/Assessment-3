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
using System.Net;
using System.IO;

namespace App6
{
    [Activity(Label = "RegisterActivity")]
    public class RegisterActivity : Activity
    {
        Button btnRegister;Button btnBack; EditText editCountry;EditText editUserName; EditText editPassword;EditText editFirstName; EditText editLastName;EditText editAddress;EditText editPhone;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Signup);
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;

            btnRegister = FindViewById<Button>(Resource.Id.btnRegister);
            btnBack = FindViewById<Button>(Resource.Id.btnBack);
            editCountry = FindViewById<EditText>(Resource.Id.editCountry);
            editUserName= FindViewById<EditText>(Resource.Id.editUserName);
            editPassword = FindViewById<EditText>(Resource.Id.editPassword);
            editFirstName = FindViewById<EditText>(Resource.Id.editFirstName);
            editLastName = FindViewById<EditText>(Resource.Id.editLastName);
            editAddress = FindViewById<EditText>(Resource.Id.editAddress);
            editPhone = FindViewById<EditText>(Resource.Id.editPhone);

            btnBack.Click += (sender, e) =>
            {
                Intent loginActivityIntent = new Intent(this, typeof(loginActivity));
                StartActivity(loginActivityIntent);
            };

            btnRegister.Click += btnRegister_Click;

        }

        private async void btnRegister_Click(object sender,EventArgs e )
        {
            var request = HttpWebRequest.Create(string.Format(@"https://10.0.2.2:5001/api/Users"));
            //http://172.31.99.148:5000/api/Users
            request.ContentType = "application/jason";
            request.Method = "POST";

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                string userJason = "{\"Id\":\"1\"," + "\"Country\":\"editCountry\"," + "\"UserName\":\"editUserName\"," + "\"Password\":\"editPassword\"," +
                   "\"FirstName\":\"editFirstName\"," + "\"LastName\":\"editLastName\"," + "\"Address\":\"editAddress\"," +
                   "\"Phone\":\"editPhone\"}";

                   streamWriter.Write(userJason);
            }
            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {

                if (response.StatusCode != HttpStatusCode.OK)
                { 
                    Console.Out.WriteLine("Error fetching data. Server returned status code: {0}", response.StatusCode);
                    Toast.MakeText(this, "User created successfully", ToastLength.Long);

                    Intent loginActivityIntent = new Intent(this, typeof(loginActivity));
                    StartActivity(loginActivityIntent);
                }
                else
                {
                    Toast.MakeText(this, "Failed to create user. Please retry!", ToastLength.Long);
                }
            }
        }
    }
}