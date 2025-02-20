using BlazorAppClient.Models;
using Microsoft.JSInterop;
using System.Net.Http.Json;

namespace BlazorAppClient.Services
{
    public class AuthenticationService
    {
        private readonly HttpClient _httpClient;
        private readonly IJSRuntime _jsruntime;
        public AuthenticationService(HttpClient httpClient, IJSRuntime jsRuntime) 
        {
          _httpClient = httpClient;
            _jsruntime = jsRuntime;
        }

        public async Task<Response<bool>> RegisterAsync(RegisterDTO registerDTO)
        {
            var response = await _httpClient.PostAsJsonAsync("https://dev1.tenzingtechnologies.com/Authenticate/Register", registerDTO);
            return await response.Content.ReadFromJsonAsync<Response<bool>>();
        }
    }

    
}
