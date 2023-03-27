using System.Collections.Generic;

#nullable enable
namespace Dt.EsApi.Models
{
    public record AddressObjectModel(int? StreetId,
                                     int CityId,
                                     int DistrictId,
                                     string Building,
                                     string Corps,
                                     IReadOnlyCollection<int> FireReactionPlanIds);
}