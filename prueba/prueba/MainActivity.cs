using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace prueba
{
    [Activity(Label = "prueba", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;
        EditText Edi;
        TextView res;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Edi = FindViewById<EditText>(Resource.Id.editText1);
            Button btn = FindViewById<Button>(Resource.Id.button1);
            res = FindViewById<TextView>(Resource.Id.textView1);
            btn.Click += Btn_Click;
          
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            String s = Edi.Text.ToString();
            res.Text = "Bienvenidos al xamarin Dev day " + s;


        }
    }
}

