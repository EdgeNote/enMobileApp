using EdgeNote.UI.Constants;
using Xamarin.Forms;

namespace EdgeNote.UI.Controls
{
    public class ENFormButton : ENButton
    {
        public ENFormButton()
        {
            BackgroundColor = Color.FromHex(UIConstants.FormButtonBackgroundColor);
            TextColor = Color.FromHex(UIConstants.FormButtonTextColor);
            BorderColor = Color.FromHex(UIConstants.FormButtonBorderColor);
            BorderRadius = 0;
            BorderWidth = 1;
            FontFamily = UIConstants.FontFamily;
            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Button));
            FontAttributes = FontAttributes.Bold;

        }
    }
}
