using SiteOrder.helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace SiteOrder.custom_uielements
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : UserControl
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void loginBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = (TextBox)sender;
            var TextBoxLoginPlaseholder = (TextBox)FindName("TextBoxLoginPlaseholder");
            var brush = String.IsNullOrEmpty((string)textBox.Text) ? (SolidColorBrush)this.FindResource("PlaceHolderColor") : new SolidColorBrush(Colors.Transparent);
            TextBoxLoginPlaseholder.Foreground = brush;
        }

        private void passwordBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = (TextBox)sender;
            var TextBoxLoginPlaseholder = (TextBox)FindName("passwordBoxPlaseholder");
            var brush = String.IsNullOrEmpty((string)textBox.Text) ? (SolidColorBrush)this.FindResource("PlaceHolderColor") : new SolidColorBrush(Colors.Transparent);
            TextBoxLoginPlaseholder.Foreground = brush;
        }

        private void passwordRepeatBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = (TextBox)sender;
            var TextBoxLoginPlaseholder = (TextBox)FindName("passwordRepeatBoxPlaseholder");
            var brush = String.IsNullOrEmpty((string)textBox.Text) ? (SolidColorBrush)this.FindResource("PlaceHolderColor") : new SolidColorBrush(Colors.Transparent);
            TextBoxLoginPlaseholder.Foreground = brush;
        }

        private void loginBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !Helper.IsTextAllowed(e.Text);
        }
    }
}
