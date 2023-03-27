using Dt.EsApi.Enums;

#nullable enable
namespace Dt.EsApi.Models
{
    public record MapTileUrlModel(
        string TileSource,
        TileProviderType TileProvider,
        string MapCenterCityName);
}