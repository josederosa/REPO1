using System.Text.Json;

namespace WebConAPI.Client
{
    public class TokenAdmin
    {
        private static string _token=null;
        public static HttpClient Client =new();

        
        public static async Task<string>  Get()
        {
            if (_token is null)
            {
               await GetToken();
            }

            return _token;
        }

        public static async Task GetToken()
        {
            var _content = new FormUrlEncodedContent(new[]
            {
                   new KeyValuePair<string, string>("grant_type", "password"),
                   new KeyValuePair<string, string>("username", "bascswebapi"),
                   new KeyValuePair<string, string>("password","b4scsw4"),
                   new KeyValuePair<string, string>("client_id", "api" ),
                   new KeyValuePair<string, string>("client_secret", "secret" )
    });


            var _response = await Client.PostAsync("https://intranet.bas.com.ar/bascsapiv02/auth/token", _content);
            if (_response.IsSuccessStatusCode)
            {
                var _tokenResponse = await _response.Content.ReadAsStringAsync();
                JsonToken JsonToken = JsonSerializer.Deserialize<JsonToken>(_tokenResponse);
                _token = JsonToken.access_token;
            }
                      
        }

        public class JsonToken
        {
            public string access_token { get; set; }
            public string token_type { get; set; }
            public int expires_in { get; set; }
            public string refresh_token { get; set; }
        }
    }
}



