using EdgeNote.UI.Constants;
using EdgeNote.UI.Controls;
using Xamarin.Forms;

namespace HydrantWiki.Forms
{
    public class MenuPage : ContentPage
    {
        public MenuListView Menu { get; set; }

        public MenuPage()
        {
            //Icon = "settings.png";
            Title = DisplayConstants.Menu;
            BackgroundColor = Color.FromHex(UIConstants.MenuPageTitleBackgroundColor);

            ENHeader header = new ENHeader("Menu");

            Menu = new MenuListView();

            var layout = new StackLayout
            {
                Spacing = 0,
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            layout.Children.Add(header);
            layout.Children.Add(Menu);


            Content = layout;
        }
    }
}

