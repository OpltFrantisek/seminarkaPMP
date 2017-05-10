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
        string[] dnyVTydnu = { "Po", "Út", "St", "Èt", "Pá" };
        Dictionary<string, List<RozvrhovaAkce>> akce = new Dictionary<string, List<RozvrhovaAkce>>();
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

           var i = Convert.ToInt32(Intent.GetStringExtra("i"));
           var semestr = Intent.GetStringExtra("Sem");
           var rozvrh = (Rozvrh)hellperClass.SharedClass.sharedObject[i];

            var neco = (from dny in dnyVTydnu select (from akce in rozvrh.rozvrhovaAkce where akce.denZkr == dny && akce.semestr == semestr select akce).ToList()).ToDictionary(x => x.Count != 0? x[0].denZkr:"null" ,x => x);

            /*
               akce.Add("Po", (from akce in rozvrh.rozvrhovaAkce where akce.denZkr == "Po" && akce.semestr == semestr select akce).ToList());
               akce.Add("Ut", (from akce in rozvrh.rozvrhovaAkce where akce.denZkr == "Ut" && akce.semestr == semestr select akce).ToList());
               akce.Add("St", (from akce in rozvrh.rozvrhovaAkce where akce.denZkr == "St" && akce.semestr == semestr select akce).ToList());
               akce.Add("Ct", (from akce in rozvrh.rozvrhovaAkce where akce.denZkr == "Ct" && akce.semestr == semestr select akce).ToList());
               akce.Add("Pa", (from akce in rozvrh.rozvrhovaAkce where akce.denZkr == "Pa" && akce.semestr == semestr select akce).ToList());

            */
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