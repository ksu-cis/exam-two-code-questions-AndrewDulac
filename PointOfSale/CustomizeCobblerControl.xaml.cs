using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ExamTwoCodeQuestions.Data;

namespace ExamTwoQuestions.PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCobblerControl.xaml
    /// </summary>
    public partial class CustomizeCobblerControl : UserControl
    {
        public CustomizeCobblerControl()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Cobbler ac = (Cobbler)DataContext;
            switch (((Button)sender).Name)
            {
                case "PeachButton":
                    ac.Fruit = FruitFilling.Peach;
                    CobblerInformation.Text = "Peach";
                    break;
                case "CherryButton":
                    ac.Fruit = FruitFilling.Cherry;
                    CobblerInformation.Text = "Cherry";
                    break;
                case "BlueberryButton":
                    ac.Fruit = FruitFilling.Blueberry;
                    CobblerInformation.Text = "Blueberry";
                    break;
                case "WithIceCreamButton":
                    if (ac.WithIceCream)
                        IceCreamInformation.Text = "Holding Ice Cream";
                    else
                        IceCreamInformation.Text = "Not Holding Ice Cream";
                    ac.WithIceCream = !ac.WithIceCream;
                    break;
                default:
                    throw new NotImplementedException("Unknown Cobbler Toggle Button Pressed");
            }
        }
    }
}
