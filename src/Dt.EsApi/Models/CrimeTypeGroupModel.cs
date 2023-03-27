using System.Collections.Generic;

#nullable enable
namespace Dt.EsApi.Models
{
    public record CrimeTypeGroupModel(string Name,
                                      IReadOnlyDictionary<int, CrimeTypeModel> Crimes);
}