using System.Collections.Generic;

#nullable enable
namespace Dt.EsApi.Models
{
    public record FireReactionPlanModel(string Name,
                                        int DepartmentId,
                                        IReadOnlyCollection<FireReactionPlanItemModel> PlanItems);
}