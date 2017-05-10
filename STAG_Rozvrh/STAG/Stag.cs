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
using StagRestLib;
using System.IO;
using Newtonsoft.Json;

namespace STAG_Rozvrh.STAG
{
    class Stag
    {
        static Auth auth;
        static RestPuller puller;
        static JsonSerializer serializer;
        public static Rozvrh Stahni(string login,string pass,string osCislo)
        {
            
            auth = new Auth("st77219", "Songaa405Tjd");
            puller = new RestPuller(auth);
            return Download_RozvrhByStudent("F15183");                  
        }


        private static Rozvrh Download_RozvrhByStudent(string osCislo)
        {
           // string path = Android.OS.Environment.ExternalStorageDirectory.AbsolutePath;
            var path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
            // string path = Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string file = System.IO.Path.Combine(path, "rozvrh.json");
            string content;
            Rozvrh rozvrh;
            using (var streamWriter = new StreamWriter(file, true))
            {
                var request = STAGRequests.GetRozvrhByStudent;
                request.SetToken("osCislo", osCislo);
                request.AddToken("outputFormat", "json");
                request.AddToken("jenRozvrhoveAkce", "true");
                request.AddToken("vsechnyAkce", "false");

                content = puller.GetResponseContent(request);
                streamWriter.WriteLine(content);
            }
            using (var streamReader = new StreamReader(file))
            {
                JsonSerializer serializer = new JsonSerializer();
                var tmp =  ((List<Rozvrh>)serializer.Deserialize(streamReader, typeof(List<Rozvrh>)))[0];
                rozvrh = tmp;
               // rozvrh = (Rozvrh)serializer.Deserialize(streamReader, typeof(Rozvrh));              
              // System.Diagnostics.Debug.WriteLine(content);
            }
            return rozvrh;
        }
    }
}