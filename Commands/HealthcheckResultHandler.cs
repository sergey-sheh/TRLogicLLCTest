
using System;

namespace MyBinary.Commands
{
    public class HealthcheckResultHandler : IHealthcheckResultHandler
    {
        public void Handle(HealthcheckResult request){
            Console.WriteLine($"Checking '{request.Url}'. Result: {(request.Status == 200? "OK" : "ERR")}({request.Status})");
        }
    }
    public interface IHealthcheckResultHandler{
        void Handle(HealthcheckResult request);
    }
}