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
    /// Логика взаимодействия для EditTechnicalTaskContent.xaml
    /// </summary>
    public partial class EditTechnicalTaskContent : TabItemContentParent
    {
        private TechnicalTask technicalTask;

        private bool createFlag = false;

        public EditTechnicalTaskContent(TabItemParent mainTabItem, TechnicalTask technicalTask = null) : base(mainTabItem)
        {
            InitializeComponent();
            if (technicalTask == null) 
            {
                technicalTask = new TechnicalTask();
                ButtonDelete.Visibility = Visibility.Collapsed;
                ButtonAddDemand.Visibility = Visibility.Collapsed;
                BorderTogglePopup.IsEnabled = false;
                createFlag = true;
            }
            this.DataContext = this.technicalTask = technicalTask;
            Update();
        }

        public override void Update()
        {
            DemandList.ItemsSource = null;
            DemandList.ItemsSource = technicalTask.Demand;
            //  ComboBoxStatusChange.ItemsSource = Enum.GetValues(typeof(TechnicalTask_status)).Cast<TechnicalTask_status>();
        }

        private void DemandDescriptionUpdate(Demand demand)
        {
            DemandDescription.Text = demand.text.Trim();
        }

        /// <summary>
        /// CLick => show description of demand
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBox_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            var item = ItemsControl.ContainerFromElement(sender as ListBox, e.OriginalSource as DependencyObject) as ListBoxItem;
            if (item != null)
            {
                var currentDemand = (Demand)item.DataContext;
                DemandDescriptionUpdate(currentDemand);
            }
        }

        /// <summary>
        /// Click => open edit demand window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var item = ItemsControl.ContainerFromElement(sender as ListBox, e.OriginalSource as DependencyObject) as ListBoxItem;
            if (item != null)
            {
                var currentDemand = (Demand)item.DataContext;
                MainTabItem.AddChildUserControl(new EditDemandContent(MainTabItem, technicalTask, currentDemand));
            }
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите сохранить данное ТЗ?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                StringBuilder errors = new StringBuilder();

                if (
                    String.IsNullOrWhiteSpace(name.Text)
                    )
                {
                    errors.AppendLine("Вы не заполнили одно или несколько важных полей!");
                }

                if (errors.Length != 0)
                {
                    MessageBox.Show(
                        errors.ToString(),
                        "Error",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);
                    return;
                }

                
                if (createFlag)
                {
                    technicalTask.createDatetime = DateTime.Now;
                    technicalTask.Status = TechnicalTask_status.processing;
                    SitesCreateEntities.GetContext().TechnicalTask.Add(technicalTask);
                }

                try
                {
                    SitesCreateEntities.GetContext().SaveChanges();
                    if (createFlag)
                    {
                        var newLogBook = new Logbook();
                        newLogBook.technicalTaskId = technicalTask.id;
                        newLogBook.userLogin = MainTabItem.MainWindow.User.login;
                        newLogBook.userType = nameof(Logbook_userType.customer);
                        SitesCreateEntities.GetContext().Logbook.Add(newLogBook);
                        SitesCreateEntities.GetContext().SaveChanges();
                    }
                    MessageBox.Show(
                        "Данные успешно обновлены!",
                        "Success",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
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

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить данное ТЗ?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes && !createFlag)
            {
                SitesCreateEntities.GetContext().TechnicalTask.Remove(technicalTask);
                try
                {
                    SitesCreateEntities.GetContext().SaveChanges();
                    MainTabItem.ExecuteShowPrevPage();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(
                        ex.Message,
                        "Error",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);
                }
            }
        }

        private void ButtonAddDemand_Click(object sender, RoutedEventArgs e)
        {
            MainTabItem.AddChildUserControl(new EditDemandContent(MainTabItem, technicalTask));
        }

        private void ButtonStatusChange_Click(object sender, RoutedEventArgs e)
        {
            if (createFlag)
            {
                return;
            }
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
    }
}
