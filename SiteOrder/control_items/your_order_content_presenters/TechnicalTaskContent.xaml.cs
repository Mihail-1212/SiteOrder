using SiteOrder.db_context;
using SiteOrder.overridden_controls;
using SiteOrder.tab_items;
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

namespace SiteOrder.control_items.your_order_content_presenters
{
    /// <summary>
    /// Логика взаимодействия для TechnicalTaskContent.xaml
    /// </summary>
    public partial class TechnicalTaskContent : TabItemContentParent
    {
        private TechnicalTask technicalTask;

        public TechnicalTaskContent(TabItemParent mainTabItem, TechnicalTask technicalTask) : base(mainTabItem)
        {
            InitializeComponent();
            if (technicalTask == null)  // control for output => technical task cannot be null
            {
                throw new ArgumentNullException();
            }
            DataContext = this.technicalTask = technicalTask;
        }

        public override void Update()
        {

        }

        private void ButtonStatusChange_Click(object sender, RoutedEventArgs e)
        {
            var newStatus = (TechnicalTask_status)((Button)sender).Tag;
            if (
                MessageBox.Show("Вы уверены, что хотите изменить статус для данного ТЗ?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes
                )
            {
                technicalTask.Status = newStatus;
                try
                {
                    SitesCreateEntities.GetContext().SaveChanges();
                    MainTabItem.ExecuteShowPrevPage();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        ex.Message,
                        "Error",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);
                }
            }
        }

        private void ListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var item = ItemsControl.ContainerFromElement(sender as ListBox, e.OriginalSource as DependencyObject) as ListBoxItem;
            if (item != null)
            {
                var currentDemand = (Demand)item.DataContext;
                MainTabItem.AddChildUserControl(new DemandContent(MainTabItem, currentDemand));
            }
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить данное ТЗ?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                SitesCreateEntities.GetContext().TechnicalTask.Remove(technicalTask);
                try
                {
                    SitesCreateEntities.GetContext().SaveChanges();
                    MainTabItem.ExecuteShowPrevPage();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        ex.Message,
                        "Error",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);
                }
            }
        }
    }
}
