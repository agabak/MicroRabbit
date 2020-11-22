using MicroRabbitMQ.MVC.Models.Dtos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MicroRabbitMQ.MVC.Services
{
    public class TransferService : ITransferService
    {
        private readonly HttpClient _client;

        public TransferService(HttpClient client)
        {
            _client = client;     
        }
        public async Task Transfer(TransferDto transferDto)
        {
            var uri = "https://localhost:5001/api/banking";
            var transferContent = new StringContent(JsonConvert.SerializeObject(transferDto),
                                          System.Text.Encoding.UTF8, "application/json");
            var response = await _client.PostAsync(uri, transferContent);
            response.EnsureSuccessStatusCode();
        }
    }
}
