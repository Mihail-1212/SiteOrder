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

namespace SiteOrder.control_items.executor_content_presenters
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
            techincalTaskList.ItemsSource = null;
            techincalTaskList.ItemsSource = SitesCreateEntities.GetContext().TechnicalTask.Where(v => v.Logbook
                    .Where(s => s.userLogin == MainTabItem.MainWindow.User.login && s.userType == nameof(Logbook_userType.executor)).Count() != 0).ToList();
        }

        /// <summary>
        /// Filter technical tasks
        /// </summary>
        private void filterBystatusGroup_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton currentRadioButton = (RadioButton)sender;
            if (techincalTaskList != null)
            {
                Object currentTag = currentRadioButton.Tag; // order status
                foreach (TechnicalTask technicalTaskObject in techincalTaskList.Items)
                {
                    var technicalTaskItem = (ListBoxItem)techincalTaskList.ItemContainerGenerator.ContainerFromItem(technicalTaskObject);
                    if (technicalTaskItem != null)
                    {
                        // techincalTaskList.ItemContainerGenerator.Items
                        technicalTaskItem.Visibility = Visibility.Visible;
                        if (currentTag != null)
                        {
                            if (((TechnicalTask)technicalTaskItem.DataContext).status != currentTag.ToString())
                            {
                                technicalTaskItem.Visibility = Visibility.Collapsed;
                            }
                        }
                    }
                }
            }
        }

        private void showAvaibleTechnicalTask_Click(object sender, RoutedEventArgs e)
        {
            MainTabItem.AddChildUserControl(new AvaibleTechnicalTaskListContent(MainTabItem));
        }

        private void buttonDemandAction_Click(object sender, RoutedEventArgs e)
        {
            var currentTechnicalTask = (TechnicalTask)((Button)sender).DataContext;
            MainTabItem.AddChildUserControl(new ShowTechnicalTaskContent(MainTabItem, currentTechnicalTask, true));
        }

        private void demandListPreview_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var item = ItemsControl.ContainerFromElement(sender as ListBox, e.OriginalSource as DependencyObject) as ListBoxItem;
            if (item != null)
            {
                var currentDemand = (Demand)item.DataContext;
                MainTabItem.AddChildUserControl(new ShowDemandContent(MainTabItem, currentDemand));
                //  MainTabItem.AddChildUserControl(new DemandContent(MainTabItem, currentDemand));
            }
        }

        private void buttonTechnicalTaskWork_Click(object sender, RoutedEventArgs e)
        {
            var currentTechnicalTask = (TechnicalTask)((Button)sender).DataContext;
            var currentLogbook = currentTechnicalTask.Logbook.ToList()
                .Where(v => v.userLogin == MainTabItem.MainWindow.User.login && v.userType == nameof(Logbook_userType.executor)).FirstOrDefault();
            MainTabItem.AddChildUserControl(new SiteLayoutListContent(MainTabItem, currentLogbook));
        }
    }
}
