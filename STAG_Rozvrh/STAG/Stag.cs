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
using RestSharp.Authenticators;

namespace STAG_Rozvrh.STAG
{
    class Stag
    {
        
        public static Rozvrh Download(string login,string pass)
        {
            var authenticator = StagRestLib.Auth(login, pass);
            var neco = StagRestLib.Download(StagRestLib.Auth(login, pass), "F15183", STAGSchool.Ujep, STAGRequest.GetRozvrhByStudent);
            return null;
        }
        public static Rozvrh Load()
        {
            return null;
        }
    }
  
}