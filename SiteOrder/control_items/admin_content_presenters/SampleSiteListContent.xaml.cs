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

namespace SiteOrder.control_items.admin_content_presenters
{
    /// <summary>
    /// Логика взаимодействия для SampleSiteListContent.xaml
    /// </summary>
    public partial class SampleSiteListContent : TabItemContentParent
    {
        public SampleSiteListContent(TabItemParent mainTabItem) : base(mainTabItem)
        {
            InitializeComponent();
            Update();
        }

        public override void Update()
        {
            datagridSampleSiteList.ItemsSource = null;
            datagridSampleSiteList.ItemsSource = SitesCreateEntities.GetContext().SampleSite.ToList();
        }

        private void buttonUserEdit_Click(object sender, RoutedEventArgs e)
        {
            var currentSampleSite = (SampleSite)((Button)sender).DataContext;
            MainTabItem.AddChildUserControl(new EditSampleSiteContent(MainTabItem, currentSampleSite));
        }

        private void buttonCreate_Click(object sender, RoutedEventArgs e)
        {
            MainTabItem.AddChildUserControl(new EditSampleSiteContent(MainTabItem));
        }

        private void buttonDelete_Click(object sender, RoutedEventArgs e)
        {
            var deletedObjects = datagridSampleSiteList.SelectedItems.Cast<SampleSite>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {deletedObjects.Count()} элементов? Все их связи с требованиями тоже удалятся!", "Question", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    SitesCreateEntities.GetContext().SampleSite.RemoveRange(deletedObjects);
                    SitesCreateEntities.GetContext().SaveChanges();
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

        private void buttobLink_Click(object sender, RoutedEventArgs e)
        {
            var currentSampleSite = (SampleSite)((Button)sender).DataContext;
            System.Diagnostics.Process.Start(currentSampleSite.siteURL);
        }
    }
}
