using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Dochazka2
{
    public partial class PhotoPage : ContentPage
    {
        public PhotoPage()
        {
            InitializeComponent();
        }

        public async void CameraButton1_Clicked(System.Object sender, System.EventArgs e)
        {
            var photo = await Plugin.Media.CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions() { });

            if (photo != null)
                PhotoImage.Source = ImageSource.FromStream(() => { return photo.GetStream(); });
        }

        public async void CameraButton_Clicked(System.Object sender, System.EventArgs e)
        {
            var photo = await Plugin.Media.CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions() { });

            if (photo != null)
                PhotoImage.Source = ImageSource.FromStream(() => { return photo.GetStream(); });
        }

        void CameraButton2_Clicked(System.Object sender, System.EventArgs e)
        {
        }
    }
}
