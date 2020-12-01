using SiteOrder.overridden_controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SiteOrder.control_items.main_content_presenters
{
    /// <summary>
    /// Логика взаимодействия для MainContentPresenter.xaml
    /// </summary>
    public partial class MainContentPresenter : TabItemContentParent
    {
        public MainContentPresenter(TabItemParent mainTabItem) : base(mainTabItem)
        {
            InitializeComponent();
            Update();
        }

        public override void Update()
        {
            
        }

        private void MainWindowButtonStart_Click(object sender, RoutedEventArgs e)
        {
            if (MainTabItem.MainWindow.User == null)
            {
                var toggleButton = (ToggleButton)MainTabItem.MainWindow.MainTabControl.Template.FindName("ToggleButton", MainTabItem.MainWindow.MainTabControl);
                toggleButton.IsChecked = true;
            }
            else
            {
                MessageBox.Show("LETS START, GENTELMENTS!", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                // если юзер зареган => бан
            }
        }
    }
}
