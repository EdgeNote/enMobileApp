using System.Threading.Tasks;
using Xamarin.Forms;

namespace EdgeNote.UI.Interfaces
{
    public interface IMainForm
    {
        Task<bool> ShowAlert(string _title, string _message, string _accept, string _cancel);

        void PushModal(Page _form);
    }
}

