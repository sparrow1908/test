using System.Collections.Generic;

#nullable enable
namespace Dt.EsApi.Models
{
    public record IncidentTypeModel(int? CallTypeId,
                                    int? RegionId,
                                    bool IsDeleted,
                                    IReadOnlyCollection<int> ServiceTypeIds);
}