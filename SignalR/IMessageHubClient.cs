namespace SignalRProject.SignalR
{
    public interface IMessageHubClient
    {
        Task SendOffersToUser(string message);
    }
}
