using System;
using RestSharp;
using EdgeNote.UI.Managers;
using EdgeNote.iOS.Helpers;
using EdgeNote.UI.Network;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EdgeNote.iOS.Managers
{
    public class PlatformManager : IPlatformManager
    {
        public PlatformManager()
        {
        }

        public bool HasNetworkConnectivity
        {
            get
            {
                NetworkStatus internetStatus = Reachability.InternetConnectionStatus();

                if (internetStatus == NetworkStatus.NotReachable)
                {
                    return false;
                }

                return true;
            }
        }

        public string ApiHost
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string DataFolder
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string ImageFolder
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public ENRestResponse SendRestRequest(ENRestRequest _request)
        {
            //TODO save client in dictionary based on host
            RestClient client = new RestClient(_request.Host);

            RestRequest request = new RestRequest(_request.Path, GetMethod(_request.Method));

            //Process Headers
            foreach (var key in _request.Headers.Keys)
            {
                request.AddHeader(key, _request.Headers[key]);
            }

            //Add Body
            if (_request.Body != null)
            {
                request.AddBody(_request.Body);
            }

            //Execute Rest Method
            var response = client.Execute(request);

            //Create Response
            ENRestResponse atResponse = new ENRestResponse();

            //Process Headers, set status and body
            foreach (var parameter in response.Headers)
            {
                atResponse.Headers.Add(parameter.Name, parameter.Value.ToString());
            }
            atResponse.Status = GetStatus(response.ResponseStatus);
            atResponse.Body = response.Content;

            return atResponse;
        }

        private ENResponseStatus GetStatus(ResponseStatus status)
        {
            switch (status)
            {
            case ResponseStatus.None:
                return ENResponseStatus.None;
            case ResponseStatus.Aborted:
                return ENResponseStatus.Aborted;
            case ResponseStatus.Completed:
                return ENResponseStatus.Completed;
            case ResponseStatus.Error:
                return ENResponseStatus.Error;
            case ResponseStatus.TimedOut:
                return ENResponseStatus.Error;
            }

            throw new ArgumentException("Unexpected rest status");
        }

        private Method GetMethod(ENRestMethods method)
        {
            switch (method)
            {
            case ENRestMethods.Post:
                return Method.POST;
            case ENRestMethods.Get:
                return Method.GET;
            case ENRestMethods.Delete:
                return Method.DELETE;
            }

            throw new ArgumentException("Unexpected rest method");
        }

        public string GetLocalImageFilename(string _filename)
        {
            throw new NotImplementedException();
        }

        public string GetLocalThumbnailFilename(string _filename)
        {
            throw new NotImplementedException();
        }

        public Task SaveImage(ImageSource _imageSource, string _filename)
        {
            throw new NotImplementedException();
        }

        public void GenerateThumbnail(string _imageFilename, string _thumbnailFilename)
        {
            throw new NotImplementedException();
        }
    }
}