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
    /// Логика взаимодействия для ShowDemandContent.xaml
    /// </summary>
    public partial class ShowDemandContent : TabItemContentParent
    {
        private Demand demand;

        public ShowDemandContent(TabItemParent mainTabItem, Demand demand) : base(mainTabItem)
        {
            InitializeComponent();
            if (demand == null)
            {
                throw new ArgumentNullException();
            }
            DataContext = this.demand = demand;
            Update();
        }

        public override void Update()
        {

        }

        private void SampleSitesList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var item = ItemsControl.ContainerFromElement(sender as ListBox, e.OriginalSource as DependencyObject) as ListBoxItem;
            if (item != null)
            {
                var currentSampleSite = (SampleSitesGroup)item.DataContext;
                System.Diagnostics.Process.Start(currentSampleSite.SampleSite.siteURL);
            }
        }
    }
}
