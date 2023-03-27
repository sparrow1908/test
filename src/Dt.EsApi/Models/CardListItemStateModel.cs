using System.Drawing;

#nullable enable
namespace Dt.EsApi.Models
{
    public record CardListItemStateModel(string Name,
                                         Brush ImportantBrush,
                                         Brush NotImportantBrush);
}