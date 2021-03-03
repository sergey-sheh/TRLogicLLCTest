using System;

namespace MyBinary.Queries
{
    public class GetHealthcheckRequestHandler
    {
        public GetHealthcheckRequest Handle(string[] requests){
            try{
                if(requests.Length != 2){
                    throw new ArgumentOutOfRangeException("The number of arguments is not a format of two");
                }
                int interval = Convert.ToInt32(requests[0]);
                if(interval < 1){
                    throw new ArgumentOutOfRangeException($"The first argument must be a integer in the range 1 to {int.MaxValue}");
                }
                return new GetHealthcheckRequest(){
                    Interval = interval,
                    Url = requests[1]
                };
            }
            catch(FormatException e){
                throw new FormatException($"The first argument must be a integer", e);
            }
            
            
        }
    }
}