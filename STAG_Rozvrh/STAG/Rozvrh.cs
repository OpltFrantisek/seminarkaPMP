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

using Newtonsoft.Json;

namespace STAG_Rozvrh
{
    public class Ucitel
    {

        [JsonProperty("ucitIdno")]
        public int ucitIdno { get; set; }

        [JsonProperty("jmeno")]
        public string jmeno { get; set; }

        [JsonProperty("prijmeni")]
        public string prijmeni { get; set; }

        [JsonProperty("titulPred")]
        public string titulPred { get; set; }

        [JsonProperty("titulZa")]
        public string titulZa { get; set; }

        [JsonProperty("platnost")]
        public string platnost { get; set; }

        [JsonProperty("zamestnanec")]
        public string zamestnanec { get; set; }
    }

    public class HodinaSkutOd
    {

        [JsonProperty("value")]
        public string value { get; set; }
    }

    public class HodinaSkutDo
    {

        [JsonProperty("value")]
        public string value { get; set; }
    }

    public class Datum
    {

        [JsonProperty("value")]
        public string value { get; set; }
    }

    public class DatumOd
    {

        [JsonProperty("value")]
        public string value { get; set; }
    }

    public class DatumDo
    {

        [JsonProperty("value")]
        public string value { get; set; }
    }

    public class RozvrhovaAkce
    {

        [JsonProperty("roakIdno")]
        public int? roakIdno { get; set; }

        [JsonProperty("nazev")]
        public string nazev { get; set; }

        [JsonProperty("katedra")]
        public string katedra { get; set; }

        [JsonProperty("predmet")]
        public string predmet { get; set; }

        [JsonProperty("statut")]
        public string statut { get; set; }

        [JsonProperty("ucitIdno")]
        public int? ucitIdno { get; set; }

        [JsonProperty("ucitel")]
        public Ucitel ucitel { get; set; }

        [JsonProperty("rok")]
        public string rok { get; set; }

        [JsonProperty("budova")]
        public string budova { get; set; }

        [JsonProperty("mistnost")]
        public string mistnost { get; set; }

        [JsonProperty("kapacitaMistnosti")]
        public int? kapacitaMistnosti { get; set; }

        [JsonProperty("planObsazeni")]
        public int? planObsazeni { get; set; }

        [JsonProperty("obsazeni")]
        public int obsazeni { get; set; }

        [JsonProperty("typAkce")]
        public string typAkce { get; set; }

        [JsonProperty("typAkceZkr")]
        public string typAkceZkr { get; set; }

        [JsonProperty("semestr")]
        public string semestr { get; set; }

        [JsonProperty("platnost")]
        public string platnost { get; set; }

        [JsonProperty("den")]
        public string den { get; set; }

        [JsonProperty("denZkr")]
        public string denZkr { get; set; }

        [JsonProperty("hodinaOd")]
        public int? hodinaOd { get; set; }

        [JsonProperty("hodinaDo")]
        public int? hodinaDo { get; set; }

        [JsonProperty("hodinaSkutOd")]
        public HodinaSkutOd hodinaSkutOd { get; set; }

        [JsonProperty("hodinaSkutDo")]
        public HodinaSkutDo hodinaSkutDo { get; set; }

        [JsonProperty("tydenOd")]
        public int tydenOd { get; set; }

        [JsonProperty("tydenDo")]
        public int tydenDo { get; set; }

        [JsonProperty("tyden")]
        public string tyden { get; set; }

        [JsonProperty("tydenZkr")]
        public string tydenZkr { get; set; }

        [JsonProperty("grupIdno")]
        public object grupIdno { get; set; }

        [JsonProperty("jeNadrazena")]
        public string jeNadrazena { get; set; }

        [JsonProperty("maNadrazenou")]
        public string maNadrazenou { get; set; }

        [JsonProperty("kontakt")]
        public string kontakt { get; set; }

        [JsonProperty("krouzky")]
        public string krouzky { get; set; }

        [JsonProperty("casovaRada")]
        public string casovaRada { get; set; }

        [JsonProperty("datum")]
        public Datum datum { get; set; }

        [JsonProperty("datumOd")]
        public DatumOd datumOd { get; set; }

        [JsonProperty("datumDo")]
        public DatumDo datumDo { get; set; }

        [JsonProperty("druhAkce")]
        public string druhAkce { get; set; }

        [JsonProperty("vsichniUciteleUcitIdno")]
        public string vsichniUciteleUcitIdno { get; set; }

        [JsonProperty("vsichniUciteleJmenaTituly")]
        public string vsichniUciteleJmenaTituly { get; set; }

        [JsonProperty("vsichniUcitelePrijmeni")]
        public string vsichniUcitelePrijmeni { get; set; }

        [JsonProperty("referencedIdno")]
        public int referencedIdno { get; set; }

        [JsonProperty("poznamkaRozvrhare")]
        public object poznamkaRozvrhare { get; set; }

        [JsonProperty("nekonaSe")]
        public object nekonaSe { get; set; }

        [JsonProperty("owner")]
        public string owner { get; set; }

        [JsonProperty("zakazaneAkce")]
        public string zakazaneAkce { get; set; }

        [JsonProperty("vyucJazyk")]
        public object vyucJazyk { get; set; }
    }

    public class Rozvrh
    {

        [JsonProperty("rozvrhovaAkce")]
        public IList<RozvrhovaAkce> rozvrhovaAkce { get; set; }
    }


}