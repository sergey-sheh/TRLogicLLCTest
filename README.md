# TRLogicLLCTest
# README
## Run:
> dotnet run 2 http://example.com/

*Result: Checking 'http://example.com/'. Result: OK(200)*

> dotnet run 1 http://httpstat.us/500

*Result: Checking 'http://httpstat.us/500'. Result: ERR(500)*

> dotnet run 1 http://httpstat.us/503 

*Result: Checking 'http://httpstat.us/503'. Result: ERR(503)*

> dotnet run 1 this_is_not_an_url

*Result: URL parsing error*

> dotnet run -1 http://example.com/

*Result: The first argument must be a number in the range 1 to 2147483647*

> dotnet run a http://example.com/

*Result: The first argument must be a number in the range 1 to 2147483647*

> dotnet run 1 http://example.com/ 1

*Result: The number of arguments is not a format of two*
**Enjoy!**
