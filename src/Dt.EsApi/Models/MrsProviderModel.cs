using System;

#nullable enable
namespace Dt.EsApi.Models
{
    public record MrsProviderModel(
        string ProviderPath,
        string FtpUserLogin,
        string FtpPassword,
        string CallIdFilter,
        TimeSpan GetFileListTimeout);
}