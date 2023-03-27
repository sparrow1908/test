#nullable enable
namespace Dt.EsApi.Models
{
    public record CardMarkerModel(
        int CardId,
        string GlobalId,
        int? CardStateId,
        int? CallTypeId,
        string Description,
        bool IsNeedToShow,
        GeoPointModel Coords);
}