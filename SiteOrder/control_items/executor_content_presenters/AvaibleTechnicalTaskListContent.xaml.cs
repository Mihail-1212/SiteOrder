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
    /// Логика взаимодействия для AvaibleTechnicalTaskListContent.xaml
    /// </summary>
    public partial class AvaibleTechnicalTaskListContent : TabItemContentParent
    {
        public AvaibleTechnicalTaskListContent(TabItemParent mainTabItem) : base(mainTabItem)
        {
            InitializeComponent();
            Update();
        }

        public override void Update()
        {
            techincalTaskList.ItemsSource = null;
            techincalTaskList.ItemsSource = SitesCreateEntities.GetContext().TechnicalTask.ToList()
                .Except(
                    SitesCreateEntities.GetContext().Logbook.ToList().Where(v => v.userLogin == MainTabItem.MainWindow.User.login && (v.userType == nameof(Logbook_userType.executor) || v.userType == nameof(Logbook_userType.customer))).Select(v => v.TechnicalTask).ToList()
                ).ToList();
        }

        private void demandListPreview_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var currentTechnicalTask = (TechnicalTask)((ListBox)sender).DataContext;
            var item = ItemsControl.ContainerFromElement(sender as ListBox, e.OriginalSource as DependencyObject) as ListBoxItem;
            if (item != null)
            {
                var currentDemand = (Demand)item.DataContext;
                MainTabItem.AddChildUserControl(new ShowDemandContent(MainTabItem, currentDemand));
            }
        }

        private void buttonDemandAction_Click(object sender, RoutedEventArgs e)
        {
            var currentTechnicalTask = (TechnicalTask)((Button)sender).DataContext;
            MainTabItem.AddChildUserControl(new ShowTechnicalTaskContent(MainTabItem, currentTechnicalTask));
        }

        private void buttonDemandAdd_Click(object sender, RoutedEventArgs e)
        {
            var currentTechnicalTask = (TechnicalTask)((Button)sender).DataContext;
            if( MessageBox.Show("Вы уверены, что хотите взять данное задание?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                var newLogbook = new Logbook();
                newLogbook.userLogin = MainTabItem.MainWindow.User.login;
                newLogbook.userType = nameof(Logbook_userType.executor);
                newLogbook.technicalTaskId = currentTechnicalTask.id;
                try
                {
                    SitesCreateEntities.GetContext().Logbook.Add(newLogbook);
                    SitesCreateEntities.GetContext().SaveChanges();
                    MessageBox.Show(
                        "Вы успешно взяли техническое задание!",
                        "Success",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        ex.Message,
                        "Error",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);
                }
                finally
                {
                    SitesCreateEntities.GetContext().ClearStateAndReloadAll();
                    Update();
                }
            }
        }
    }
}
