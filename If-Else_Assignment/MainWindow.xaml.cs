using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace If_Else_Assignment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            labelAnswer.Content = "";

            if (textBoxOne.Text == textBoxTwo.Text)
            {
                labelAnswer.Content = "These are, in fact, quite equal to one another. Move on.";

            }
            else
            {
                labelAnswer.Content = "You must be seriously dumb to think those would be equal. Fail.";
            }

            //if (hungryCheckBox.IsChecked == true)
            //{
            //    labelResponse.Content = "Sucks.";


            //}
            //else
            //{
            //    labelResponse.Content = "Cool.";
            //}

            //if (radioButtonPizza.IsChecked == true)
            //{

            //    labelTooBad.Content = "Too Bad! No Food!";

            //}
            //else if (radioButtonBigMac.IsChecked == true)
            //{

            //    labelTooBad.Content = "Too Bad! No Food!";

            //}
            //else if (radioButtonAnything.IsChecked == true)
            //{

            //    labelTooBad.Content = "Too Bad! No Food!";

            //}


        }

        private void buttonHungry__Click(object sender, RoutedEventArgs e)
        {
            if (hungryCheckBox.IsChecked == true)
            {
                labelResponse.Content = "Sucks.";


            }
            else
            {
                labelResponse.Content = "Cool.";
            }
        }

        private void buttonChooseOne_Click(object sender, RoutedEventArgs e)
        {
            if (radioButtonPizza.IsChecked == true)
            {

                labelTooBad.Content = "Too Bad! No Food!";

            }
            else if (radioButtonBigMac.IsChecked == true)
            {

                labelTooBad.Content = "Too Bad! No Food!";

            }
            else if (radioButtonAnything.IsChecked == true)
            {

                labelTooBad.Content = "Too Bad! No Food!";

            }
        }
    }
}
