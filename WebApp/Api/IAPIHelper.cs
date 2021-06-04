using System.Net.Http;

namespace WebApp.Api
{
    public interface IAPIHelper
    {
        HttpClient ApiClient { get; }
    }
}