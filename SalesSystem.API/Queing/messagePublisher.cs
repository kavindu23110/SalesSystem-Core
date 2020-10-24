using Azure.Core;
using Microsoft.Azure.ServiceBus;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SalesSystem.API.queing
{
    public class MessagePublisher : IMessagePublisher
    {
    
        private readonly IQueueClient queueClient;

        public MessagePublisher(IQueueClient queueClient)
        {
            this.queueClient = queueClient;
        }
        public Task PublisheAsync<T>(T request)
        {
            var jsonMeassage = JsonConvert.SerializeObject(request);
            var message = new Message(body: Encoding.UTF8.GetBytes(jsonMeassage));
          return  queueClient.SendAsync(message);
        }
    }
}

public interface IMessagePublisher
{
    Task PublisheAsync<T>(T request);
}
