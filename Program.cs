using System;
using System.Threading.Tasks;
using MyBinary.Commands;
using MyBinary.Queries;

namespace MyBinary
{
    class Program
    {
        static async Task Main(string[] args) => await MainAsync(args);
        private static async Task MainAsync(string[] args){
            var healthcheckHandler = new HealthcheckHandler();
            var healthcheckRequestHandler = new HealthcheckRequestHandler();
            try{
                await healthcheckHandler.Handle(healthcheckRequestHandler.Handle(args));
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
    }
}
 