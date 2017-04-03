using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace FRC_Batman.Core
{
    public partial class MainPage : ContentPage
    {
        List<Label> FieldLabels;
        //Grandchildren
        Grid AutoG, AutoB, AutoHF, AutoLF, GearS, GearD, LF, HF, Climb, Defense;
        Entry TeamNumber; Editor Notes;
        //Great Grandchildren | NO TOUCH!!!!! ONLY LOOK!!!
        Button AutoG_GS, AutoG_GD, AutoG_NG;
        Button AutoB_BL, AutoB_NBL;
        Button AutoHF_P, AutoHF_M; Label AutoHF_L;
        Button AutoLF_P, AutoLF_M; Label AutoLF_L;
        Button GearS_P, GearS_M; Label GearS_L;
        Button GearD_P, GearD_M; Label GearD_L;
        Button LF_P, LF_M; Label LF_L;
        Button HF_P, HF_M; Label HF_L;
        Button Climb_SC, Climb_FA, Climb_NA;
        Button Defense_P, Defense_M; Label Defense_L;
        //Output
        uint AutoHFIn, AutoLFIn, GearSIn, GearDIn, LFIn, HFIn, DefenseIn;
        AUTOG AutoGIn; bool AutoBIn; CLIMB ClimbIn;

        public MainPage()
        {
            BackgroundColor = Color.FromHex("EDEDED");
            FieldLabels = new List<Label>
            {
                new Label
                {
                    Text = "Team Name",
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)) * 2,
                    TextColor = BCS.Secondary,
                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                    VerticalOptions = LayoutOptions.Start,
                    FontAttributes = FontAttributes.Bold
                },                               //Entry
                new Label
                {
                    Text = "Auto",
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)) * 2,
                    TextColor = BCS.Secondary,
                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                    VerticalOptions = LayoutOptions.Start,
                    FontAttributes = FontAttributes.Bold
                },
                QuickLabel.Make("Autonomous Gear"),         //3-Button Choice
                QuickLabel.Make("Autonomous Movement"),     //2-Button Choice
                QuickLabel.Make("Autonomous HF"),           //+-
                QuickLabel.Make("Autonomous LF"),           //+-
                new Label
                {
                    Text = "TeleOp",
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)) * 2,
                    TextColor = BCS.Secondary,
                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                    VerticalOptions = LayoutOptions.Start,
                    FontAttributes = FontAttributes.Bold
                },
                QuickLabel.Make("Gears Scored"),            //+- limit 0-12
                QuickLabel.Make("Gears Dropped"),           //+-
                QuickLabel.Make("Low Fuel"),                //+-
                QuickLabel.Make("High Fuel"),               //+-
                QuickLabel.Make("Climb"),                   //3-Button Choice
                new Label
                {
                    Text = "Post Game",
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)) * 2,
                    TextColor = BCS.Accent2,
                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                    VerticalOptions = LayoutOptions.Start,
                    FontAttributes = FontAttributes.Bold
                },
                QuickLabel.Make("Defense"),                 //+- limit to 0-5
                QuickLabel.Make("Notes")                    //Editor
            };
            var Stack = new StackLayout();

            GenerateUI();
            Stack.Children.Add(FieldLabels[0]); //First Header
            Stack.Children.Add(TeamNumber);
            Stack.Children.Add(FieldLabels[1]); //Second Header
            Stack.Children.Add(FieldLabels[2]);
            Stack.Children.Add(AutoG);
            Stack.Children.Add(FieldLabels[3]);
            Stack.Children.Add(AutoB);
            Stack.Children.Add(FieldLabels[4]);
            Stack.Children.Add(AutoHF);
            Stack.Children.Add(FieldLabels[5]);
            Stack.Children.Add(AutoLF);
            Stack.Children.Add(FieldLabels[6]); //Third Header
            Stack.Children.Add(FieldLabels[7]);
            Stack.Children.Add(GearS);
            Stack.Children.Add(FieldLabels[8]);
            Stack.Children.Add(GearD);
            Stack.Children.Add(FieldLabels[9]);
            Stack.Children.Add(LF);
            Stack.Children.Add(FieldLabels[10]);
            Stack.Children.Add(HF);
            Stack.Children.Add(FieldLabels[11]);
            Stack.Children.Add(Climb);
            Stack.Children.Add(FieldLabels[12]); //Fourth Header
            Stack.Children.Add(FieldLabels[13]);
            Stack.Children.Add(Defense);
            Stack.Children.Add(FieldLabels[14]);
            Stack.Children.Add(Notes);

            Content = new ScrollView { Content = Stack };
        }
    }
}
