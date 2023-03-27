#nullable enable
using System.Collections.Generic;

namespace Dt.EsApi.Models
{
    public record RegionAdditionalInfoModel(
        int RegionId,
        string Value,
        IReadOnlyCollection<CommunicationTypeLinkModel> CommunicationInfos);
}