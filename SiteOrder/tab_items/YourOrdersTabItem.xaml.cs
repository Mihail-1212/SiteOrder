using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using SiteOrder.control_items.your_order_content_presenters;
using SiteOrder.db_context;
using SiteOrder.overridden_controls;

namespace SiteOrder.tab_items
{
    /// <summary>
    /// Логика взаимодействия для YourOrdersTabItem.xaml
    /// </summary>
    public partial class YourOrdersTabItem : TabItemParent
    {
        public YourOrdersTabItem(MainWindow mainWindow) : base(mainWindow)
        {
            InitializeComponent();
            this.AddChildUserControl(new MainContentPresenter(this));
            mainWindow.CommandBindingBackPage.Executed += CommandBindingBackPage_Executed;
        }

        private void CommandBindingBackPage_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (MainWindow.IsTabItemActive(this))   // если открыта текущая страница
            {
                this.ShowPrevPage();
                SitesCreateEntities.GetContext().ClearStateAndReloadAll();
            }
        }
    }
}
