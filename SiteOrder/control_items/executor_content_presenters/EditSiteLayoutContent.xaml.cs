using SiteOrder.db_context;
using SiteOrder.graphic_editor.ViewModel;
using SiteOrder.overridden_controls;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для EditSiteLayoutContent.xaml
    /// </summary>
    public partial class EditSiteLayoutContent : TabItemContentParent
    {
        #region constraint

        private const String layoutFolder = "layouts";

        #endregion

        #region private fields

        private SiteLayout siteLayout;
        private Logbook logbook;
        private bool createFlag = false;

        #endregion

        public EditSiteLayoutContent(TabItemParent mainTabItem, Logbook logbook, SiteLayout siteLayout=null) : base(mainTabItem)
        {
            InitializeComponent();
            if (logbook == null)
            {
                throw new ArgumentNullException();
            }
            if(siteLayout == null)
            {
                siteLayout = new SiteLayout();
                buttonDelete.Visibility = Visibility.Collapsed;
                createFlag = true;
            }
            this.logbook = logbook;
            this.DataContext = this.siteLayout = siteLayout;
            Update();
        }

        public override void Update()
        {
            listboxUser.ItemsSource = null;
            listboxUser.ItemsSource = SitesCreateEntities.GetContext().LayoutAccess.ToList()
                .Where(v => v.siteLayoutId == siteLayout.id && v.executerId != logbook.id);

                //  .Except(SitesCreateEntities.GetContext().)
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите сохранить данные о макете?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                StringBuilder errors = new StringBuilder();

                if (
                    String.IsNullOrWhiteSpace(description.Text)
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
                    var uniqueFileName = String.Format(@"{0}.se", Guid.NewGuid());
                    String newFIleName = $"{Environment.CurrentDirectory}\\{layoutFolder}\\{uniqueFileName}";
                    MainViewModel.CreateScene(newFIleName);
                    siteLayout.fileName = newFIleName;
                    SitesCreateEntities.GetContext().SiteLayout.Add(siteLayout);
                }

                try
                {
                    SitesCreateEntities.GetContext().SaveChanges();
                    if (createFlag)
                    {
                        var newLayoutAccess = new LayoutAccess();
                        newLayoutAccess.isOwner = true;
                        newLayoutAccess.haveAccess = true;
                        newLayoutAccess.executerId = logbook.id;
                        newLayoutAccess.siteLayoutId = siteLayout.id;
                        SitesCreateEntities.GetContext().LayoutAccess.Add(newLayoutAccess);
                        SitesCreateEntities.GetContext().SaveChanges();
                    }
                    MessageBox.Show(
                        "Данные успешно обновлены!",
                        "Success",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
                    this.MainTabItem.ExecuteShowPrevPage();
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

        private void buttonDelete_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить данный макет?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes && !createFlag)
            {
                SitesCreateEntities.GetContext().SiteLayout.Remove(siteLayout);
                try
                {
                    if (File.Exists(siteLayout.fileName))
                    {
                        File.Delete(siteLayout.fileName);
                    }
                    SitesCreateEntities.GetContext().SaveChanges();
                    MessageBox.Show(
                        "Макет успешно удален!",
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

        private void buttonRightsAdd_Click(object sender, RoutedEventArgs e)
        {
            var currentLayoutAccess = (LayoutAccess)((Button)sender).DataContext;
            if (!currentLayoutAccess.haveAccess)
            {
                if (MessageBox.Show("Вы точно хотите дать данному пользователю доступ к макету?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    currentLayoutAccess.haveAccess = true;
                }
            }
            else
            {
                if (MessageBox.Show("Вы точно хотите изменить права данного пользователя?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    currentLayoutAccess.isOwner = !currentLayoutAccess.isOwner;
                }
            }
            try
            {
                SitesCreateEntities.GetContext().SaveChanges();
                SitesCreateEntities.GetContext().ClearStateAndReloadAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
            Update();
        }

        private void buttonRightsDelete_Click(object sender, RoutedEventArgs e)
        {
            var currentLayoutAccess = (LayoutAccess)((Button)sender).DataContext;
            if (MessageBox.Show("Вы уверены, что хотите удалить права для данного пользователя?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes && !createFlag)
            {
                SitesCreateEntities.GetContext().LayoutAccess.Remove(currentLayoutAccess);
                try
                {
                    SitesCreateEntities.GetContext().SaveChanges();
                    SitesCreateEntities.GetContext().ClearStateAndReloadAll();
                    MessageBox.Show("Права успешно удалены!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        ex.Message,
                        "Error",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);
                }
                Update();
            }
        }
    }
}
