using System;
using System.Collections;
using System.Text;

namespace Dt.EsApi
{
    public static class StringBuilderExtensions
    {
        public static void AppendIfNotNull(this StringBuilder stringBuilder,
            string? paramName,
            object? objectToLog,
            string? separator = null)
        {
            if (string.IsNullOrEmpty(paramName) ||
                objectToLog is null)
            {
                return;
            }

            separator ??= Environment.NewLine;

            switch (objectToLog)
            {
                case string stringParamToLog when string.IsNullOrEmpty(stringParamToLog):
                case ICollection { Count: 0 }:
                {
                    return;
                }

                case ICollection collection:
                {
                    stringBuilder.AppendWithSeparator($"{paramName}:", separator);

                    foreach (var item in collection)
                    {
                        stringBuilder.AppendWithSeparator($"{item}", separator);
                    }

                    break;
                }

                default:
                {
                    stringBuilder.AppendWithSeparator($"{paramName}: {objectToLog}", separator);
                    break;
                }
            }
        }

        public static void AppendWithSeparator(this StringBuilder stringBuilder,
            string value,
            string? separator = null)
        {
            separator ??= Environment.NewLine;

            stringBuilder.Append(value);
            stringBuilder.Append(separator);
        }
    }
}
