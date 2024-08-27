using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Primitives;
using System.IO;
using System.Linq;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.Run(async (HttpContext context) =>
{
    StreamReader reader = new StreamReader(context.Request.Body);
     string body = await reader.ReadToEndAsync();

    Dictionary<string, StringValues> queryDict =
    Microsoft.AspNetCore.WebUtilities.QueryHelpers.ParseQuery
    (body);

    if (queryDict.ContainsKey("firstName"))
    {
        string firstName = queryDict["firstName"][0];
        await context.Response.WriteAsync(firstName);
    }
   

});  


app.Run();
