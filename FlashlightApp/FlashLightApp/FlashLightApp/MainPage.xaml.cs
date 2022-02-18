using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;


namespace FlashLightApp
{
    public partial class MainPage : ContentPage
    {
        string entryToConvert;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Text_To_Morse_Clicked(object sender, EventArgs e)
        {
            entryToConvert = entryToConvertToMorse.Text;
            try
            {             

                int count;
                for (count = 0; count < entryToConvert.Length; count++)
                {
                    char convertLetter = char.ToUpper(entryToConvert[count]);
                   
                    switch (convertLetter)
                    {
                        case 'A':
                                {
                                    await Utility.A();
                                    break;
                                }    
                        case 'B':
                                {
                                    await Utility.B();
                                    break;
                                }
                        case 'C':
                                {
                                    await Utility.C();
                                    break;
                                }
                        case 'D':
                                {
                                    await Utility.D();
                                    break;
                                }
                        case 'E':
                                {
                                    await Utility.E();
                                    break;
                                }
                        case 'F':
                                {
                                    await Utility.F();
                                    break;
                                }
                        case 'G':
                            {
                                await Utility.G();
                                break;
                            }
                        case 'H':
                            {
                                await Utility.H();
                                break;
                            }
                        case 'I':
                            {
                                await Utility.I();
                                break;
                            }
                        case 'J':
                            {
                                await Utility.J();
                                break;
                            }
                        case 'K':
                            {
                                await Utility.K();
                                break;
                            }
                        case 'L':
                            {
                                await Utility.L();
                                break;
                            }
                        case 'M':
                            {
                                await Utility.M();
                                break;
                            }
                        case 'N':
                            {
                                await Utility.N();
                                break;
                            }
                        case 'O':
                            {
                                await Utility.O();
                                break;
                            }
                        case 'P':
                            {
                                await Utility.P();
                                break;
                            }
                        case 'Q':
                            {
                                await Utility.Q();
                                break;
                            }
                        case 'R':
                            {
                                await Utility.R();
                                break;
                            }
                        case 'S':
                            {
                                await Utility.S();
                                break;
                            }
                        case 'T':
                            {
                                await Utility.T();
                                break;
                            }
                        case 'U':
                            {
                                await Utility.U();
                                break;
                            }
                        case 'V':
                            {
                                await Utility.V();
                                break;
                            }
                        case 'W':
                            {
                                await Utility.W();
                                break;
                            }
                        case 'X':
                            {
                                await Utility.X();
                                break;
                            }
                        case 'Y':
                            {
                                await Utility.Y();
                                break;
                            }
                        case 'Z':
                            {
                                await Utility.Z();
                                break;
                            }
                        default:

                            await DisplayAlert("Failed to translate", "Must enter letters", "OK");
                            break;
                    }
                    
                }
            }
                     
            catch (FeatureNotSupportedException fnsEx)
            {
                await DisplayAlert("Failed access to flashlight", "This feature is not supported by this device", "OK");
            }
            catch (PermissionException pEx)
            {
                await DisplayAlert("Failed access to flashlight", "Permission for camera is needed to access flashlight", "OK");
                
            }
            catch (Exception ex)
            {
                
            }
        }

        private async void Fire_Clicked(object sender, EventArgs e)
        {
            await Utility.F();
            await Utility.I();
            await Utility.R();
            await Utility.E();
        }
        private async void Kidnapped_Clicked(object sender, EventArgs e)
        {
            await Utility.K();
            await Utility.I();
            await Utility.D();
            await Utility.N();
            await Utility.A();
            await Utility.P();
            await Utility.P();
            await Utility.E();
            await Utility.D();
        }
        private async void Shooter_Clicked(object sender, EventArgs e)
        {
            await Utility.S();
            await Utility.H();
            await Utility.O();
            await Utility.O();
            await Utility.T();
            await Utility.E();
            await Utility.R();
        }
        private async void Lost_Clicked(object sender, EventArgs e)
        {
            await Utility.L();
            await Utility.O();
            await Utility.S();
            await Utility.T();
        }
        private async void Medic_Clicked(object sender, EventArgs e)
        {
            await Utility.M();
            await Utility.E();
            await Utility.D();
            await Utility.I();
            await Utility.C();
        }
        private async void Help_Clicked(object sender, EventArgs e)
        {
            await Utility.H();
            await Utility.E();
            await Utility.L();
            await Utility.P();
        }
    }
}
