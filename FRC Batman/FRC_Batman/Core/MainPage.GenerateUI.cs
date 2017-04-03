using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace FRC_Batman.Core
{
    public partial class MainPage
    {        
        public void GenerateUI()
        {
            //TeamNumber
            TeamNumber = new Entry
            {
                Keyboard = Keyboard.Numeric,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Placeholder = "Team Name (e.g. 3674)"
            };

            //AutoG
            AutoG = new Grid
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                ColumnDefinitions = new ColumnDefinitionCollection
                {
                    new ColumnDefinition { Width = GridLength.Auto },
                    new ColumnDefinition { Width = GridLength.Auto },
                    new ColumnDefinition { Width = GridLength.Auto }
                },
                RowDefinitions = new RowDefinitionCollection
                {
                    new RowDefinition { Height = 100 }
                }
            };
            AutoG_GS = new Button
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Text = "Gear Scored",
                BackgroundColor = BCS.Active,
                Command = new Command( () =>
                {
                    AutoGIn = AUTOG.GearScored;
                    AutoG_GS.BackgroundColor = BCS.Selected;
                    AutoG_GD.BackgroundColor = BCS.Active;
                    AutoG_NG.BackgroundColor = BCS.Active;
                })
            };
            AutoG_GD = new Button
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Text = "Gear Dropped",
                BackgroundColor = BCS.Active,
                Command = new Command ( () =>
                {
                    AutoGIn = AUTOG.GearDropped;
                    AutoG_GD.BackgroundColor = BCS.Selected;
                    AutoG_GS.BackgroundColor = BCS.Active;
                    AutoG_NG.BackgroundColor = BCS.Active;
                })
            };
            AutoG_NG = new Button
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Text = "None",
                BackgroundColor = BCS.Active,
                Command = new Command(() =>
                {
                    AutoGIn = AUTOG.GearDropped;
                    AutoG_NG.BackgroundColor = BCS.Selected;
                    AutoG_GS.BackgroundColor = BCS.Active;
                    AutoG_GD.BackgroundColor = BCS.Active;
                })
            };
            AutoG.Children.Add(AutoG_GS, 0, 0);
            AutoG.Children.Add(AutoG_GD, 1, 0);
            AutoG.Children.Add(AutoG_NG, 2, 0);

            //AutoB
            AutoB = new Grid
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                ColumnDefinitions = new ColumnDefinitionCollection
                {
                    new ColumnDefinition { Width = GridLength.Auto },
                    new ColumnDefinition { Width = GridLength.Auto }
                },
                RowDefinitions = new RowDefinitionCollection
                {
                    new RowDefinition { Height = 100 }
                }
            };
            AutoB_BL = new Button
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                BackgroundColor = BCS.Active,
                Text = "Baseline",
                Command = new Command( () =>
                {
                    AutoB_BL.BackgroundColor = BCS.Selected;
                    AutoBIn = true;
                    AutoB_NBL.BackgroundColor = BCS.Active;
                })

            };
            AutoB_NBL = new Button
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                BackgroundColor = BCS.Active,
                Text = "None",
                Command = new Command(() =>
                {
                    AutoB_NBL.BackgroundColor = BCS.Selected;
                    AutoBIn = false;
                    AutoB_BL.BackgroundColor = BCS.Active;
                })
            };
            AutoB.Children.Add(AutoB_BL, 0, 0);
            AutoB.Children.Add(AutoB_NBL, 1, 0);

            //AutoHF
            AutoHF = new Grid
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                ColumnDefinitions = new ColumnDefinitionCollection
                {
                    new ColumnDefinition { Width = GridLength.Auto },
                    new ColumnDefinition { Width = GridLength.Auto },
                    new ColumnDefinition { Width = GridLength.Auto }
                },
                RowDefinitions = new RowDefinitionCollection
                {
                    new RowDefinition { Height = 100 }
                }
            };
            AutoHF_M = QuickButton.Make('-'); AutoHF_M.Command = new Command(() =>
            {
                if (AutoHFIn > 0) 
                    AutoHFIn--;
                AutoHF_L.Text = AutoHFIn.ToString();
            });
            AutoHF_P = QuickButton.Make('+'); AutoHF_P.Command = new Command(() =>
            {
                AutoHFIn++;
                AutoHF_L.Text = AutoHFIn.ToString();
            });
            AutoHF_L = QuickCounter.Make();
            AutoHF.Children.Add(AutoHF_M, 0, 0);
            AutoHF.Children.Add(AutoHF_L, 1, 0);
            AutoHF.Children.Add(AutoHF_P, 2, 0);

            //AutoLF
            AutoLF = new Grid
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                ColumnDefinitions = new ColumnDefinitionCollection
                {
                    new ColumnDefinition { Width = GridLength.Auto },
                    new ColumnDefinition { Width = GridLength.Auto },
                    new ColumnDefinition { Width = GridLength.Auto }
                },
                RowDefinitions = new RowDefinitionCollection
                {
                    new RowDefinition { Height = 100 }
                }
            };
            AutoLF_M = QuickButton.Make('-'); AutoLF_M.Command = new Command(() =>
            {
                if (AutoLFIn > 0)
                    AutoLFIn--;
                AutoLF_L.Text = AutoLFIn.ToString();
            });
            AutoLF_P = QuickButton.Make('+'); AutoLF_P.Command = new Command(() =>
            {
                AutoLFIn++;
                AutoLF_L.Text = AutoLFIn.ToString();
            });
            AutoLF_L = QuickCounter.Make();
            AutoLF.Children.Add(AutoLF_M, 0, 0);
            AutoLF.Children.Add(AutoLF_L, 1, 0);
            AutoLF.Children.Add(AutoLF_P, 2, 0);

            //GearS
            GearS = new Grid
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                ColumnDefinitions = new ColumnDefinitionCollection
                {
                    new ColumnDefinition { Width = GridLength.Auto },
                    new ColumnDefinition { Width = GridLength.Auto },
                    new ColumnDefinition { Width = GridLength.Auto }
                },
                RowDefinitions = new RowDefinitionCollection
                {
                    new RowDefinition { Height = 100 }
                }
            };
            GearS_M = QuickButton.Make('-'); GearS_M.Command = new Command(() =>
            {
                if (GearSIn > 0)
                    GearSIn--;
                GearS_L.Text = GearSIn.ToString();
            });
            GearS_P = QuickButton.Make('+'); GearS_P.Command = new Command(() =>
            {
                if (GearSIn < 12)
                {
                    GearSIn++;
                    GearS_L.Text = GearSIn.ToString();
                }
            });
            GearS_L = QuickCounter.Make();
            GearS.Children.Add(GearS_M, 0, 0);
            GearS.Children.Add(GearS_L, 1, 0);
            GearS.Children.Add(GearS_P, 2, 0);

            //GearD
            GearD = new Grid
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                ColumnDefinitions = new ColumnDefinitionCollection
                {
                    new ColumnDefinition { Width = GridLength.Auto },
                    new ColumnDefinition { Width = GridLength.Auto },
                    new ColumnDefinition { Width = GridLength.Auto }
                },
                RowDefinitions = new RowDefinitionCollection
                {
                    new RowDefinition { Height = 100 }
                }
            };
            GearD_M = QuickButton.Make('-'); GearD_M.Command = new Command(() =>
            {
                if (GearDIn > 0)
                    GearDIn--;
                GearD_L.Text = GearDIn.ToString();
            });
            GearD_P = QuickButton.Make('+'); GearD_P.Command = new Command(() =>
            {
                    GearDIn++;
                    GearD_L.Text = GearSIn.ToString();
            });
            GearD_L = QuickCounter.Make();
            GearD.Children.Add(GearD_M, 0, 0);
            GearD.Children.Add(GearD_L, 1, 0);
            GearD.Children.Add(GearD_P, 2, 0);

            //LF
            LF = new Grid
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                ColumnDefinitions = new ColumnDefinitionCollection
                {
                    new ColumnDefinition { Width = GridLength.Auto },
                    new ColumnDefinition { Width = GridLength.Auto },
                    new ColumnDefinition { Width = GridLength.Auto }
                },
                RowDefinitions = new RowDefinitionCollection
                {
                    new RowDefinition { Height = 100 }
                }
            };
            LF_M = QuickButton.Make('-'); LF_M.Command = new Command(() =>
            {
                if (LFIn > 0)
                    LFIn--;
                LF_L.Text = LFIn.ToString();
            });
            LF_P = QuickButton.Make('+'); LF_P.Command = new Command(() =>
            {
                LFIn++;
                LF_L.Text = LFIn.ToString();
            });
            LF_L = QuickCounter.Make();
            LF.Children.Add(LF_M, 0, 0);
            LF.Children.Add(LF_L, 1, 0);
            LF.Children.Add(LF_P, 2, 0);

            //HF
            HF = new Grid
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                ColumnDefinitions = new ColumnDefinitionCollection
                {
                    new ColumnDefinition { Width = GridLength.Auto },
                    new ColumnDefinition { Width = GridLength.Auto },
                    new ColumnDefinition { Width = GridLength.Auto }
                },
                RowDefinitions = new RowDefinitionCollection
                {
                    new RowDefinition { Height = 100 }
                }
            };
            HF_M = QuickButton.Make('-'); HF_M.Command = new Command(() =>
            {
                if (HFIn > 0)
                    HFIn--;
                HF_L.Text = HFIn.ToString();
            });
            HF_P = QuickButton.Make('+'); HF_P.Command = new Command(() =>
            {
                HFIn++;
                HF_L.Text = HFIn.ToString();
            });
            HF_L = QuickCounter.Make();
            HF.Children.Add(HF_M, 0, 0);
            HF.Children.Add(HF_L, 1, 0);
            HF.Children.Add(HF_P, 2, 0);

            //Climb
            Climb = new Grid
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                ColumnDefinitions = new ColumnDefinitionCollection
                {
                    new ColumnDefinition { Width = GridLength.Auto },
                    new ColumnDefinition { Width = GridLength.Auto },
                    new ColumnDefinition { Width = GridLength.Auto }
                },
                RowDefinitions = new RowDefinitionCollection
                {
                    new RowDefinition { Height = 100 }
                }
            };
            Climb_SC = new Button
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Text = "Successful\nClimb",
                BackgroundColor = BCS.Active,
                Command = new Command(() =>
                {
                    ClimbIn = CLIMB.Yes;
                    Climb_SC.BackgroundColor = BCS.Selected;
                    Climb_FA.BackgroundColor = BCS.Active;
                    Climb_NA.BackgroundColor = BCS.Active;
                })
            };
            Climb_FA = new Button
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Text = "Failed\nAttempt",
                BackgroundColor = BCS.Active,
                Command = new Command(() =>
                {
                    ClimbIn = CLIMB.FailedAttempt;
                    Climb_FA.BackgroundColor = BCS.Selected;
                    Climb_SC.BackgroundColor = BCS.Active;
                    Climb_NA.BackgroundColor = BCS.Active;
                })
            };
            Climb_NA = new Button
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Text = "No Attempt",
                BackgroundColor = BCS.Active,
                Command = new Command(() =>
                {
                    ClimbIn = CLIMB.NoAttempt;
                    Climb_NA.BackgroundColor = BCS.Selected;
                    Climb_SC.BackgroundColor = BCS.Active;
                    Climb_FA.BackgroundColor = BCS.Active;
                })
            };
            Climb.Children.Add(Climb_SC, 0, 0);
            Climb.Children.Add(Climb_FA, 1, 0);
            Climb.Children.Add(Climb_NA, 2, 0);

            //Defense
            Defense = new Grid
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                ColumnDefinitions = new ColumnDefinitionCollection
                {
                    new ColumnDefinition { Width = GridLength.Auto },
                    new ColumnDefinition { Width = GridLength.Auto },
                    new ColumnDefinition { Width = GridLength.Auto }
                },
                RowDefinitions = new RowDefinitionCollection
                {
                    new RowDefinition { Height = 100 }
                }
            };
            Defense_M = QuickButton.Make('-'); Defense_M.Command = new Command(() =>
            {
                if (DefenseIn > 0)
                    DefenseIn--;
                Defense_L.Text = DefenseIn.ToString();
            });
            Defense_P = QuickButton.Make('+'); Defense_P.Command = new Command(() =>
            {
                if (DefenseIn < 5)
                {
                    DefenseIn++;
                    Defense_L.Text = DefenseIn.ToString();
                }
            });
            Defense_L = QuickCounter.Make();
            Defense.Children.Add(Defense_M, 0, 0);
            Defense.Children.Add(Defense_L, 1, 0);
            Defense.Children.Add(Defense_P, 2, 0);

            //Notes
            Notes = new Editor
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Keyboard = Keyboard.Plain
            };
        }
    }
}