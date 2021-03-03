using System.Threading;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using MyBinary.Queries;

namespace MyBinary.Commands
{
    public class HealthcheckHandler
    {
        public IGetUrlStatusCodeHandler getUrlStatusCodeHandler { get; set; }
        public IHealthcheckResultHandler healthcheckResultHandler { get; set; }
        public HealthcheckHandler()
        {
            this.getUrlStatusCodeHandler = new GetUrlStatusCodeHandler();
            this.healthcheckResultHandler = new HealthcheckResultHandler();
        }
        public async Task Handle(GetHealthcheckRequest request){
            while(true){
                healthcheckResultHandler.Handle(new HealthcheckResult(){
                    Url = request.Url,
                    Status = await getUrlStatusCodeHandler.Handle(request)
                });
                Thread.Sleep(request.Interval * 1000);
            }
        }
    }
}