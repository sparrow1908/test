namespace Dt.EsApi.Models.Notifications
{
    public record UpdateClientNotif(long Sid,
                                    string Ip,
                                    string Sha1Distr,
                                    string Sha1Installer,
                                    string PathDistr,
                                    string PathInstaller,
                                    string User,
                                    string Password);
}