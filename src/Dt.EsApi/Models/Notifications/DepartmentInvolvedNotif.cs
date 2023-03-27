namespace Dt.EsApi.Models.Notifications
{
    public record DepartmentInvolvedNotif(
        int ServiceTypeId,
        int CardId,
        DepartmentModel Department);
}