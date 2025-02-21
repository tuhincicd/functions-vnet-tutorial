

using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json;

public static async Task<IActionResult> Run(HttpRequest req, ILogger log)
{
    log.LogInformation("C# HTTP trigger function processed a request.");

    var client = new HttpClient();
    var response = await client.GetAsync(@"https://ifconfig.me");
    var responseMessage = await response.Content.ReadAsStringAsync();

    return new OkObjectResult(responseMessage);
}