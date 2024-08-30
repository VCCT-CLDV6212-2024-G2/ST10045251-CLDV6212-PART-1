using Azure.Storage.Queues;

namespace ST10045251_CLDV6212_POE
{
    public class QueueService
    {
        private readonly QueueClient _queueClient;

        public QueueService(string storageConnectionString, string queueName)
        {
            _queueClient = new QueueClient(storageConnectionString, queueName);
        }

        public async Task AddMessageToQueueAsync(string message)
        {
            await _queueClient.SendMessageAsync(message);
        }
    }
}
