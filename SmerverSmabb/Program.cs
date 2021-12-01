using System;

using RestSharp;

RestClient pokeClient = new RestClient("https://pokeapi.co/api/v2/");
RestRequest pokeRequest = new RestRequest("pokemon/mismagius");
IRestResponse response = pokeClient.Get(pokeRequest);

Console.WriteLine(response.StatusCode);

Console.ReadLine();