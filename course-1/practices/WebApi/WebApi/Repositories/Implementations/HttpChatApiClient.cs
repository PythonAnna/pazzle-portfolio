using System.Net.Http.Headers;
using WebApi.Repositories.Interfaces;
using WebApi.Repositories.Models;
using WebApi.Settings;

namespace WebApi.Repositories.Implementations
{
    public class HttpChatApiClient: IChatApiClient
    {
        private readonly HttpClient _httpClient;
        public HttpChatApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri(ChatApiSettings.BaseUrl);
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", ChatApiSettings.ApiKey);
        }
        public async Task<string> SendMessageAsync(string userMessage)
        {
            var payload = new OpenApiRequest()
            {
                Model = ChatApiSettings.DefoultModel,
                Messages = new List<OpenApiResponse.Message>{new()
                    {Role = "user",Content = userMessage} },
                MaxTokens = 1000
            };
            var response = await _httpClient.PostAsJsonAsync("", payload);
            response.EnsureSuccessStatusCode();
            var body = await
                response.Content.ReadFromJsonAsync<OpenApiResponse?>();
            if (body?.Choices != null && body.Choices.Length > 0)
            {
                return body.Choices[0].Message.Content;
            }
            return await response.Content.ReadAsStringAsync();
        }
    }
}
