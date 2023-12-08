using Grpc.Core;
using Grpc.Net.Client;
using GrpcGreeter;

using static System.Console;

// The port number must match the port of the gRPC server.
var port = Environment.GetEnvironmentVariable("DAPR_GRPC_PORT") ?? "5062";
var address = $"http://localhost:{port}";
WriteLine($"Connecting to {address}...");
using var channel = GrpcChannel.ForAddress(address);
var client = new Greeter.GreeterClient(channel);

var metadata = new Metadata { { "dapr-app-id", "server" } };
var reply = await client.SayHelloAsync(
                  new HelloRequest { Name = "GreeterClient" }, metadata);
WriteLine("Greeting: " + reply.Message);