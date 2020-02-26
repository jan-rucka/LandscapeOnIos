using Prism.Navigation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamPri.ViewModels;

namespace XamPri.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page3 : ContentPage, IDestructible
    {
		public Page3()
		{
			InitializeComponent();
		}


        public void Destroy()
        {
            //homeListView.Behaviors.Clear();
        }

    }
}