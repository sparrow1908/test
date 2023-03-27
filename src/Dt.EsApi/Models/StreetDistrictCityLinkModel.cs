#nullable enable
namespace Dt.EsApi.Models
{
    public record StreetDistrictCityLinkModel(int StreetId,
                                              int DistrictId,
                                              int CityId,
                                              bool IsDeleted);
}