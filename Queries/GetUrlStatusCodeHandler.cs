using System;
using System.Net.Http;
using System.Threading.Tasks;
using MyBinary.Commands;

namespace MyBinary.Queries
{
    public class GetUrlStatusCodeHandler : IGetUrlStatusCodeHandler
    {
        public async Task<int> Handle(Healthcheck request){
            var client = new HttpClient();
            try{
                var response = await client.GetAsync(request.Url);
                return (int)response.StatusCode;
            }
            catch(InvalidOperationException){
                throw new InvalidOperationException("URL parsing error");
            }
            finally{
                client.Dispose();
            }
            
        }
    }
    public interface IGetUrlStatusCodeHandler
    {
        Task<int> Handle(Healthcheck request);
    }
}