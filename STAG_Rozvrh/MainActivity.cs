using Android.App;
using Android.Widget;
using Android.OS;

namespace STAG_Rozvrh
{
    [Activity(Label = "STAG_Rozvrh", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            var tlacitkoPotvrdit = FindViewById<Button>(Resource.Id.Prihlasit);
            var login = FindViewById<EditText>(Resource.Id.editTextLogin);
            var pass = FindViewById<EditText>(Resource.Id.editTextPassword);

            tlacitkoPotvrdit.Click += (sender, e) =>
            {
                STAG.Stag.Download(login.Text, pass.Text);
            };
        }
    }
}

