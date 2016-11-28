using Xamarin.Forms;
using System.Collections.Generic;
using EdgeNote.UI.Constants;
using EdgeNote.UI.Objects;
using HydrantWiki.Cells;
using HydrantWiki.Data;

namespace EdgeNote.UI.Controls
{
    public class MenuListView : AbstractListView
    {
        public MenuListView()
        {
            BackgroundColor = Color.FromHex(UIConstants.MenuPageListBackgroundColor);

            ItemTemplate = new DataTemplate(typeof(MenuCell));

            List<MenuOption> data = MenuListData.GetMenu();
            ItemsSource = data;

            RowHeight = 60;
        }
    }
}

