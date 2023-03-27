namespace Dt.EsApi.Models.Notifications
{
    public record BroadcastMessageCreatedNotif(
        int MessageId,
        int ServiceTypeId,
        string Message,
        string Sender);
}