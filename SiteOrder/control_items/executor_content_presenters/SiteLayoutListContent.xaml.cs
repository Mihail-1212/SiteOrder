using SiteOrder.db_context;
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

namespace SiteOrder.control_items.executor_content_presenters
{
    /// <summary>
    /// Логика взаимодействия для SiteLayoutListContent.xaml
    /// </summary>
    public partial class SiteLayoutListContent : TabItemContentParent
    {
        private Logbook logbook; 

        public SiteLayoutListContent(TabItemParent mainTabItem, Logbook logbook) : base(mainTabItem)
        {
            InitializeComponent();
            if (logbook == null)
            {
                throw new ArgumentNullException();
            }
            this.DataContext = this.logbook = logbook;
            Update();
        }

        public override void Update()
        {
            datagridSiteLayoutList.ItemsSource = null;
            //  all self layouts of this task
            datagridSiteLayoutList.ItemsSource = SitesCreateEntities.GetContext().LayoutAccess.ToList()
                .Where(v => v.executerId == logbook.id && v.haveAccess);
        }

        private void buttonCreateLayout_Click(object sender, RoutedEventArgs e)
        {
            this.MainTabItem.AddChildUserControl(new EditSiteLayoutContent(MainTabItem, logbook));
        }

        /// <summary>
        /// Open form of all (not self) layouts and public => can get, private => request for access 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRequestAccess_Click(object sender, RoutedEventArgs e)
        {
            this.MainTabItem.AddChildUserControl(new SiteLayoutPossibleListContent(MainTabItem, logbook));
        }

        private void buttonSiteLayoutWork_Click(object sender, RoutedEventArgs e)
        {
            var currentLayoutAccess = (LayoutAccess)((Button)sender).DataContext;
            var currentSiteLayout = currentLayoutAccess.SiteLayout;
            this.MainTabItem.AddChildUserControl(new SiteLayoutWorkContent(MainTabItem, currentLayoutAccess, currentSiteLayout));
        }
    }
}
