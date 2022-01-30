using System.Threading.Tasks;
using Grpc.Net.Client;
using GrpcGreeterClient;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

using var channel = GrpcChannel.ForAddress("https://localhost:7021");
var client = new Greeter.GreeterClient(channel);
var helloRequest = new HelloRequest { Name = "Nitin" };
var reply = await client.SayHelloAsync(helloRequest);
Console.WriteLine($"Greeting :{reply.Message}");

var greetReply = await client.GreetWithTimeAsync(helloRequest);
Console.WriteLine($"{greetReply.GreetingOfDay}\nToday is {greetReply.Day}, {greetReply.Time}\n{greetReply.ExtraMessage}");
Console.ReadKey();

