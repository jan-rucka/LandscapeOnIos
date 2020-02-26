using Prism.Navigation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamPri.ViewModels;

namespace XamPri.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page2 : ContentPage, IDestructible
    {
		public Page2()
		{
			InitializeComponent();
		}


        public void Destroy()
        {
            //homeListView.Behaviors.Clear();
        }

    }
}