using SML.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace SML.Views
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