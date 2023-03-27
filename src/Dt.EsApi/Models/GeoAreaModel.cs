#nullable enable
namespace Dt.EsApi.Models
{
    public record GeoAreaModel(
        GeoPointModel BottomCorner,
        GeoPointModel UpperCorner,
        long? IacObjectId,
        string? Floors);
}