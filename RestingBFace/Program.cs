using System;
using RestSharp;
using System.Text.Json;
using System.Net;
RestClient starClient = new("https://swapi.py4e.com/api/");
RestRequest request = new("starships/9/");
RestResponse response = starClient.GetAsync(request).Result;

if (response.StatusCode == HttpStatusCode.OK)
{
  Starship p = JsonSerializer.Deserialize<Starship>(response.Content);
  Console.WriteLine(p.name);
  Console.WriteLine(p.length);
}
else
{
  Console.WriteLine("What?");
}

// Console.WriteLine(response.Content);

Console.ReadLine();