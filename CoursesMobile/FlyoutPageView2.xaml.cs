using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoursesMobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlyoutPageView2 : FlyoutPage
    {
        public FlyoutPageView2()
        {
            InitializeComponent();

            masterView.NavigationListView.ItemSelected += NavigationListView_ItemSelected;
        }

        private void NavigationListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(e.SelectedItem is MasterNavigationItem item)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.Target));
                masterView.NavigationListView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}