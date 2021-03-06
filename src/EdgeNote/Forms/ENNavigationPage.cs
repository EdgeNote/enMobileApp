﻿using System.Threading.Tasks;
using EdgeNote.UI.Constants;
using EdgeNote.UI.Interfaces;
using Xamarin.Forms;

namespace HydrantWiki.Forms
{
    public class ENNavigationPage : NavigationPage
    {
        public ENNavigationPage(Page page) : base(page)
        {
            BarTextColor = Color.FromHex(UIConstants.NavBarTextColor);
            BarBackgroundColor = Color.FromHex(UIConstants.NavBarColor);
        }

        async public new Task PushAsync(Page _page, bool _animated)
        {
            await base.PushAsync(_page, _animated);
        }

        async public new Task PopAsync(bool _animated)
        {
            var validatedContentPage = CurrentPage as IValidatedPage;

            if (validatedContentPage != null)
            {
                if (!validatedContentPage.ValidatePage())
                {
                    return;
                }
            }

            await base.PopAsync(_animated);
        }
    }
}
