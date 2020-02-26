using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Events;
using Prism.Navigation;
using Prism.Services;
using XamPri.Extensions;
using XamPri.Model;
using XamPri.Views;

namespace XamPri.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        #region Fields


        #endregion

        private ObservableCollectionExt<MainMenuItem> _menuItems = new ObservableCollectionExt<MainMenuItem>();
        public ObservableCollectionExt<MainMenuItem> MenuItems
        {
            get => _menuItems;
            set => SetProperty(ref _menuItems, value);
        }

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";

        }


        #region Commands

        private DelegateCommand<MainMenuItem> _menuItemTappedCommand;

        public DelegateCommand<MainMenuItem> MenuItemTappedCommand => _menuItemTappedCommand ??
            (_menuItemTappedCommand = new DelegateCommand<MainMenuItem>(async i => await _MenuItemTappedExecute(i)));

        #endregion


        #region Command methods

        private async Task _MenuItemTappedExecute(MainMenuItem mainMenuItem)
        {
            if (!string.IsNullOrEmpty(mainMenuItem.DestinationPageName))
            {
                await NavigationService.NavigateAsync($"{nameof(BaseNavigationPage)}/{mainMenuItem.DestinationPageName}", animated:false);
            }
        }

        #endregion

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
            MenuItems.Reset(new List<MainMenuItem>
            {
                new MainMenuItem
                {
                    DestinationPageName = nameof(Page1),
                    Title = nameof(Page1)
                },
                new MainMenuItem
                {
                    DestinationPageName = nameof(Page2),
                    Title = nameof(Page2)
                },
                new MainMenuItem
                {
                    DestinationPageName = nameof(Page3),
                    Title = nameof(Page3)
                },
                new MainMenuItem
                {
                    DestinationPageName = nameof(Page4),
                    Title = nameof(Page4)
                }
            });
        }


        public override void Destroy()
        {
            _menuItemTappedCommand = null;
            base.Destroy();
        }
    }
}
