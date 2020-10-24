using Microsoft.Azure.ServiceBus;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SalesSystem.queing
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
            string xml = null;
            using (var stringwriter = new System.IO.StringWriter())
            {
                var serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(stringwriter, request);
                xml = stringwriter.ToString();
            }
            var message = new Message(body: Encoding.UTF8.GetBytes(xml));
            return queueClient.SendAsync(message);
        }
    }
}

public interface IMessagePublisher
{
    Task PublisheAsync<T>(T request);
}
