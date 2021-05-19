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
    public partial class VideosPerrosPage1 : ContentPage
    {
        public VideosPerrosPage1()
        {
            InitializeComponent();

            video1.Source = "https://www.youtube.com/embed/fmPJIV6Unqs";
            video2.Source = "https://www.youtube.com/embed/xETswYvRecw";
            video3.Source = "https://www.youtube.com/embed/xETswYvRecw";
            video4.Source = "https://www.youtube.com/embed/s-cNrKjzQjs";
            video5.Source = "https://www.youtube.com/embed/D0i6lJK91fY";


        }
    }
} 