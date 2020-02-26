using Prism.Navigation;
using Xamarin.Forms;

namespace XamPri.Views
{	
    public partial class BaseNavigationPage : NavigationPage, IDestructible
    {
        public BaseNavigationPage()
        {
            InitializeComponent();
        }

        public void Destroy()
        {

        }
    }
}