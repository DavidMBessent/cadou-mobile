using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace cadou_mobile.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void OnNextpagebuttonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TodoList());
        }
    }
}
