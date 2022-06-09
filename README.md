# koobits-peer-challenge-service

isolated peer challenge service from koobits-core

## Technologies
* asp net core (.net 5.0)
* entity framework core (.net 5.0)
* docker
* serilog
* identity server
* tinymapper
* postgresql

## Project Overview
using clean architecture

### Domain
This will contain all entities, enums, exceptions, interfaces, types and logic specific to the domain layer.

### Application

This layer contains all application logic. It is dependent on the domain layer, but has no dependencies on any other layer or project. This layer defines interfaces that are implemented by outside layers. For example, if the application need to access a notification service, a new interface would be added to application and an implementation would be created within infrastructure.

### Infrastructure

This layer contains classes for accessing external resources such as file systems, web services, smtp, and so on. These classes should be based on interfaces defined within the application layer.
noted: for current project structure, also implement application services in this layer

### Api
This layer is a asp net core web api project. This layer depends on both the Application and Infrastructure layers, however, the dependency on Infrastructure is only to support dependency injection. Therefore only Startup.cs should reference Infrastructure.


## refactor principle (1 stage)
1. abandon repository pattern and use dbcontext 
2. only return the necessary data as response
3. use transaction to commit the changes
4. reduces db query counts as we can
5. paging response data(to be confirmed)

## discussions
1. business logic service currently in infra project, but it should be in application project, but we don't have idbcontext interfact for these dbcontext for now


## TODO List
- [ ] project setup
  - [ ] folder structure
  - [ ] dummy endpoints
  - [ ] api versioning
- [ ] authentication with identity service
- [ ] serilog setting(local and aws s3 sink) 
- [ ] cors setting
- [ ] exeception handling (with extended controller, considering using middleware pattern)
- [ ] dockerize this app
- [ ] migrate existing code (koobit-core and koobits-service)
- [ ] di settings and draft version setup
- [ ] remove repository pattern for all services
- [ ] refactor dailychallenge fro performance tuning
- [ ] remove dependency of IUserLoggedIn and get user id from request params
- [ ] setup ci pipeline(with azure devops or aws)
- [ ] migrate existing db tables to standalone db
