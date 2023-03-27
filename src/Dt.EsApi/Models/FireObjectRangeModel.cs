using System.Collections.Generic;

#nullable enable
namespace Dt.EsApi.Models
{
    public record FireObjectRangeModel(string Name,
                                       int? BuildingFrom,
                                       int? BuildingTo,
                                       int? Odd,
                                       int? StreetId,
                                       int DistrictId,
                                       int CityId,
                                       int DepartmentId,
                                       IReadOnlyCollection<int> FireReactionPlanIds);
}