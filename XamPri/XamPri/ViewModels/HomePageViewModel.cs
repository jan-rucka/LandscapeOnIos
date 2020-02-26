using System;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Events;
using Prism.Navigation;
using Prism.Services;
using XamPri.Model;

namespace XamPri.ViewModels
{
    public class HomePageViewModel : ViewModelBase
    {
        #region Fields


        #endregion

        public HomePageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";

        }


        #region Commands

        private DelegateCommand<MainMenuItem> _menuItemTappedCommand;

        public DelegateCommand<MainMenuItem> MenuItemTappedCommand => _menuItemTappedCommand ??
            (_menuItemTappedCommand = new DelegateCommand<MainMenuItem>(async i => await _MenuItemTappedExecute(i)));

        private DelegateCommand _exitCommand;

        public DelegateCommand ExitCommand => _exitCommand ?? (_exitCommand = new DelegateCommand(async () => await _ExitApp()));
        #endregion


        #region Command methods

        private async Task _MenuItemTappedExecute(MainMenuItem mainMenuItem)
        {
            if (mainMenuItem.Command != default(DelegateCommand))
            {
                mainMenuItem.Command.Execute();
            }

            if (!string.IsNullOrEmpty(mainMenuItem.DestinationPageName))
            {
                await NavigationService.NavigateAsync(mainMenuItem.DestinationPageName);
            }
        }

        private async Task _ExitApp()
        {
        }


        #endregion


        public override void Destroy()
        {
            _exitCommand = null;
            _menuItemTappedCommand = null;
            base.Destroy();
        }
    }
}
