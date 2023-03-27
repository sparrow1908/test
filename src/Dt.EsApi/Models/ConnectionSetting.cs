using System;
using System.Collections.Generic;
using System.Text;

#nullable enable
namespace Dt.EsApi.Models
{
    public class ConnectionSetting : ICloneable<ConnectionSetting>
    {
        public Uri ActionUri { get; }

        public Uri NotificationWebSocketUri { get; }

        public Uri ReportUri { get; }

        public int Priority { get; }

        public int AttemptCount { get; }

        public ConnectionSetting(Uri actionUri,
                                 Uri notificationWebSocketUri,
                                 Uri reportUri,
                                 int priority,
                                 int attemptCount)
        {
            ActionUri = actionUri ?? throw new ArgumentNullException(nameof(actionUri));
            NotificationWebSocketUri = notificationWebSocketUri ?? throw new ArgumentNullException(nameof(notificationWebSocketUri));
            ReportUri = reportUri ?? throw new ArgumentNullException(nameof(reportUri));
            Priority = priority;
            AttemptCount = attemptCount;
        }

        public ConnectionSetting Clone()
        {
            return new(ActionUri,
                       NotificationWebSocketUri,
                       ReportUri,
                       Priority,
                       AttemptCount);
        }

        public override int GetHashCode()
        {
            var hashCode = -659746988;
            hashCode = hashCode * -1521134295 + EqualityComparer<Uri>.Default.GetHashCode(ActionUri);
            hashCode = hashCode * -1521134295 + EqualityComparer<Uri>.Default.GetHashCode(NotificationWebSocketUri);
            hashCode = hashCode * -1521134295 + EqualityComparer<Uri>.Default.GetHashCode(ReportUri);
            hashCode = hashCode * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Priority);
            hashCode = hashCode * -1521134295 + EqualityComparer<int>.Default.GetHashCode(AttemptCount);
            return hashCode;
        }

        public override bool Equals(object other)
        {
            return other is ConnectionSetting casted &&
                   EqualityComparer<Uri>.Default.Equals(ActionUri, casted.ActionUri) &&
                   EqualityComparer<Uri>.Default.Equals(NotificationWebSocketUri, casted.NotificationWebSocketUri) &&
                   EqualityComparer<Uri>.Default.Equals(ReportUri, casted.ReportUri) &&
                   EqualityComparer<int>.Default.Equals(Priority, casted.Priority) &&
                   EqualityComparer<int>.Default.Equals(AttemptCount, casted.AttemptCount);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"ActionUri: {ActionUri}");
            sb.AppendLine($"NotificationWebSocketUri: {NotificationWebSocketUri}");
            sb.AppendLine($"ReportUri: {ReportUri}");
            sb.AppendLine($"Priority: {Priority}");
            sb.AppendLine($"AttemptCount: {AttemptCount}");
            return sb.ToString();
        }
    }
}