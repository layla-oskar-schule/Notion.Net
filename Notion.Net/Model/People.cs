using System;
using Newtonsoft.Json;

namespace Notion.Net.Model
{
	public class People : User
	{
		[JsonProperty("person.email", Required = Required.Always)]
		public string Email { get; set; }

		public People()
		{
		}
	}
}

