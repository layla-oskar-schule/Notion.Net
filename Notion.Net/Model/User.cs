using System;
using Newtonsoft.Json;

namespace Notion.Net.Model
{
	public class User
	{

		[JsonProperty("id", Required = Required.Always)]
		public string Id { get; set; }

		[JsonProperty("name", Required = Required.Always)]
		public string Name { get; set; }

        [JsonProperty("avatar_url", Required = Required.Always)]
        public string AvatarUrl { get; set; }

        public User()
		{
		}
	}
}

