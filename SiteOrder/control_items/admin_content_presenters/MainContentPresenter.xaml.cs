using SiteOrder.overridden_controls;
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

namespace SiteOrder.control_items.admin_content_presenters
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

        private void buttonUser_Click(object sender, RoutedEventArgs e)
        {
            MainTabItem.AddChildUserControl(new UserListContent(MainTabItem));
        }

        private void buttonSampleSites_Click(object sender, RoutedEventArgs e)
        {
            MainTabItem.AddChildUserControl(new SampleSiteListContent(MainTabItem));
        }
    }
}
