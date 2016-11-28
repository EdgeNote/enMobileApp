using System;
using System.Collections.Generic;

namespace EdgeNote.UI.Network
{
    public class ENRestResponse
    {
        public ENRestResponse()
        {
            Headers = new Dictionary<string, string>();
        }

        public ENResponseStatus Status { get; set; }
        public Dictionary<string, string> Headers { get; set; }
        public string Body { get; set; }

    }
}

