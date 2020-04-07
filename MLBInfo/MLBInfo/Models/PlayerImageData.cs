using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MLBInfo.Models
{
    public class PlayerImage
    {

        [JsonProperty("idPlayer")]
        public string IdPlayer { get; set; }

        [JsonProperty("idTeam")]
        public string IdTeam { get; set; }

        [JsonProperty("idTeam2")]
        public object IdTeam2 { get; set; }

        [JsonProperty("idTeamNational")]
        public object IdTeamNational { get; set; }

        [JsonProperty("idSoccerXML")]
        public object IdSoccerXML { get; set; }

        [JsonProperty("idAPIfootball")]
        public object IdAPIfootball { get; set; }

        [JsonProperty("idPlayerManager")]
        public object IdPlayerManager { get; set; }

        [JsonProperty("strNationality")]
        public string StrNationality { get; set; }

        [JsonProperty("strPlayer")]
        public string StrPlayer { get; set; }

        [JsonProperty("strTeam")]
        public string StrTeam { get; set; }

        [JsonProperty("strTeam2")]
        public object StrTeam2 { get; set; }

        [JsonProperty("strSport")]
        public string StrSport { get; set; }

        [JsonProperty("intSoccerXMLTeamID")]
        public object IntSoccerXMLTeamID { get; set; }

        [JsonProperty("dateBorn")]
        public string DateBorn { get; set; }

        [JsonProperty("strNumber")]
        public object StrNumber { get; set; }

        [JsonProperty("dateSigned")]
        public object DateSigned { get; set; }

        [JsonProperty("strSigning")]
        public string StrSigning { get; set; }

        [JsonProperty("strWage")]
        public string StrWage { get; set; }

        [JsonProperty("strOutfitter")]
        public object StrOutfitter { get; set; }

        [JsonProperty("strKit")]
        public object StrKit { get; set; }

        [JsonProperty("strAgent")]
        public object StrAgent { get; set; }

        [JsonProperty("strBirthLocation")]
        public string StrBirthLocation { get; set; }

        [JsonProperty("strDescriptionEN")]
        public string StrDescriptionEN { get; set; }

        [JsonProperty("strDescriptionDE")]
        public object StrDescriptionDE { get; set; }

        [JsonProperty("strDescriptionFR")]
        public object StrDescriptionFR { get; set; }

        [JsonProperty("strDescriptionCN")]
        public object StrDescriptionCN { get; set; }

        [JsonProperty("strDescriptionIT")]
        public object StrDescriptionIT { get; set; }

        [JsonProperty("strDescriptionJP")]
        public object StrDescriptionJP { get; set; }

        [JsonProperty("strDescriptionRU")]
        public object StrDescriptionRU { get; set; }

        [JsonProperty("strDescriptionES")]
        public object StrDescriptionES { get; set; }

        [JsonProperty("strDescriptionPT")]
        public object StrDescriptionPT { get; set; }

        [JsonProperty("strDescriptionSE")]
        public object StrDescriptionSE { get; set; }

        [JsonProperty("strDescriptionNL")]
        public object StrDescriptionNL { get; set; }

        [JsonProperty("strDescriptionHU")]
        public object StrDescriptionHU { get; set; }

        [JsonProperty("strDescriptionNO")]
        public object StrDescriptionNO { get; set; }

        [JsonProperty("strDescriptionIL")]
        public object StrDescriptionIL { get; set; }

        [JsonProperty("strDescriptionPL")]
        public object StrDescriptionPL { get; set; }

        [JsonProperty("strGender")]
        public string StrGender { get; set; }

        [JsonProperty("strSide")]
        public object StrSide { get; set; }

        [JsonProperty("strPosition")]
        public string StrPosition { get; set; }

        [JsonProperty("strCollege")]
        public object StrCollege { get; set; }

        [JsonProperty("strFacebook")]
        public string StrFacebook { get; set; }

        [JsonProperty("strWebsite")]
        public string StrWebsite { get; set; }

        [JsonProperty("strTwitter")]
        public string StrTwitter { get; set; }

        [JsonProperty("strInstagram")]
        public string StrInstagram { get; set; }

        [JsonProperty("strYoutube")]
        public string StrYoutube { get; set; }

        [JsonProperty("strHeight")]
        public string StrHeight { get; set; }

        [JsonProperty("strWeight")]
        public string StrWeight { get; set; }

        [JsonProperty("intLoved")]
        public string IntLoved { get; set; }

        [JsonProperty("strThumb")]
        public string StrThumb { get; set; }

        [JsonProperty("strCutout")]
        public string StrCutout { get; set; }

        [JsonProperty("strRender")]
        public object StrRender { get; set; }

        [JsonProperty("strBanner")]
        public object StrBanner { get; set; }

        [JsonProperty("strFanart1")]
        public object StrFanart1 { get; set; }

        [JsonProperty("strFanart2")]
        public object StrFanart2 { get; set; }

        [JsonProperty("strFanart3")]
        public object StrFanart3 { get; set; }

        [JsonProperty("strFanart4")]
        public object StrFanart4 { get; set; }

        [JsonProperty("strCreativeCommons")]
        public object StrCreativeCommons { get; set; }

        [JsonProperty("strLocked")]
        public string StrLocked { get; set; }
    }

    public class PlayerImageData
    {

        [JsonProperty("player")]
        public IList<PlayerImage> PlayerImage { get; set; }
    }


}
