using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using System;

namespace STAG_Rozvrh
{
    [Activity(Label = "STAG_Rozvrh", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        static Rozvrh rozvrh;
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
               rozvrh = STAG.Stag.Download(login.Text, pass.Text);
            };

            Button showPopupMenu = FindViewById<Button>(Resource.Id.popupButton);
            showPopupMenu.Click += (sender, arg) => {
                PopupMenu menu = new PopupMenu(this, showPopupMenu);
                menu.Inflate(Resource.Menu.menu);
                menu.MenuItemClick += Menu_MenuItemClick;
                menu.Show();
            };
           
        }

        private void Menu_MenuItemClick(object sender, PopupMenu.MenuItemClickEventArgs e)
        {
            switch (e.Item.ItemId)
            {
                case Resource.Id.item1:
                    var intent = new Intent(this, typeof(ShowRozvrhActivity));
                    var data = new Bundle();
                    int i = AddObject(rozvrh);
                    intent.PutExtra("i",i);
                    StartActivity(intent);
                    ; break;
                case Resource.Id.item2:
                    intent = new Intent(this, typeof(TerminyActivity));
                    StartActivity(intent); ; break;
                case Resource.Id.item3:;break;
            }
        }

        private int AddObject(object item)
        {
            if (hellperClass.SharedClass.sharedObject == null)
                hellperClass.SharedClass.sharedObject = new System.Collections.Generic.List<object>();
            hellperClass.SharedClass.sharedObject.Add(item);
            return hellperClass.SharedClass.sharedObject.IndexOf(item);
        }
    }
}

