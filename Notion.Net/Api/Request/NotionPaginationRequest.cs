using System;
using Newtonsoft.Json;

namespace Notion.Net.Api.Request
{
	public class NotionPaginationRequest : NotionRequest
	{
		[JsonProperty("page_size", Required = Required.Default)]	
		public int PageSize { get; set; }

		[JsonProperty("start_cursor", Required = Required.Default)]
		public string StartCursor { get; set; }
	}
}

