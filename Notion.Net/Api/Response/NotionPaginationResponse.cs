using System;
using Newtonsoft.Json;
using Notion.Net.Api.Model;

namespace Notion.Net.Api.Response
{
	public class NotionPaginationResponse<T> : NotionResponse where T : NotionModel
	{
		[JsonProperty("has_more", Required = Required.Always)]
		public bool HasMore { get; set; }

		[JsonProperty("next_cursor", Required = Required.Always)]
		public string NextCursor { get; set; }

		[JsonProperty("results", Required = Required.Always)]
		public T[] Results { get; set; }
		
	}
}

