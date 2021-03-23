# TRLogicLLCTest
# README

## Docs:
[Specification](SPECIFICATION.md)

## Build:
> docker build -t mybinary .
## Run:
> docker run --rm mybinary 2 http://example.com/

*Result: Checking 'http://example.com/'. Result: OK(200)*

> docker run --rm mybinary 1 http://httpstat.us/500

*Result: Checking 'http://httpstat.us/500'. Result: ERR(500)*

> docker run --rm mybinary 1 http://httpstat.us/503 

*Result: Checking 'http://httpstat.us/503'. Result: ERR(503)*

> docker run --rm mybinary 1 this_is_not_an_url

*Result: URL parsing error*

> docker run --rm mybinary -1 http://example.com/

*Result: The first argument must be a integer in the range 1 to 2147483647*

> docker run --rm mybinary a http://example.com/

*Result: The first argument must be a integer*

> docker run --rm mybinary 1 http://example.com/ 1

> docker run --rm mybinary 1

*Result: The number of arguments is not a format of two*

**Enjoy!**
