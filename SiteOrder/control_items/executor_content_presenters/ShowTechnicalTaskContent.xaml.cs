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
    /// Логика взаимодействия для ShowTechnicalTaskContent.xaml
    /// </summary>
    public partial class ShowTechnicalTaskContent : TabItemContentParent
    {
        private TechnicalTask technicalTask;

        public ShowTechnicalTaskContent(TabItemParent mainTabItem, TechnicalTask technicalTask, bool isAvaible = false) : base(mainTabItem)
        {
            InitializeComponent();
            if (technicalTask == null)
            {
                throw new ArgumentNullException();
            }
            this.DataContext = this.technicalTask = technicalTask;

            if (isAvaible)  // if task not chosed by user
            {
                buttonDemandAdd.Visibility = Visibility.Collapsed;
            }
            else
            {
                buttonRefuseTechnicalTask.Visibility = Visibility.Collapsed;
                buttonTechnicalTaskWork.Visibility = Visibility.Collapsed;
            }
        }

        public override void Update()
        {
            
        }

        private void ListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var item = ItemsControl.ContainerFromElement(sender as ListBox, e.OriginalSource as DependencyObject) as ListBoxItem;
            if (item != null)
            {
                var currentDemand = (Demand)item.DataContext;
                MainTabItem.AddChildUserControl(new ShowDemandContent(MainTabItem, currentDemand));
                //  MainTabItem.AddChildUserControl(new DemandContent(MainTabItem, currentDemand));
            }
        }

        private void buttonDemandAdd_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите взять данное задание?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                var newLogbook = new Logbook();
                newLogbook.userLogin = MainTabItem.MainWindow.User.login;
                newLogbook.userType = nameof(Logbook_userType.executor);
                newLogbook.technicalTaskId = technicalTask.id;
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
                    MainTabItem.ExecuteShowPrevPage();
                }
            }
        }

        private void buttonRefuseTechnicalTask_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите отказаться от выполнения данного задания?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                //  technicalTask
                var logBook = technicalTask.Logbook.ToList().Where(v => v.userLogin == MainTabItem.MainWindow.User.login && v.userType == nameof(Logbook_userType.executor)).FirstOrDefault();
                if(logBook == null)
                {
                    throw new NullReferenceException();
                }
                SitesCreateEntities.GetContext().Logbook.Remove(logBook);
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

        private void buttonTechnicalTaskWork_Click(object sender, RoutedEventArgs e)
        {
            var currentLogbook = technicalTask.Logbook.ToList()
                .Where(v => v.userLogin == MainTabItem.MainWindow.User.login && v.userType == nameof(Logbook_userType.executor)).FirstOrDefault();
            MainTabItem.AddChildUserControl(new SiteLayoutListContent(MainTabItem, currentLogbook));
        }
    }
}
