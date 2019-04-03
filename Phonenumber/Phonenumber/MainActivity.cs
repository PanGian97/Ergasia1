using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Views;
using Java.Lang.Ref;
using System;
using Android.Content;

namespace Phonenumber
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Button loginButton;
        EditText usernameField;
        EditText passwordField;
        String dataUser = " ";
        String dataPass = " ";
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            loginButton = FindViewById<Button>(Resource.Id.loginButton);
            usernameField = FindViewById<EditText>(Resource.Id.editTextEmail);
            passwordField = FindViewById<EditText>(Resource.Id.editTextPassword);

            loginButton.Click += SendData;
            
        }
        
        public void SendData(object sender,EventArgs e)
        {
            dataUser = usernameField.Text;
            dataPass = passwordField.Text;
            if (dataUser.Equals("") )
            {
                Toast.MakeText(this,"Please Enter Username", ToastLength.Long).Show();
            }
            if (dataPass.Length <= 8 )
            {
                Toast.MakeText(this, "Your password bust contain more than 8 letters", ToastLength.Long).Show();
            }
            else { Intent intent = new Intent(this,typeof(SecondActivity));
                intent.PutExtra("text", dataUser);
                StartActivity(intent);
            }

        }
    }
}
      