# Lucas Technology Solution


## High level architecture
![hexog](https://user-images.githubusercontent.com/13305576/142688722-03c02ab9-8480-4d44-84ee-62900883bffa.jpg)

## Build Status
| Build server    | Platform       | Status      |
|-----------------|----------------|-------------|
| Azure Pipelines | All            |[![Build Status](https://simplcommerce.visualstudio.com/simplcommerce/_apis/build/status/simplcommerce.SimplCommerce?branchName=master)](https://simplcommerce.visualstudio.com/simplcommerce/_build/latest?definitionId=1&branchName=master)
|Travis           | Linux / MacOS  |[![Build Status](https://travis-ci.org/simplcommerce/SimplCommerce.svg?branch=master)](https://travis-ci.org/simplcommerce/SimplCommerce) |



## Lucas Technology Solution is built based on:

* ASP NET Core 5.0
* Blazor App
* Architecture Driven Microservices
* MediatR 7.0.0 for domain event

### The application is divided into modules. Each module contains all the stuff for itself to run including Controllers, Services, Views and even static files. If a module is no longer need, you can simply just delete it by a single click.

### The LucastechnologyServices.ErpBlazor is the ASP.NET Core project and acts as the host. It will bootstrap the app and load all the modules it found in the modules.json. The source code of modules are placed outside the WebHost, in the /src/Modules folder. .
