using Newtonsoft.Json;

namespace Notion.Net.Model
{
	public class Database : NotionModel
	{
		[JsonProperty("id", Required = Required.Always)]
		public string Id { get; set; }
        [JsonProperty("created_time", Required = Required.Always)]
        public DateTime CreatedTime { get; set; }
		[JsonProperty("created_by", Required = Required.Always)]
		public User User { get; set; }
	}
}

