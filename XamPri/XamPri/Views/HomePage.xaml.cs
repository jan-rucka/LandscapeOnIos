using Prism.Navigation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamPri.ViewModels;

namespace XamPri.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage, IDestructible
    {
		public HomePage()
		{
			InitializeComponent();
		}

        protected override bool OnBackButtonPressed()
        {
            if (BindingContext is HomePageViewModel vm)
            {
                vm.ExitCommand.Execute();
            }

            return true;
        }


        public void Destroy()
        {
            //homeListView.Behaviors.Clear();
        }

    }
}