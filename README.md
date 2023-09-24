# dotnet-bol-example

Example implementation of the National Motor Freight Traffic Association's Digital LTL Council eBill of Lading specification.

## Reference Documentation

* To run and test locally, you will need to set your PostgreSQL server connection and Auth0 domain/issuer variables in your .vscode/launch.json within the configurations block, as such:
```
"env": {
                "ASPNETCORE_ENVIRONMENT": "Development",
                "pgConnectionString" : "<connectionstring>",
                "jwtAuthority" : "<Auth0 Authority>",
                "jwtAudience" : "<Auth0 Audience>"
            },
```

## Prerequisites
The following components are needed for development of these functions.

* [.NET 7 SDK](https://dotnet.microsoft.com/download)
* [Azure CLI version 2.4 or later](https://learn.microsoft.com/en-us/cli/azure/install-azure-cli)

## Dependencies
The following components are used:
* JwtBearers
* EntityFrameworkCore
* The community-maintained PostgreSQL EntityFramework library
* Swagger / Swashbuckle
* Dynamic Linq Libraries
