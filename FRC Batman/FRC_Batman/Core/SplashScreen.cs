using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace FRC_Batman.Core
{
    public class SplashScreen : ContentPage
    {
        public SplashScreen()
        {
            BackgroundColor = BCS.Primary;

            Content = new StackLayout
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Children =
                {
                    new Image
                    {
                        Source = ImageSource.FromFile("SplashLogo.png"),
                        HorizontalOptions = LayoutOptions.Center
                    },
                    new ActivityIndicator
                    {
                        Color = BCS.Accent,
                        IsRunning = true
                    },
                    new Label
                    {
                        Text = "Loading...",
                        TextColor = BCS.Accent,
                        FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                        HorizontalTextAlignment = TextAlignment.Center
                    }
                }
            };
        }
    }
}