# Service to Service invocation with gRPC

Server

```shell
# Run Dapr with the gRPC service on port 5062 and with the app ID 'server'
dapr run -a server -p 5062 -P grpc -- dotnet run
```

Client

```shell
dapr run -a client -P grpc -- dotnet run
```
