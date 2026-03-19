namespace WebApi.Settings
{
    public class ChatApiSettings
    {
        public static string BaseUrl { get; } = "https://penrouter.ai/api/v1/chat/complections";
        public static string ApiKey { get; } = "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";
        public static string DefoultModel { get; } = "gpt-3.5-turbo";
    }
}
