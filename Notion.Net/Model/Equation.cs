using System;
using Newtonsoft.Json;

namespace Notion.Net.Model
{
	public class Equation : NotionModel
	{
		[JsonProperty("expression", Required = Required.Always)]
		public string Expression { get; set; }


		public Equation()
		{
		}
	}
}

