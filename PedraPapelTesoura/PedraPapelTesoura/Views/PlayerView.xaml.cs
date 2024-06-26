using PedraPapelTesoura.ViewModels;

namespace PedraPapelTesoura
{
    public partial class PlayerView : ContentPage
    {
        int count = 0;

        public PlayerView()
        {
            InitializeComponent();
            BindingContext = new PlayerViewModel();
        }

        private void PlayBtn_Clicked(object sender, EventArgs e)
        {

        }
    }

}
