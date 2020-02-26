using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamPri.Model;
using XamPri.ViewModels;

namespace XamPri.Views
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        protected override void OnSizeAllocated(double width, double height)
        {
            if (Device.RuntimePlatform == Device.iOS && Device.Idiom == TargetIdiom.Tablet)
            {
                MasterPage.Title = width > height ? " " : "☰";
            }
        }

        private void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (BindingContext is MainPageViewModel context && e.SelectedItem is MainMenuItem item)
            {
                context.MenuItemTappedCommand.Execute(item);
            }
        }
    }
}