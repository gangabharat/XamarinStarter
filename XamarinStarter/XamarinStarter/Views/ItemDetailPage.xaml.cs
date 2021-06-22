using System.ComponentModel;
using Xamarin.Forms;
using XamarinStarter.ViewModels;

namespace XamarinStarter.Views
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