namespace Dt.EsApi.Models.Notifications
{
    public record DepartmentChangedNotif(
        int ServiceTypeId,
        DepartmentModel Department);
}