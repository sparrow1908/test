using Dt.EsApi.Enums;

#nullable enable
namespace Dt.EsApi.Models
{
    public class CommunicationTypeLinkModel
    {
        public CommunicationType? CommunicationType { get; }

        public CommunicationPhoneType? CommunicationPhoneType { get; }

        public string? Phone { get; }

        public string? Service { get; }

        public string? Group { get; }

        public CommunicationTypeLinkModel(string phone,
                                          CommunicationType? communicationType,
                                          CommunicationPhoneType? communicationPhoneType)
        {
            CommunicationType = communicationType;
            Phone = phone;
            CommunicationPhoneType = communicationPhoneType;
        }

        public CommunicationTypeLinkModel(string service,
                                          string group,
                                          CommunicationType? communicationType,
                                          CommunicationPhoneType? communicationPhoneType)
        {
            CommunicationType = communicationType;
            Service = service;
            Group = group;
            CommunicationPhoneType = communicationPhoneType;
        }

        public bool IsValidDestination(CommunicationType communicationType,
                                       CommunicationPhoneType communicationPhoneType)
        {
            return CommunicationType == communicationType
                && CommunicationPhoneType == communicationPhoneType;
        }
    }
}