using System;
using System.Collections.Generic;
using EdgeNote.Library.Objects;
using EdgeNote.UI.Network;
using EdgeNote.UI.Objects;
using EdgeNote.UI.ResponseObjects;
using Newtonsoft.Json;

namespace EdgeNote.UI.Managers
{
    public class ApiManager
    {
        private EdgeNoteManager m_ENManager;

        public ApiManager(EdgeNoteManager _manager)
        {
            m_ENManager = _manager;
        }

        /// <summary>
        /// Returns a list of the sync sets that this machine needs
        /// </summary>
        /// <returns>The sync sets.</returns>
        /// <param name="lastSyncSet">Last sync set.</param>
        public List<long> GetSyncSets(long lastSyncSet)
        {
            return null;
        }

        /// <summary>
        /// Returns the requested sync set
        /// </summary>
        /// <returns>The sync set.</returns>
        /// <param name="syncSet">Sync set.</param>
        public SyncSet GetSyncSet(long syncSet)
        {
            return null;
        }

        /// <summary>
        /// Saves a sync set to the server
        /// </summary>
        /// <returns>The sync set.</returns>
        /// <param name="syncSet">Sync set.</param>
        public SaveSyncSetResponse SaveSyncSet(SyncSet syncSet)
        {
            return null;
        }

        public void Log(string prefix, string _message)
        {
            try
            {
                Guid installId = m_ENManager.SettingManager.GetInstallId();
                var config = AppConfiguration.GetInstance();

                LogglyMessage lm = new LogglyMessage
                {
                    from = installId.ToString(),
                    message = prefix + ": " + _message
                };
                string json = JsonConvert.SerializeObject(lm);


                ENRestRequest request = new ENRestRequest();
                request.Method = ENRestMethods.Post;
                request.Host = config.LogglyHost;
                request.Path = string.Format(config.LogglyResource, config.LogglyToken);
                request.Timeout = 3000;
                request.ContentType = "application/x-www-form-urlencoded";
                request.Body = json;

                m_ENManager.PlatformManager.SendRestRequest(request);
            }
            catch
            {
                //Eat error
            }
        }
    }
}
