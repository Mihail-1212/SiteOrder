using SiteOrder.db_context;
using SiteOrder.dialog_windows;
using SiteOrder.helper;
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

namespace SiteOrder.control_items.your_order_content_presenters
{
    /// <summary>
    /// Логика взаимодействия для EditDemandContent.xaml
    /// </summary>
    public partial class EditDemandContent : TabItemContentParent
    {
        private Demand demand;

        private TechnicalTask technicalTask;

        private bool createFlag = false;

        public EditDemandContent(TabItemParent mainTabItem, TechnicalTask technicalTask, Demand demand = null) : base(mainTabItem)
        {
            InitializeComponent();
            if (demand == null)
            {
                createFlag = true;
                ButtonDelete.Visibility = Visibility.Collapsed;
                SampleSitesCombobox.Visibility = Visibility.Collapsed;
                ButtonSaveSite.Visibility = Visibility.Collapsed;
                demand = new Demand();
            }
            if (technicalTask == null)
            {
                throw new ArgumentNullException();
            }
            this.technicalTask = technicalTask;
            this.DataContext = this.demand = demand;
            Update();
        }

        public override void Update()
        {
            SampleSitesList.ItemsSource = null;
            SampleSitesList.ItemsSource = demand.SampleSitesGroup;
            SampleSitesCombobox.ItemsSource = SitesCreateEntities.GetContext().SampleSite.ToList()
                .Except(SitesCreateEntities.GetContext().SampleSitesGroup.ToList().Where(v => v.demandId == demand.id).Select(v => v.SampleSite));
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите сохранить данное требование?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                StringBuilder errors = new StringBuilder();

                if (
                    String.IsNullOrWhiteSpace(name.Text) ||
                    String.IsNullOrWhiteSpace(text.Text)
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
                    demand.technicalTaskId = technicalTask.id;
                    SitesCreateEntities.GetContext().Demand.Add(demand);
                }

                try
                {
                    SitesCreateEntities.GetContext().SaveChanges();
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
            if (MessageBox.Show("Вы уверены, что хотите удалить требование?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes && !createFlag)
            {
                SitesCreateEntities.GetContext().Demand.Remove(demand);
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

        /// <summary>
        /// If urls exist => create and add else add
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SampleSitesComboboxSelect(ComboBox combobox)
        {
            SampleSite sampleSite = null;
            if (combobox.SelectedItem == null)
            {
                if (
                    String.IsNullOrWhiteSpace(combobox.Text) ||
                    !Helper.IsValidURL(combobox.Text)
                    )   // if text is empty or text is not url
                {
                    MessageBox.Show("Нельзя добавить к требованию данный сайт! Ошибка url.","Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                if (demand.SampleSites.ToList().Select(v => v.siteURL).Contains(combobox.Text))
                {
                    MessageBox.Show("Нельзя добавить к требованию данный сайт! Данный сайт уже прикреплен к требованию!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    SampleSitesList.SelectedItem = demand.SampleSitesGroup.ToList().Where(v => v.SampleSite.siteURL == combobox.Text).FirstOrDefault();
                    return;
                }

                if (MessageBox.Show("Вы хотите добавить сайт в систему?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    sampleSite = new SampleSite();
                    sampleSite.siteURL = combobox.Text;
                    SitesCreateEntities.GetContext().SampleSite.Add(sampleSite);
                    SitesCreateEntities.GetContext().SaveChanges();
                    SitesCreateEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(v => v.Reload());
                    // add new URL Site
                }
                else
                {
                    return;
                }
            }
            if (sampleSite == null)
            {
                sampleSite = (SampleSite)combobox.SelectedItem;
            }
            var dialog = new Dialog("Введите примечания.");
            if (dialog.ShowDialog() == true)
            {
                var sampleSitesGroup = new SampleSitesGroup();
                sampleSitesGroup.sampleSiteId = sampleSite.id;
                sampleSitesGroup.demandId = demand.id;
                sampleSitesGroup.note = dialog.Answer;

                try
                {
                    SitesCreateEntities.GetContext().SampleSitesGroup.Add(sampleSitesGroup);
                    SitesCreateEntities.GetContext().SaveChanges();
                    SitesCreateEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(v => v.Reload());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    SitesCreateEntities.GetContext().ClearStateAndReloadAll();
                }
                
            }
            Update();
        }
       

        private void ButtonSaveSite_Click(object sender, RoutedEventArgs e)
        {
            SampleSitesComboboxSelect(SampleSitesCombobox);
        }

        /// <summary>
        /// Update siteGroup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SampleSitesList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var item = ItemsControl.ContainerFromElement(sender as ListBox, e.OriginalSource as DependencyObject) as ListBoxItem;
            if (item != null)
            {
                var currentSampleSite = (SampleSitesGroup)item.DataContext;
                var dialog = new Dialog("Измените примечания.", currentSampleSite.note);
                if (dialog.ShowDialog() == true)
                {
                    currentSampleSite.note = dialog.Answer;
                    try
                    {
                        SitesCreateEntities.GetContext().SaveChanges();
                        SitesCreateEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(v => v.Reload());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        SitesCreateEntities.GetContext().ClearStateAndReloadAll();
                    }
                }
                Update();
                //  MainTabItem.AddChildUserControl(new EditDemandContent(MainTabItem, technicalTask, currentDemand));
            }
        }

        private void ButtonSampleSiteDelete_Click(object sender, RoutedEventArgs e)
        {
            var currentSiteGroup = (SampleSitesGroup)((Button)sender).DataContext;
            if (MessageBox.Show("Вы точно хотите удалить данный сайт у данного требования?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    SitesCreateEntities.GetContext().SampleSitesGroup.Remove(currentSiteGroup);
                    SitesCreateEntities.GetContext().SaveChanges();
                    SitesCreateEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(v => v.Reload());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    SitesCreateEntities.GetContext().ClearStateAndReloadAll();
                    return;
                }
                Update();
                MessageBox.Show("Вы успешно удалили сайт!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void buttonSampleSiteOpen_Click(object sender, RoutedEventArgs e)
        {
            var currentSiteGroup = (SampleSitesGroup)((Button)sender).DataContext;
            System.Diagnostics.Process.Start(currentSiteGroup.SampleSite.siteURL);
        }
    }
}
