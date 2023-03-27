using Dt.EsApi.Enums;
using Dt.EsApi.Models;
using ServerLogic.Types;

#nullable enable
namespace Dt.EsApi
{
    public static class DtTypeConverter
    {
        public static MapType ToMapType(this TileProviderType provider)
        {
            return provider switch
            {
                TileProviderType.Iac => MapType.IAC,
                TileProviderType.ArcGis => MapType.ArcGIS,
                TileProviderType.Pppur => MapType.ChromeBrowserPppur,
                _ => MapType.Protei
            };
        }

        public static TileProviderType ToTileProviderType(this MapType mapType)
        {
            return mapType switch
            {
                MapType.IAC => TileProviderType.Iac,
                MapType.ArcGIS => TileProviderType.ArcGis,
                MapType.ChromeBrowserPppur => TileProviderType.Pppur,
                _ => TileProviderType.Protei
            };
        }

        public static CallCommandType ToCallCommandType(this Command command)
        {
            return command switch
            {
                Command.InitConferenceCommand => CallCommandType.InitConference,
                Command.SaveCardWithTransferCommand => CallCommandType.TransferCall,
                _ => CallCommandType.TransferCall
            };
        }

        public static Command ToCommand(this CallCommandType callCommandType)
        {
            return callCommandType switch
            {
                CallCommandType.InitConference => Command.InitConferenceCommand,
                CallCommandType.TransferCall => Command.SaveCardWithTransferCommand,
                _ => Command.SaveCardWithTransferCommand
            };
        }

        public static User03Role ToUser03Role(this En_User03Role user03Role)
        {
            return user03Role switch
            {
                En_User03Role.Operator_03 => User03Role.Operator,
                En_User03Role.Dispatcher_03 => User03Role.Dispatcher,
                _ => User03Role.Dispatcher
            };
        }

        public static En_User03Role ToUser03Role(this User03Role user03Role)
        {
            return user03Role switch
            {
                User03Role.Operator => En_User03Role.Operator_03,
                User03Role.Dispatcher => En_User03Role.Dispatcher_03,
                _ => En_User03Role.Dispatcher_03
            };
        }

        public static CallCenterProvider ToCallCenterProvider(this CallCenterProviderType callCenterProvider)
        {
            return callCenterProvider switch
            {
                CallCenterProviderType.Protei or CallCenterProviderType.ProteiEACD3 => CallCenterProvider.ProteiCallCenter,
                CallCenterProviderType.Avaya7 => CallCenterProvider.Avaya7CallCenter,
                CallCenterProviderType.EmergencyServer => CallCenterProvider.EmergencyServer,
                CallCenterProviderType.GridBookServer => CallCenterProvider.GridBookServer,
                CallCenterProviderType.ProteiEACDWPServer => CallCenterProvider.ProteiWpServer,
                _ => CallCenterProvider.NotSet
            };
        }

        public static CallCenterProviderType ToCallCenterProviderType(this CallCenterProvider callCenterProvider)
        {
            return callCenterProvider switch
            {
                CallCenterProvider.ProteiCallCenter => CallCenterProviderType.ProteiEACD3,
                CallCenterProvider.Avaya7CallCenter => CallCenterProviderType.Avaya7,
                CallCenterProvider.EmergencyServer => CallCenterProviderType.EmergencyServer,
                CallCenterProvider.GridBookServer => CallCenterProviderType.GridBookServer,
                CallCenterProvider.ProteiWpServer => CallCenterProviderType.ProteiEACDWPServer,
                _ => CallCenterProviderType.NotSet
            };
        }

        public static GeoPointModel ToGeoPointModel(this GeoPoint geoPoint)
        {
            return new GeoPointModel(geoPoint.lat, geoPoint.lng);
        }

        public static GeoPoint ToGeoPoint(this GeoPointModel geoPointModel)
        {
            return new GeoPoint
            {
                lat = geoPointModel.Latitude,
                lng = geoPointModel.Longitude
            };
        }
    }
}