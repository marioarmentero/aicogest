using aicoffi.modelos;
using aicoffi.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace aicoffi
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            btnLogin.Clicked += BtnLogin_Clicked;
            btnRegister.Clicked += BtnRegister_Clicked;
        }

        private void BtnRegister_Clicked(object sender, EventArgs e)
        {
            // throw new NotImplementedException();
            Navigation.PushAsync(new registerPage());
        }

        private void BtnLogin_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("OK", "Subscripción realizada", "OK");
            // Navigation.PushAsync(new registerPage());
            //  throw new NotImplementedException();
        }

        private async Task Button_ClickedAsync(object sender, EventArgs e)
        {
            Login log = new Login
            {
                Email = txtEmail.Text,
                Password = txtPass.Text
            };
            LoginService Serv = new LoginService();
            var res = Serv.GetLoginAsync();

            if (res != null)
            {
                foreach (var va in res.Result)
                { 
                    if ((va.Email==log.Email)&(va.Password==log.Password))
                    {
                        await DisplayAlert("Login Exitoso", "Puede acceder.", "Cerrar");
                    }
                
                }
            }

        }
    }
}
