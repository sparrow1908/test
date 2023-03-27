using ServerLogic.Types;
using System.Collections.Generic;

#nullable enable
namespace Dt.EsApi.Models
{
    public record DepartmentHistoryModel(
        int ActiveStateId,
        IReadOnlyCollection<CardDepartmentState> StateHistory);
}