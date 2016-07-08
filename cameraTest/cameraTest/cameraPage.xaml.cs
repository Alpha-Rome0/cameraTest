using Xamarin.Forms;

namespace cameraTest
{
    public partial class cameraPage : ContentPage
    {
        public cameraPage()
        {
            InitializeComponent();
            this.BindingContext = new CameraViewModel();
        }
    }
}
