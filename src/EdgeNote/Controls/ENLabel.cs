using EdgeNote.UI.Constants;
using Xamarin.Forms;

namespace EdgeNote.UI.Controls
{
    public class ENLabel : Label
    {
        public ENLabel()
        {
            FontFamily = UIConstants.FontFamily;
            LineBreakMode = LineBreakMode.WordWrap;

            if (Device.Idiom == TargetIdiom.Phone)
            {
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label));
            } else {
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label));
            }
        }
    }
}

