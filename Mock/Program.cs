// See https://aka.ms/new-console-template for more information

using System.Net;
using WireMock.Logging;
using WireMock.RequestBuilders;
using WireMock.ResponseBuilders;
using WireMock.Server;
using WireMock.Settings;

var server = WireMockServer.Start(new WireMockServerSettings
{
    Port = 8080,
    Logger = new WireMockConsoleLogger()
});

server.Given(Request.Create().UsingGet().WithPath("/validate"))
    .RespondWith(Response.Create().WithStatusCode(HttpStatusCode.OK));

while (true)
{
    Console.WriteLine($"{DateTime.UtcNow} WireMock.Net server running");
    Thread.Sleep(30000);
}