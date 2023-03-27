#nullable enable
namespace Dt.EsApi.Models
{
    public record CarMapModel(
        int Id,
        string AdditionalInfo,
        string IconUri,
        GeoPointModel Coords);
}