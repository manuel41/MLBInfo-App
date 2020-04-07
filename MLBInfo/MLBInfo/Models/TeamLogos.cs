using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace MLBInfo.Models
{
    public class Parameters
    {

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class Country
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("flag")]
        public string Flag { get; set; }
    }

    public class Response
    {
        [JsonIgnore]
        private string teamName;
        [JsonIgnore]
        public string TeamName
        {
            get
            {
                teamName = this.Name.Replace(" ", "");
                return teamName;
            }
        }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("nationnal")]
        public bool Nationnal { get; set; }

        [JsonProperty("country")]
        public Country Country { get; set; }
    }

    public class TeamLogos
    {

        [JsonIgnore]
        public List<Response> TeamsList
        {
            get
            {
                if (this.Response is JArray list) return list.ToObject<List<Response>>();
                return null;
            }
        }

        [JsonProperty("get")]
        public string Get { get; set; }

        [JsonProperty("parameters")]
        public Parameters Parameters { get; set; }

        [JsonProperty("errors")]
        public IList<object> Errors { get; set; }

        [JsonProperty("results")]
        public int Results { get; set; }

        [JsonProperty("response")]
        public Object Response { get; set; }
    }


}
