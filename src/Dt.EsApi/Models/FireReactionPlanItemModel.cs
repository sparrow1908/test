#nullable enable
namespace Dt.EsApi.Models
{
    public record FireReactionPlanItemModel(int FireRectionPlanId,
                                            int FireEngineTypeId,
                                            string FireEngineType,
                                            int FireDepartmentId,
                                            int Count,
                                            int Order,
                                            int FireClassId);
}