using System;
using EdgeNote.UI.Network;
using EdgeNote.UI.Objects;
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
