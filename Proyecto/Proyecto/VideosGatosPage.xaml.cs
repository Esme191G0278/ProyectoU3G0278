using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyecto
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VideosGatosPage : ContentPage
    {
        public VideosGatosPage()
        {
            InitializeComponent();

            video.Source = "https://www.youtube.com/embed/hhOOJOzr2Wo";
            video6.Source = "https://www.youtube.com/embed/5lgi4AESGXE";
            video7.Source = "https://www.youtube.com/embed/ZQ2ZThKQRR4";
            video8.Source = "https://www.youtube.com/embed/dRaBBROykUQ";
        }
    }
}