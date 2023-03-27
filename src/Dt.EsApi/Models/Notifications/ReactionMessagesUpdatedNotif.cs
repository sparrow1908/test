using System.Collections.Generic;

namespace Dt.EsApi.Models.Notifications
{
    public record ReactionMessagesUpdatedNotif(
        int ServiceTypeId,
        int CardId,
        IReadOnlyCollection<CardMessageModel> Messages);
}