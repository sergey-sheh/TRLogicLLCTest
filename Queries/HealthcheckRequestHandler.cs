using System;

namespace MyBinary.Queries
{
    public class HealthcheckRequestHandler : IHealthcheckRequestHandler
    {
        public HealthcheckRequest Handle(string[] requests){
            try{
                if(requests.Length != 2){
                    throw new ArgumentOutOfRangeException("The number of arguments is not a format of two");
                }
                int interval = Convert.ToInt32(requests[0]);
                if(interval < 1){
                    throw new ArgumentOutOfRangeException($"The first argument must be a number in the range 1 to {int.MaxValue}");
                }
                return new HealthcheckRequest(){
                    Interval = interval,
                    Url = requests[1]
                };
            }
            catch(FormatException e){
                throw new FormatException($"The first argument must be a number in the range 1 to {int.MaxValue}", e);
            }
            
            
        }
    }
    public interface IHealthcheckRequestHandler{
        HealthcheckRequest Handle(string[] requests);
    }
}