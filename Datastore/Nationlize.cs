using apiintegration.Models;
using Newtonsoft.Json;
using System;
using System.Text.Json.Serialization;

namespace apiintegration.Datastore
{
    public class Nationlize
    {
        private readonly HttpClient _httpclient;
        public Nationlize(HttpClient httpClient) 
        {
            _httpclient = httpClient;
        } 
        public async Task<Nation> GetNationAsync(string name)
        { 
            HttpResponseMessage? response = await _httpclient.GetAsync($"https://api.nationalize.io/?name={name}");
            response.EnsureSuccessStatusCode(); 
            string content = await response.Content.ReadAsStringAsync();
            var nation =  JsonConvert.DeserializeObject<Nation>(content);

            return nation;
        }
    }
}
