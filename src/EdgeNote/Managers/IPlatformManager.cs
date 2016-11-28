using System;
using System.Threading.Tasks;
using EdgeNote.UI.Network;
using Xamarin.Forms;

namespace EdgeNote.UI.Managers
{
    public interface IPlatformManager
    {
        bool HasNetworkConnectivity { get; }

        ENRestResponse SendRestRequest(ENRestRequest _request);

        string ApiHost { get; }

        string GetLocalImageFilename(string _filename);

        string GetLocalThumbnailFilename(string _filename);

        Task SaveImage(ImageSource _imageSource, string _filename);

        void GenerateThumbnail(string _imageFilename, string _thumbnailFilename);

        string DataFolder { get; }

        string ImageFolder { get; }
    }
}

