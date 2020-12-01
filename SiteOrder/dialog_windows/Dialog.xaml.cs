using SiteOrder.templates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace SiteOrder.dialog_windows
{
    /// <summary>
    /// Логика взаимодействия для Dialog.xaml
    /// </summary>
    public partial class Dialog : CustomWindow, INotifyPropertyChanged
    {
        private String message;

        public Dialog(String message, String answer = "", String title = "Диалоговое окно")
        {
            InitializeComponent();
            Message = message;
            Title = title;
            txtAnswer.Text = answer;
        }

        public String Message
        {
            get => message;
            private set
            {
                message = value;
                NotifyPropertyChanged();
            }
        }

        public String Answer
        {
            get { return txtAnswer.Text; }
        }

        private void ButtonOk_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        private void CustomWindow_ContentRendered(object sender, EventArgs e)
        {
            txtAnswer.SelectAll();
            txtAnswer.Focus();
        }

        private void CustomWindow_Closing(object sender, CancelEventArgs e)
        {
            this.DialogResult = this.DialogResult ?? false;
        }
    }
}
