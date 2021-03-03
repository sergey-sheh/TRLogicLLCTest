using System;
using System.Threading.Tasks;
using MyBinary.Commands;
using MyBinary.Queries;

namespace MyBinary
{
    class Program
    {
        static async Task Main(string[] args){
            var healthcheckHandler = new HealthcheckHandler();
            var getHealthcheckRequestHandler = new GetHealthcheckRequestHandler();
            try{
                await healthcheckHandler.Handle(getHealthcheckRequestHandler.Handle(new GetHealthcheckRequest(){ Args = args }));
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
    }
}
 