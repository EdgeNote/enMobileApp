using EdgeNote.UI.Constants;
using Xamarin.Forms;

namespace EdgeNote.UI.Forms
{
    public class About : AbstractPage
    {
        WebView m_webAbout;

        public About() : base(DisplayConstants.FormAbout)
        {
            m_webAbout = new WebView()
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Source = new HtmlWebViewSource
                {
                    Html = AboutConstants.AboutText
                },
                Margin = new Thickness(10, 10, 10, 10)
            };
            OutsideLayout.Children.Add(m_webAbout);
        }
    }
}
