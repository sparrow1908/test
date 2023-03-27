#nullable enable
namespace Dt.EsApi.Models
{
    public record DistrictCityLinkModel(int DistrictId,
                                        int CityId,
                                        bool IsDeleted);
}