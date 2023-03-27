namespace Dt.EsApi.Models.Notifications
{
    public record ReactionMessageCreatedNotif(
        int ServiceTypeId,
        int CardId,
        CardMessageModel Message);
}