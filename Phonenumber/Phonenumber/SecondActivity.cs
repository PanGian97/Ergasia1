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

namespace Phonenumber
{
    
    [Activity(Label = "SecondActivity")]
    public class SecondActivity : Activity
    {
        TextView textView;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.SecondLayout);

            textView = FindViewById<TextView>(Resource.Id.textView);
            textView.Text = Intent.GetStringExtra("text");
        }
    }
}