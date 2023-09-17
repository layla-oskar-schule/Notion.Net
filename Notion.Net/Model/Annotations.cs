using System;
using Newtonsoft.Json;

namespace Notion.Net.Model
{
	public class Annotations : NotionModel
	{
        [JsonProperty("bold")]
        public bool Bold { get; set; }
        [JsonProperty("italic")]
        public bool Italic { get; set; }
        [JsonProperty("strikethrough")]
        public bool Strikethrough { get; set; }
        [JsonProperty("underline")]
        public bool Underline { get; set; }
        [JsonProperty("code")]
        public bool Code { get; set; }
        [JsonProperty("color", Required = Required.Always)]
        public string Color { get; set; }

        public Annotations()
		{
		}
	}
}

