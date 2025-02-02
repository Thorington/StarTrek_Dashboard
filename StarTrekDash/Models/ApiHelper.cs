using System.Threading.Tasks;
using RestSharp;
using System;
using System.Collections.Generic;

namespace StarTrekDash.Models
{
  class ApiHelper
  {
    public static async Task<string> GetAllArticles()
    {
      RestClient client = new RestClient("https://api.nytimes.com/svc/topstories/v2");
      RestRequest request = new RestRequest($"science.json?api-key=rIRXqv5I1wGtzAaNZGDPaQ11A5UDX3so", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
    
    public static async Task<string> GetAllWeather()
    {
      // RestClient client = new RestClient("https://api.openweathermap.org/data/2.5/");
      // RestRequest request = new RestRequest("$weather?q=portland,oregon&appid=1c1b98fa298118950e0f4b736fb9f1a6", Method.GET);
      // var response = await client.ExecuteTaskAsync(request);
      // return response.Content;

      // var client = new RestClient("https://weatherbit-v1-mashape.p.rapidapi.com/forecast/minutely?lat=35.5&lon=-78.5");
      // var request = new RestRequest(Method.GET);
      // request.AddHeader("X-RapidAPI-Key", "08865bee04msh17e6a2c6cac849fp142897jsncdc0a5c75998");
      // request.AddHeader("X-RapidAPI-Host", "weatherbit-v1-mashape.p.rapidapi.com");
      // IRestResponse response = await client.ExecuteTaskAsync(request);

      var client = new RestClient("https://weatherbit-v1-mashape.p.rapidapi.com");
      var request = new RestRequest("/current?lat=45.5&lon=-122.7", Method.GET);
      request.AddHeader("X-RapidAPI-Key", "37c0a1d315msh14263c82d6398edp1fbb3djsn6522c5e5acfc");
      request.AddHeader("X-RapidAPI-Host", "weatherbit-v1-mashape.p.rapidapi.com");
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
  }
}