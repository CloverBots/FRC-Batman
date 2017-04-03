
using Xamarin.Forms;

namespace FRC_Batman.Core
{
    static class QuickLabel
    {
        /// <summary>
        /// Creates a Large, Dark Grey, CenteredExpand (Horiz), Start (Vert) Xamarin.Forms.Label
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static public Label Make(string text)
        {
            return new Label
            {
                Text = text,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                TextColor = BCS.Accent2,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.Start
            };
        }
    }
}
