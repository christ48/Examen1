using Fronend.Helpers.Interfaces;

namespace Fronend.Helpers.Implementations
{
    public class ServiceRepository : IServiceRepository

    {
        public HttpClient Cliente { get; set; }
        
        public ServiceRepository(HttpClient _client,IConfiguration configuration) {
        
            Cliente = _client;
            string baseUrl = configuration.GetValue<string>("BackEnd:Url");
           
            Cliente.BaseAddress = new Uri(baseUrl);
        
        
        }
        
        public HttpResponseMessage DeleteResponse(string url)
        {
            return Cliente.DeleteAsync(url).Result;
        }

        public HttpResponseMessage GetResponse(string url)
        {
            return Cliente.GetAsync(url).Result;
        }

        public HttpResponseMessage PostResponse(string url, object model)
        {
           return Cliente.PostAsJsonAsync(url, model).Result;
        }

        public HttpResponseMessage PutResponse(string url, object model)
        {
            return Cliente.PutAsJsonAsync(url, model).Result;
        }
    }
}
