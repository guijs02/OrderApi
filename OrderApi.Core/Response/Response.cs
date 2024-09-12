using OrderApi.Core.Config;
using System.Text.Json.Serialization;

namespace OrderApi.Core.Response
{
    public class Response<TData>(TData? data,
    string? message = null,
    int code = Configuration.DefaultStatusCode)
    {
        public TData? Data { get; set; } = data;
        public int StatusCode => code;
        public string? Message { get; set; } = message;
        [JsonIgnore]
        private bool IsSuccess => code is >= 200 and <= 299;
    }
}
