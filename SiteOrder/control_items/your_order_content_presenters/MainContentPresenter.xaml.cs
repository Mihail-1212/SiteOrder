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
                    .Where(s => s.userLogin == MainTabItem.MainWindow.User.login && s.userType == nameof(Logbook_userType.customer)).Count() != 0).ToList();

/*            techincalTaskList.Children.Clear();
            foreach (var technicalTask in )
            {
                techincalTaskList.Children.Add(new TechnicalTaskListSImple(MainTabItem, technicalTask));
            }*/
            filterBystatusGroup_Checked(
                filterBystatusGroupContainer.Children.OfType<RadioButton>()
                                      .FirstOrDefault(r => (bool)r.IsChecked),
                new RoutedEventArgs()
                );
        }

        /// <summary>
        /// Go to create page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createNewTaskButton_Click(object sender, RoutedEventArgs e)
        {
            MainTabItem.AddChildUserControl(new EditTechnicalTaskContent(MainTabItem));
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
                    var technicalTaskItem  = (ListBoxItem)techincalTaskList.ItemContainerGenerator.ContainerFromItem(technicalTaskObject);
                    if(technicalTaskItem != null)
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

        private void buttonDemandAction_Click(object sender, RoutedEventArgs e)
        {
            //  var currentDemand = (Demand)((Button)sender).DataContext;
            var currentTechnicalTask = (TechnicalTask)((Button)sender).DataContext;
            switch (currentTechnicalTask.Status)
            {
                case TechnicalTask_status.completed:
                case TechnicalTask_status.canceled:
                    MainTabItem.AddChildUserControl(new TechnicalTaskContent(MainTabItem, currentTechnicalTask));
                    break;
                case TechnicalTask_status.processing:
                    MainTabItem.AddChildUserControl(new EditTechnicalTaskContent(MainTabItem, currentTechnicalTask));
                    break;
            }
        }

        private void demandList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var currentTechnicalTask = (TechnicalTask)((ListBox)sender).DataContext;
            var item = ItemsControl.ContainerFromElement(sender as ListBox, e.OriginalSource as DependencyObject) as ListBoxItem;
            if (item != null)
            {
                var currentDemand = (Demand)item.DataContext;
                switch (currentTechnicalTask.Status)
                {
                    case TechnicalTask_status.completed:
                    case TechnicalTask_status.canceled:
                        MainTabItem.AddChildUserControl(new DemandContent(MainTabItem, currentDemand));
                        break;
                    case TechnicalTask_status.processing:
                        MainTabItem.AddChildUserControl(new EditDemandContent(MainTabItem, currentTechnicalTask, currentDemand));
                        break;
                }
            }
        }
    }
}
