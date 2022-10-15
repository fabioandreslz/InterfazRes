using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InterfazRes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }
       private async void Button_Clicked(object sender, EventArgs e)
        {
           
            if (txtDocu.Text == "1013" && txtCont.Text == "123")
            {
                await DisplayAlert("Ingreso", "Bienvenido", "Aceptar");
                await Navigation.PushModalAsync(new OrderPage());
            }
            else
            {
                await DisplayAlert("Error", "Los datos ingresados son incorrectos", "Aceptar");
            }
        }

       
    }
}