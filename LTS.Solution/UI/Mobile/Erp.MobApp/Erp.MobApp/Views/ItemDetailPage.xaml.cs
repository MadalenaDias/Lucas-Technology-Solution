using Erp.MobApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Erp.MobApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}