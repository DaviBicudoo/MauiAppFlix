using MauiAppFlix.Categorias;
using System.Runtime.CompilerServices;

namespace MauiAppFlix
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void fantasyButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Fantasy());
        }

        private async void animationButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AnimationCategory());
        }

        private async void comedyButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Comedy());
        }

        private async void terrorButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Terror());
        }

        private async void warButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new War());
        }

        private async void action_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ActionCategory());
        }
    }
}
