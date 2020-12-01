using SiteOrder.db_context;
using SiteOrder.graphic_editor.ViewModel;
using SiteOrder.overridden_controls;
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

namespace SiteOrder.control_items.executor_content_presenters
{
    /// <summary>
    /// Логика взаимодействия для SiteLayoutWorkContent.xaml
    /// </summary>
    public partial class SiteLayoutWorkContent : TabItemContentParent
    {
        #region private fields

        private LayoutAccess layoutAccess;
        private SiteLayout siteLayout;
        private String fileNameEmptyMessage = "У данного шаблона отсутствует файл проекта!";

        #endregion

        public SiteLayoutWorkContent(TabItemParent mainTabItem, LayoutAccess layoutAccess, SiteLayout siteLayout) : base(mainTabItem)
        {
            InitializeComponent();
            if (siteLayout == null || layoutAccess == null)
            {
                throw new ArgumentNullException();
            }
            this.DataContext = this.siteLayout = siteLayout;
            this.layoutAccess = layoutAccess;
            if (!layoutAccess.isOwner)
            {
                buttonSiteLayoutEdit.Visibility = Visibility.Collapsed;
            }
            else
            {
                buttonDenyLayout.Visibility = Visibility.Collapsed;
            }
            Update();
        }

        public override void Update()
        {
            var currentMainViewModel = (MainViewModel)graphicControl.DataContext;
            if (siteLayout.FileName != null)
            {
                currentMainViewModel.LoadScenePublic(siteLayout.FileName);
            }
            else
            {
                if (SitesCreateEntities.GetContext().Entry(siteLayout).State == EntityState.Detached)
                {
                    this.MainTabItem.ExecuteShowPrevPage();
                    return;
                }
                MessageBox.Show(fileNameEmptyMessage, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void buttonSiteLayoutEdit_Click(object sender, RoutedEventArgs e)
        {
            if (layoutAccess.isOwner)
            {
                this.MainTabItem.AddChildUserControl(new EditSiteLayoutContent(MainTabItem, (Logbook)layoutAccess.Logbook, siteLayout));
            }
            else
            {
                throw new Exception("You are not owner of this layout");
            }
        }

        private void buttonDenyLayout_Click(object sender, RoutedEventArgs e)
        {
            if (layoutAccess.isOwner)
            {
                throw new Exception("You are owner of this layout");
            }
            if (MessageBox.Show("Вы уверены, что хотите отказаться от доступа к данному макету?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                SitesCreateEntities.GetContext().LayoutAccess.Remove(layoutAccess);
                try
                {
                    SitesCreateEntities.GetContext().SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                finally
                {
                    this.MainTabItem.ExecuteShowPrevPage();
                }
            }
        }
    }
}
