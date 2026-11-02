using Microsoft.AspNetCore.SignalR;

namespace ExpressRepairAssessment.Hubs;

public class NotificationHub : Hub
{
    public Task SendNotification(string message) =>
        Clients.All.SendAsync("ReceiveNotification", message);
}
