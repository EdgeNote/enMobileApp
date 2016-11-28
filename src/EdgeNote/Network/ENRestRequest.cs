using System;
using System.Collections.Generic;

namespace EdgeNote.UI.Network
{
    public class ENRestRequest
    {
        public ENRestRequest()
        {
            Headers = new Dictionary<string, string>();
        }

        public string Host { get; set; }
        public string Path { get; set; }
        public ENRestMethods Method { get; set; }
        public Dictionary<string, string> Headers { get; set; }
        public string Body { get; set; }
    }
}

