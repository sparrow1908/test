using Dt.EsApi.Enums;

namespace Dt.EsApi.Models.Notifications
{
    public record ServiceCardChangedNotif(
        int CardId,
        string GlobalId,
        int ServiceTypeId,
        ServiceCardChangeType ChangeType);
}