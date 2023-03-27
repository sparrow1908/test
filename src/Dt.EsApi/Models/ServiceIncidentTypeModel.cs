using System.Collections.Generic;

#nullable enable
namespace Dt.EsApi.Models
{
    public record ServiceIncidentTypeModel(string Text,
                                           bool IsDeleted,
                                           bool IsEmergency,
                                           int? IncidentTypeId,
                                           IReadOnlyCollection<int> AuxiliaryIncidentIds);
}