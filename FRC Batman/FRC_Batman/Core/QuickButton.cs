
using Xamarin.Forms;

namespace FRC_Batman.Core
{
    static class QuickButton
    {
        public static Button Make(char t)
        {
            Button button;
            if (t == '+')
            {
                button = new Button
                {
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    VerticalOptions = LayoutOptions.Center,
                    Text = "+"
                };
                return button;
            }
            else if (t == '-')
            {
                button = new Button
                {
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    VerticalOptions = LayoutOptions.Center,
                    Text = "-"
                };
                return button;
            }
            else
                throw new System.Exception("ERROR: QuickButton.Make(char) Bad input");
        }
    }
    static class QuickCounter
    {
        public static Label Make()
        {
            return new Label
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.Start,
                Text = "0",
                FontSize = 75,
                FontAttributes = FontAttributes.Bold,
                TextColor = BCS.Primary
            };
        }
    }
}
