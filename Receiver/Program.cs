using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.ServiceBus;

namespace Receiver
{
	internal class Program
	{
		// private Connection String for the namespace can be obtained from the Azure portal under the

		// 'Shared Access policies' section.
		private const string ServiceBusConnectionString = "Endpoint=sb://ms20921880.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=wk+l7v5oA0XDJST8kSb/9vpdwc5fRY9+zf5TKv6bQA8=";

		private const string QueueName = "esad";
		private static IQueueClient queueClient;

		private static void Main(string[] args)
		{
			MainAsync().GetAwaiter().GetResult();
		}

		private static async Task MainAsync()
		{
			queueClient = new QueueClient(ServiceBusConnectionString, QueueName);

			Console.WriteLine("======================================================");
			Console.WriteLine("Press ENTER key to exit after receiving all the messages.");
			Console.WriteLine("======================================================");

			// Register QueueClient's MessageHandler and receive messages in a loop
			RegisterOnMessageHandlerAndReceiveMessages();

			Console.ReadKey();

			await queueClient.CloseAsync();
		}

		private static void RegisterOnMessageHandlerAndReceiveMessages()
		{
			// Configure the MessageHandler Options in terms of exception handling, number of concurrent messages to deliver etc.
			var messageHandlerOptions = new MessageHandlerOptions(ExceptionReceivedHandler)
			{
				// Maximum number of Concurrent calls to the callback `ProcessMessagesAsync`, set to 1 for simplicity.
				// Set it according to how many messages the application wants to process in parallel.
				MaxConcurrentCalls = 1,

				// Indicates whether MessagePump should automatically complete the messages after returning from User Callback.
				// False below indicates the Complete will be handled by the User Callback as in `ProcessMessagesAsync` below.
				AutoComplete = false
			};

			// Register the function that will process messages
			queueClient.RegisterMessageHandler(ProcessMessagesAsync, messageHandlerOptions);
		}

		private static async Task ProcessMessagesAsync(Message message, CancellationToken token)
		{
			// Process the message
			Console.WriteLine($"Received message: SequenceNumber:{message.SystemProperties.SequenceNumber} Body:{Encoding.UTF8.GetString(message.Body)}");

			// Complete the message so that it is not received again.
			// This can be done only if the queueClient is created in ReceiveMode.PeekLock mode (which is default).
			await queueClient.CompleteAsync(message.SystemProperties.LockToken);

			// Note: Use the cancellationToken passed as necessary to determine if the queueClient has already been closed.
			// If queueClient has already been Closed, you may chose to not call CompleteAsync() or AbandonAsync() etc. calls
			// to avoid unnecessary exceptions.
		}

		private static Task ExceptionReceivedHandler(ExceptionReceivedEventArgs exceptionReceivedEventArgs)
		{
			Console.WriteLine($"Message handler encountered an exception {exceptionReceivedEventArgs.Exception}.");
			var context = exceptionReceivedEventArgs.ExceptionReceivedContext;
			Console.WriteLine("Exception context for troubleshooting:");
			Console.WriteLine($"- Endpoint: {context.Endpoint}");
			Console.WriteLine($"- Entity Path: {context.EntityPath}");
			Console.WriteLine($"- Executing Action: {context.Action}");
			return Task.CompletedTask;
		}
	}
}
