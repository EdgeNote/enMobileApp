using System;
using System.Collections.Generic;
using EdgeNote.Library.Objects;
using EdgeNote.UI.Forms;
using EdgeNote.UI.Managers;
using EdgeNote.UI.Objects;

namespace HydrantWiki.Data
{
    public static class MenuListData
    {
        public static List<MenuOption> GetMenu()
        {
            List<MenuOption> menuItems = new List<MenuOption>();

            User user = EdgeNoteManager.GetInstance().SettingManager.GetUser();

            menuItems.Add(new MenuOption()
            {
                Title = "Home",
                TargetType = typeof(DefaultForm)
            });

            menuItems.Add(new MenuOption()
            {
                Title = "Nodes",
                TargetType = typeof(NodesForm)
            });

            menuItems.Add(new MenuOption()
            {
                Title = "Labels",
                TargetType = typeof(LabelsForm)
            });

            menuItems.Add(new MenuOption()
            {
                Title = "Object Types",
                TargetType = typeof(LabelSetsForm)
            });

            if (user != null
                && user.UserType != null
                && user.UserType.Equals("Administrator", StringComparison.OrdinalIgnoreCase))
            {
                menuItems.Add(new MenuOption()
                {
                    Title = "Users",
                    TargetType = typeof(UsersForm)
                });
            }

            menuItems.Add(new MenuOption()
            {
                Title = "About",
                TargetType = typeof(About)
            });

            menuItems.Add(new MenuOption()
            {
                Title = "Account",
                TargetType = typeof(AccountForm)
            });

            return menuItems;
        }
    }
}

