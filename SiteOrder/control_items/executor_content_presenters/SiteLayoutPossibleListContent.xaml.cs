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
    /// Логика взаимодействия для SiteLayoutPossibleListContent.xaml
    /// </summary>
    public partial class SiteLayoutPossibleListContent : TabItemContentParent
    {
        private Logbook logbook;

        public SiteLayoutPossibleListContent(TabItemParent mainTabItem, Logbook logbook) : base(mainTabItem)
        {
            InitializeComponent();
            if (logbook == null)
            {
                throw new ArgumentNullException();
            }
            this.DataContext = this.logbook = logbook;
            Update();
        }

        public override void Update()
        {
            datagridSiteLayoutFullList.ItemsSource = null;
            //   all not self layouts of this task
            datagridSiteLayoutFullList.ItemsSource = SitesCreateEntities.GetContext().SiteLayout.ToList()
                .Where(v => v.LayoutAccess.Count() != 0 && v.LayoutAccess.First().Logbook.TechnicalTask.id == logbook.TechnicalTask.id )
                .Except(logbook.LayoutAccess.ToList().Where(v => v.haveAccess).Select(v => v.SiteLayout))    // except your layouts with access
                ;
        }

        private void buttonRequestLayout_Click(object sender, RoutedEventArgs e)
        {
            var currentSiteLayout = (SiteLayout)((Button)sender).DataContext;
            var existingRequests = logbook.LayoutAccess.ToList().Where(v => v.SiteLayout.id == currentSiteLayout.id);
            if (existingRequests.Count() != 0)  // if private => resend request, if was private, but bow public => getting access
            {
                try
                {
                    var existingRequest = existingRequests.First();
                    SitesCreateEntities.GetContext().LayoutAccess.Remove(existingRequest);
                    SitesCreateEntities.GetContext().SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        ex.Message,
                        "Error",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);
                    return;
                }
            }
            var newLayoutAccess = new LayoutAccess();
            newLayoutAccess.siteLayoutId = currentSiteLayout.id;
            newLayoutAccess.executerId = logbook.id;
            if (currentSiteLayout.isPublic)
            {
                newLayoutAccess.haveAccess = true;
            }
            else
            {
                newLayoutAccess.haveAccess = false;
            }
            try
            {
                SitesCreateEntities.GetContext().LayoutAccess.Add(newLayoutAccess);
                SitesCreateEntities.GetContext().SaveChanges();
                MessageBox.Show(
                    newLayoutAccess.haveAccess?"Вы успешно получили права к данному макету!": "Вы успешно запросили права к данному макету",
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
}
