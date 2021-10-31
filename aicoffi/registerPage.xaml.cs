using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace aicoffi
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class registerPage : ContentPage
    {
        public registerPage()
        {
            InitializeComponent();
            btnRegister.Clicked += BtnRegister_Clicked;
        }

        private void BtnRegister_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
            // throw new NotImplementedException();
        }
    }
}