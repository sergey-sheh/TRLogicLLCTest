using System;
using MyBinary.Commands;

namespace MyBinary.Queries
{
    public class GetHealthcheckRequestHandler
    {
        public Healthcheck Handle(GetHealthcheckRequest request){
            try{
                if(request.Args.Length != 2){
                    throw new ArgumentOutOfRangeException("The number of arguments is not a format of two");
                }
                int interval = Convert.ToInt32(request.Args[0]);
                if(interval < 1){
                    throw new ArgumentOutOfRangeException($"The first argument must be a integer in the range 1 to {int.MaxValue}");
                }
                return new Healthcheck(){
                    Interval = interval,
                    Url = request.Args[1]
                };
            }
            catch(FormatException e){
                throw new FormatException($"The first argument must be a integer", e);
            }
            
            
        }
    }
}