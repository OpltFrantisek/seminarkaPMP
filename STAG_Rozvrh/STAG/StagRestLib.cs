using RestSharp;
using RestSharp.Authenticators;

namespace STAG_Rozvrh.STAG
{
    public enum STAGRequestResponseType
    {
        XML,
        JSON,
        XLS,
        CSV
    }
    public static class STAGSchool
    {
        public static string Ujep => @"https://ws.ujep.cz";
    }
    public static class STAGRequest
    {
        public static string GetRozvrhByStudent => @"/ws/services/rest/rozvrhy/getRozvrhByStudent";         
    }

    public static class StagRestLib
    {
        static RestClient client;
        public static  HttpBasicAuthenticator Auth(string login, string pass) => new HttpBasicAuthenticator(login, pass);
        public static Rozvrh Download(HttpBasicAuthenticator auth,string osCislo,string school,string request)
        {
            client = new RestClient(school);
            client.Authenticator = auth;         
            string fullURL = request + "?" + string.Format("stagUser={0}&semestr=LS&outputFormat=json&osCislo={0}", osCislo);
            var restRequest = new RestRequest(fullURL, Method.POST);
            IRestResponse response = client.Execute(restRequest);
            var content = response.Content;
            int a = 1;
            return null;
        }
       
    }
}