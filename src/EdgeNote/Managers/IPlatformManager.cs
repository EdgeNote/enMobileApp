using System;
using EdgeNote.UI.Network;

namespace EdgeNote.UI.Managers
{
    public interface IPlatformManager
    {
        bool HasNetworkConnectivity { get; }

        ENRestResponse SendRestRequest(ENRestRequest _request);
    }
}

