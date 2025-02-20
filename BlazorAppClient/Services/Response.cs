namespace BlazorAppClient.Services
{
    public class Response<T>
    {
        public bool IsSuccess { get; set; }
        public int StatusCode { get; set; }
        public string? Message { get; set; }
        public T? Result { get; set; }
    }
}