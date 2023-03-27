using System;

#nullable enable
namespace Dt.EsApi.Models
{
    public record CardMessageModel(
        int Id,
        int CardId,
        int? ServiceTypeId,
        string Creator,
        int? DepartmentId,
        string Message,
        bool IsServiceMessage,
        DateTime Creation);
}