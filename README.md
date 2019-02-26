# PocPCFService
Hello world net.tcp service.

Three projects are contained in the solution:

1. PocPCFService
2. PocPCFService.Consumer
3. PocPCFService.Host

### PocPCFService
This WCF Library project contains the service contract and implementation for an IPocPCFService.

### PocPCFService.Host
This WCF Application project references the PocPCFService project and provides a host for the service defined in the WCF Library.
The web.config in this project should be modified for testing hosting scenarios.  
There is a rudamentary transform provided for web.config.release for publishing to CF.

### PocPCFService.Consumer
This is an ASP.NET WebApi project whose `ValuesController` calls the endpoint hosted by *PocPCFService.Host*.  
This project references the PocPCFService WCF Library and uses the shared interface IPocPCFService to define a service client.
The web.config in this project should have the endpoint defined in `system.serviceModel/client` pointed at the service under test.  

