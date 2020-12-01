using SiteOrder.helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

namespace SiteOrder.custom_uielements
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : UserControl
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void passwordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            var passwordBox = (PasswordBox)sender;
            var textBoxPlaceholder = (TextBox)FindName("TextBoxPasswordPlaseholder");
            var brush = String.IsNullOrEmpty((string)passwordBox.Password) ? (SolidColorBrush)this.FindResource("PlaceHolderColor") : new SolidColorBrush(Colors.Transparent);
            textBoxPlaceholder.Foreground = brush;
        }

        private void loginBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = (TextBox)sender;
            var TextBoxLoginPlaseholder = (TextBox)FindName("TextBoxLoginPlaseholder");
            var brush = String.IsNullOrEmpty((string)textBox.Text) ? (SolidColorBrush)this.FindResource("PlaceHolderColor") : new SolidColorBrush(Colors.Transparent);
            TextBoxLoginPlaseholder.Foreground = brush;
        }

        private void loginBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !Helper.IsTextAllowed(e.Text);
        }
    }
}
