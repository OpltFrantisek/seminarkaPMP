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

namespace STAG_Rozvrh
{
    [Activity(Label = "ShowRozvrhActivity")]
    public class ShowRozvrhActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ShowRozvrh);

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
            Intent intent;
            switch (e.Item.ItemId)
            {
                case Resource.Id.item1: ; break;
                case Resource.Id.item2:
                    intent = new Intent(this, typeof(TerminyActivity));
                    StartActivity(intent);
                    ; break;
                case Resource.Id.item3:
                    intent = new Intent(this, typeof(MainActivity));
                    StartActivity(intent);
                    ; break;
            }
        }
    }
}