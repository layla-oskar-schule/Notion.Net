using RestSharp;
using RestSharp.Authenticators.OAuth2;

namespace Notion.Net
{
	using Utils;

	public class NotionClient : RestClient
	{
		public NotionClient(string token) : base(new RestClientOptions(Constants.NOTION_BASE_URL)
        {
            Authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator(token, "Bearer")

        })
		{

		}


	}
}

