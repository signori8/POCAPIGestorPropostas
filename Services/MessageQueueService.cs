using Azure.Messaging.ServiceBus;

namespace POC.Services
{
    public static class MessageQueueService
    {
        
        public static async Task AddMessage(string proposta)
        {
            try
            {

                string connectionstring = "Endpoint=sb://pocgestorpropostas.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=nU/ophrsCsLPvS6s/vflNyR7tl0okZKl7kxOdCd08Os=";
                string queueName = "propostas";

                ServiceBusClient client = new ServiceBusClient(connectionstring);
                ServiceBusSender sender = client.CreateSender(queueName);


                ServiceBusMessage message = new ServiceBusMessage(proposta);

                await sender.SendMessageAsync(message);

            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }


}

