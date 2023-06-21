

using Microsoft.AspNetCore.SignalR;

namespace SignalRProject.SignalR
{
    public class MessageHub: Hub<IMessageHubClient>
    {
       public async Task SendOffersToUser(string message)
        {
            await Clients.All.SendOffersToUser(message);
        }

        public async Task receiveMessage(string message)
        {
            await Clients.All.SendOffersToUser(message);
        }


    }
}
